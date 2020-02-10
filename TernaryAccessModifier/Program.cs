using System;

namespace TernaryAccessModifier {
    class Program {
        static void Main(string[] args) {

            //can print off next id to show even though in customer
            Console.WriteLine(Customer.PrintNextId()) ;
            Console.WriteLine($"the cube of 17 is {cubed(17)}");

            //need to create a customer and an order and
            //order is going to use customer

            var cust1 = new Customer ( "Max Technical Training" );
            var cust2 = new Customer ( "Amazon" );
            var cust3 = new Customer ( "Target" );

            cust1.NationalAccount("yes");

            //create our order
            var order1 = new Order { Id = 1, Amount = 1000, Customer = cust1};
            
            static int cubed(int nbr) {
                return nbr * nbr * nbr;
            }
        }
    }
}
