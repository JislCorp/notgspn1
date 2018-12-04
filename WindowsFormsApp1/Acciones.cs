using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApp1
{
    class Acciones
    {
        String nombre, password;

        public int validacionUsuario(String user, String pass)
        {
            conexcion_base_de_datos conexcion = new conexcion_base_de_datos();
            DataTable dataRow = conexcion.conexionBase("SELECT * FROM Engineer  where Usuario = '" + user + "';");
            //Presentación de la tabla
            foreach (DataRow dtRow in dataRow.Rows)
            {
               nombre = dtRow["Usuario"].ToString();
               password = dtRow["Password"].ToString();
                
            }
            if (nombre == user && password == pass)
            {
                return 1;

            }
            return 0;

        }
        public void AgregarUsuario()
        {
            conexcion_base_de_datos conexcion = new conexcion_base_de_datos();
            DataTable dataRow = conexcion.conexionBase("INSERT INTO Enginner VALUES (4, 'Benjamin', 'TechLab', 'CAPACITACION', 2, 'ENTRENADOR1')");
            
        }
    }
}
