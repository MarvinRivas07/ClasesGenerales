using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.Negocio
{
    class NPersona
    {
        public string ACCESO(Persona login)
        {
            if (login.Nombre == "Marvin" || login.Password == "123")
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }



        
        
        
        
        
        
        
        
        
            
          

    }
}
