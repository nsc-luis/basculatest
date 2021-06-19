using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace BasculaTest
{
    class basededatos
    {
        private const string DBName = @".\db\registros.db";
        SQLiteConnection db = new SQLiteConnection(string.Format("Data Source={0};Version=3;", DBName));

        public basededatos()
        {
            try
            {
                db.Open();
                MessageBox.Show("Conexion a BD satisfactoria!");
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private SQLiteConnection GetInstance()
        {
            db.Open();
            return db;
        }

        private DataTable qSelect(string q)
        {
            var con = GetInstance();
            var cmd = new SQLiteCommand(q, con);
            SQLiteDataReader dr = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(dr);
            ds.Tables.Add(dt);
            con.Close();
            return dt;
        }

        private void qInsert(string q)
        {
            try
            {
                var con = GetInstance();
                var cmd = new SQLiteCommand(q, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void qUpdateSerialCOM(int port, int bitRate, int parity, int bitData, int stopBit)
        {
            var query = "" +
                $"UPDATE serialcom SET idPort = {port}, idBitRate = {bitRate}, " +
                $"idParity = {parity}, idBitData = {bitData}, idStopBit = {stopBit} " +
                $"WHERE idSerialCom = 1";
            qInsert(query);
        }

        public void AgregaElementos(ComboBox combobox, string tabla, string key, string value)
        {
            var query = qSelect($"SELECT * FROM {tabla}");
            Dictionary<string, string> elementos = new Dictionary<string, string>();
            foreach (DataRow row in query.Rows)
            {
                elementos.Add(row[key].ToString(), row[value].ToString());
            }
            combobox.DataSource = new BindingSource(elementos, null);
            combobox.DisplayMember = "Value";
            combobox.ValueMember = "Key";
        }

        public void AgregaRegistro(string cliente, string producto, string turno, string peso)
        {
            qInsert($"INSERT INTO movimiento (idClie,idProd,idTurn,peso) VALUES({cliente},{producto},{turno},{peso})");
        }

        public DataTable ConsultaMovimientos(string cliente, string producto, string turno)
        {
            return qSelect($"SELECT m.idMovt, c.descClie cliente, p.descProd producto, t.descTurn turno, m.peso, m.datetime fechahora FROM movimiento m " +
                $"JOIN cliente c ON c.idClie = m.idClie " +
                $"JOIN producto p ON p.idProd = m.idProd " +
                $"JOIN turno t ON t.idTurn = m.idTurn " +
                $"WHERE m.idClie = {cliente} AND m.idProd = {producto} AND m.idTurn = {turno}");
        }

        public DataTable TodosLosMovtos()
        {
            return qSelect($"SELECT m.idMovt, c.descClie cliente, p.descProd producto, t.descTurn turno, m.peso, m.datetime fechahora FROM movimiento m " +
                $"JOIN cliente c ON c.idClie = m.idClie " +
                $"JOIN producto p ON p.idProd = m.idProd " +
                $"JOIN turno t ON t.idTurn = m.idTurn");
        }

        //METODO PARA CONSULTAR LA CONFIGURACION DEL SERIAL COM
        public DataTable GetSerialCOMSettings()
        {
            var query = 
                "SELECT s.idPort, s.idBitRate, s.idParity, s.idBitData, s.idStopBit, " +
                "p.value port, br.value bitRate, par.key parity, bd.value bitData, sb.key stopBit " +
                "FROM serialcom s " +
                "JOIN port p ON p.idPort = s.idPort " +
                "JOIN bitRate br ON br.idBitRate = s.idBitRate " +
                "JOIN parity par ON par.idParity = s.idParity " +
                "JOIN bitData bd ON bd.idBitData = s.idBitData " +
                "JOIN stopBit sb ON sb.idStopBit = s.idStopBit";
            return qSelect(query);
        }
    }
}
