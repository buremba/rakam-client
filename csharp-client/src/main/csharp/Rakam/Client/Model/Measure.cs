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
  public class Measure {
    
    /// <summary>
    /// Gets or Sets Column
    /// </summary>
    [DataMember(Name="column", EmitDefaultValue=false)]
    public string Column { get; set; }

    
    /// <summary>
    /// Gets or Sets Aggregation
    /// </summary>
    [DataMember(Name="aggregation", EmitDefaultValue=false)]
    public string Aggregation { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Measure {\n");
      
      sb.Append("  Column: ").Append(Column).Append("\n");
      
      sb.Append("  Aggregation: ").Append(Aggregation).Append("\n");
      
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
