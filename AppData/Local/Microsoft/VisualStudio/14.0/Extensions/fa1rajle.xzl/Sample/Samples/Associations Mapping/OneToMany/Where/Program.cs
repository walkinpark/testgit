using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace Where {
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
        Console.WriteLine(string.Format("{0}|  Employees Count: {1} ", Department.Name, Department.Employees.Count));
        foreach (Employee employee in Department.Employees)
          Console.WriteLine(string.Format("       Employee: {0} {1}", employee.EmployeeId, employee.Name));
      }
      Console.Read();
    }
  }
}
