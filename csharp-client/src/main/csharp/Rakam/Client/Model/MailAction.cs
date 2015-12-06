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
  public class MailAction {
    
    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    
    /// <summary>
    /// Gets or Sets Variables
    /// </summary>
    [DataMember(Name="variables", EmitDefaultValue=false)]
    public Dictionary<string, string> Variables { get; set; }

    
    /// <summary>
    /// Gets or Sets FromUser
    /// </summary>
    [DataMember(Name="fromUser", EmitDefaultValue=false)]
    public string FromUser { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MailAction {\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
      sb.Append("  Variables: ").Append(Variables).Append("\n");
      
      sb.Append("  FromUser: ").Append(FromUser).Append("\n");
      
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
