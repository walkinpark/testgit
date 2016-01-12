using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace MapWithComplexTypeIndex {
  class Program {
    static void Main(string[] args) {

      ISessionFactory sessionFactory = new Configuration().AddAssembly(typeof(Program).Assembly).BuildSessionFactory();
      ISession session = sessionFactory.OpenSession();

      IList<Department> result = session.CreateQuery("from Department").List<Department>();

      // select all employees
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Department:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Department Department in result) {
        Console.WriteLine(string.Format("{0}|  Employees Count: {1} ", Department.Name, Department.Employees.Count));
      }


      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Retrive only the employees with the name 'SMITH MENSON' from the first Department:");
      Console.WriteLine("------------------------------------------------------");
      KeyType key = new KeyType() {
        FirstName = "SMITH",
        LastName = "MENSON"
      };
      Console.WriteLine(string.Format("Employee Id: {0}, Name: {1} {2} ", result.First().Employees[key].EmployeeId, result.First().Employees[key].FirstName, result.First().Employees[key].LastName));

      Console.Read();
    }
  }
}
