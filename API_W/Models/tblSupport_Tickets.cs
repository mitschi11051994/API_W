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

    public partial class tblSupport_Tickets
    {
        public int id_Support_Tickets { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string detalle { get; set; }
        [Required]
        public int id_user { get; set; }
        [Required]
        public int id_client { get; set; }
        [Required]
        public string estado { get; set; }
    }
}
