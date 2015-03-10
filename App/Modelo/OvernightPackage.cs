using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class OvernightPackage ()
    {
        #region "Atributos"
        string CostoEnvioNoche;
        #endregion

        #region "Propiedades"
        public string CostoEnvioNoche1
        {
            get { return CostoEnvioNoche; }
            set { CostoEnvioNoche = value; }
        }
        #endregion

        #region "Constructor"
        public OvernightPackage ()
         {
            this.CostoEnvioNoche = "4000";
         }
        
        public OvernightPackage(string CostoEnvioNoche)
         {
             this.CostoEnvioNoche = CostoEnvioNoche;
         }
        #endregion
    }
}