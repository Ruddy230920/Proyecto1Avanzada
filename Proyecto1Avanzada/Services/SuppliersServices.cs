using Proyecto1Avanzada.DTO;
using Proyecto1Avanzada.Models;
using Proyecto1Avanzada.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Avanzada.Services
{
    public class SuppliersServices : ISuppliersServices
    {
        private readonly ISuppliersRepository _suppliersRepository;
        public SuppliersServices(ISuppliersRepository suppliersRepository)
        {
            _suppliersRepository = suppliersRepository;
        }
        public void Add(SupplierDTO supplier)
        {
            _suppliersRepository.Add(supplier);
        }

        public void Delete(SupplierDTO supplier)
        {
            _suppliersRepository.Delete(supplier);
        }

        public IEnumerable<SupplierDTO> GetAllSuppliers()
        {
            return _suppliersRepository.GetAllSuppliers();
        }

        public SupplierDTO GetSuppliersById(int supplierId)
        {
            throw new NotImplementedException();
        }

        public void Update(SupplierDTO supplier)
        {
            _suppliersRepository.Update(supplier);
        }
    }
}
