using System.Data;
using System.Data.Common;
using NHibernate.AdoNet;
using NHibernate.SqlTypes;
using NHibernate.Dialect;
using NHibernate.Dialect.Schema;
using Iesi.Collections.Generic;

namespace NHibernate.Driver {

  public class DevartDriver : ReflectionBasedDriver {

    public DevartDriver()
      : base("Devart.Data.SQLite",
      "Devart.Data.SQLite.SQLiteConnection",
      "Devart.Data.SQLite.SQLiteCommand") {
    }

    public override bool UseNamedPrefixInSql {
      get {
        return true;
      }
    }

    public override bool UseNamedPrefixInParameter {
      get {
        return false;
      }
    }

    public override string NamedPrefix {
      get {
        return ":";
      }
    }

    protected override void InitializeParameter(IDbDataParameter dbParam, string name, SqlType sqlType) {

      base.InitializeParameter(dbParam, name, sqlType);
    }
  }

  public class DevartSQLiteDialect : SQLiteDialect {

    public override Dialect.Schema.IDataBaseSchema GetDataBaseSchema(System.Data.Common.DbConnection connection) {
      return new DevartSQLiteDataBaseMetaData(connection);
    }
  }

  public class DevartSQLiteDataBaseMetaData : SQLiteDataBaseMetaData {

    public DevartSQLiteDataBaseMetaData(DbConnection connection)
      : base(connection) {
    }

    public override Iesi.Collections.Generic.ISet<string> GetReservedWords() {
      var result = new HashedSet<string>();
      DataTable dtReservedWords = Connection.GetSchema(DbMetaDataCollectionNames.ReservedWords);
      foreach (DataRow row in dtReservedWords.Rows) {
        result.Add(row["name"].ToString());
      }
      return result;
    }
  }
}