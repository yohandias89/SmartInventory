using SmartInventory.Models;
using SmartInventory.Repositories;

namespace SmartInventory.Services
{
    public class PurchaseService
    {
        public static bool CreatePurchase(PurchaseHeader purchase)
        {

            return PurchaseRepository.CreatePurchase(purchase);

        }
    }
}
