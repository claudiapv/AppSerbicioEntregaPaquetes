using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Customers
    {
        #region "Atributos"
        string IdCliente;
        string NomCliente;
        string ApeCliente;
        string DirCliente;
        string TelCliente;
        string EmailCliente;
        #endregion

        #region "Propiedades"
        public string IdCliente1
          {
           get { return IdCliente; }
           set { IdCliente = value; }
          }
        public string NomCliente1
          {
             get { return NomCliente; }
             set { NomCliente = value; }
          }
        public string ApeCliente1
         {
            get { return ApeCliente; }
             set { ApeCliente = value; }
         }
        public string DirCliente1
        {
             get { return DirCliente; }
            set { DirCliente = value; }
        }
        public string TelCliente1
        {
             get { return TelCliente; }
            set { TelCliente = value; }
        }
        public string EmailCliente1
        {
            get { return EmailCliente; }
             set { EmailCliente = value; }
        }

        #endregion

        #region "Constructor"
        public Customers()
        {
            this.IdCliente = "32906084";
            this.NomCliente = "Caroline";
            this.ApeCliente = "Catañeda Puello";
            this.DirCliente = "San fernando";
            this.TelCliente = "6813065";
            this.EmailCliente = "car@gmail.com";
        }
        public Customers(string IdCliente, string NomCliente, string ApeCliente,string DirCliente, string TelCliente, string Emailcliente,)
        {
            this.IdCliente = IdCliente;
            this.NomCliente = NomCliente;
            this.ApeCliente = ApeCliente;
            this.DirCliente = DirCliente;
            this.TelCliente = TelCliente;
            this.EmailCliente = EmailCliente;
        }

        #endregion
    } 
}