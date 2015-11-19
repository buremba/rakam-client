using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Rakam.Client.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class RealTimeReport {
    
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
    /// Gets or Sets Aggregation
    /// </summary>
    [DataMember(Name="aggregation", EmitDefaultValue=false)]
    public string Aggregation { get; set; }

    
    /// <summary>
    /// Gets or Sets TableName
    /// </summary>
    [DataMember(Name="table_name", EmitDefaultValue=false)]
    public string TableName { get; set; }

    
    /// <summary>
    /// Gets or Sets Collections
    /// </summary>
    [DataMember(Name="collections", EmitDefaultValue=false)]
    public List<string> Collections { get; set; }

    
    /// <summary>
    /// Gets or Sets Filter
    /// </summary>
    [DataMember(Name="filter", EmitDefaultValue=false)]
    public string Filter { get; set; }

    
    /// <summary>
    /// Gets or Sets Measure
    /// </summary>
    [DataMember(Name="measure", EmitDefaultValue=false)]
    public string Measure { get; set; }

    
    /// <summary>
    /// Gets or Sets Dimensions
    /// </summary>
    [DataMember(Name="dimensions", EmitDefaultValue=false)]
    public List<string> Dimensions { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RealTimeReport {\n");
      
      sb.Append("  Project: ").Append(Project).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Aggregation: ").Append(Aggregation).Append("\n");
      
      sb.Append("  TableName: ").Append(TableName).Append("\n");
      
      sb.Append("  Collections: ").Append(Collections).Append("\n");
      
      sb.Append("  Filter: ").Append(Filter).Append("\n");
      
      sb.Append("  Measure: ").Append(Measure).Append("\n");
      
      sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
