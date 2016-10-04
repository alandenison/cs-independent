using System;
using System.Collections.Generic;

namespace CustomerService.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public long Zip { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}