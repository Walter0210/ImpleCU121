using CU121.Dominio;
using System;
using System.Collections.Generic;

namespace CU121.FabricacionPura
{
    class EstructuraCarta : IEstructuraCarta
    {
        private string comentario;
        private List<EstructuraCarta> componentes;
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

        public EstructuraCarta(Producto producto)
        {
            this.producto = producto;
        }

        public EstructuraCarta(string nombre)
        {
            this.nombre = nombre;
        }

        public EstructuraCarta(List<EstructuraCarta> componentes, string nombre)
        {
            this.componentes = componentes;
            this.nombre = nombre;
        }

        public EstructuraCarta(string comentario, bool esFavorito, List<EstructuraCarta> componentes, DateTime fechaCreacion, DateTime fechaFinVigencia, DateTime fechaInicioVigencia, string nombre, float precio, Producto producto, string responsableCreacion)
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

        public List<EstructuraCarta> Componentes
        {
            get => componentes;
            set => componentes = value;
        }



        public List<EstructuraCarta> obtenerHijo()
        {
            return this.componentes;
        }
    }
}
