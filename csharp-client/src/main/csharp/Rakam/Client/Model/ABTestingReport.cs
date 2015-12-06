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
  public class ABTestingReport {
    
    /// <summary>
    /// Gets or Sets Project
    /// </summary>
    [DataMember(Name="project", EmitDefaultValue=false)]
    public string Project { get; set; }

    
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Gets or Sets Variants
    /// </summary>
    [DataMember(Name="variants", EmitDefaultValue=false)]
    public List<Variant> Variants { get; set; }

    
    /// <summary>
    /// Gets or Sets Goal
    /// </summary>
    [DataMember(Name="goal", EmitDefaultValue=false)]
    public Goal Goal { get; set; }

    
    /// <summary>
    /// Gets or Sets Options
    /// </summary>
    [DataMember(Name="options", EmitDefaultValue=false)]
    public Object Options { get; set; }

    
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /// <summary>
    /// Gets or Sets CollectionName
    /// </summary>
    [DataMember(Name="collectionName", EmitDefaultValue=false)]
    public string CollectionName { get; set; }

    
    /// <summary>
    /// Gets or Sets ConnectorField
    /// </summary>
    [DataMember(Name="connectorField", EmitDefaultValue=false)]
    public string ConnectorField { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ABTestingReport {\n");
      
      sb.Append("  Project: ").Append(Project).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Variants: ").Append(Variants).Append("\n");
      
      sb.Append("  Goal: ").Append(Goal).Append("\n");
      
      sb.Append("  Options: ").Append(Options).Append("\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  CollectionName: ").Append(CollectionName).Append("\n");
      
      sb.Append("  ConnectorField: ").Append(ConnectorField).Append("\n");
      
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
