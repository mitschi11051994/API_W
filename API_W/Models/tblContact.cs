//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_W.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblContact
    {
        public int id_contact { get; set; }
        [Required]
        public int id_client { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string first_name { get; set; }
        [Required]
        public string web_address { get; set; }
        [Required]
        public string tel { get; set; }
        [Required]
        public string puesto { get; set; }
    }
}
