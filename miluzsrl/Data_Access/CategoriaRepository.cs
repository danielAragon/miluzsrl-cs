using miluzsrl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace miluzsrl.Data_Acces
{
    public interface ICategoriaRepoitory
    {
        void Registrar(Categoria categoria);
        void Actualizar(Categoria categoria);
        List<Categoria> Filtrar(string filtro);
    }
    public class CategoriaRepository : ICategoriaRepoitory
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