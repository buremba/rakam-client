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
  public class FunnelQuery {
    
    /// <summary>
    /// Gets or Sets Project
    /// </summary>
    [DataMember(Name="project", EmitDefaultValue=false)]
    public string Project { get; set; }

    
    /// <summary>
    /// Gets or Sets ConnectorField
    /// </summary>
    [DataMember(Name="connector_field", EmitDefaultValue=false)]
    public string ConnectorField { get; set; }

    
    /// <summary>
    /// Gets or Sets Steps
    /// </summary>
    [DataMember(Name="steps", EmitDefaultValue=false)]
    public List<FunnelStep> Steps { get; set; }

    
    /// <summary>
    /// Gets or Sets Dimension
    /// </summary>
    [DataMember(Name="dimension", EmitDefaultValue=false)]
    public string Dimension { get; set; }

    
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
    /// Gets or Sets EnableOtherGrouping
    /// </summary>
    [DataMember(Name="enableOtherGrouping", EmitDefaultValue=false)]
    public bool? EnableOtherGrouping { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FunnelQuery {\n");
      
      sb.Append("  Project: ").Append(Project).Append("\n");
      
      sb.Append("  ConnectorField: ").Append(ConnectorField).Append("\n");
      
      sb.Append("  Steps: ").Append(Steps).Append("\n");
      
      sb.Append("  Dimension: ").Append(Dimension).Append("\n");
      
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      
      sb.Append("  EnableOtherGrouping: ").Append(EnableOtherGrouping).Append("\n");
      
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
