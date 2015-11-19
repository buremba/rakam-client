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
  public class ContinuousQuery {
    
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
    /// Gets or Sets Collections
    /// </summary>
    [DataMember(Name="collections", EmitDefaultValue=false)]
    public List<string> Collections { get; set; }

    
    /// <summary>
    /// Gets or Sets Options
    /// </summary>
    [DataMember(Name="options", EmitDefaultValue=false)]
    public Dictionary<string, Object> Options { get; set; }

    
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
    /// Gets or Sets RawQuery
    /// </summary>
    [DataMember(Name="rawQuery", EmitDefaultValue=false)]
    public string RawQuery { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContinuousQuery {\n");
      
      sb.Append("  Project: ").Append(Project).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Collections: ").Append(Collections).Append("\n");
      
      sb.Append("  Options: ").Append(Options).Append("\n");
      
      sb.Append("  TableName: ").Append(TableName).Append("\n");
      
      sb.Append("  PartitionKeys: ").Append(PartitionKeys).Append("\n");
      
      sb.Append("  RawQuery: ").Append(RawQuery).Append("\n");
      
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
