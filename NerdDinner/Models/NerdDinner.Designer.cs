﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5420
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("NerdDinnerModel", "FK_RSVP_Dinners", "Dinners", global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(NerdDinner.Models.Dinners), "RSVP", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(NerdDinner.Models.RSVP))]

// Original file name:
// Generation date: 2011-03-27 22:56:20
namespace NerdDinner.Models
{
    
    /// <summary>
    /// There are no comments for NerdDinnerEntities in the schema.
    /// </summary>
    public partial class NerdDinnerEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new NerdDinnerEntities object using the connection string found in the 'NerdDinnerEntities' section of the application configuration file.
        /// </summary>
        public NerdDinnerEntities() : 
                base("name=NerdDinnerEntities", "NerdDinnerEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new NerdDinnerEntities object.
        /// </summary>
        public NerdDinnerEntities(string connectionString) : 
                base(connectionString, "NerdDinnerEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new NerdDinnerEntities object.
        /// </summary>
        public NerdDinnerEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "NerdDinnerEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Dinners in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Dinners> Dinners
        {
            get
            {
                if ((this._Dinners == null))
                {
                    this._Dinners = base.CreateQuery<Dinners>("[Dinners]");
                }
                return this._Dinners;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Dinners> _Dinners;
        /// <summary>
        /// There are no comments for RSVP in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<RSVP> RSVP
        {
            get
            {
                if ((this._RSVP == null))
                {
                    this._RSVP = base.CreateQuery<RSVP>("[RSVP]");
                }
                return this._RSVP;
            }
        }
        private global::System.Data.Objects.ObjectQuery<RSVP> _RSVP;
        /// <summary>
        /// There are no comments for Dinners in the schema.
        /// </summary>
        public void AddToDinners(Dinners dinners)
        {
            base.AddObject("Dinners", dinners);
        }
        /// <summary>
        /// There are no comments for RSVP in the schema.
        /// </summary>
        public void AddToRSVP(RSVP rSVP)
        {
            base.AddObject("RSVP", rSVP);
        }
    }
    /// <summary>
    /// There are no comments for NerdDinnerModel.Dinners in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DinnerID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="NerdDinnerModel", Name="Dinners")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Dinners : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Dinners object.
        /// </summary>
        /// <param name="dinnerID">Initial value of DinnerID.</param>
        /// <param name="title">Initial value of Title.</param>
        /// <param name="eventDate">Initial value of EventDate.</param>
        /// <param name="description">Initial value of Description.</param>
        /// <param name="hostedBy">Initial value of HostedBy.</param>
        /// <param name="contactPhone">Initial value of ContactPhone.</param>
        /// <param name="address">Initial value of Address.</param>
        /// <param name="country">Initial value of Country.</param>
        /// <param name="latitide">Initial value of Latitide.</param>
        /// <param name="longitude">Initial value of Longitude.</param>
        public static Dinners CreateDinners(int dinnerID, string title, global::System.DateTime eventDate, string description, string hostedBy, string contactPhone, string address, string country, double latitide, double longitude)
        {
            Dinners dinners = new Dinners();
            dinners.DinnerID = dinnerID;
            dinners.Title = title;
            dinners.EventDate = eventDate;
            dinners.Description = description;
            dinners.HostedBy = hostedBy;
            dinners.ContactPhone = contactPhone;
            dinners.Address = address;
            dinners.Country = country;
            dinners.Latitide = latitide;
            dinners.Longitude = longitude;
            return dinners;
        }
        /// <summary>
        /// There are no comments for Property DinnerID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int DinnerID
        {
            get
            {
                return this._DinnerID;
            }
            set
            {
                this.OnDinnerIDChanging(value);
                this.ReportPropertyChanging("DinnerID");
                this._DinnerID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DinnerID");
                this.OnDinnerIDChanged();
            }
        }
        private int _DinnerID;
        partial void OnDinnerIDChanging(int value);
        partial void OnDinnerIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this.ReportPropertyChanging("Title");
                this._Title = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Title");
                this.OnTitleChanged();
            }
        }
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property EventDate in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.DateTime EventDate
        {
            get
            {
                return this._EventDate;
            }
            set
            {
                this.OnEventDateChanging(value);
                this.ReportPropertyChanging("EventDate");
                this._EventDate = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("EventDate");
                this.OnEventDateChanged();
            }
        }
        private global::System.DateTime _EventDate;
        partial void OnEventDateChanging(global::System.DateTime value);
        partial void OnEventDateChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this.ReportPropertyChanging("Description");
                this._Description = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Description");
                this.OnDescriptionChanged();
            }
        }
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property HostedBy in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string HostedBy
        {
            get
            {
                return this._HostedBy;
            }
            set
            {
                this.OnHostedByChanging(value);
                this.ReportPropertyChanging("HostedBy");
                this._HostedBy = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("HostedBy");
                this.OnHostedByChanged();
            }
        }
        private string _HostedBy;
        partial void OnHostedByChanging(string value);
        partial void OnHostedByChanged();
        /// <summary>
        /// There are no comments for Property ContactPhone in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactPhone
        {
            get
            {
                return this._ContactPhone;
            }
            set
            {
                this.OnContactPhoneChanging(value);
                this.ReportPropertyChanging("ContactPhone");
                this._ContactPhone = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("ContactPhone");
                this.OnContactPhoneChanged();
            }
        }
        private string _ContactPhone;
        partial void OnContactPhoneChanging(string value);
        partial void OnContactPhoneChanged();
        /// <summary>
        /// There are no comments for Property Address in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                this.OnAddressChanging(value);
                this.ReportPropertyChanging("Address");
                this._Address = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Address");
                this.OnAddressChanged();
            }
        }
        private string _Address;
        partial void OnAddressChanging(string value);
        partial void OnAddressChanged();
        /// <summary>
        /// There are no comments for Property Country in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Country
        {
            get
            {
                return this._Country;
            }
            set
            {
                this.OnCountryChanging(value);
                this.ReportPropertyChanging("Country");
                this._Country = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Country");
                this.OnCountryChanged();
            }
        }
        private string _Country;
        partial void OnCountryChanging(string value);
        partial void OnCountryChanged();
        /// <summary>
        /// There are no comments for Property Latitide in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public double Latitide
        {
            get
            {
                return this._Latitide;
            }
            set
            {
                this.OnLatitideChanging(value);
                this.ReportPropertyChanging("Latitide");
                this._Latitide = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Latitide");
                this.OnLatitideChanged();
            }
        }
        private double _Latitide;
        partial void OnLatitideChanging(double value);
        partial void OnLatitideChanged();
        /// <summary>
        /// There are no comments for Property Longitude in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public double Longitude
        {
            get
            {
                return this._Longitude;
            }
            set
            {
                this.OnLongitudeChanging(value);
                this.ReportPropertyChanging("Longitude");
                this._Longitude = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Longitude");
                this.OnLongitudeChanged();
            }
        }
        private double _Longitude;
        partial void OnLongitudeChanging(double value);
        partial void OnLongitudeChanged();
        /// <summary>
        /// There are no comments for RSVP in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("NerdDinnerModel", "FK_RSVP_Dinners", "RSVP")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<RSVP> RSVP
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<RSVP>("NerdDinnerModel.FK_RSVP_Dinners", "RSVP");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<RSVP>("NerdDinnerModel.FK_RSVP_Dinners", "RSVP", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for NerdDinnerModel.RSVP in the schema.
    /// </summary>
    /// <KeyProperties>
    /// RsvpID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="NerdDinnerModel", Name="RSVP")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class RSVP : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new RSVP object.
        /// </summary>
        /// <param name="rsvpID">Initial value of RsvpID.</param>
        /// <param name="attendeeName">Initial value of AttendeeName.</param>
        public static RSVP CreateRSVP(int rsvpID, string attendeeName)
        {
            RSVP rSVP = new RSVP();
            rSVP.RsvpID = rsvpID;
            rSVP.AttendeeName = attendeeName;
            return rSVP;
        }
        /// <summary>
        /// There are no comments for Property RsvpID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int RsvpID
        {
            get
            {
                return this._RsvpID;
            }
            set
            {
                this.OnRsvpIDChanging(value);
                this.ReportPropertyChanging("RsvpID");
                this._RsvpID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("RsvpID");
                this.OnRsvpIDChanged();
            }
        }
        private int _RsvpID;
        partial void OnRsvpIDChanging(int value);
        partial void OnRsvpIDChanged();
        /// <summary>
        /// There are no comments for Property AttendeeName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string AttendeeName
        {
            get
            {
                return this._AttendeeName;
            }
            set
            {
                this.OnAttendeeNameChanging(value);
                this.ReportPropertyChanging("AttendeeName");
                this._AttendeeName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("AttendeeName");
                this.OnAttendeeNameChanged();
            }
        }
        private string _AttendeeName;
        partial void OnAttendeeNameChanging(string value);
        partial void OnAttendeeNameChanged();
        /// <summary>
        /// There are no comments for Dinners in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("NerdDinnerModel", "FK_RSVP_Dinners", "Dinners")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public Dinners Dinners
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Dinners>("NerdDinnerModel.FK_RSVP_Dinners", "Dinners").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Dinners>("NerdDinnerModel.FK_RSVP_Dinners", "Dinners").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for Dinners in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<Dinners> DinnersReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Dinners>("NerdDinnerModel.FK_RSVP_Dinners", "Dinners");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<Dinners>("NerdDinnerModel.FK_RSVP_Dinners", "Dinners", value);
                }
            }
        }
    }
}
