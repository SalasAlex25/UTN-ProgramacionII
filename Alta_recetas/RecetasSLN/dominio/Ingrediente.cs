using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    class Ingrediente
    {
        public int IngredienteId { get; set; }
        public string Nombre { get; set; }

        public string Unidad { get; set; }

        public Ingrediente(int ingredienteID, string nombre ,string unidad)
        {
            this.IngredienteId = ingredienteID;
            this.Nombre = nombre;
            this.Unidad = unidad;
        }


        public override string ToString()
        {
            return Nombre;
        }

    }
}
