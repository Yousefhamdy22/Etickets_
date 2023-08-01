using Etickets_.Data.Base;
using Etickets_.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Etickets_.Data.services
{
    public interface Iorder 
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
    }
}
