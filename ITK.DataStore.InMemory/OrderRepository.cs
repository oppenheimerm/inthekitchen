using ITK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITK.DataStore.InMemory
{
    public class OrderRepository// : IOrderRepository
    {
        private List<Order> _orders;

        public OrderRepository()
        {
            _orders = new List<Order>()
            {
                new Order(){ OrderDate = new DateTime(2022, 01, 05), FirstName = "Victoria", LastName = "Cooper", PostCode = "NW1 3RM", AddressLine1 = "34 Trout Lane, Sparrows Reach, London", OrderStatus = OrderStatus.COMPLETED },
                new Order(){ OrderDate = new DateTime(2022, 01, 14), FirstName = "Stacey", LastName = "Smith", PostCode = "M4 1RH", AddressLine1 = "12 Somerset Drive, Hersey, Bristol", OrderStatus = OrderStatus.COMPLETED},
                new Order(){ OrderDate = new DateTime(2022, 02, 29), FirstName = "Bjorn", LastName = "Hensen", PostCode = "S1 9ER", AddressLine1 = "1 Red House Square, Northhampton", OrderStatus =  OrderStatus.COMPLETED}/*,
                new Order(){ OrderDate = , FirstName = "", LastName = "", PostCode = "", AddressLine1 = "", OrderStatus = },
                new Order(){ OrderDate = , FirstName = "", LastName = "", PostCode = "", AddressLine1 = "", OrderStatus = },
                new Order(){ OrderDate = , FirstName = "", LastName = "", PostCode = "", AddressLine1 = "", OrderStatus = },
                new Order(){ OrderDate = , FirstName = "", LastName = "", PostCode = "", AddressLine1 = "", OrderStatus = },
                new Order(){ OrderDate = , FirstName = "", LastName = "", PostCode = "", AddressLine1 = "", OrderStatus = },
                new Order(){ OrderDate = , FirstName = "", LastName = "", PostCode = "", AddressLine1 = "", OrderStatus = },
                new Order(){ OrderDate = , FirstName = "", LastName = "", PostCode = "", AddressLine1 = "", OrderStatus = },
                new Order(){ OrderDate = , FirstName = "", LastName = "", PostCode = "", AddressLine1 = "", OrderStatus = },
                new Order(){ OrderDate = , FirstName = "", LastName = "", PostCode = "", AddressLine1 = "", OrderStatus = },
                new Order(){ OrderDate = , FirstName = "", LastName = "", PostCode = "", AddressLine1 = "", OrderStatus = },
                new Order(){ OrderDate = , FirstName = "", LastName = "", PostCode = "", AddressLine1 = "", OrderStatus = },
                new Order(){ OrderDate = , FirstName = "", LastName = "", PostCode = "", AddressLine1 = "", OrderStatus = },*/

            };
        }
    }
}
