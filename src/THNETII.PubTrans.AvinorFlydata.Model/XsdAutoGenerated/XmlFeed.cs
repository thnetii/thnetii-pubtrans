//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace THNETII.PubTrans.AvinorFlydata.Bindings.XsdAutoGenerated {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class airport {
        
        private airportFlights flightsField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public airportFlights flights {
            get {
                return this.flightsField;
            }
            set {
                this.flightsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class airportFlights {
        
        private airportFlightsFlight[] flightField;
        
        private System.DateTime lastUpdateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("flight", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public airportFlightsFlight[] flight {
            get {
                return this.flightField;
            }
            set {
                this.flightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime lastUpdate {
            get {
                return this.lastUpdateField;
            }
            set {
                this.lastUpdateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class airportFlightsFlight {
        
        private string airlineField;
        
        private string flight_idField;
        
        private string dom_intField;
        
        private System.DateTime schedule_timeField;
        
        private string arr_depField;
        
        private string airportField;
        
        private string via_airportField;
        
        private string check_inField;
        
        private string gateField;
        
        private statusType statusField;
        
        private string beltField;
        
        private string delayedField;
        
        private string uniqueIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="NMTOKEN")]
        public string airline {
            get {
                return this.airlineField;
            }
            set {
                this.airlineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="NMTOKEN")]
        public string flight_id {
            get {
                return this.flight_idField;
            }
            set {
                this.flight_idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="NMTOKEN")]
        public string dom_int {
            get {
                return this.dom_intField;
            }
            set {
                this.dom_intField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime schedule_time {
            get {
                return this.schedule_timeField;
            }
            set {
                this.schedule_timeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="NMTOKEN")]
        public string arr_dep {
            get {
                return this.arr_depField;
            }
            set {
                this.arr_depField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="NMTOKEN")]
        public string airport {
            get {
                return this.airportField;
            }
            set {
                this.airportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string via_airport {
            get {
                return this.via_airportField;
            }
            set {
                this.via_airportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string check_in {
            get {
                return this.check_inField;
            }
            set {
                this.check_inField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="NMTOKEN")]
        public string gate {
            get {
                return this.gateField;
            }
            set {
                this.gateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public statusType status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string belt {
            get {
                return this.beltField;
            }
            set {
                this.beltField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="NMTOKEN")]
        public string delayed {
            get {
                return this.delayedField;
            }
            set {
                this.delayedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string uniqueID {
            get {
                return this.uniqueIDField;
            }
            set {
                this.uniqueIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class statusType {
        
        private string codeField;
        
        private System.DateTime timeField;
        
        private bool timeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime time {
            get {
                return this.timeField;
            }
            set {
                this.timeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeSpecified {
            get {
                return this.timeFieldSpecified;
            }
            set {
                this.timeFieldSpecified = value;
            }
        }
    }
}
