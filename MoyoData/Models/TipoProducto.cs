using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyoData.Models
{
    public class TipoProducto
    {

        public int id;
        public string tipoProducto;
        public int categoria;

        public TipoProducto(int id, string tipoProducto, int categoria) { 
            this.id = id;
            this.tipoProducto = tipoProducto;
            this.categoria = categoria;
        }
    }
}
