//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalBaseDeDatos.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class CITA
    {
        public System.DateTime dia { get; set; }
        public string hora_inicio { get; set; }
        public string hora_termino { get; set; }
        public int clave_doc { get; set; }
        public int expediente { get; set; }
        public int numeroCita { get; set; }
    
        public virtual DOCTOR DOCTOR { get; set; }
        public virtual paciente paciente { get; set; }
    }
}