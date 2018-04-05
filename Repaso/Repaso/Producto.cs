using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        private string codigoDeBarras;
        private string marca;
        private float precio;


        /// <summary>
        /// Unico constructor disponible
        /// </summary>
        /// <param name="marca">Marca del producto </param>
        /// <param name="codigo">Codigo de barras del producto</param>
        /// <param name="precio">Precio del producto</param>
        public Producto(string marca, string codigo, float precio) {
            this.marca = marca;
            this.codigoDeBarras = codigo;
            this.precio = precio;
        }

        /// <summary>
        ///  retornará el valor correspondiente del atributo marca
        /// </summary>
        /// <returns></returns>
        public string GetMarca() {
            return this.marca;
        }

        /// <summary>
        /// retornará el valor asociado al atributo precio
        /// </summary>
        /// <returns></returns>
        public float GetPrecio() {
            return this.precio;
        }

        /// <summary>
        /// Retorna el codigo de barras
        /// </summary>
        /// <returns>Codigo de barras del producto</returns>
        public string GetCodigoDeBarras(){
            return this.codigoDeBarras;
        }

        /// <summary>
        /// y retornará una cadena detallando los atributos de la clase
        /// </summary>
        /// <param name="producto">Producto a describir</param>
        /// <returns>Atributos del producto</returns>
        public static string MostrarProducto(Producto producto){
            StringBuilder productoStr = new StringBuilder();        
            productoStr.AppendFormat("  Marca: {0}", producto.GetMarca());
            productoStr.AppendLine();
            productoStr.AppendFormat("  Precio: {0}", producto.GetPrecio());
            productoStr.AppendLine();
            productoStr.AppendFormat("  Codigo de Barras: {0}", (string)producto);            
            return productoStr.ToString();
        }

        /// <summary>
        /// Retornará el código de barras del producto que recibe como parámetro.
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>Codigo de barras del producto</returns>
        public static explicit operator string(Producto producto) {
            return producto.GetCodigoDeBarras();
        }

        /// <summary>
        /// Retornará true, si son el mismo producto
        /// </summary>
        /// <param name="p">Primero producto a comprar</param>
        /// <param name="p1">Producto que comparar con el primero</param>
        /// <returns>Retorna true en caso de que sean el mismo producto</returns>
        public static bool operator  == (Producto p, Producto p1){
            return p.GetMarca() == p1.GetMarca();
        }

        /// <summary>
        /// Retornará true, si NO son el mismo producto
        /// </summary>
        /// <param name="p">Primero producto a comprar</param>
        /// <param name="p1">Producto que comparar con el primero</param>
        /// <returns>Retorna true en caso de que NO sean el mismo producto</returns>
        public static bool operator  != (Producto p, Producto p1){
            return p.GetMarca() != p1.GetMarca();
        }

        /// <summary>
        ///  Retornará true, si la marca del producto coincide con la cadena pasada por parámetro, false, caso contrario.
        /// </summary>
        /// <param name="p">Producto que comprar con la marca</param>
        /// <param name="marca">Marca con la que comprare el producto</param>
        /// <returns>Devuelve TRUE en caso de la marca de producto sea la indicada en marca</returns>
        public static bool operator ==(Producto producto, string marca) {
            return producto.GetMarca() == marca;
        }

        /// <summary>
        ///  Retornará true, si la marca del producto NO coincide con la cadena pasada por parámetro, false, caso contrario.
        /// </summary>
        /// <param name="p">Producto que comprar con la marca</param>
        /// <param name="marca">Marca con la que comprare el producto</param>
        /// <returns>Devuelve TRUE en caso de la marca de producto NO sea la indicada en marca</returns>
        public static bool operator !=(Producto producto, string marca) { 
            return producto.GetMarca() != marca;
        }
    }
}
