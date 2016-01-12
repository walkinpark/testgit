using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;

namespace WithoutResult {
  class Program {
    static void Main(string[] args) {

      Devart.Data.SQLite.SQLiteConnection connection = new Devart.Data.SQLite.SQLiteConnection(@"Data Source=..\..\Database\database.db");
      connection.Open();

      Devart.Data.SQLite.SQLiteScript script = new Devart.Data.SQLite.SQLiteScript(@"
DELETE FROM Department;

INSERT INTO Department VALUES (10,'ACCOUNTING','NEW YORK');
INSERT INTO Department VALUES (20,'RESEARCH','DALLAS');
INSERT INTO Department VALUES (30,'SALES','CHICAGO');
INSERT INTO Department VALUES (40,'OPERATIONS','BOSTON');
", connection);
      script.Execute();

      Console.WriteLine("");
      Console.WriteLine("Departments count: 4.");
      Console.WriteLine("");
      Console.WriteLine("Execute InsertDepartment query. SQL:");

      ISessionFactory sessionFactory = new Configuration().AddAssembly(typeof(Program).Assembly).BuildSessionFactory();
      ISession session = sessionFactory.OpenSession();
      databaseModelMethodsExecutor executor = new databaseModelMethodsExecutor(session);
      executor.InsertDepartment(50, "MANAGERS", "NEW YORK");

      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("Retrieve Departments. SQL:");

      IList<Department> result = session.CreateQuery("from Department").List<Department>();
      Console.WriteLine("");
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
