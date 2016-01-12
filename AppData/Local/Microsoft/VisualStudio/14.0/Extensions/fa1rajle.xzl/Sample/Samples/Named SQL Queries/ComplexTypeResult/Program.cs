using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;

namespace ComplexTypeResult {
  class Program {
    static void Main(string[] args) {

      ISessionFactory sessionFactory = new Configuration().AddAssembly(typeof(Program).Assembly).BuildSessionFactory();
      ISession session = sessionFactory.OpenSession();
      databaseModelMethodsExecutor executor = new databaseModelMethodsExecutor(session);

      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("Execute GetDepartments query.");
      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Department types:");
      Console.WriteLine("------------------------------------------------------");
      foreach (DepartmentType Department in executor.GetDepartments()) {
        Console.WriteLine(string.Format("'{0}' '{1}'", Department.Name, Department.Location));
      }


      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("Execute GetDepartmentsByLocation query.");
      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Department types with Location='NEW YORK':");
      Console.WriteLine("------------------------------------------------------");
      foreach (DepartmentType Department in executor.GetDepartmentsByLocation("NEW YORK")) {
        Console.WriteLine(string.Format("'{0}' '{1}'", Department.Name, Department.Location));
      }

      Console.Read();
    }
  }
}
