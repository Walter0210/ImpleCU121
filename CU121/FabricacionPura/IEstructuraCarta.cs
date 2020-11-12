using System.Collections.Generic;

namespace CU121.Dominio
{
    interface IEstructuraCarta
    {
        void agregarHijo(IEstructuraCarta interfazEstructuraCarta);

        void eliminarHijo(IEstructuraCarta interfazEstructuraCarta);


        string getNombre();

        string getNombreProducto();

        List<IEstructuraCarta> obtenerHijo();
    }
}
