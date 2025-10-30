using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using SmartInventory.Repositories;

namespace SmartInventory.Services
{
    public class SupplierService
    {
        public static List<Supplier> GetSuppliers()
        {
            return SupplierRepository.GetSuppliers();
        }

        public static Supplier GetSupplier(string supplierCode)
        {
            return SupplierRepository.GetSupplier(supplierCode);
        }

        public static bool CreateSupplier(Supplier supplier)
        {
            return SupplierRepository.CreateSuppler(supplier);
        }
        public static bool UpdateSupplier(SupplierUpdateModel supplier)
        {
            return SupplierRepository.UpdateSupplier(supplier);
        }

        public static bool DeleteSupplier(string supplierCode)
        {
            return SupplierRepository.DeleteSupplier(supplierCode);
        }

    }
}
