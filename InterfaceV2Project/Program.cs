using System;

namespace InterfaceV2Project {
    public class Program {
        static void Main(string[] args) {
            var p1 = new Product(1, "Basic Widget", 10, 2500);
            var p2 = new Product(2, "Advanced Widget", 25, 1500);
            var p3 = new Product(3, "Supreme Widget", 50, 1000);

            var s1 = new Service(4, "Basic Service", 25, 1000);
            var s2 = new Service(5, "Priority Support", 50, 550);
            var s3 = new Service(6, "24x7 Support", 100, 750);



        }
    }
}
