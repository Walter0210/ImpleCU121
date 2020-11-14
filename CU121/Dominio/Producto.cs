using System;
using System.Collections.Generic;

namespace CU121.Dominio
{
    class Producto : IEstructuraCarta
    {
        private DateTime fechaCreacion;
        private int foto;
        private string nombre;
        private float precio;

        public Producto()
        {
        }

        public Producto(DateTime fechaCreacion, int foto, string nombre, float precio)
        {
            this.fechaCreacion = fechaCreacion;
            this.foto = foto;
            this.nombre = nombre;
            this.precio = precio;
        }

        public DateTime fechaDeCreacion
        {
            get => fechaCreacion;
            set => fechaCreacion = value;
        }
        public int fotografia
        {
            get => foto;
            set => foto = value;
        }
        public string nombreProducto
        {
            get => nombre;
            set => nombre = value;
        }
        public float precioProducto
        {
            get => precio;
            set => precio = value;
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
            throw new NotImplementedException();
        }

        public List<IEstructuraCarta> obtenerHijo()
        {
            throw new NotImplementedException();
        }
    }
}
