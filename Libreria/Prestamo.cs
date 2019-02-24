using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Prestamo
    {
        public Usuario usuario;
        public Ejemplar ejemplar;
        public DateTime fecpres;
        public DateTime fecdev;
        public Prestamo(Usuario usuario, Ejemplar ejemplar, int dias)
        {
            fecpres = DateTime.Today;
            this.ejemplar = ejemplar;
            this.usuario = usuario;
            fecdev = fecpres;
            fecdev = fecdev.AddDays(dias);
        }

        public bool Vencido()
        {
            if (DateTime.Today > fecdev)
               return true;
            return false;
        }
    }
}
