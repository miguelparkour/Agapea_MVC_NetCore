﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agapea_MVC_NetCore.Models
{
    public class Libro : IEquatable<Libro>
    {
        #region "...propiedades de la clase..."
        private String _isbn;
        private String _isbn13;
        private String _titulo;
        private String _editorial;
        private String _autor;
        private int _numeroDePaginas;
        private decimal _precio;
        private String _imagen;
        private String _descripcion;
        private int _idMateria;
        private DateTime _fechaDeEdicion;


        public String descripcion { get { return _descripcion; } set { this._descripcion = value; } }
        public String autor { get { return _autor; } set { this._autor = value; } }
        public String titulo { get { return _titulo; } set { this._titulo = value; } }
        public String editorial  { get { return _editorial; } set { this._editorial = value; } }
        public String imagen  { get { return _imagen; } set { this._imagen = value; } }
        public int numeroDePaginas  { get { return _numeroDePaginas; } set { this._numeroDePaginas = value; } }
        public String isbn  { get { return _isbn; } set { this._isbn = value; } }
        public String isbn13  { get { return _isbn13; } set { this._isbn13 = value; } }
        public DateTime fechaDeEdicion  { get { return _fechaDeEdicion; } set { this._fechaDeEdicion = value; } }
        public decimal precio  { get { return _precio; } set { this._precio = value; } }
        public int idMateria { get { return _idMateria; } set { this._idMateria = value; } }


        #endregion

        #region "...métodos de la clase..."
        #region "...Métodos privados..."
        #endregion

        #region "...Métodos públicos..."
        #region "...Contrusctores..."
        public Libro()
        {

        }
        public Libro(String sTitulo, 
                     String sAutor, 
                     String sEditorial ,
                     String iIsbn,
                     String iIsbn13, 
                     decimal iPrecio, 
                     DateTime dFechaDeEdicion, 
                     String sImagen, 
                     int iNumeroDePaginas
                     )
        {
            this.titulo = sTitulo;
            this.autor = sAutor;
            this.editorial = sEditorial;
            this.isbn = iIsbn;
            this.isbn13 = iIsbn13;
            this.precio = iPrecio;
            this.fechaDeEdicion = dFechaDeEdicion;
            this.imagen = sImagen;
            this.numeroDePaginas = iNumeroDePaginas;
        }

        #endregion
        #region "...Métodos publicos de clase..."
        public override int GetHashCode()
        {
            return isbn.GetHashCode();
            /*
                Esto esta mal, por lo que pone en la documentacion:

                    'Si dos objetos de cadena son iguales, el método GetHashCode devuelve valores idénticos. 
                     Sin embargo, no hay ningún valor de código hash único para cada valor de cadena único. 
                     Cadenas diferentes pueden devolver el mismo código hash. (...)'

                    '(...) Como resultado, los códigos hash nunca deben usarse fuera del dominio de aplicación 
                     en el que se crearon, nunca deben usarse como campos de clave en una colección y nunca 
                     deben persistir.'
             */
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Libro);
        }
        public bool Equals(Libro other)
        {
            return other != null && other.isbn == this.isbn;
        }
        #endregion
        #endregion
        #endregion
    }
}
