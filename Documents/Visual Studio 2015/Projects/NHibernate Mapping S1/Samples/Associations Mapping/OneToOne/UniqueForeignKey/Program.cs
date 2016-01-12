using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace UniqueForeignKey {
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
      Console.WriteLine("Contact:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Contact contact in session.CreateQuery("from Contact").List<Contact>()) {
        Console.WriteLine(string.Format("{0} '{1}'|  Person: '{2}' {3}", contact.Name, contact.Phone, contact.Person.BirthDay.ToString(), contact.Person.Address));
      }
      Console.Read();
    }
  }
}
