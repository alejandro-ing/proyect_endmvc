using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using MySql.Data.MySqlClient;
using proyect_endmvc.Models;

namespace proyect_endmvc.Controllers
{
    public class accesoController : Controller
    {
        private string cadena = "server=localhost; database=final_proyect_PW; user=root;password=root";
        public MySqlConnection conectar;

        public void abrir_conexion()
        {
            try
            {
                Console.WriteLine("Holass");
                conectar = new MySqlConnection();
                conectar.ConnectionString = cadena;
                conectar.Open();
                System.Diagnostics.Debug.WriteLine("te has conectado");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);

            }
            {

                
            }

            
        }
        public ActionResult login()
        {
            return View();
        }


        public ActionResult registrar()
        {
            return View();
        }


   


    }
}