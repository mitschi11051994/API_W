using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_API_W.Models
{
    public class tblSupport_Tickets
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