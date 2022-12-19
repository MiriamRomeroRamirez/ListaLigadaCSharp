using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassJugueteListaLigada
{
    public class Jugueteligado
    {
        private Juguete Cabeza = null;
        public string BusacarNodoPorNombre(string nombuscar, ref Juguete ElNodoEncontrado, ref Juguete NodoAnte_Encontrado)
        {
            Juguete t = null;
            ElNodoEncontrado = null;
            NodoAnte_Encontrado = null;
            Juguete atras = null;
            string msj = "";
            t = Cabeza;
            atras = t;

            if (nombuscar == null)
            {
                msj = "¡No se puede realizar busqueda, el valor dado es nulo!";
            }
            else
            {
                while (t != null)
                {
                    if (t.nomjuguete == nombuscar)
                    {
                        ElNodoEncontrado = t;
                        NodoAnte_Encontrado = atras;
                    }
                    atras = t;
                    t = t.enlace;
                }
                if (ElNodoEncontrado != null)
                {
                    msj = $"¡El NODO que contiene el nombre: {nombuscar}, se ha encontrado!";
                }
                else
                {
                    msj = $"¡El NODO que contiene el nombre: {nombuscar}, NO se ha podido encontrar!";
                }
            }
            return msj;
        }//fin de metodo
        public string InsertarNuevoJuguete(Juguete nuevo)
        {
            Juguete ultimo = null;
            string msj = "";

            if (Cabeza == null)
            {//montar la cabeza en el objeto independiente en este caso nuevo
                Cabeza =nuevo;
                msj = "¡Listo! Se ha insertado tu PRIMER objeto en la lista";
            }
            else
            {
                if (Cabeza != null)
                { 
                    ultimo = Cabeza;
                    while (ultimo.enlace != null)
                    {
                        ultimo = ultimo.enlace;
                    }
                    ultimo.enlace = nuevo;
                    msj = "¡Listo! Se ha insertado un ¡NUEVO! objeto en el final de la lista";
                }
                else
                {
                    msj = "¡Error! No se pudo insertar ningun objeto en la lista";
                }
            }
            return msj;
        }//fin de metodo
        public string InsertarNuevoJuguete_Inicio(Juguete nuevo)
        {
            string msj = "";
            Juguete NuevoInicio = null;

            NuevoInicio = nuevo;
            NuevoInicio.enlace = Cabeza;
            Cabeza = NuevoInicio;
            msj = "Ya se inserto un nuevo elemento a la cabeza";
            return msj;
        }//fin de metodo
        public string[] MostrarDatosJuguetes()
        {
            Juguete temp = null;
            temp = Cabeza;
            int a = 0;//contador para ir sumando cada que se encuentre un nodo
                      //ayudara a crear el tamaño de arreglo de string
            while (temp != null)
            {
                a++;
                temp = temp.enlace;
            }
            temp = Cabeza;
            string[] CatalogoJ = new string[a];
            int b = 0;
            while (temp != null)
            {
                CatalogoJ[b] = temp.mostrardatos();
                temp = temp.enlace;
                b++;
            }
            return CatalogoJ;
        }
        public string ModificarNodo(Juguete NodoEncontrado,  Juguete NuevoMod)
        {
            string mensaje = "";
            if (NodoEncontrado != null)
            {
                NuevoMod.enlace = NodoEncontrado.enlace;
                mensaje = $"EL NODO con el nombre: {NodoEncontrado.nomjuguete}, se ha modificado con los datos" +
                    $" del nuevo objeto con el nombre: {NuevoMod.nomjuguete}";
            }
            else
            {
                mensaje = "La modificación no se ha podido realizar. ¡PRIMERO REALIZA UNA BUSQUEDA DE UN NODO EXISTENTE!";
            }
            return mensaje;
        }
        public string InsertarJugueteDespues(Juguete NodoEncontrado, Juguete Nuevo)
        {
            string mensaje = "";
            if (NodoEncontrado != null)
            {
                Nuevo.enlace = NodoEncontrado.enlace;
                NodoEncontrado.enlace = Nuevo;
                mensaje = $"El juguete nuevo se ha insertado despues del NODO: {NodoEncontrado.nomjuguete}";
            }
            else
            {
                mensaje = "NO se inserto ningun juguete. ¡NO SE HA REALIZADO NINGUNA BUSQUEDA!";
            }
            return mensaje;
        }
        public string EliminarNodo(Juguete NodoEncontrado, Juguete antesde)
        {
            string mensaje = "";
            if (NodoEncontrado != null)
            {
                if (NodoEncontrado != Cabeza)
                {
                    antesde.enlace = NodoEncontrado.enlace;
                    NodoEncontrado.enlace = null;
                    mensaje = $"El NODO con el nombre: {NodoEncontrado.nomjuguete}, se ha eliminado de la lista";
                }
                else
                {//caso especial para eliminar el primer nodo de la lista
                    Cabeza = Cabeza.enlace;
                    NodoEncontrado.enlace = null;
                    mensaje = $"El NODO con el nombre: {NodoEncontrado.nomjuguete}, se ha eliminado del principio de la lista ligada";
                }
            }
            else
            {
                mensaje = "No se ha podido eliminar el nodo";
            }
            return mensaje;
        }

        public Juguete MostrarImagenes(int posicion)
        {
            Juguete x = null;
            x = Cabeza;
            int k = 0;
            for (k = 1; k <= posicion; k++)
            {
                x = x.enlace;
            }
            return x;
        }

        
    }//fin de class
}//fin dee namespace
