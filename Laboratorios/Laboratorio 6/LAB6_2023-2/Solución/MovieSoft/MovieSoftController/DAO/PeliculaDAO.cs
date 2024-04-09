using MovieSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSoftController.DAO
{
    public interface PeliculaDAO
    {
        int insertar(Pelicula pelicula);
        BindingList<Pelicula> lista();
    }
}
