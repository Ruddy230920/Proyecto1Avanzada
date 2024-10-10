using Proyecto1Avanzada.DTO;
using Proyecto1Avanzada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Avanzada.Services
{
   public interface ISuppliersServices
    {
        IEnumerable<SupplierDTO> GetAllSuppliers();
            SupplierDTO GetSuppliersById(int supplierId);
        void Add(SupplierDTO supplier);
        void Update(SupplierDTO supplier);
        void Delete(SupplierDTO supplier);
    }
}
