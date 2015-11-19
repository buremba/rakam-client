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
  public class AutomationRule {
    
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /// <summary>
    /// Gets or Sets Project
    /// </summary>
    [DataMember(Name="project", EmitDefaultValue=false)]
    public string Project { get; set; }

    
    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="is_active", EmitDefaultValue=false)]
    public bool? IsActive { get; set; }

    
    /// <summary>
    /// Gets or Sets Scenarios
    /// </summary>
    [DataMember(Name="scenarios", EmitDefaultValue=false)]
    public List<ScenarioStep> Scenarios { get; set; }

    
    /// <summary>
    /// Gets or Sets Actions
    /// </summary>
    [DataMember(Name="actions", EmitDefaultValue=false)]
    public List<Action> Actions { get; set; }

    
    /// <summary>
    /// Gets or Sets CustomData
    /// </summary>
    [DataMember(Name="custom_data", EmitDefaultValue=false)]
    public string CustomData { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AutomationRule {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Project: ").Append(Project).Append("\n");
      
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      
      sb.Append("  Scenarios: ").Append(Scenarios).Append("\n");
      
      sb.Append("  Actions: ").Append(Actions).Append("\n");
      
      sb.Append("  CustomData: ").Append(CustomData).Append("\n");
      
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
