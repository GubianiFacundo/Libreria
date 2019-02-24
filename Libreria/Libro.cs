using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Libro : IExport
    {
        public List<Ejemplar> ejemplares= new List<Ejemplar>();
        public string titulo;
        public long ISBN;
        public string ubicacion;
        public string autores;
        public int nroEjemplar = 1;

        public Libro(long ISBN, int cantejem, string titulo, string autores)
        {
            this.ISBN = ISBN;
            this.titulo = titulo;
            this.autores = autores;
            for (int i = 0; i < cantejem; i++)
            {
                ejemplares.Add(new Ejemplar(this.ISBN,nroEjemplar));
                nroEjemplar++;
            }
                
        }

        public void addEjemplar(int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                ejemplares.Add(new Ejemplar(this.ISBN,nroEjemplar));
                nroEjemplar++;
            }
                      
        }

        public bool tieneParaPrestar()
        {   
            int libre=0;

            foreach( Ejemplar e in ejemplares)
            {
                if (!e.estaPrestado && !e.deBaja)
                {
                    libre++;
                    if(libre==2)
                       return true;
                }
            }
            return false;
        }

        public string Export() 
        { 
            int nroEjemplares = 0;
            foreach (Ejemplar ejemplar in ejemplares)
                if (!ejemplar.deBaja)
                    nroEjemplares++;
            string str;
            str = ISBN + ";" + titulo + ";" + autores + ";" +nroEjemplares.ToString();

            return str;
        }

      }


  }


