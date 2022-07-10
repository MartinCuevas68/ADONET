using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crud.Models
{
    public class PersonaModel
    {
        public int id { get; set; }
        public string  Nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public float estatura { get; set; }
        public float peso { get; set;}
        public float IMC { get; set; }

        public string grupo { get; set; }


    }
}