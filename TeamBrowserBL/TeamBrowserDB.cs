﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeamBrowserBL.DataAccess
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="vh_browser_teams")]
	public partial class TeamBrowserDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTeam(TeamBrowserBL.Models.Team instance);
    partial void UpdateTeam(TeamBrowserBL.Models.Team instance);
    partial void DeleteTeam(TeamBrowserBL.Models.Team instance);
    partial void InsertPlayer(TeamBrowserBL.Models.Player instance);
    partial void UpdatePlayer(TeamBrowserBL.Models.Player instance);
    partial void DeletePlayer(TeamBrowserBL.Models.Player instance);
    #endregion
		
		public TeamBrowserDBDataContext() : 
				base(global::TeamBrowser.Properties.Settings.Default.vh_browser_teamsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TeamBrowserDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TeamBrowserDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TeamBrowserDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TeamBrowserDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TeamBrowserBL.Models.Team> Teams
		{
			get
			{
				return this.GetTable<TeamBrowserBL.Models.Team>();
			}
		}
		
		public System.Data.Linq.Table<TeamBrowserBL.Models.Player> Players
		{
			get
			{
				return this.GetTable<TeamBrowserBL.Models.Player>();
			}
		}
	}
}
namespace TeamBrowserBL.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.team")]
	public partial class Team : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private EntitySet<Player> _Players;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public Team()
		{
			this._Players = new EntitySet<Player>(new Action<Player>(this.attach_Players), new Action<Player>(this.detach_Players));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
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
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="team_player", Storage="_Players", ThisKey="id", OtherKey="id_team")]
		public EntitySet<Player> Players
		{
			get
			{
				return this._Players;
			}
			set
			{
				this._Players.Assign(value);
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
		
		private void attach_Players(Player entity)
		{
			this.SendPropertyChanging();
			entity.Team = this;
		}
		
		private void detach_Players(Player entity)
		{
			this.SendPropertyChanging();
			entity.Team = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.player")]
	public partial class Player : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private int _games_won;
		
		private int _games_played;
		
		private int _kills;
		
		private int _deaths;
		
		private int _assists;
		
		private int _id_team;
		
		private EntityRef<Team> _Team;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void Ongames_wonChanging(int value);
    partial void Ongames_wonChanged();
    partial void Ongames_playedChanging(int value);
    partial void Ongames_playedChanged();
    partial void OnkillsChanging(int value);
    partial void OnkillsChanged();
    partial void OndeathsChanging(int value);
    partial void OndeathsChanged();
    partial void OnassistsChanging(int value);
    partial void OnassistsChanged();
    partial void Onid_teamChanging(int value);
    partial void Onid_teamChanged();
    #endregion
		
		public Player()
		{
			this._Team = default(EntityRef<Team>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
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
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_games_won", DbType="Int NOT NULL")]
		public int games_won
		{
			get
			{
				return this._games_won;
			}
			set
			{
				if ((this._games_won != value))
				{
					this.Ongames_wonChanging(value);
					this.SendPropertyChanging();
					this._games_won = value;
					this.SendPropertyChanged("games_won");
					this.Ongames_wonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_games_played", DbType="Int NOT NULL")]
		public int games_played
		{
			get
			{
				return this._games_played;
			}
			set
			{
				if ((this._games_played != value))
				{
					this.Ongames_playedChanging(value);
					this.SendPropertyChanging();
					this._games_played = value;
					this.SendPropertyChanged("games_played");
					this.Ongames_playedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kills", DbType="Int NOT NULL")]
		public int kills
		{
			get
			{
				return this._kills;
			}
			set
			{
				if ((this._kills != value))
				{
					this.OnkillsChanging(value);
					this.SendPropertyChanging();
					this._kills = value;
					this.SendPropertyChanged("kills");
					this.OnkillsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deaths", DbType="Int NOT NULL")]
		public int deaths
		{
			get
			{
				return this._deaths;
			}
			set
			{
				if ((this._deaths != value))
				{
					this.OndeathsChanging(value);
					this.SendPropertyChanging();
					this._deaths = value;
					this.SendPropertyChanged("deaths");
					this.OndeathsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_assists", DbType="Int NOT NULL")]
		public int assists
		{
			get
			{
				return this._assists;
			}
			set
			{
				if ((this._assists != value))
				{
					this.OnassistsChanging(value);
					this.SendPropertyChanging();
					this._assists = value;
					this.SendPropertyChanged("assists");
					this.OnassistsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_team", DbType="Int NOT NULL")]
		public int id_team
		{
			get
			{
				return this._id_team;
			}
			set
			{
				if ((this._id_team != value))
				{
					if (this._Team.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_teamChanging(value);
					this.SendPropertyChanging();
					this._id_team = value;
					this.SendPropertyChanged("id_team");
					this.Onid_teamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="team_player", Storage="_Team", ThisKey="id_team", OtherKey="id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Team Team
		{
			get
			{
				return this._Team.Entity;
			}
			set
			{
				Team previousValue = this._Team.Entity;
				if (((previousValue != value) 
							|| (this._Team.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Team.Entity = null;
						previousValue.Players.Remove(this);
					}
					this._Team.Entity = value;
					if ((value != null))
					{
						value.Players.Add(this);
						this._id_team = value.id;
					}
					else
					{
						this._id_team = default(int);
					}
					this.SendPropertyChanged("Team");
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
