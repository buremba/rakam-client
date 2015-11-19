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
  public class Message {
    
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /// <summary>
    /// Gets or Sets Content
    /// </summary>
    [DataMember(Name="content", EmitDefaultValue=false)]
    public string Content { get; set; }

    
    /// <summary>
    /// Gets or Sets FromUser
    /// </summary>
    [DataMember(Name="from_user", EmitDefaultValue=false)]
    public Object FromUser { get; set; }

    
    /// <summary>
    /// Gets or Sets ToUser
    /// </summary>
    [DataMember(Name="to_user", EmitDefaultValue=false)]
    public Object ToUser { get; set; }

    
    /// <summary>
    /// Gets or Sets ParentId
    /// </summary>
    [DataMember(Name="parentId", EmitDefaultValue=false)]
    public int? ParentId { get; set; }

    
    /// <summary>
    /// Gets or Sets Seen
    /// </summary>
    [DataMember(Name="seen", EmitDefaultValue=false)]
    public bool? Seen { get; set; }

    
    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    [DataMember(Name="time", EmitDefaultValue=false)]
    public long? Time { get; set; }

    
    /// <summary>
    /// Gets or Sets Project
    /// </summary>
    [DataMember(Name="project", EmitDefaultValue=false)]
    public string Project { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Message {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Content: ").Append(Content).Append("\n");
      
      sb.Append("  FromUser: ").Append(FromUser).Append("\n");
      
      sb.Append("  ToUser: ").Append(ToUser).Append("\n");
      
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      
      sb.Append("  Seen: ").Append(Seen).Append("\n");
      
      sb.Append("  Time: ").Append(Time).Append("\n");
      
      sb.Append("  Project: ").Append(Project).Append("\n");
      
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
