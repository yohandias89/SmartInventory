using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using SmartInventory.Repositories;
using System.Drawing.Printing;

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
        public static string GetSupplierCode()
        {
            return SupplierRepository.GetSupplierCode();
        }

        public static List<SupplierSearchModel> GetSupplierSearchDetails(
           out int totalRecords,
           out int  totalPages,
           int pageSize,
           int currentPage,
           string filterSupplierName,
           string filterEmail,
           string filterContact
       )
        {  var suppliers = SupplierRepository.GetSupplierSearchDetails(
               out totalRecords,
               pageSize,
               currentPage,
               filterSupplierName,
               filterEmail,
               filterContact);
            totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
            return suppliers;
        }

    }
}
