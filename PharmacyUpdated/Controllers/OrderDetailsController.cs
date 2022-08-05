using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmacyUpdated.Models;
using PharmacyUpdated.services;

namespace PharmacyUpdated.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly OrderDetailsService _order;

        public OrderDetailsController(OrderDetailsService order)
        {
            _order = order;
        }

        // GET: api/OrderDetail
        [HttpGet]
        public List<OrderDetail> GetOrderDetails()
        {
            return _order.GetAllOrderDetail();
        }



        // GET: api/OrderDetail/5
        [HttpGet("{id}")]
        public IActionResult GetOrderDetail(int id)
        {
            
            return Ok(_order.GetOrderDetailById(id));
        }

        // PUT: api/OrderDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutOrderDetail( OrderDetail orderDetail)
        {

            return Ok(_order.UpdateOrderDetail(orderDetail));
        }

        // POST: api/OrderDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult PostOrderDetail(OrderDetail orderDetail)
        {
            return Ok(_order.CreateOrderDetail(orderDetail));
        }

        // DELETE: api/OrderDetail/5
        [HttpDelete("{id}")]
        public IActionResult DeleteOrderDetail(int id)
        {
            

            return Ok(_order.DeleteOrderDetailById(id));
        }

    }
}
