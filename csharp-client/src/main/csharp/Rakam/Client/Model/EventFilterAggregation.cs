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
  public class EventFilterAggregation {
    
    /// <summary>
    /// Gets or Sets Field
    /// </summary>
    [DataMember(Name="field", EmitDefaultValue=false)]
    public string Field { get; set; }

    
    /// <summary>
    /// Gets or Sets Minimum
    /// </summary>
    [DataMember(Name="minimum", EmitDefaultValue=false)]
    public long? Minimum { get; set; }

    
    /// <summary>
    /// Gets or Sets Maximum
    /// </summary>
    [DataMember(Name="maximum", EmitDefaultValue=false)]
    public long? Maximum { get; set; }

    
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EventFilterAggregation {\n");
      
      sb.Append("  Field: ").Append(Field).Append("\n");
      
      sb.Append("  Minimum: ").Append(Minimum).Append("\n");
      
      sb.Append("  Maximum: ").Append(Maximum).Append("\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
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
