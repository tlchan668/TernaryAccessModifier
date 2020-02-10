using System;
using System.Collections.Generic;
using System.Text;

namespace TernaryAccessModifier {
    public class Customer {

        private static int NextId = 1;//after each instance will increment everyone will share this one value
        public int Id { get; set; }
        public string Name { get; set; }
        private bool IsNationalAccount { get; set; }

        public void NationalAccount (string yesOrNo) {
            //just looking at first letter only looking for y or n, throw others away
            //this.IsNationalAccount = yesOrNo.StartsWith("y");
            //if look for "yes" use
            this.IsNationalAccount = yesOrNo.Equals("yes") ? true : false;

        }

        public static string PrintNextId() {
            return $"next id is {NextId}";
            
        }
        //constructor for next id
        public Customer(string Name) {
            this.Id = NextId;//take off this to be part of class and not an instance
            this.Name = Name;
            NextId++;
        }
    }
}
