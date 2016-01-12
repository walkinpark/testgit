//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate Fluent Mapping template.
// Code is generated on: 15.06.2012 18:12:00
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using FluentNHibernate.MappingModel.Collections;

namespace JoinTables
{
    public class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
              Table("Orders");
              LazyLoad();
              Id(x => x.OrderID)
                .Column("OrderID")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("INTEGER")
                .Not.Nullable()                
                .GeneratedBy.Identity();
              Map(x => x.Company)    
                .Column("Company")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(50);
              Join("OrderDetails", j => {
                        j.KeyColumn("OrderID");
                        j.Map(x => x.Price)    
                            .Column("Price")
                            .CustomType("Double")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("REAL");
                        j.HasMany<OrderImplementer>(x => x.OrderImplementers)    
                                    .Access.Property()
                                    .AsSet()
                                    .Cascade.None()
                                    .LazyLoad()
                                    // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
                                    .Inverse()
                                    .Generic()
                                    .KeyColumns.Add("OrderID", mapping => mapping.Name("OrderID")
                                                                                         .SqlType("INTEGER")
                                                                                         .Not.Nullable());
                        });
        }
    }

    public class OrderImplementerMap : ClassMap<OrderImplementer>
    {
        public OrderImplementerMap()
        {
              Table("OrderImplementers");
              LazyLoad();
              Id(x => x.ImplementerID)
                .Column("ImplementerID")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("INTEGER")
                .Not.Nullable()                
                .GeneratedBy.Identity();
              Map(x => x.Name)    
                .Column("Name")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("VARCHAR")
                .Length(50);
              References(x => x.Order)
                .Class<Order>()
                .Access.Property()
                .Cascade.None()
                .LazyLoad()
                .Columns("OrderID");
        }
    }

}
