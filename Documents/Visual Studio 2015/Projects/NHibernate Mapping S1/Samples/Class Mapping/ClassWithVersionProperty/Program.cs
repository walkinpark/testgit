using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace ClassWithVersionProperty {
  class Program {
    static void Main(string[] args) {

      bool isFluentMapping = false;
      ISessionFactory sessionFactory;
      if (isFluentMapping)
        sessionFactory = Fluently.Configure().Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>()).BuildSessionFactory();
      else
        sessionFactory = new Configuration().AddAssembly(typeof(Program).Assembly).BuildSessionFactory();

      Devart.Data.SQLite.SQLiteConnection connection = new Devart.Data.SQLite.SQLiteConnection(@"Data Source=..\..\Database\database.db");
      connection.Open();

      Devart.Data.SQLite.SQLiteScript script = new Devart.Data.SQLite.SQLiteScript(@"
DELETE FROM Department;

INSERT INTO Department(DEPTNO, DNAME, LOC) VALUES (10,'ACCOUNTING','NEW YORK');
INSERT INTO Department(DEPTNO, DNAME, LOC) VALUES (20,'RESEARCH','DALLAS');
INSERT INTO Department(DEPTNO, DNAME, LOC) VALUES (30,'SALES','CHICAGO');
INSERT INTO Department(DEPTNO, DNAME, LOC) VALUES (40,'OPERATIONS','BOSTON');
", connection);
      script.Execute();


      ISession session = sessionFactory.OpenSession();
      IList<Department> result = session.CreateQuery("from Department").List<Department>();

      Devart.Data.SQLite.SQLiteCommand command = new Devart.Data.SQLite.SQLiteCommand("UPDATE Department SET LOC = 'SAN FRANCISCO' WHERE DEPTNO = 10", connection);
      command.ExecuteNonQuery();

      // when you try to update an object Hibernate will check whether the value of the version contained in the object matches that held in the database.
      // If they don't match Hibernate throws a StaleObjectException. If they do Hibernate updates the object incrementing the version. 
      result[0].LOC = "WASHINGTON";
      session.Flush();
    }
  }
}
