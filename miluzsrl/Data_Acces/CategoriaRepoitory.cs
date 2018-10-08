using miluzsrl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace miluzsrl.Data_Acces
{
    interface ICategoriaRepoitory
    {
        void Registrar(Categoria categoria);
        void Actualizar(Categoria categoria);
        List<Categoria> Filtrar(string filtro);
    }
    public class CategoriaRepoitory : ICategoriaRepoitory
    {
        public Entities context = new Entities();

        private void cargarDatos()
        {

        }
        public void Actualizar(Categoria categoria)
        {
            throw new NotImplementedException();
        }
        public List<Categoria> Filtrar(string filtro)
        {
            throw new NotImplementedException();
        }

        public void Registrar(Categoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}