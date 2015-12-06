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
  public class BatchSendMessages {
    
    /// <summary>
    /// Gets or Sets Project
    /// </summary>
    [DataMember(Name="project", EmitDefaultValue=false)]
    public string Project { get; set; }

    
    /// <summary>
    /// Gets or Sets Filter
    /// </summary>
    [DataMember(Name="filter", EmitDefaultValue=false)]
    public string Filter { get; set; }

    
    /// <summary>
    /// Gets or Sets EventFilters
    /// </summary>
    [DataMember(Name="event_filters", EmitDefaultValue=false)]
    public List<EventFilter> EventFilters { get; set; }

    
    /// <summary>
    /// Gets or Sets Config
    /// </summary>
    [DataMember(Name="config", EmitDefaultValue=false)]
    public MailAction Config { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BatchSendMessages {\n");
      
      sb.Append("  Project: ").Append(Project).Append("\n");
      
      sb.Append("  Filter: ").Append(Filter).Append("\n");
      
      sb.Append("  EventFilters: ").Append(EventFilters).Append("\n");
      
      sb.Append("  Config: ").Append(Config).Append("\n");
      
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
