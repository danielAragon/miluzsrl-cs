using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.edu.upc.miluz.core.entity;
using pe.edu.upc.miluz.core.repository;

namespace pe.edu.upc.miluz.core.repository
{
    public interface IProveedorRespository
    {
        bool Create(Proveedor proveedor);
        bool Update(Proveedor proveedor);
        bool Delete(int id);

        List<Proveedor> Reader();
        List<Proveedor> ReaderByName(string Name);
    }
}
