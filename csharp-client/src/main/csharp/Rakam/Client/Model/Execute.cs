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
  public class Execute {
    
    /// <summary>
    /// Gets or Sets Project
    /// </summary>
    [DataMember(Name="project", EmitDefaultValue=false)]
    public string Project { get; set; }

    
    /// <summary>
    /// Gets or Sets Measure
    /// </summary>
    [DataMember(Name="measure", EmitDefaultValue=false)]
    public Measure Measure { get; set; }

    
    /// <summary>
    /// Gets or Sets Grouping
    /// </summary>
    [DataMember(Name="grouping", EmitDefaultValue=false)]
    public Reference Grouping { get; set; }

    
    /// <summary>
    /// Gets or Sets Segment
    /// </summary>
    [DataMember(Name="segment", EmitDefaultValue=false)]
    public Reference Segment { get; set; }

    
    /// <summary>
    /// Gets or Sets FilterExpression
    /// </summary>
    [DataMember(Name="filterExpression", EmitDefaultValue=false)]
    public string FilterExpression { get; set; }

    
    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    public DateTime? StartDate { get; set; }

    
    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    public DateTime? EndDate { get; set; }

    
    /// <summary>
    /// Gets or Sets Collections
    /// </summary>
    [DataMember(Name="collections", EmitDefaultValue=false)]
    public List<string> Collections { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Execute {\n");
      
      sb.Append("  Project: ").Append(Project).Append("\n");
      
      sb.Append("  Measure: ").Append(Measure).Append("\n");
      
      sb.Append("  Grouping: ").Append(Grouping).Append("\n");
      
      sb.Append("  Segment: ").Append(Segment).Append("\n");
      
      sb.Append("  FilterExpression: ").Append(FilterExpression).Append("\n");
      
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      
      sb.Append("  Collections: ").Append(Collections).Append("\n");
      
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
