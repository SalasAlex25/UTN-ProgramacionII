using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
     class Receta
    {
        public int recetaNro { get; set; }
        public string nombre { get; set; }
        public int tipoReceta { get; set; }
        public string cheff { get; set; }
        public List<DetalleReceta> DetalleRecetas { get; set; }

        public Receta()
        {
            DetalleRecetas = new List<DetalleReceta>();
        }

        public void AgregarReceta(DetalleReceta detalle)
        {
            DetalleRecetas.Add(detalle);
        }

        public void Eliminar(int indice)
        {
            DetalleRecetas.RemoveAt(indice);
        }


    }
}
