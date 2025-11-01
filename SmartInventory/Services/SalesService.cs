using SmartInventory.Models;
using SmartInventory.Repositories;

namespace SmartInventory.Services
{
    public class SalesService
    {
        public static bool CreateSale(SalesHeader salesHeader)
        {
            return SalesRepository.CreateSales(salesHeader);

        }
    }
}
