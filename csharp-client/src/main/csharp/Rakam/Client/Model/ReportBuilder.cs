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
  public class ReportBuilder {
    
    /// <summary>
    /// Gets or Sets Slug
    /// </summary>
    [DataMember(Name="slug", EmitDefaultValue=false)]
    public string Slug { get; set; }

    
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
    public Dictionary<string, Object> Options { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReportBuilder {\n");
      
      sb.Append("  Slug: ").Append(Slug).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Query: ").Append(Query).Append("\n");
      
      sb.Append("  Options: ").Append(Options).Append("\n");
      
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