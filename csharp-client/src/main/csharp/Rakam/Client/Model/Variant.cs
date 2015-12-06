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
  public class Variant {
    
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Gets or Sets Weight
    /// </summary>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    public int? Weight { get; set; }

    
    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name="data", EmitDefaultValue=false)]
    public Object Data { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Variant {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      
      sb.Append("  Data: ").Append(Data).Append("\n");
      
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
