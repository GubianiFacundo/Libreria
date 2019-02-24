using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Biblioteca
    {
        public List<Usuario> usuarios = new List<Usuario>();
        public List<Libro> libros = new List<Libro>();


        public bool AddLibro(Libro l)
        {
            if (libros.Count > 0)
            {
                foreach (Libro libro in libros)
                    if (libro.ISBN == l.ISBN)
                    {
                        libro.addEjemplar(l.ejemplares.Count);
                        return true;
                    }
       
                libros.Add(l);
                return false;
            }
                
            else
                libros.Add(l);
            return false;
        }

        public void AddUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public Usuario buscarUsuario(long dni)
        {
            for (int i = 0; i < usuarios.Count; i++)
                if (usuarios[i].dni == dni)
                    return usuarios[i];
            return null;
        }

        public Usuario buscarUsuario(Usuario user)
        {
            for (int i = 0; i < usuarios.Count; i++)
                if (usuarios[i].Equals(user))
                    return usuarios[i];
            return null;
        }

        public Ejemplar buscarEjemplar(string codigo)
        { 
            string [] nro_isbn = codigo.Split('-');
            long isbn = Convert.ToInt64(nro_isbn[1]);

            for (int i = 0; i < libros.Count;i++ )
            {
                if (libros[i].ISBN == isbn)
                    for (int j = 0; j < libros[i].ejemplares.Count;j++ )
                        if (libros[i].ejemplares[j].NroPatrimonial == codigo)
                            return libros[i].ejemplares[j];
                }
            return null;
        
        }

        public Libro buscarLibro(long isbn)
        {
            for (int i = 0; i < libros.Count; i++)
            {
                if (libros[i].ISBN == isbn)
                    return libros[i];
            }
            return null;
        }
        public Libro buscarLibro(string codigo)
        {
            string[] renglon = codigo.Split('-');
            long isbn=Convert.ToInt64(renglon[1]);

            return buscarLibro(isbn);
        }

    }
}
