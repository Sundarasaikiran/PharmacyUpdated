using Microsoft.EntityFrameworkCore;
using PharmacyUpdated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PharmacyUpdated.Repository
{
    public class OrderDetailRepo : IOrderDetails
    {
        private readonly PharmacyProjectContext _context;
        public OrderDetailRepo(PharmacyProjectContext context)
        {
            _context = context;
        }
        #region CreateOrderDetail
        public string CreateOrderDetail(OrderDetail orderDetail)
        {
            string stcode = string.Empty;
            try
            {
                _context.OrderDetails.Add(orderDetail);
                _context.SaveChangesAsync();
                stcode = "200";
            }
            catch (Exception)
            {
                stcode = "400";
            }

            return stcode;
        }
        #endregion

        #region DeleteOrderDetailById
        public string DeleteOrderDetailById(int id)
        {
            string Result=string.Empty;
            OrderDetail orderDetail=null;
            try
            {
                orderDetail = _context.OrderDetails.Find(id);
                if (orderDetail != null)
                {
                    _context.OrderDetails.Remove(orderDetail);
                    _context.SaveChangesAsync();
                    Result = "200";
                }
                
            }catch (Exception)
            {
                Result = "400";
            }

            return Result;
        }
        #endregion

        #region GetAllOrderDetail
        public List<OrderDetail> GetAllOrderDetail()
        {

            List<OrderDetail> result = null;
            try
            {
                result = _context.OrderDetails.ToList();
            }
            catch (Exception)
            {

            }
            return result;
        }
        #endregion

        #region GetOrderDetailById
        public OrderDetail GetOrderDetailById(int id)
        {
            OrderDetail result = null;
            try
            {
                result= _context.OrderDetails.FirstOrDefault(OrderDetail => OrderDetail.OrderId == id);
            }
            catch (Exception)
            {

            }
            return result;
        }
        #endregion

        #region UpdateOrderDetail
        public string UpdateOrderDetail( OrderDetail orderDetail)
        {
            string Result = string.Empty;

            try
            {
                _context.Entry(orderDetail).State = EntityState.Modified;
                 _context.SaveChanges();
                Result = "200";

               
            }
            catch (Exception)
            {
                Result = "400";
            }
            return Result;
        }
        #endregion
    }
}
