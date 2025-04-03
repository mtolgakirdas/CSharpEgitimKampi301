using CSharpEgitimKampi301.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IOrderDal : IGenericDal<Order>
    {
        // Buraya Order'e özel metotlar yazılabilir.
        // Örneğin: List<Order> GetOrdersByCustomerId(int customerId);
        // veya List<Order> GetOrdersByStatus(string status);
    }
}
