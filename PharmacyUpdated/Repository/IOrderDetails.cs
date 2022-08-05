using PharmacyUpdated.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PharmacyUpdated.Repository
{
    public interface IOrderDetails
    {
        public List<OrderDetail> GetAllOrderDetail();
        public OrderDetail GetOrderDetailById(int id);
        public string UpdateOrderDetail( OrderDetail orderDetail);
        public string CreateOrderDetail(OrderDetail orderDetail);
        public string DeleteOrderDetailById(int id);
    }
}
