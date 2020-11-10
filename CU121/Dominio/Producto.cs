using System;
using System.Collections.Generic;
using System.Text;

namespace CU121.Dominio
{
    class Producto : IEstructuraCarta
    {
        private DateTime fechaCreacion;
        private int foto;
        private string nombre;
        private float precio;

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
    }

}
