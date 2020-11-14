using CU121.Dominio;
using System;
using System.Collections.Generic;

namespace CU121.FabricacionPura
{
    class EstructuraCarta : IEstructuraCarta
    {
        private string comentario;
        private List<IEstructuraCarta> componentes;
        private bool esFavorito;
        private DateTime fechaCreacion;
        private DateTime fechaFinVigencia;
        private DateTime fechaInicioVigencia;
        private string nombre;
        private float precio;
        private Producto producto;
        private string responsableCreacion;

        public EstructuraCarta(bool esFavorito, DateTime fechaCreacion, string nombre, Producto producto)
        {
            this.esFavorito = esFavorito;
            this.fechaCreacion = fechaCreacion;
            this.nombre = nombre;
            this.producto = producto;
        }

        public EstructuraCarta(List<IEstructuraCarta> componentes, string nombre)
        {
            this.componentes = componentes;
            this.nombre = nombre;
        }

        public EstructuraCarta(string comentario, bool esFavorito, List<IEstructuraCarta> componentes, DateTime fechaCreacion, DateTime fechaFinVigencia, DateTime fechaInicioVigencia, string nombre, float precio, Producto producto, string responsableCreacion)
        {
            Comentario = comentario;
            EsFavorito = esFavorito;
            Componentes = componentes;
            FechaCreacion = fechaCreacion;
            FechaFinVigencia = fechaFinVigencia;
            FechaInicioVigencia = fechaInicioVigencia;
            Nombre = nombre;
            Precio = precio;
            Producto = producto;
            ResponsableCreacion = responsableCreacion;
        }

        public string Comentario
        {
            get => comentario;
            set => comentario = value;
        }

        public bool EsFavorito
        {
            get => esFavorito;
            set => esFavorito = value;
        }

        public DateTime FechaCreacion
        {
            get => fechaCreacion;
            set => fechaCreacion = value;
        }
        public DateTime FechaFinVigencia

        {
            get => fechaFinVigencia;
            set => fechaFinVigencia = value;
        }

        public DateTime FechaInicioVigencia
        {
            get => fechaInicioVigencia;
            set => fechaInicioVigencia = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public float Precio
        {
            get => precio;
            set => precio = value;
        }

        public Producto Producto
        {
            get => producto;
            set => producto = value;
        }

        public string ResponsableCreacion
        {
            get => responsableCreacion;
            set => responsableCreacion = value;
        }

        public List<IEstructuraCarta> Componentes
        {
            get => componentes;
            set => componentes = value;
        }

        public void agregarHijo(IEstructuraCarta interfazEstructuraCarta)
        {
            throw new NotImplementedException();
        }

        public void eliminarHijo(IEstructuraCarta interfazEstructuraCarta)
        {
            throw new NotImplementedException();
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getNombreProducto()
        {
            return this.producto.getNombre();
        }

        public List<IEstructuraCarta> obtenerHijo()
        {
            return this.componentes;
        }

        public double getPrecio()
        {
            return this.producto.getPrecio();
        }

        public int CompareTo(EstructuraCarta obj)
        {
            return string.Compare(nombre, obj.nombre);
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
