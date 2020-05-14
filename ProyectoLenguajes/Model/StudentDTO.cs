using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ProyectoLenguajes.Model
{
    public class StudentDTO
    {
        public int Student_id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public Image Photo { get; set; }
        public string Interest { get; set; }
    }
}