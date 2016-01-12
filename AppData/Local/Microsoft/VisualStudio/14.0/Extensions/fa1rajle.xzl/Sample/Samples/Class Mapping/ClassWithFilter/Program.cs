using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace ClassWithFilter {
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
      Console.WriteLine("Departments(filter disabled):");
      Console.WriteLine("------------------------------------------------------");
      foreach (Department Department in session.CreateQuery("from Department").List<Department>()) {
        Console.WriteLine(string.Format("{0}  {1} {2}", Department.DEPTNO, Department.DNAME, Department.LOC));
      }

    
      session.EnableFilter("MyFilter").SetParameter("param", 20);

      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Departments (filter enabled):");
      Console.WriteLine("------------------------------------------------------");
      foreach (Department Department in session.CreateQuery("from Department").List<Department>()) {
        Console.WriteLine(string.Format("{0}  {1} {2}", Department.DEPTNO, Department.DNAME, Department.LOC));
      }

      session.DisableFilter("MyFilter");

      Console.Read();
    }
  }
}
