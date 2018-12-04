using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace WindowsFormsApp1
{
    class conexcion_base_de_datos
    {
        
        //conexion a la base de datos
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ORDEN DE SERVICIO DEMO.accdb");
        
        public DataTable conexionBase(string query)
        {
            OleDbCommand cmd = conn.CreateCommand();
            //apertura de la conexion de base de datos
            conn.Open();
            //query que se corre
            cmd.CommandText = query;
            //variable de conexion
            cmd.Connection = conn;
            //execusion del query
            cmd.ExecuteNonQuery();
            //Adpatador de base de datos a un data set
            OleDbDataAdapter comd = new OleDbDataAdapter(cmd.CommandText, conn);
            conn.Close();
            //declaración de nuevo data set y relacion con la tabla
            DataSet dataNueva = new DataSet();
            //validación con la tabla
            comd.Fill(dataNueva, "Engineer");
            //relación con la columnas de la tabla
            DataTable dataRow = dataNueva.Tables[0];

            return dataRow;
        }
       
    }
}
