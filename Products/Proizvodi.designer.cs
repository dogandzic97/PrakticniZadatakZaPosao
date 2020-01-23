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

namespace Products
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
    using System.ComponentModel.DataAnnotations;

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Proizvodi")]
	public partial class ProizvodiDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProizvod(Proizvod instance);
    partial void UpdateProizvod(Proizvod instance);
    partial void DeleteProizvod(Proizvod instance);
    #endregion
		
		public ProizvodiDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ProizvodiConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProizvodiDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProizvodiDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProizvodiDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProizvodiDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Proizvod> Proizvods
		{
			get
			{
				return this.GetTable<Proizvod>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Proizvod")]
	public partial class Proizvod : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Naziv;
		
		private string _Opis;
		
		private string _Kategorija;
		
		private string _Proizvodjac;
		
		private string _Dobavljac;
		
		private double _Cena;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNazivChanging(string value);
    partial void OnNazivChanged();
    partial void OnOpisChanging(string value);
    partial void OnOpisChanged();
    partial void OnKategorijaChanging(string value);
    partial void OnKategorijaChanged();
    partial void OnProizvodjacChanging(string value);
    partial void OnProizvodjacChanged();
    partial void OnDobavljacChanging(string value);
    partial void OnDobavljacChanged();
    partial void OnCenaChanging(double value);
    partial void OnCenaChanged();
    #endregion
		
		public Proizvod()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Naziv", DbType="NVarChar(50)")]
        [Required]
		public string Naziv
		{
			get
			{
				return this._Naziv;
			}
			set
			{
				if ((this._Naziv != value))
				{
					this.OnNazivChanging(value);
					this.SendPropertyChanging();
					this._Naziv = value;
					this.SendPropertyChanged("Naziv");
					this.OnNazivChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Opis", DbType="NVarChar(250)")]
        [Required]
        public string Opis
		{
			get
			{
				return this._Opis;
			}
			set
			{
				if ((this._Opis != value))
				{
					this.OnOpisChanging(value);
					this.SendPropertyChanging();
					this._Opis = value;
					this.SendPropertyChanged("Opis");
					this.OnOpisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kategorija", DbType="NVarChar(100)")]
        [Required]
        public string Kategorija
		{
			get
			{
				return this._Kategorija;
			}
			set
			{
				if ((this._Kategorija != value))
				{
					this.OnKategorijaChanging(value);
					this.SendPropertyChanging();
					this._Kategorija = value;
					this.SendPropertyChanged("Kategorija");
					this.OnKategorijaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Proizvodjac", DbType="NVarChar(50)")]
        [Required]
        public string Proizvodjac
		{
			get
			{
				return this._Proizvodjac;
			}
			set
			{
				if ((this._Proizvodjac != value))
				{
					this.OnProizvodjacChanging(value);
					this.SendPropertyChanging();
					this._Proizvodjac = value;
					this.SendPropertyChanged("Proizvodjac");
					this.OnProizvodjacChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dobavljac", DbType="NVarChar(50)")]
        [Required]
        public string Dobavljac
		{
			get
			{
				return this._Dobavljac;
			}
			set
			{
				if ((this._Dobavljac != value))
				{
					this.OnDobavljacChanging(value);
					this.SendPropertyChanging();
					this._Dobavljac = value;
					this.SendPropertyChanged("Dobavljac");
					this.OnDobavljacChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cena", DbType="Float NOT NULL")]
        [Required]
        public double Cena
		{
			get
			{
				return this._Cena;
			}
			set
			{
				if ((this._Cena != value))
				{
					this.OnCenaChanging(value);
					this.SendPropertyChanging();
					this._Cena = value;
					this.SendPropertyChanged("Cena");
					this.OnCenaChanged();
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
}
#pragma warning restore 1591