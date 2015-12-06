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
  public class SearchUsers {
    
    /// <summary>
    /// Gets or Sets Project
    /// </summary>
    [DataMember(Name="project", EmitDefaultValue=false)]
    public string Project { get; set; }

    
    /// <summary>
    /// Gets or Sets Columns
    /// </summary>
    [DataMember(Name="columns", EmitDefaultValue=false)]
    public List<string> Columns { get; set; }

    
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
    /// Gets or Sets Sorting
    /// </summary>
    [DataMember(Name="sorting", EmitDefaultValue=false)]
    public Sorting Sorting { get; set; }

    
    /// <summary>
    /// Gets or Sets Offset
    /// </summary>
    [DataMember(Name="offset", EmitDefaultValue=false)]
    public int? Offset { get; set; }

    
    /// <summary>
    /// Gets or Sets Limit
    /// </summary>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    public int? Limit { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SearchUsers {\n");
      
      sb.Append("  Project: ").Append(Project).Append("\n");
      
      sb.Append("  Columns: ").Append(Columns).Append("\n");
      
      sb.Append("  Filter: ").Append(Filter).Append("\n");
      
      sb.Append("  EventFilters: ").Append(EventFilters).Append("\n");
      
      sb.Append("  Sorting: ").Append(Sorting).Append("\n");
      
      sb.Append("  Offset: ").Append(Offset).Append("\n");
      
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      
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
