﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AccesoDatos
{
    internal class Datos
    {
        String cadenaConexion = "Data Source=DESKTOP-H69TC9M\\SQLEXPRESS;" +
            "integrated security=true;initial catalog=pubs";
        SqlConnection conexion;

        private SqlConnection abrirConexion() {
            try {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open(); //Abrir conexion a BD
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                return null;
            }

        }
        public bool prueba() {
            try
            {
                abrirConexion();
                return true;
            }
            catch   (Exception ex)
            {
              return false;
            }
          
        }
            
    }
}
