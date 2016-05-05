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
    public class ContinuousQuery :  IEquatable<ContinuousQuery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousQuery" /> class.
        /// </summary>
        public ContinuousQuery()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public Dictionary<string, InlineResponse200> Options { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TableName
        /// </summary>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PartitionKeys
        /// </summary>
        [DataMember(Name="partitionKeys", EmitDefaultValue=false)]
        public List<string> PartitionKeys { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContinuousQuery {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  PartitionKeys: ").Append(PartitionKeys).Append("\n");
            
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
            return this.Equals(obj as ContinuousQuery);
        }

        /// <summary>
        /// Returns true if ContinuousQuery instances are equal
        /// </summary>
        /// <param name="obj">Instance of ContinuousQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContinuousQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Project == other.Project ||
                    this.Project != null &&
                    this.Project.Equals(other.Project)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(other.Options)
                ) && 
                (
                    this.TableName == other.TableName ||
                    this.TableName != null &&
                    this.TableName.Equals(other.TableName)
                ) && 
                (
                    this.PartitionKeys == other.PartitionKeys ||
                    this.PartitionKeys != null &&
                    this.PartitionKeys.SequenceEqual(other.PartitionKeys)
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
                
                if (this.Project != null)
                    hash = hash * 57 + this.Project.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Query != null)
                    hash = hash * 57 + this.Query.GetHashCode();
                
                if (this.Options != null)
                    hash = hash * 57 + this.Options.GetHashCode();
                
                if (this.TableName != null)
                    hash = hash * 57 + this.TableName.GetHashCode();
                
                if (this.PartitionKeys != null)
                    hash = hash * 57 + this.PartitionKeys.GetHashCode();
                
                return hash;
            }
        }

    }
}
