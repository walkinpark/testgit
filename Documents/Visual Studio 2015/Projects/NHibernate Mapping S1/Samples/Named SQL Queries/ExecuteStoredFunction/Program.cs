using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;

namespace ExecuteStoredFunction {
  class Program {
    static void Main(string[] args) {

      ISessionFactory sessionFactory = new Configuration().AddAssembly(typeof(Program).Assembly).BuildSessionFactory();
      ISession session = sessionFactory.OpenSession();
      ModelMethodsExecutor executor = new ModelMethodsExecutor(session);

      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("Sqrt(25)={0}", executor.Sqrt(25));

      Console.Read();
    }
  }
}
