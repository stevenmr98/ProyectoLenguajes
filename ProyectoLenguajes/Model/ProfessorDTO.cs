using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ProyectoLenguajes.Controllers
{
    public class ProfessorDTO
    {
        public int Profesor_id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Grade { get; set; }
        public Image Photo { get; set; }
        public string Interest { get; set; }
        public string IsAdmin{ get; set; }
        public string Address { get; set; }

    }
}
