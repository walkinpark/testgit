﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 14.06.2012 18:59:17
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

namespace Map
{

    /// <summary>
    /// There are no comments for Map.Employee, Map in the schema.
    /// </summary>
    public partial class Employee {

        private int _EmployeeId;

        private string _Name;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public Employee()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for EmployeeId in the schema.
        /// </summary>
        public virtual int EmployeeId
        {
            get
            {
                return this._EmployeeId;
            }
            set
            {
                this._EmployeeId = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Name in the schema.
        /// </summary>
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
            }
        }
    }

    /// <summary>
    /// There are no comments for Map.Department, Map in the schema.
    /// </summary>
    public partial class Department {

        private int _DepartmentId;

        private string _Name;

        private IDictionary<string,Employee> _Employees;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public Department()
        {
            this._Employees = new Dictionary<string,Employee>();
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for DepartmentId in the schema.
        /// </summary>
        public virtual int DepartmentId
        {
            get
            {
                return this._DepartmentId;
            }
            set
            {
                this._DepartmentId = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Name in the schema.
        /// </summary>
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Employees in the schema.
        /// </summary>
        public virtual IDictionary<string,Employee> Employees
        {
            get
            {
                return this._Employees;
            }
            set
            {
                this._Employees = value;
            }
        }
    }

}
