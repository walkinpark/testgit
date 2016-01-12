using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace CompositeID {
  class Program {
    static void Main(string[] args) {

      bool isFluentMapping = false;
      ISessionFactory sessionFactory;
      if (isFluentMapping)
        sessionFactory = Fluently.Configure().Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>()).BuildSessionFactory();
      else
        sessionFactory = new Configuration().AddAssembly(typeof(Program).Assembly).BuildSessionFactory();
      ISession session = sessionFactory.OpenSession();

      IList<DepartmentPhone> result = session.CreateQuery("from DepartmentPhone").List<DepartmentPhone>();
      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("DepartmentPhone table:");
      Console.WriteLine("------------------------------------------------------");
      foreach (DepartmentPhone DepartmentPhone in result) {
        Console.WriteLine(string.Format("PK({0}-{1}): '{2}'  {3}  {4}", DepartmentPhone.DepartmentPhoneID.DepartmentID, DepartmentPhone.DepartmentPhoneID.PhoneID, DepartmentPhone.PhoneNumber, DepartmentPhone.DeptName, DepartmentPhone.Location));
      }

      Console.Read();
    }
  }
}
