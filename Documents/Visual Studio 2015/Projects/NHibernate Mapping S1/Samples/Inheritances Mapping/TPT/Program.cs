using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace TPT {
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
      Console.WriteLine("All Animals:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Animal animal in session.CreateQuery("from Animal").List<Animal>()) {
        if (animal is Snake)
          Console.WriteLine(string.Format("Class:'{0}' FoodClassification:'{1}' IsVenomous:'{2}' Length:{3}", animal.GetType().Name, animal.FoodClassification, ((Snake)animal).IsVenomous, ((Snake)animal).Length));
        else
          if (animal is Crocodile)
            Console.WriteLine(string.Format("Class:'{0}' FoodClassification:'{1}' Length:{2}", animal.GetType().Name, animal.FoodClassification, ((Crocodile)animal).Length));
          else
            if (animal is Horse)
              Console.WriteLine(string.Format("Class:'{0}' FoodClassification:'{1}' Breed:'{2}' MaximumSpeed:{2}", animal.GetType().Name, animal.FoodClassification, ((Horse)animal).Breed, ((Horse)animal).MaximumSpeed));
            else
              if (animal is Dog)
                Console.WriteLine(string.Format("Class:'{0}' FoodClassification:'{1}' Breed:'{2}'", animal.GetType().Name, animal.FoodClassification, ((Dog)animal).Breed));
      }


      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Snakes:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Snake snake in session.CreateQuery("from Snake").List<Snake>())
        Console.WriteLine(string.Format("Class:'{0}' FoodClassification:'{1}' IsVenomous:'{2}' Length:{3}", snake.GetType().Name, snake.FoodClassification, snake.IsVenomous, snake.Length));
     

      Console.Read();
    }
  }
}
