using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_Inventario
{
    class Inventario
    {
        Producto producto;
        private Producto[] _Inventario;
        private int _contador;
        Producto auxiliar;
        //int dato;
        //Producto siguiente;
        Producto inicio;
        Producto final;

        public Inventario()
        {
            inicio = null;
            final = null;
        }

        public bool vacia()
        {
            if (inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void agregarProducto(Producto producto)
        {
            Producto tmp = producto;

            if (vacia())
            {
                inicio = tmp;
                final = tmp;
            }
            else
            {
                final.siguiente = tmp;
                tmp.anterior = final;
                final = tmp;
            }
        }

        public void agregarInicio(Producto producto)
        {
            Producto tmp = producto;

            tmp.siguiente = inicio;
           inicio.anterior = tmp;
            inicio = tmp;
        }

        public void eliminarProducto(int posicion)
        {
            Producto anterior = inicio;
            Producto actual = inicio;

            int cont = 0;

            if (posicion == 1)
            {
                inicio= inicio.siguiente;
                inicio.anterior = null;
            }
            else if (posicion > cont)
            {
                while (posicion != cont && actual.siguiente != null)
                {
                    anterior = actual;
                    actual = actual.siguiente;
                    cont++;
                }
                anterior.siguiente = actual.siguiente;
            }
        }            

        public void eliminarPrimerProducto()
        {
            inicio = inicio.siguiente;
            inicio.anterior = null;
        }

        public void eliminarUltimoProducto()
        {
            final = final.anterior;
            final.siguiente = null;
        }

        public Producto buscarProducto(int posicion)
        {
            Producto tmp = inicio;

            while (tmp != null && tmp.codigo != posicion)
            {
                tmp = tmp.siguiente;
            }

            return tmp;
        }

        public void insertarProducto(Producto producto, int posicion)
        {
            int cont = 1;
            Producto tmp = producto;

            if (posicion == 1)
            {
                tmp.siguiente = inicio;
               inicio.anterior = tmp;
                inicio = tmp;
            }
            else
            {
                while (cont != posicion && inicio.siguiente != null)
                {
                    cont++;
                    inicio = inicio.siguiente;
                }
                tmp.siguiente =inicio;
                inicio.anterior = tmp;
                tmp.anterior = inicio.anterior;
                inicio = tmp;
            }
        }

           
        public string reporteInverso()
        {
            string mostrar = " ";
            Producto tmp = final;

            while (tmp != null)
            {
                mostrar += tmp.ToString();
                tmp = tmp.anterior;
            }
            return mostrar;
        }

        public override string ToString()
        {
            string mostrar = "";
            Producto tmp = inicio;

            while (tmp != null)
            {
                mostrar += tmp.ToString();
                tmp = tmp.siguiente;
            }
            return mostrar;
        }
    }
}


