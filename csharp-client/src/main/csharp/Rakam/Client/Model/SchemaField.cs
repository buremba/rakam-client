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
  public class SchemaField {
    
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    /// <summary>
    /// Gets or Sets Nullable
    /// </summary>
    [DataMember(Name="nullable", EmitDefaultValue=false)]
    public bool? Nullable { get; set; }

    
    /// <summary>
    /// Gets or Sets Unique
    /// </summary>
    [DataMember(Name="unique", EmitDefaultValue=false)]
    public bool? Unique { get; set; }

    
    /// <summary>
    /// Gets or Sets DescriptiveName
    /// </summary>
    [DataMember(Name="descriptiveName", EmitDefaultValue=false)]
    public string DescriptiveName { get; set; }

    
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    public string Description { get; set; }

    
    /// <summary>
    /// Gets or Sets Category
    /// </summary>
    [DataMember(Name="category", EmitDefaultValue=false)]
    public string Category { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SchemaField {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Nullable: ").Append(Nullable).Append("\n");
      
      sb.Append("  Unique: ").Append(Unique).Append("\n");
      
      sb.Append("  DescriptiveName: ").Append(DescriptiveName).Append("\n");
      
      sb.Append("  Description: ").Append(Description).Append("\n");
      
      sb.Append("  Category: ").Append(Category).Append("\n");
      
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
