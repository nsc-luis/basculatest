namespace BasculaTest
{
    partial class frmBascula
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPeso = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnRegistraPeso = new System.Windows.Forms.Button();
            this.lblClie = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.cmbClie = new System.Windows.Forms.ComboBox();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.cmbTurn = new System.Windows.Forms.ComboBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnTodosLosRegistros = new System.Windows.Forms.Button();
            this.gpoSerialCOM = new System.Windows.Forms.GroupBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.lblPuertoCOM = new System.Windows.Forms.Label();
            this.btnGuardaSerial = new System.Windows.Forms.Button();
            this.cmbStopBit = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbBitData = new System.Windows.Forms.ComboBox();
            this.cmbBitRate = new System.Windows.Forms.ComboBox();
            this.lblBitsDeParada = new System.Windows.Forms.Label();
            this.lblParidad = new System.Windows.Forms.Label();
            this.lblBitDatos = new System.Windows.Forms.Label();
            this.lblBitRate = new System.Windows.Forms.Label();
            this.gpoRegistros = new System.Windows.Forms.GroupBox();
            this.gridRepMovtos = new System.Windows.Forms.DataGridView();
            this.btnRegistraImp = new System.Windows.Forms.Button();
            this.gpoSerialCOM.SuspendLayout();
            this.gpoRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRepMovtos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(16, 113);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(52, 13);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso (kg)";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(109, 106);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPeso.Size = new System.Drawing.Size(121, 20);
            this.txtPeso.TabIndex = 2;
            this.txtPeso.Text = "0";
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRegistraPeso
            // 
            this.btnRegistraPeso.Location = new System.Drawing.Point(288, 12);
            this.btnRegistraPeso.Name = "btnRegistraPeso";
            this.btnRegistraPeso.Size = new System.Drawing.Size(105, 21);
            this.btnRegistraPeso.TabIndex = 3;
            this.btnRegistraPeso.Text = "Registra peso";
            this.btnRegistraPeso.UseVisualStyleBackColor = true;
            this.btnRegistraPeso.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblClie
            // 
            this.lblClie.AutoSize = true;
            this.lblClie.Location = new System.Drawing.Point(16, 20);
            this.lblClie.Name = "lblClie";
            this.lblClie.Size = new System.Drawing.Size(39, 13);
            this.lblClie.TabIndex = 4;
            this.lblClie.Text = "Cliente";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Location = new System.Drawing.Point(16, 52);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(50, 13);
            this.lblProd.TabIndex = 5;
            this.lblProd.Text = "Producto";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Location = new System.Drawing.Point(16, 83);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(35, 13);
            this.lblTurn.TabIndex = 6;
            this.lblTurn.Text = "Turno";
            // 
            // cmbClie
            // 
            this.cmbClie.FormattingEnabled = true;
            this.cmbClie.Location = new System.Drawing.Point(109, 11);
            this.cmbClie.Name = "cmbClie";
            this.cmbClie.Size = new System.Drawing.Size(121, 21);
            this.cmbClie.TabIndex = 7;
            // 
            // cmbProd
            // 
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(109, 43);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(121, 21);
            this.cmbProd.TabIndex = 8;
            // 
            // cmbTurn
            // 
            this.cmbTurn.FormattingEnabled = true;
            this.cmbTurn.Location = new System.Drawing.Point(109, 74);
            this.cmbTurn.Name = "cmbTurn";
            this.cmbTurn.Size = new System.Drawing.Size(121, 21);
            this.cmbTurn.TabIndex = 9;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(288, 42);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(105, 23);
            this.btnReporte.TabIndex = 10;
            this.btnReporte.Text = "Reporte filtrado";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnTodosLosRegistros
            // 
            this.btnTodosLosRegistros.Location = new System.Drawing.Point(288, 72);
            this.btnTodosLosRegistros.Name = "btnTodosLosRegistros";
            this.btnTodosLosRegistros.Size = new System.Drawing.Size(105, 23);
            this.btnTodosLosRegistros.TabIndex = 12;
            this.btnTodosLosRegistros.Text = "Todos los registros";
            this.btnTodosLosRegistros.UseVisualStyleBackColor = true;
            this.btnTodosLosRegistros.Click += new System.EventHandler(this.btnTodosLosRegistros_Click);
            // 
            // gpoSerialCOM
            // 
            this.gpoSerialCOM.Controls.Add(this.cmbPort);
            this.gpoSerialCOM.Controls.Add(this.lblPuertoCOM);
            this.gpoSerialCOM.Controls.Add(this.btnGuardaSerial);
            this.gpoSerialCOM.Controls.Add(this.cmbStopBit);
            this.gpoSerialCOM.Controls.Add(this.cmbParity);
            this.gpoSerialCOM.Controls.Add(this.cmbBitData);
            this.gpoSerialCOM.Controls.Add(this.cmbBitRate);
            this.gpoSerialCOM.Controls.Add(this.lblBitsDeParada);
            this.gpoSerialCOM.Controls.Add(this.lblParidad);
            this.gpoSerialCOM.Controls.Add(this.lblBitDatos);
            this.gpoSerialCOM.Controls.Add(this.lblBitRate);
            this.gpoSerialCOM.Location = new System.Drawing.Point(431, 11);
            this.gpoSerialCOM.Name = "gpoSerialCOM";
            this.gpoSerialCOM.Size = new System.Drawing.Size(261, 169);
            this.gpoSerialCOM.TabIndex = 14;
            this.gpoSerialCOM.TabStop = false;
            this.gpoSerialCOM.Text = "Serial COM";
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(120, 14);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 21);
            this.cmbPort.TabIndex = 12;
            // 
            // lblPuertoCOM
            // 
            this.lblPuertoCOM.AutoSize = true;
            this.lblPuertoCOM.Location = new System.Drawing.Point(16, 22);
            this.lblPuertoCOM.Name = "lblPuertoCOM";
            this.lblPuertoCOM.Size = new System.Drawing.Size(65, 13);
            this.lblPuertoCOM.TabIndex = 11;
            this.lblPuertoCOM.Text = "Puerto COM";
            // 
            // btnGuardaSerial
            // 
            this.btnGuardaSerial.Location = new System.Drawing.Point(120, 136);
            this.btnGuardaSerial.Name = "btnGuardaSerial";
            this.btnGuardaSerial.Size = new System.Drawing.Size(75, 23);
            this.btnGuardaSerial.TabIndex = 10;
            this.btnGuardaSerial.Text = "Guardar";
            this.btnGuardaSerial.UseVisualStyleBackColor = true;
            this.btnGuardaSerial.Click += new System.EventHandler(this.btnGuardaSerial_Click);
            // 
            // cmbStopBit
            // 
            this.cmbStopBit.Enabled = false;
            this.cmbStopBit.FormattingEnabled = true;
            this.cmbStopBit.Location = new System.Drawing.Point(120, 109);
            this.cmbStopBit.Name = "cmbStopBit";
            this.cmbStopBit.Size = new System.Drawing.Size(121, 21);
            this.cmbStopBit.TabIndex = 8;
            // 
            // cmbParity
            // 
            this.cmbParity.Enabled = false;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(120, 85);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(121, 21);
            this.cmbParity.TabIndex = 7;
            // 
            // cmbBitData
            // 
            this.cmbBitData.FormattingEnabled = true;
            this.cmbBitData.Location = new System.Drawing.Point(120, 61);
            this.cmbBitData.Name = "cmbBitData";
            this.cmbBitData.Size = new System.Drawing.Size(121, 21);
            this.cmbBitData.TabIndex = 6;
            // 
            // cmbBitRate
            // 
            this.cmbBitRate.FormattingEnabled = true;
            this.cmbBitRate.Location = new System.Drawing.Point(120, 37);
            this.cmbBitRate.Name = "cmbBitRate";
            this.cmbBitRate.Size = new System.Drawing.Size(121, 21);
            this.cmbBitRate.TabIndex = 5;
            // 
            // lblBitsDeParada
            // 
            this.lblBitsDeParada.AutoSize = true;
            this.lblBitsDeParada.Location = new System.Drawing.Point(16, 118);
            this.lblBitsDeParada.Name = "lblBitsDeParada";
            this.lblBitsDeParada.Size = new System.Drawing.Size(75, 13);
            this.lblBitsDeParada.TabIndex = 3;
            this.lblBitsDeParada.Text = "Bits de parada";
            // 
            // lblParidad
            // 
            this.lblParidad.AutoSize = true;
            this.lblParidad.Location = new System.Drawing.Point(16, 94);
            this.lblParidad.Name = "lblParidad";
            this.lblParidad.Size = new System.Drawing.Size(43, 13);
            this.lblParidad.TabIndex = 2;
            this.lblParidad.Text = "Paridad";
            // 
            // lblBitDatos
            // 
            this.lblBitDatos.AutoSize = true;
            this.lblBitDatos.Location = new System.Drawing.Point(16, 70);
            this.lblBitDatos.Name = "lblBitDatos";
            this.lblBitDatos.Size = new System.Drawing.Size(68, 13);
            this.lblBitDatos.TabIndex = 1;
            this.lblBitDatos.Text = "Bits de datos";
            // 
            // lblBitRate
            // 
            this.lblBitRate.AutoSize = true;
            this.lblBitRate.Location = new System.Drawing.Point(16, 46);
            this.lblBitRate.Name = "lblBitRate";
            this.lblBitRate.Size = new System.Drawing.Size(86, 13);
            this.lblBitRate.TabIndex = 0;
            this.lblBitRate.Text = "Bits por segundo";
            // 
            // gpoRegistros
            // 
            this.gpoRegistros.Controls.Add(this.gridRepMovtos);
            this.gpoRegistros.Location = new System.Drawing.Point(19, 186);
            this.gpoRegistros.Name = "gpoRegistros";
            this.gpoRegistros.Size = new System.Drawing.Size(673, 142);
            this.gpoRegistros.TabIndex = 17;
            this.gpoRegistros.TabStop = false;
            this.gpoRegistros.Text = "Registros";
            // 
            // gridRepMovtos
            // 
            this.gridRepMovtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRepMovtos.Location = new System.Drawing.Point(6, 19);
            this.gridRepMovtos.Name = "gridRepMovtos";
            this.gridRepMovtos.Size = new System.Drawing.Size(651, 117);
            this.gridRepMovtos.TabIndex = 12;
            // 
            // btnRegistraImp
            // 
            this.btnRegistraImp.Location = new System.Drawing.Point(288, 103);
            this.btnRegistraImp.Name = "btnRegistraImp";
            this.btnRegistraImp.Size = new System.Drawing.Size(105, 23);
            this.btnRegistraImp.TabIndex = 18;
            this.btnRegistraImp.Text = "Imprime/Registra";
            this.btnRegistraImp.UseVisualStyleBackColor = true;
            this.btnRegistraImp.Click += new System.EventHandler(this.btnRegistraImp_Click_1);
            // 
            // frmBascula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 335);
            this.Controls.Add(this.btnRegistraImp);
            this.Controls.Add(this.gpoRegistros);
            this.Controls.Add(this.gpoSerialCOM);
            this.Controls.Add(this.btnTodosLosRegistros);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.cmbTurn);
            this.Controls.Add(this.cmbProd);
            this.Controls.Add(this.cmbClie);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblClie);
            this.Controls.Add(this.btnRegistraPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.MaximizeBox = false;
            this.Name = "frmBascula";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Bascula";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpoSerialCOM.ResumeLayout(false);
            this.gpoSerialCOM.PerformLayout();
            this.gpoRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRepMovtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnRegistraPeso;
        private System.Windows.Forms.Label lblClie;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.ComboBox cmbClie;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.ComboBox cmbTurn;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnTodosLosRegistros;
        private System.Windows.Forms.GroupBox gpoSerialCOM;
        private System.Windows.Forms.ComboBox cmbStopBit;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbBitData;
        private System.Windows.Forms.ComboBox cmbBitRate;
        private System.Windows.Forms.Label lblBitsDeParada;
        private System.Windows.Forms.Label lblParidad;
        private System.Windows.Forms.Label lblBitDatos;
        private System.Windows.Forms.Label lblBitRate;
        private System.Windows.Forms.Button btnGuardaSerial;
        private System.Windows.Forms.GroupBox gpoRegistros;
        private System.Windows.Forms.DataGridView gridRepMovtos;
        private System.Windows.Forms.Button btnRegistraImp;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label lblPuertoCOM;
    }
}

