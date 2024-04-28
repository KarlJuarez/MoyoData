using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyoData.Models
{
    public class Rol
    {
        //Atributos
        public  int id;
        public string rol;
        public Rol(int id, string rol) {
            this.id = id;
            this.rol = rol; 
        }
    }
}
