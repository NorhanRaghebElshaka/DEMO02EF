using DEMO02EF.Context;
using DEMO02EF.Entites;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static object context;

    private static void Main(string[] args)
    {
        #region Revision

        // EF Core: ORM in .NET
        // ORM

        // 1. Mapping
        //    Code First [Generate Table Per Class]
        //    DB First [Generate Class Per Table]
        //    2. L2E [C# Code (LINQ) --> EF Core --> SQL DB]

        // 3 Ways Generate
        // 1. TPC : Table Per Class
        // 2. TPH : Table Per Hierarchy
        // 3. TPCC : Table Per Concrete Class

        //code 
        #endregion

        // CRUD Operation
        // Create - Read - Update - Delete

        // AppDbContext context = new AppDbContext();
        // try
        // {
        //     // Code
        // }
        // finally
        // {
        //     context.Dispose();
        // }

        // using (AppDbContext context = new AppDbContext())
        // {
        //     CRUD
        // }

        using AppDbContext Context= new AppDbContext();


        #region  // Create - Insert

        // Create - Insert

        var employee = new Employee()
        {
            Name = "Ahmed Ali",
            Salary = 12000,
            Address = "Cairo",
            Age = 25
        };

        /*///  Console.WriteLine(context.Entry(employee).State); // Detached
                                                            // context.Add(employee);
                                                            // context.Employees.Add(employee);*/


        //Console.WriteLine(context.Entry(employee).State); // Detached
        //                                                  // context.Add(employee);
        //context.Employee.Add(employee);

        //Console.WriteLine(context.Entry(employee).State); // Added
        //var Result = context.SaveChanges();
        //Console.WriteLine(context.Entry(employee).State); // Unchanged
        //Console.WriteLine(Result);



        //Console.WriteLine(context.Entry(employee).State);

        //context.Entry(employee).State = EntityState.Added;

        //Console.WriteLine(context.Entry(employee).State);

        //context.SaveChanges();


        #endregion


        #region   // Read - Select
        // Read - Select

        //var Result = context.Employees.Where(E => E.Id == 40).FirstOrDefault();
        //var Result = context.Employees.FirstOrDefault(E => E.Id == 40);

        var Result = context.Employee.Select(E => E.Id);

        foreach (var item in Result)
        {
            Console.WriteLine(item.Name);
        }

        //Console.WriteLine(Result?.Name);
        //Console.WriteLine(Result?.Id);



        #endregion


        #region   //// Update


        //// Update

        //var Result = context.Employees.FirstOrDefault(E => E.Id == 40);

        //Console.WriteLine(context.Entry(Result).State);

        //Result.Name = "Omar Mohamed";
        ////Console.WriteLine(context.Entry(Result).State);

        ////context.Update(Result);
        //Console.WriteLine(context.Entry(Result).State);

        //context.SaveChanges();
        //Console.WriteLine(context.Entry(Result).State);

        #endregion


        #region //// Delete

        //// Delete
        //var Result = context.Employees.FirstOrDefault(E => E.Id == 30);
        //Console.WriteLine(context.Entry(Result).State); // Unchanged

        //context.Employees.Remove(Result);
        //Console.WriteLine(context.Entry(Result).State); // Deleted

        //context.SaveChanges();
        //Console.WriteLine(context.Entry(Result).State); // Detached 
        #endregion



        //Employee employee = new Employee();
        //Department department = new Department();

        //employee.WorkFor = department;

        //department.Manager = employee;
      

    }
}