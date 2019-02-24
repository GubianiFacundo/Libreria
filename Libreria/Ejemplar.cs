using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Ejemplar
    {
        public string ubicacion;
        public string NroPatrimonial;
        public bool estaPrestado = false;
        public bool deBaja = false;
        
        public Ejemplar(long isbn,int nroEjemplar)
        {
            this.NroPatrimonial = nroEjemplar+"-"+isbn;
        }

        public void setUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }

        public void darDeBaja()
        {
            deBaja = true;
        }

        
    }
}
