using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassJugueteListaLigada
{
    public class Juguete
    {
        public  string nomjuguete { set; get; }
        public string marca { set; get; }
        public string categoria { set; get; }
        public float precio { set; get; }
        private Image imagenjug = null;
        public Juguete enlace = null;

        public Image mostrarimagen()
        {
            return imagenjug;
        }

        public void asignaimagen(string ruta)
        {
            imagenjug = Image.FromFile(ruta);
        }

        public void asignaimagen1(Image foto)
        {
            imagenjug = foto;
        }

        public string mostrardatos()
        {
            return "Juguete:" + nomjuguete + " de marca:" + marca + " de categoria" + categoria + " cuesta $" + precio;
        }//fin de metodo

        //private Image[] ColeccionFotos = new Image[3];

        //public void InsertarImagen(Image[] Coleccion)
        //{
        //    Image[] Recibir = new Image[3];
        //    Recibir = Coleccion;
        //    ColeccionFotos = Coleccion;
        //}

        //public Image[] MostrarColeccion()
        //{
        //    return ColeccionFotos;
        //}

    }//fin de class
}//fin de namespace
