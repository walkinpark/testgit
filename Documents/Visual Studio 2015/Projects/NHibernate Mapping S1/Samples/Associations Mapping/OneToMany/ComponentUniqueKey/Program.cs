using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace ComponentUniqueKey {
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
      Console.WriteLine("Department:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Department Department in session.CreateQuery("from Department").List<Department>()) {
        Console.WriteLine(string.Format("'{1}' - {0}: Employees count: {2}", Department.UniqueKey.Phone, Department.UniqueKey.Name, Department.Employees.Count));
      }

      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Employees:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Employee employee in session.CreateQuery("from Employee").List<Employee>()) {
        Console.WriteLine(string.Format("{0} | Department: {1} '{2}'", employee.Name, employee.Department.UniqueKey.Name, employee.Department.UniqueKey.Phone));
      }
      Console.Read();
    }
  }
}
