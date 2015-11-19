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
  public class EventContext {
    
    /// <summary>
    /// Gets or Sets WriteKey
    /// </summary>
    [DataMember(Name="writeKey", EmitDefaultValue=false)]
    public string WriteKey { get; set; }

    
    /// <summary>
    /// Gets or Sets ApiVersion
    /// </summary>
    [DataMember(Name="apiVersion", EmitDefaultValue=false)]
    public string ApiVersion { get; set; }

    
    /// <summary>
    /// Gets or Sets UploadTime
    /// </summary>
    [DataMember(Name="uploadTime", EmitDefaultValue=false)]
    public long? UploadTime { get; set; }

    
    /// <summary>
    /// Gets or Sets Checksum
    /// </summary>
    [DataMember(Name="checksum", EmitDefaultValue=false)]
    public string Checksum { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EventContext {\n");
      
      sb.Append("  WriteKey: ").Append(WriteKey).Append("\n");
      
      sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
      
      sb.Append("  UploadTime: ").Append(UploadTime).Append("\n");
      
      sb.Append("  Checksum: ").Append(Checksum).Append("\n");
      
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
