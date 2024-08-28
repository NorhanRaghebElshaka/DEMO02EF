using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO02EF.Entites
{//model//entite
    internal class Employee
    {

        public int Id { get; set; } // pk -> emplioyee identity (1.1)

        public string Name { get; set; }    //nvrchar (max)

        public double Salary {  get; set; }

        public int Age  { get;  set; }

        public string Address {  get; set; }

      
          
        //    [InverseProperty(nameof(Department.Manager))]
            public Department Department { get; set; }

            public int WorkForId { get; set; } // FK

            public Department? WorkFor { get; set; }
      
    }
}
