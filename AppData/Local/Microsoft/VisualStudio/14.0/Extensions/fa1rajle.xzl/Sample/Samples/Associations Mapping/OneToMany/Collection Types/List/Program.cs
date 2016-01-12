using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace List {
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
      foreach (Conversation conversation in session.CreateQuery("from Conversation").List<Conversation>()) {
        Console.WriteLine(string.Format("{0}|  Message Count: {1} ", conversation.Description, conversation.Messages.Count));
        foreach (Message message in conversation.Messages) {
          Console.WriteLine(string.Format("       Message: {0}", message.Text));
        }
      }
      Console.Read();
    }
  }
}
