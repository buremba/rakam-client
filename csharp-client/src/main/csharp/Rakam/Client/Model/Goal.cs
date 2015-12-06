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
  public class Goal {
    
    /// <summary>
    /// Gets or Sets Collection
    /// </summary>
    [DataMember(Name="collection", EmitDefaultValue=false)]
    public string Collection { get; set; }

    
    /// <summary>
    /// Gets or Sets Filter
    /// </summary>
    [DataMember(Name="filter", EmitDefaultValue=false)]
    public string Filter { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Goal {\n");
      
      sb.Append("  Collection: ").Append(Collection).Append("\n");
      
      sb.Append("  Filter: ").Append(Filter).Append("\n");
      
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
