﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 13.06.2012 11:28:59
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

namespace CompositeID
{

    /// <summary>
    /// There are no comments for CompositeID.DepartmentPhone, CompositeID in the schema.
    /// </summary>
    public partial class DepartmentPhone {

        private int _DeptID;

        private int _PhoneID;

        private string _PhoneNumber;

        private string _DeptName;

        private string _Location;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          DepartmentPhone toCompare = obj as DepartmentPhone;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.DeptID, toCompare.DeptID))
            return false;
          if (!Object.Equals(this.PhoneID, toCompare.PhoneID))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + DeptID.GetHashCode();
          hashCode = (hashCode * 7) + PhoneID.GetHashCode();
          return hashCode;
        }
        
        #endregion

        public DepartmentPhone()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for DeptID in the schema.
        /// </summary>
        public virtual int DeptID
        {
            get
            {
                return this._DeptID;
            }
            set
            {
                this._DeptID = value;
            }
        }

    
        /// <summary>
        /// There are no comments for PhoneID in the schema.
        /// </summary>
        public virtual int PhoneID
        {
            get
            {
                return this._PhoneID;
            }
            set
            {
                this._PhoneID = value;
            }
        }

    
        /// <summary>
        /// There are no comments for PhoneNumber in the schema.
        /// </summary>
        public virtual string PhoneNumber
        {
            get
            {
                return this._PhoneNumber;
            }
            set
            {
                this._PhoneNumber = value;
            }
        }

    
        /// <summary>
        /// There are no comments for DeptName in the schema.
        /// </summary>
        public virtual string DeptName
        {
            get
            {
                return this._DeptName;
            }
            set
            {
                this._DeptName = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Location in the schema.
        /// </summary>
        public virtual string Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                this._Location = value;
            }
        }
    }

}
