using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyoData.Models
{
    public class UnidadMedida
    {
        public int id;
        public string unidadMedida;
        public UnidadMedida(int id, string unidadMedida)
        {
            this.id = id;
            this.unidadMedida = unidadMedida;
        }
    }
}
