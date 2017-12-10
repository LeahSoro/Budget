﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Budget.Data
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Budget")]
	public partial class BudgetDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertExpense(Expense instance);
    partial void UpdateExpense(Expense instance);
    partial void DeleteExpense(Expense instance);
    partial void InsertMethod(Method instance);
    partial void UpdateMethod(Method instance);
    partial void DeleteMethod(Method instance);
    partial void InsertStore(Store instance);
    partial void UpdateStore(Store instance);
    partial void DeleteStore(Store instance);
    #endregion
		
		public BudgetDataContext() : 
				base(global::Budget.Data.Properties.Settings.Default.BudgetConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BudgetDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BudgetDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BudgetDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BudgetDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Expense> Expenses
		{
			get
			{
				return this.GetTable<Expense>();
			}
		}
		
		public System.Data.Linq.Table<Method> Methods
		{
			get
			{
				return this.GetTable<Method>();
			}
		}
		
		public System.Data.Linq.Table<Store> Stores
		{
			get
			{
				return this.GetTable<Store>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Expenses")]
	public partial class Expense : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Type;
		
		private int _StoreId;
		
		private System.DateTime _Date;
		
		private decimal _Amount;
		
		private int _RecurringType;
		
		private int _MethodId;
		
		private EntityRef<Method> _Method;
		
		private EntityRef<Store> _Store;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnStoreIdChanging(int value);
    partial void OnStoreIdChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnAmountChanging(decimal value);
    partial void OnAmountChanged();
    partial void OnRecurringTypeChanging(int value);
    partial void OnRecurringTypeChanged();
    partial void OnMethodIdChanging(int value);
    partial void OnMethodIdChanged();
    #endregion
		
		public Expense()
		{
			this._Method = default(EntityRef<Method>);
			this._Store = default(EntityRef<Store>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StoreId", DbType="Int NOT NULL")]
		public int StoreId
		{
			get
			{
				return this._StoreId;
			}
			set
			{
				if ((this._StoreId != value))
				{
					if (this._Store.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStoreIdChanging(value);
					this.SendPropertyChanging();
					this._StoreId = value;
					this.SendPropertyChanged("StoreId");
					this.OnStoreIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Money NOT NULL")]
		public decimal Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecurringType", DbType="Int NOT NULL")]
		public int RecurringType
		{
			get
			{
				return this._RecurringType;
			}
			set
			{
				if ((this._RecurringType != value))
				{
					this.OnRecurringTypeChanging(value);
					this.SendPropertyChanging();
					this._RecurringType = value;
					this.SendPropertyChanged("RecurringType");
					this.OnRecurringTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MethodId", DbType="Int NOT NULL")]
		public int MethodId
		{
			get
			{
				return this._MethodId;
			}
			set
			{
				if ((this._MethodId != value))
				{
					if (this._Method.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMethodIdChanging(value);
					this.SendPropertyChanging();
					this._MethodId = value;
					this.SendPropertyChanged("MethodId");
					this.OnMethodIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Method_Expense", Storage="_Method", ThisKey="MethodId", OtherKey="id", IsForeignKey=true)]
		public Method Method
		{
			get
			{
				return this._Method.Entity;
			}
			set
			{
				Method previousValue = this._Method.Entity;
				if (((previousValue != value) 
							|| (this._Method.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Method.Entity = null;
						previousValue.Expenses.Remove(this);
					}
					this._Method.Entity = value;
					if ((value != null))
					{
						value.Expenses.Add(this);
						this._MethodId = value.id;
					}
					else
					{
						this._MethodId = default(int);
					}
					this.SendPropertyChanged("Method");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Store_Expense", Storage="_Store", ThisKey="StoreId", OtherKey="Id", IsForeignKey=true)]
		public Store Store
		{
			get
			{
				return this._Store.Entity;
			}
			set
			{
				Store previousValue = this._Store.Entity;
				if (((previousValue != value) 
							|| (this._Store.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Store.Entity = null;
						previousValue.Expenses.Remove(this);
					}
					this._Store.Entity = value;
					if ((value != null))
					{
						value.Expenses.Add(this);
						this._StoreId = value.Id;
					}
					else
					{
						this._StoreId = default(int);
					}
					this.SendPropertyChanged("Store");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Method")]
	public partial class Method : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _Type;
		
		private EntitySet<Expense> _Expenses;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    #endregion
		
		public Method()
		{
			this._Expenses = new EntitySet<Expense>(new Action<Expense>(this.attach_Expenses), new Action<Expense>(this.detach_Expenses));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Method_Expense", Storage="_Expenses", ThisKey="id", OtherKey="MethodId")]
		public EntitySet<Expense> Expenses
		{
			get
			{
				return this._Expenses;
			}
			set
			{
				this._Expenses.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Expenses(Expense entity)
		{
			this.SendPropertyChanging();
			entity.Method = this;
		}
		
		private void detach_Expenses(Expense entity)
		{
			this.SendPropertyChanging();
			entity.Method = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Store")]
	public partial class Store : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Expense> _Expenses;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Store()
		{
			this._Expenses = new EntitySet<Expense>(new Action<Expense>(this.attach_Expenses), new Action<Expense>(this.detach_Expenses));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Store_Expense", Storage="_Expenses", ThisKey="Id", OtherKey="StoreId")]
		public EntitySet<Expense> Expenses
		{
			get
			{
				return this._Expenses;
			}
			set
			{
				this._Expenses.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Expenses(Expense entity)
		{
			this.SendPropertyChanging();
			entity.Store = this;
		}
		
		private void detach_Expenses(Expense entity)
		{
			this.SendPropertyChanging();
			entity.Store = null;
		}
	}
}
#pragma warning restore 1591