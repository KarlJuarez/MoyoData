using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyoData.Models
{
    public class Categoria
    {
        public int id;
        public string categoria;
        public Categoria(int id, string categoria)
        {
            this.id = id;
            this.categoria = categoria;
        }
    }
}
