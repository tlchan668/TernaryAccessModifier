using System;
using System.Collections.Generic;
using System.Text;

namespace TernaryAccessModifier {
    public class Order {

        public int Id { get; set; }
        public double Amount{ get; set; }
        public Customer Customer { get; set; }

        //create method 
        public void SetCustomer(Customer customer) {

        }
    }
}
