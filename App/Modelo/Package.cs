using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Package
    {
        #region "Atributos" 
        string Codigo;
        string Nombre;
        string Dirección;
        string Ciudad;
        string Departamento;
        string CodPosR;
        string CodPosD;
        string PesoPaq;
        string Costo;
        #endregion

        #region "Propiedades"
        public string Codigo1
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string Dirección1
        {
            get { return Dirección; }
            set { Dirección = value; }
        }
        public string Ciudad1
        {
            get { return Ciudad; }
            set { Ciudad = value; }
        }
        public string Departamento1
        {
            get { return Departamento; }
            set { Departamento = value; }
        }
        public string CodPosR1
        {
            get { return CodPosR; }
            set { CodPosR = value; }
        }
        public string CodPosD1
        {
            get { return CodPosD; }
            set { CodPosD = value; }
        }
        public string PesoPaq1
        {
            get { return PesoPaq; }
            set { PesoPaq = value; }
        }
        public string Costo1
        {
            get { return Costo; }
            set { Costo = value; }
        }
        #endregion


        #region "Constructor"
        public Package()
         {
             this.Codigo = "123";
             this.Nombre = "Caroline Castañeda";
             this.Dirección = "San Fernando";
             this.Ciudad = "Cartagena";
             this.Departamento = "Bolivar";
             this.CodPosR = "1234";
             this.CodPosD = "589";
             this.PesoPaq = "15";
             this.Costo = "2000";
         }
        public Package (string Codigo, string Nombre, string Dirección, string Ciudad, string Departamento, string CodPosR, string CodPosD, string PesoPaq, string Costo) 

             {
                 this.Codigo = Codigo;
                 this.Nombre = Nombre;
                 this.Dirección = Dirección;
                 this.Ciudad = Ciudad;
                 this.Departamento = Departamento;
                 this.CodPosD = CodPosD;
                 this.CodPosR = CodPosR;
                 this.PesoPaq = PesoPaq;
                 this.Costo = Costo;

             }
               
        #endregion

     

       }
    
}