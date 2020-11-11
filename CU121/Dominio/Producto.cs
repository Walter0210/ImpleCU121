using System;

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

    }
}
