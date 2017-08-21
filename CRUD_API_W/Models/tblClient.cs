using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_API_W.Models
{
    public class tblClient
    {

        public int id_client { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string web_page { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        public string tel { get; set; }
        [Required]
        public string puesto { get; set; }
    }
}