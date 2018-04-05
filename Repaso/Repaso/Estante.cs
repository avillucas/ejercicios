using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {

        private Producto[] productos;
        private int ubicacion;

        /// <summary>
        /// El constructor de instancia privado será el único que inicializará el array
        /// </summary>
        /// <param name="capacidad"></param>
        private Estante(int capacidad) {
            this.productos = new Producto[capacidad]; 
        }

        /// <summary>
        /// La sobrecarga pública del constructor inicializará la
        /// ubicación del estante, recibiendo como parámetro capacidad y ubicación. Reutilizar código.
        /// </summary>
        /// <param name="capacidad">Cantidad de producto que el estante puede contener</param>
        /// <param name="ubicacion">Ubicacion del estante</param>
        public Estante(int capacidad, int ubicacion)
            : this(capacidad)
        {
            this.ubicacion = ubicacion;
        }

        /// <summary>
        /// El método público GetProductos, retornará el valor asociado del atributo productos.
        /// </summary>
        /// <returns>Productos que estan en el estante</returns>
        public Producto[] GetProductos() {
            return this.productos;
        }

        /// <summary>
        /// Retorna la ubicacion del estante
        /// </summary>
        /// <returns>Ubicacion del estante</returns>
        public int GetUbicacion() {
            return this.ubicacion;
        }

        /// <summary>
        /// El método público de clase MostrarEstante, retornará una cadena con toda la información del estante, incluyendo el
        /// detalle de cada uno de sus productos. Reutilizar código. 
        /// </summary>
        /// <param name="estante"></param>
        /// <returns>Retorna el valor </returns>
        public static string MostrarEstante(Estante estante) 
        {
            StringBuilder strEstante = new StringBuilder();
            strEstante.AppendFormat("El estante esta ubicado en {0} ",estante.GetUbicacion());
            strEstante.AppendLine();
            strEstante.AppendFormat("Sus productos son:");
            strEstante.AppendLine();
            foreach (Producto producto in estante.GetProductos())
            {
                strEstante.AppendLine(Producto.MostrarProducto(producto));
            }
            return strEstante.ToString();
        }

        /// <summary>
        ///  retornará true, si es que el producto ya se encuentra en el estante, false, caso contrario
        /// </summary>
        /// <param name="estante">Estante en el que buscar a producto</param>
        /// <param name="producto">Producto que buscar en estante</param>
        /// <returns>Devolvera TRUE en caso de que el producto se encuentre en el estante</returns>
        public static bool operator ==(Estante estante, Producto producto) 
        {             
            foreach (Producto posibleProducto in estante.GetProductos()) 
            {
                if (!Object.ReferenceEquals(posibleProducto, null) && producto == posibleProducto)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        ///  retornará true, si es que el producto NO se encuentra en el estante, false, caso contrario
        /// </summary>
        /// <param name="estante">Estante en el que buscar a producto</param>
        /// <param name="producto">Producto que buscar en estante</param>
        /// <returns>Devolvera TRUE en caso de que el producto NO se encuentre en el estante</returns>
        public static bool operator !=(Estante estante, Producto producto) {
            return !(estante + producto);            
        }

        /// <summary>
        ///  retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más y
        ///  dicho producto no se encuentra en él; false, caso contrario. Reutilizar código.
        /// </summary>
        /// <param name="estante"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator +(Estante estante, Producto producto){            
            if (estante == producto){
                return false;            
            }
            // si el estante posee capacidad de almacenar al menos un producto más            
            for (int i = 0; i < estante.GetProductos().Length; i++)
            {
                //Ver si queda un espacio 
                if (Object.ReferenceEquals(estante.GetProductos()[i], null))
                {
                    //eliminarlo
                    estante.productos[i] = producto;
                    return true;
                }
            }
            //no existia espacio
            return false;
        }

        public static Estante operator -(Estante estante, Producto producto) {
            //El producto esta en el estante 
            if (estante == producto) {
                for (int i = 0; i < estante.GetProductos().Length; i++)
                {
                    //Ver si queda un espacio 
                    if(estante.GetProductos()[i] == producto)
                    {
                        //eliminarlo
                        estante.GetProductos()[i] = null;
                        break;
                    }
                }
            }         
            return estante;
        }
        
    }
}
