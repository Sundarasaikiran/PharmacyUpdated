using PharmacyUpdated.Models;
using PharmacyUpdated.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace PharmacyUpdated.services
{
    public class OrderDetailsService
    {
        private readonly OrderDetailRepo _order;
        public OrderDetailsService(OrderDetailRepo order)
        {
            _order = order;
        }
        public string  CreateOrderDetail(OrderDetail orderDetail)
        {
            return _order.CreateOrderDetail(orderDetail);
        }
        public string DeleteOrderDetailById(int id)
        {
            return _order.DeleteOrderDetailById(id);
        }
        public List<OrderDetail> GetAllOrderDetail()
        {
            return _order.GetAllOrderDetail();
        }
        public OrderDetail GetOrderDetailById(int id)
        {
            return _order.GetOrderDetailById(id);
        }
        public string UpdateOrderDetail( OrderDetail orderDetail)
        {
            return _order.UpdateOrderDetail( orderDetail);
        }
    }
}
