using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Rakam.Client.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class EventFilter :  IEquatable<EventFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventFilter" /> class.
        /// </summary>
        public EventFilter()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Collection
        /// </summary>
        [DataMember(Name="collection", EmitDefaultValue=false)]
        public string Collection { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Timeframe
        /// </summary>
        [DataMember(Name="timeframe", EmitDefaultValue=false)]
        public Timeframe Timeframe { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Aggregation
        /// </summary>
        [DataMember(Name="aggregation", EmitDefaultValue=false)]
        public EventFilterAggregation Aggregation { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FilterExpression
        /// </summary>
        [DataMember(Name="filterExpression", EmitDefaultValue=false)]
        public string FilterExpression { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventFilter {\n");
            sb.Append("  Collection: ").Append(Collection).Append("\n");
            sb.Append("  Timeframe: ").Append(Timeframe).Append("\n");
            sb.Append("  Aggregation: ").Append(Aggregation).Append("\n");
            sb.Append("  FilterExpression: ").Append(FilterExpression).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as EventFilter);
        }

        /// <summary>
        /// Returns true if EventFilter instances are equal
        /// </summary>
        /// <param name="obj">Instance of EventFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Collection == other.Collection ||
                    this.Collection != null &&
                    this.Collection.Equals(other.Collection)
                ) && 
                (
                    this.Timeframe == other.Timeframe ||
                    this.Timeframe != null &&
                    this.Timeframe.Equals(other.Timeframe)
                ) && 
                (
                    this.Aggregation == other.Aggregation ||
                    this.Aggregation != null &&
                    this.Aggregation.Equals(other.Aggregation)
                ) && 
                (
                    this.FilterExpression == other.FilterExpression ||
                    this.FilterExpression != null &&
                    this.FilterExpression.Equals(other.FilterExpression)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Collection != null)
                    hash = hash * 57 + this.Collection.GetHashCode();
                
                if (this.Timeframe != null)
                    hash = hash * 57 + this.Timeframe.GetHashCode();
                
                if (this.Aggregation != null)
                    hash = hash * 57 + this.Aggregation.GetHashCode();
                
                if (this.FilterExpression != null)
                    hash = hash * 57 + this.FilterExpression.GetHashCode();
                
                return hash;
            }
        }

    }
}
