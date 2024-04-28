using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyoData.Models
{
    public class Producto
    {
        //---------------------------------------------------------------------
        //Variables.
        //---------------------------------------------------------------------
        public int Id;
        public string producto;
        public int stock;
        public int cantidadProducto;
        public int limteProducto;
        public int unidadMedida;
        public int tipoProducto;
        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public Producto(string producto, int stock, int cantidadProducto, int limiteProducto, int unidadMedida, int tipoProducto)
        {
            this.producto = producto;
            this.stock = stock;
            this.cantidadProducto = cantidadProducto;
            this.limteProducto = limiteProducto;
            this.unidadMedida = unidadMedida;
            this.tipoProducto = tipoProducto;
        }

        public Producto(int ID, string producto) { 
            this.Id = ID;
            this.producto = producto;
        }
    }
}