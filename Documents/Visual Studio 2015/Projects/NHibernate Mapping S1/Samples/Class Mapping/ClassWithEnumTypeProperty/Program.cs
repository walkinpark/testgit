using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace ClassWithEnumTypeProperty {
  class Program {
    static void Main(string[] args) {

      bool isFluentMapping = false;
      ISessionFactory sessionFactory;
      if (isFluentMapping)
        sessionFactory = Fluently.Configure().Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>()).BuildSessionFactory();
      else
        sessionFactory = new Configuration().AddAssembly(typeof(Program).Assembly).BuildSessionFactory();
      ISession session = sessionFactory.OpenSession();
      IList<Employee> result = session.CreateQuery("from Employee").List<Employee>();
      
            
      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Employee table:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Employee employee in result) {
        Console.WriteLine(string.Format("{0}  {1}:    {2} {3}", employee.EmployeeID, employee.EmployeeType, employee.FirstName, employee.LastName));
      }

      Console.Read();
    }
  }
}
