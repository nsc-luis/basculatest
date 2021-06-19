using System;
using System.Data;
using System.IO.Ports;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using System.Collections.Generic;

namespace BasculaTest
{
    public partial class frmBascula : Form
    {
        private delegate void DelegadoAcceso(string accion);
        basededatos context = new basededatos();
        private System.Timers.Timer aTimer = new System.Timers.Timer();

        public frmBascula()
        {
            InitializeComponent();
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            try
            {
                serialPort1.Write("p");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                aTimer.Enabled = false;
            }
        }

        //CARGANDO FORMULARIO PRINCIPAL
        private void Form1_Load(object sender, EventArgs e)
        {
            //POBLANDO TODOS LOS COMBOLIST DEL FROMULARIO
            context.AgregaElementos(cmbClie, "cliente", "idClie", "descClie");
            context.AgregaElementos(cmbProd, "producto", "idProd", "descProd");
            context.AgregaElementos(cmbTurn, "turno", "idTurn", "descTurn");
            context.AgregaElementos(cmbPort, "port", "idPort", "value");
            context.AgregaElementos(cmbBitRate, "bitRate", "idBitRate", "value");
            context.AgregaElementos(cmbBitData, "bitData", "idBitData", "value");
            context.AgregaElementos(cmbParity, "parity", "idParity", "value");
            context.AgregaElementos(cmbStopBit, "stopBit", "idStopBit", "value");

            //CONSULTANDO CONFIGURACION GUARDADA DEL PUERTO SERIAL COM{X}
            var serialCOM = context.GetSerialCOMSettings();
            DataRow drow = serialCOM.Rows[0];
            var cmbSerialCom = new List<ComboBox>()
            {
                cmbPort,cmbBitRate,cmbBitData,cmbParity,cmbStopBit
            };
            object[] cmbSerialComValues =
            {
                "idPort","idBitRate","idBitData","idParity","idStopBit"
            };
            for (int i = 0; i < cmbSerialComValues.Length; i++)
            {
                cmbSerialCom[i].DisplayMember = "Value";
                cmbSerialCom[i].ValueMember = "Key";
                cmbSerialCom[i].SelectedValue = drow.Field<int>(cmbSerialComValues[i].ToString()).ToString();
            }

            //PREPARANDO TIMER PARA ACTUALIZAR EL TEXTBOX DEL "PESO"
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 1000;
            aTimer.Enabled = false;

            try
            {
                //INTENTANDO ABRIR PUERTO SERIAL COM
                //serialPort1 = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
                serialPort1 = new SerialPort(
                    drow.Field<string>("port"),
                    Int32.Parse(drow.Field<string>("bitRate")),
                    (Parity)Enum.Parse(typeof(Parity), drow.Field<string>("parity")),
                    drow.Field<int>("bitData"),
                    (StopBits)Enum.Parse(typeof(StopBits), drow.Field<string>("stopBit"))
                    );
                serialPort1.Handshake = Handshake.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                serialPort1.ReadTimeout = 500;
                serialPort1.WriteTimeout = 500;
                serialPort1.Open();
                aTimer.Enabled = true;
                serialPort1.Write("p");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //METODO PARA CONSULTAR PESO ACTUAL DE LA BASCULA
        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (this.Enabled == true)
            {
                Thread.Sleep(500);
                string data = serialPort1.ReadExisting();
                this.BeginInvoke(new DelegadoAcceso(si_DataReceived), new object[] { data });
            }
        }

        //METODO PARA MOSTRAR EL PESO ACTUAL DE LA BASCULA EN EL TEXTBOX
        private void si_DataReceived(string accion)
        {
            string[] txt = accion.Split(' ');
            txtPeso.Text = "";
            txtPeso.Text = txt[2];
        }

        //GRABA UN NUEVO REGISTRO DE ACUERDO A LOS PARAMETROS INGRESADOS
        private void button1_Click(object sender, EventArgs e)
        {
            context.AgregaRegistro(
                cmbClie.SelectedValue.ToString(),
                cmbProd.SelectedValue.ToString(),
                cmbTurn.SelectedValue.ToString(),
                txtPeso.Text
            );
        }

        //METODO PARA CONSULTAR LOS REGISTROS DE PESO SEGUN FILTRO
        private void btnReporte_Click(object sender, EventArgs e)
        {
            var data = context.ConsultaMovimientos(cmbClie.SelectedValue.ToString(), cmbProd.SelectedValue.ToString(), cmbTurn.SelectedValue.ToString());
            gridRepMovtos.DataSource = data;
        }

        //METODO PARA CONSULTAR TODOS LOS REGISTROS DE PESO GUARDADOS
        private void btnTodosLosRegistros_Click(object sender, EventArgs e)
        {
            var data = context.TodosLosMovtos();
            gridRepMovtos.DataSource = data;
        }

        //The PrintPage event handler   
        public void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {

            //Get the Graphics object  
            Graphics g = ev.Graphics;

            //Create a font Arial with size 16  
            Font font = new Font("Consolas", 14);

            //Create a solid brush with black color  
            SolidBrush brush = new SolidBrush(Color.Black);

            //Get datetime
            DateTime datetime = DateTime.Now;

            string etiqueta =
                $"Cliente: {cmbClie.Text} \n" +
                $"Producto: {cmbProd.Text} \n" +
                $"Turno: {cmbTurn.Text} \n" +
                $"Peso: {txtPeso.Text} \n" +
                $"FechaHora: {datetime.ToString("yyyy-MM-dd hh:mm:ss") }";

            //Draw "Hello Printer!";  
            g.DrawString(etiqueta,
            font, brush,
            new Rectangle(20, 20, 300, 500));
        }

        //METODO PARA IMPRIMIR
        private void btnRegistraImp_Click_1(object sender, EventArgs e)
        {
            context.AgregaRegistro(
                cmbClie.SelectedValue.ToString(),
                cmbProd.SelectedValue.ToString(),
                cmbTurn.SelectedValue.ToString(),
                txtPeso.Text
            );

            //Create a PrintDocument object  
            PrintDocument pd = new PrintDocument();

            //Add PrintPage event handler  
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);

            //Print the document  
            pd.Print();
        }

        //METODO PARA GUARDAR CONFIGURACION DEL PUERTO SERIALCOM
        private void GuardaConfigSerialCOM()
        {
            try
            {
                context.qUpdateSerialCOM(
                    Int32.Parse(cmbPort.SelectedValue.ToString()),
                    Int32.Parse(cmbBitRate.SelectedValue.ToString()),
                    Int32.Parse(cmbParity.SelectedValue.ToString()),
                    Int32.Parse(cmbBitData.SelectedValue.ToString()),
                    Int32.Parse(cmbStopBit.SelectedValue.ToString())
                    );
                this.Refresh();
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardaSerial_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbBitRate.SelectedValue.ToString());
            GuardaConfigSerialCOM();
            serialPort1.Close();
            txtPeso.Text = "0";
            Form1_Load(null, EventArgs.Empty);
        }
    }
}
