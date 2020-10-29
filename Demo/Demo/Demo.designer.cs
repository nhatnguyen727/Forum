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

namespace Demo
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Blog")]
	public partial class DemoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBantin(Bantin instance);
    partial void UpdateBantin(Bantin instance);
    partial void DeleteBantin(Bantin instance);
    partial void InsertChiTiet(ChiTiet instance);
    partial void UpdateChiTiet(ChiTiet instance);
    partial void DeleteChiTiet(ChiTiet instance);
    #endregion
		
		public DemoDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BlogConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DemoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DemoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DemoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DemoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DangNhap> DangNhaps
		{
			get
			{
				return this.GetTable<DangNhap>();
			}
		}
		
		public System.Data.Linq.Table<Bantin> Bantins
		{
			get
			{
				return this.GetTable<Bantin>();
			}
		}
		
		public System.Data.Linq.Table<ChiTiet> ChiTiets
		{
			get
			{
				return this.GetTable<ChiTiet>();
			}
		}
		
		public System.Data.Linq.Table<comment> comments
		{
			get
			{
				return this.GetTable<comment>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BanTin_Insert")]
		public int BanTin_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string noiDung)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), noiDung);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BanTin_Seclectall")]
		public ISingleResult<BanTin_SeclectallResult> BanTin_Seclectall()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<BanTin_SeclectallResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SeclectID")]
		public ISingleResult<ChiTiet_SeclectIDResult> ChiTiet_SeclectID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBanTin", DbType="Int")] System.Nullable<int> iDBanTin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDBanTin);
			return ((ISingleResult<ChiTiet_SeclectIDResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SelectAll")]
		public ISingleResult<ChiTiet_SelectAllResult> ChiTiet_SelectAll()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ChiTiet_SelectAllResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SLX")]
		public int ChiTiet_SLX([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> lanXem, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), lanXem, iD);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_Insert")]
		public int ChiTiet_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(200)")] string tieuDe, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string noiDung, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> ngayDang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBanTin", DbType="Int")] System.Nullable<int> iDBanTin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tieuDe, noiDung, ngayDang, iDBanTin);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SelectHome")]
		public ISingleResult<ChiTiet_SelectHomeResult> ChiTiet_SelectHome()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ChiTiet_SelectHomeResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_LanXem")]
		public int ChiTiet_LanXem([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> lanXem)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, lanXem);
			lanXem = ((System.Nullable<int>)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SelectRanDom")]
		public ISingleResult<ChiTiet_SelectRanDomResult> ChiTiet_SelectRanDom([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBanTin", DbType="Int")] System.Nullable<int> iDBanTin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDBanTin);
			return ((ISingleResult<ChiTiet_SelectRanDomResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BanTin_SeclectID")]
		public ISingleResult<BanTin_SeclectIDResult> BanTin_SeclectID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBanTin", DbType="Int")] System.Nullable<int> iDBanTin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDBanTin);
			return ((ISingleResult<BanTin_SeclectIDResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_Delete")]
		public int ChiTiet_Delete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_Update")]
		public int ChiTiet_Update([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBanTin", DbType="Int")] System.Nullable<int> iDBanTin, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(200)")] string tieuDe, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string noiDung)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, iDBanTin, tieuDe, noiDung);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SELECT")]
		public ISingleResult<ChiTiet_SELECTResult> ChiTiet_SELECT([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((ISingleResult<ChiTiet_SELECTResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Comment_SelectAll")]
		public ISingleResult<Comment_SelectAllResult> Comment_SelectAll()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<Comment_SelectAllResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DangNhap")]
	public partial class DangNhap
	{
		
		private int _IDName;
		
		private string _userName;
		
		private string _passWord;
		
		public DangNhap()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDName", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int IDName
		{
			get
			{
				return this._IDName;
			}
			set
			{
				if ((this._IDName != value))
				{
					this._IDName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userName", DbType="NVarChar(50)")]
		public string userName
		{
			get
			{
				return this._userName;
			}
			set
			{
				if ((this._userName != value))
				{
					this._userName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passWord", DbType="NVarChar(50)")]
		public string passWord
		{
			get
			{
				return this._passWord;
			}
			set
			{
				if ((this._passWord != value))
				{
					this._passWord = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bantin")]
	public partial class Bantin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDBanTin;
		
		private string _noiDung;
		
		private EntitySet<ChiTiet> _ChiTiets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDBanTinChanging(int value);
    partial void OnIDBanTinChanged();
    partial void OnnoiDungChanging(string value);
    partial void OnnoiDungChanged();
    #endregion
		
		public Bantin()
		{
			this._ChiTiets = new EntitySet<ChiTiet>(new Action<ChiTiet>(this.attach_ChiTiets), new Action<ChiTiet>(this.detach_ChiTiets));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this.OnIDBanTinChanging(value);
					this.SendPropertyChanging();
					this._IDBanTin = value;
					this.SendPropertyChanged("IDBanTin");
					this.OnIDBanTinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noiDung", DbType="NVarChar(50)")]
		public string noiDung
		{
			get
			{
				return this._noiDung;
			}
			set
			{
				if ((this._noiDung != value))
				{
					this.OnnoiDungChanging(value);
					this.SendPropertyChanging();
					this._noiDung = value;
					this.SendPropertyChanged("noiDung");
					this.OnnoiDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bantin_ChiTiet", Storage="_ChiTiets", ThisKey="IDBanTin", OtherKey="IDBanTin")]
		public EntitySet<ChiTiet> ChiTiets
		{
			get
			{
				return this._ChiTiets;
			}
			set
			{
				this._ChiTiets.Assign(value);
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
		
		private void attach_ChiTiets(ChiTiet entity)
		{
			this.SendPropertyChanging();
			entity.Bantin = this;
		}
		
		private void detach_ChiTiets(ChiTiet entity)
		{
			this.SendPropertyChanging();
			entity.Bantin = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTiet")]
	public partial class ChiTiet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _tieuDe;
		
		private string _noiDung;
		
		private System.Nullable<int> _lanXem;
		
		private System.Nullable<System.DateTime> _ngayDang;
		
		private System.Nullable<int> _IDBanTin;
		
		private EntityRef<Bantin> _Bantin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OntieuDeChanging(string value);
    partial void OntieuDeChanged();
    partial void OnnoiDungChanging(string value);
    partial void OnnoiDungChanged();
    partial void OnlanXemChanging(System.Nullable<int> value);
    partial void OnlanXemChanged();
    partial void OnngayDangChanging(System.Nullable<System.DateTime> value);
    partial void OnngayDangChanged();
    partial void OnIDBanTinChanging(System.Nullable<int> value);
    partial void OnIDBanTinChanged();
    #endregion
		
		public ChiTiet()
		{
			this._Bantin = default(EntityRef<Bantin>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tieuDe", DbType="NVarChar(200)")]
		public string tieuDe
		{
			get
			{
				return this._tieuDe;
			}
			set
			{
				if ((this._tieuDe != value))
				{
					this.OntieuDeChanging(value);
					this.SendPropertyChanging();
					this._tieuDe = value;
					this.SendPropertyChanged("tieuDe");
					this.OntieuDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noiDung", DbType="NVarChar(MAX)")]
		public string noiDung
		{
			get
			{
				return this._noiDung;
			}
			set
			{
				if ((this._noiDung != value))
				{
					this.OnnoiDungChanging(value);
					this.SendPropertyChanging();
					this._noiDung = value;
					this.SendPropertyChanged("noiDung");
					this.OnnoiDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lanXem", DbType="Int")]
		public System.Nullable<int> lanXem
		{
			get
			{
				return this._lanXem;
			}
			set
			{
				if ((this._lanXem != value))
				{
					this.OnlanXemChanging(value);
					this.SendPropertyChanging();
					this._lanXem = value;
					this.SendPropertyChanged("lanXem");
					this.OnlanXemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> ngayDang
		{
			get
			{
				return this._ngayDang;
			}
			set
			{
				if ((this._ngayDang != value))
				{
					this.OnngayDangChanging(value);
					this.SendPropertyChanging();
					this._ngayDang = value;
					this.SendPropertyChanged("ngayDang");
					this.OnngayDangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int")]
		public System.Nullable<int> IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					if (this._Bantin.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDBanTinChanging(value);
					this.SendPropertyChanging();
					this._IDBanTin = value;
					this.SendPropertyChanged("IDBanTin");
					this.OnIDBanTinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bantin_ChiTiet", Storage="_Bantin", ThisKey="IDBanTin", OtherKey="IDBanTin", IsForeignKey=true)]
		public Bantin Bantin
		{
			get
			{
				return this._Bantin.Entity;
			}
			set
			{
				Bantin previousValue = this._Bantin.Entity;
				if (((previousValue != value) 
							|| (this._Bantin.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Bantin.Entity = null;
						previousValue.ChiTiets.Remove(this);
					}
					this._Bantin.Entity = value;
					if ((value != null))
					{
						value.ChiTiets.Add(this);
						this._IDBanTin = value.IDBanTin;
					}
					else
					{
						this._IDBanTin = default(Nullable<int>);
					}
					this.SendPropertyChanged("Bantin");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.comment")]
	public partial class comment
	{
		
		private string _name;
		
		private string _com;
		
		private System.Nullable<System.DateTime> _time;
		
		public comment()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(100)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this._name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_com", DbType="NVarChar(MAX)")]
		public string com
		{
			get
			{
				return this._com;
			}
			set
			{
				if ((this._com != value))
				{
					this._com = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="DateTime")]
		public System.Nullable<System.DateTime> time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this._time = value;
				}
			}
		}
	}
	
	public partial class BanTin_SeclectallResult
	{
		
		private int _IDBanTin;
		
		private string _noiDung;
		
		public BanTin_SeclectallResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int NOT NULL")]
		public int IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noiDung", DbType="NVarChar(50)")]
		public string noiDung
		{
			get
			{
				return this._noiDung;
			}
			set
			{
				if ((this._noiDung != value))
				{
					this._noiDung = value;
				}
			}
		}
	}
	
	public partial class ChiTiet_SeclectIDResult
	{
		
		private System.Nullable<int> _ID;
		
		private string _tieuDe;
		
		private string _noiDung;
		
		private System.Nullable<int> _lanXem;
		
		private System.Nullable<System.DateTime> _ngayDang;
		
		private System.Nullable<int> _IDBanTin;
		
		public ChiTiet_SeclectIDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int")]
		public System.Nullable<int> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tieuDe", DbType="NVarChar(200)")]
		public string tieuDe
		{
			get
			{
				return this._tieuDe;
			}
			set
			{
				if ((this._tieuDe != value))
				{
					this._tieuDe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noiDung", DbType="NVarChar(MAX)")]
		public string noiDung
		{
			get
			{
				return this._noiDung;
			}
			set
			{
				if ((this._noiDung != value))
				{
					this._noiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lanXem", DbType="Int")]
		public System.Nullable<int> lanXem
		{
			get
			{
				return this._lanXem;
			}
			set
			{
				if ((this._lanXem != value))
				{
					this._lanXem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> ngayDang
		{
			get
			{
				return this._ngayDang;
			}
			set
			{
				if ((this._ngayDang != value))
				{
					this._ngayDang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int")]
		public System.Nullable<int> IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
	}
	
	public partial class ChiTiet_SelectAllResult
	{
		
		private System.Nullable<int> _ID;
		
		private string _tieuDe;
		
		private string _noiDung;
		
		private System.Nullable<int> _lanXem;
		
		private System.Nullable<System.DateTime> _ngayDang;
		
		private System.Nullable<int> _IDBanTin;
		
		public ChiTiet_SelectAllResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int")]
		public System.Nullable<int> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tieuDe", DbType="NVarChar(200)")]
		public string tieuDe
		{
			get
			{
				return this._tieuDe;
			}
			set
			{
				if ((this._tieuDe != value))
				{
					this._tieuDe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noiDung", DbType="NVarChar(MAX)")]
		public string noiDung
		{
			get
			{
				return this._noiDung;
			}
			set
			{
				if ((this._noiDung != value))
				{
					this._noiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lanXem", DbType="Int")]
		public System.Nullable<int> lanXem
		{
			get
			{
				return this._lanXem;
			}
			set
			{
				if ((this._lanXem != value))
				{
					this._lanXem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> ngayDang
		{
			get
			{
				return this._ngayDang;
			}
			set
			{
				if ((this._ngayDang != value))
				{
					this._ngayDang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int")]
		public System.Nullable<int> IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
	}
	
	public partial class ChiTiet_SelectHomeResult
	{
		
		private System.Nullable<int> _ID;
		
		private string _tieuDe;
		
		private string _noiDung;
		
		private System.Nullable<int> _lanXem;
		
		private System.Nullable<System.DateTime> _ngayDang;
		
		private System.Nullable<int> _IDBanTin;
		
		public ChiTiet_SelectHomeResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int")]
		public System.Nullable<int> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tieuDe", DbType="NVarChar(200)")]
		public string tieuDe
		{
			get
			{
				return this._tieuDe;
			}
			set
			{
				if ((this._tieuDe != value))
				{
					this._tieuDe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noiDung", DbType="NVarChar(MAX)")]
		public string noiDung
		{
			get
			{
				return this._noiDung;
			}
			set
			{
				if ((this._noiDung != value))
				{
					this._noiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lanXem", DbType="Int")]
		public System.Nullable<int> lanXem
		{
			get
			{
				return this._lanXem;
			}
			set
			{
				if ((this._lanXem != value))
				{
					this._lanXem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> ngayDang
		{
			get
			{
				return this._ngayDang;
			}
			set
			{
				if ((this._ngayDang != value))
				{
					this._ngayDang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int")]
		public System.Nullable<int> IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
	}
	
	public partial class ChiTiet_SelectRanDomResult
	{
		
		private System.Nullable<int> _ID;
		
		private string _tieuDe;
		
		private string _noiDung;
		
		private System.Nullable<int> _lanXem;
		
		private System.Nullable<System.DateTime> _ngayDang;
		
		private System.Nullable<int> _IDBanTin;
		
		public ChiTiet_SelectRanDomResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int")]
		public System.Nullable<int> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tieuDe", DbType="NVarChar(200)")]
		public string tieuDe
		{
			get
			{
				return this._tieuDe;
			}
			set
			{
				if ((this._tieuDe != value))
				{
					this._tieuDe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noiDung", DbType="NVarChar(MAX)")]
		public string noiDung
		{
			get
			{
				return this._noiDung;
			}
			set
			{
				if ((this._noiDung != value))
				{
					this._noiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lanXem", DbType="Int")]
		public System.Nullable<int> lanXem
		{
			get
			{
				return this._lanXem;
			}
			set
			{
				if ((this._lanXem != value))
				{
					this._lanXem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> ngayDang
		{
			get
			{
				return this._ngayDang;
			}
			set
			{
				if ((this._ngayDang != value))
				{
					this._ngayDang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int")]
		public System.Nullable<int> IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
	}
	
	public partial class BanTin_SeclectIDResult
	{
		
		private int _IDBanTin;
		
		private string _noiDung;
		
		public BanTin_SeclectIDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int NOT NULL")]
		public int IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noiDung", DbType="NVarChar(50)")]
		public string noiDung
		{
			get
			{
				return this._noiDung;
			}
			set
			{
				if ((this._noiDung != value))
				{
					this._noiDung = value;
				}
			}
		}
	}
	
	public partial class ChiTiet_SELECTResult
	{
		
		private int _ID;
		
		private string _tieuDe;
		
		private string _noiDung;
		
		private System.Nullable<int> _lanXem;
		
		private System.Nullable<System.DateTime> _ngayDang;
		
		private System.Nullable<int> _IDBanTin;
		
		public ChiTiet_SELECTResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
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
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tieuDe", DbType="NVarChar(200)")]
		public string tieuDe
		{
			get
			{
				return this._tieuDe;
			}
			set
			{
				if ((this._tieuDe != value))
				{
					this._tieuDe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noiDung", DbType="NVarChar(MAX)")]
		public string noiDung
		{
			get
			{
				return this._noiDung;
			}
			set
			{
				if ((this._noiDung != value))
				{
					this._noiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lanXem", DbType="Int")]
		public System.Nullable<int> lanXem
		{
			get
			{
				return this._lanXem;
			}
			set
			{
				if ((this._lanXem != value))
				{
					this._lanXem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> ngayDang
		{
			get
			{
				return this._ngayDang;
			}
			set
			{
				if ((this._ngayDang != value))
				{
					this._ngayDang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int")]
		public System.Nullable<int> IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
	}
	
	public partial class Comment_SelectAllResult
	{
		
		private string _name;
		
		private string _com;
		
		private System.Nullable<System.DateTime> _time;
		
		public Comment_SelectAllResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(100)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this._name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_com", DbType="NVarChar(MAX)")]
		public string com
		{
			get
			{
				return this._com;
			}
			set
			{
				if ((this._com != value))
				{
					this._com = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="DateTime")]
		public System.Nullable<System.DateTime> time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this._time = value;
				}
			}
		}
	}
}
#pragma warning restore 1591