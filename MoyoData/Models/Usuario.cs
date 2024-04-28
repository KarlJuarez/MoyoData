using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyoData.Models
{
    //---------------------------------------------------------------------
    //Clase para crar un usuario.
    //---------------------------------------------------------------------
    public class Usuario
    {
        //---------------------------------------------------------------------
        //Variables.
        //---------------------------------------------------------------------
        public int id;
        public string usuario;
        public string password;
        public string rol;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public Usuario(string usuario, string password, string rol) 
        {
            this.usuario = usuario;
            this.password = password;   
            this.rol = rol;
        }

        public Usuario(int id, string usuario)
        {
            this.id = id;
            this.usuario = usuario;
        }
    }
}
