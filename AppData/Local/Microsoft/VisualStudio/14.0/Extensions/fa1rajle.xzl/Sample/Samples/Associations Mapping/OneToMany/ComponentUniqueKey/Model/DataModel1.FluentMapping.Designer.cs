//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate Fluent Mapping template.
// Code is generated on: 14.06.2012 15:22:18
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

namespace ComponentUniqueKey
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
              Table("Employee");
              LazyLoad();
              Id(x => x.EmployeeId)
                .Column("EmployeeId")
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
                .Length(10);
              References(x => x.Department)
                .Class<Department>()
                .Access.Property()
                .Cascade.None()
                .LazyLoad()
                .PropertyRef(p => p.UniqueKey)
                .Columns("DepartmentName", "DepartmentPhone");
        }
    }

    public class DepartmentMap : ClassMap<Department>
    {
        public DepartmentMap()
        {
              Table("Department");
              LazyLoad();
              Id(x => x.DepartmentId)
                .Column("DepartmentId")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("INTEGER")
                .Not.Nullable()                
                .GeneratedBy.Identity();
              Component(x => x.UniqueKey,
                        aUniqueKey => {
                        aUniqueKey.Access.Property();
                        aUniqueKey.Map(x => x.Name)    
                            .Column("Name")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Length(14);
                        aUniqueKey.Map(x => x.Phone)    
                            .Column("Phone")
                            .CustomType("String")
                            .Access.Property()
                            .Generated.Never()
                            .CustomSqlType("VARCHAR")
                            .Length(20);
                        });
              HasMany<Employee>(x => x.Employees)
                .Access.Property()
                .AsSet()
                .Cascade.None()
                .LazyLoad()
                .PropertyRef("UniqueKey")
                // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
                .Inverse()
                .Generic()
                .KeyColumns.Add("DepartmentName", mapping => mapping.Name("DepartmentName")
                                                                     .SqlType("VARCHAR")
                                                                     .Nullable()
                                                                     .Length(14))
                .KeyColumns.Add("DepartmentPhone", mapping => mapping.Name("DepartmentPhone")
                                                                     .SqlType("VARCHAR")
                                                                     .Nullable()
                                                                     .Length(20));
        }
    }

}
