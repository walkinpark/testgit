using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;

namespace ScalarValueResult {
  class Program {
    static void Main(string[] args) {

      ISessionFactory sessionFactory = new Configuration().AddAssembly(typeof(Program).Assembly).BuildSessionFactory();
      ISession session = sessionFactory.OpenSession();

      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("Execute GetDepartmentsCount query. SQL:");
      databaseModelMethodsExecutor executor = new databaseModelMethodsExecutor(session);
      Console.WriteLine("GetDepartmentsCount result: {0}.", executor.GetDepartmentsCount());

      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("Retrieve Departments. SQL:");
      IList<Department> result = session.CreateQuery("from Department").List<Department>();
      Console.WriteLine("");
      Console.WriteLine("Departments count: {0}.", result.Count);
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Departments:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Department Department in result) {
        Console.WriteLine(string.Format("{0}: '{1}' '{2}'", Department.Id, Department.Name, Department.Location));
      }

      Console.Read();
    }
  }
}
