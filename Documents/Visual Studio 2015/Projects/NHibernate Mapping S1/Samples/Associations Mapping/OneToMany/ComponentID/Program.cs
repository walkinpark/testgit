using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace ComponentID {
  class Program {
    static void Main(string[] args) {

      bool isFluentMapping = false;
      ISessionFactory sessionFactory;
      if (isFluentMapping)
        sessionFactory = Fluently.Configure().Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>()).BuildSessionFactory();
      else
        sessionFactory = new Configuration().AddAssembly(typeof(Program).Assembly).BuildSessionFactory();
      ISession session = sessionFactory.OpenSession();
      
      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("DepartmentPhone:");
      Console.WriteLine("------------------------------------------------------");
      foreach (DepartmentPhone DepartmentPhone in session.CreateQuery("from DepartmentPhone").List<DepartmentPhone>()) {
        Console.WriteLine(string.Format("'{1}' - {0}: Employees count: {2}", DepartmentPhone.Name, DepartmentPhone.PhoneNumber, DepartmentPhone.Employees.Count));
      }

      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Employees:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Employee employee in session.CreateQuery("from Employee").List<Employee>()) {
        Console.WriteLine(string.Format("{0} | Department: {1} '{2}'", employee.Name, employee.DepartmentPhone.Name, employee.DepartmentPhone.PhoneNumber));
      }

      Console.Read();
    }
  }
}
