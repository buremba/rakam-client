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
  public class EmailActionConfig {
    
    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="title", EmitDefaultValue=false)]
    public string Title { get; set; }

    
    /// <summary>
    /// Gets or Sets Content
    /// </summary>
    [DataMember(Name="content", EmitDefaultValue=false)]
    public string Content { get; set; }

    
    /// <summary>
    /// Gets or Sets ColumnName
    /// </summary>
    [DataMember(Name="columnName", EmitDefaultValue=false)]
    public string ColumnName { get; set; }

    
    /// <summary>
    /// Gets or Sets DefaultValues
    /// </summary>
    [DataMember(Name="defaultValues", EmitDefaultValue=false)]
    public Dictionary<string, string> DefaultValues { get; set; }

    
    /// <summary>
    /// Gets or Sets RichText
    /// </summary>
    [DataMember(Name="richText", EmitDefaultValue=false)]
    public bool? RichText { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmailActionConfig {\n");
      
      sb.Append("  Title: ").Append(Title).Append("\n");
      
      sb.Append("  Content: ").Append(Content).Append("\n");
      
      sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
      
      sb.Append("  DefaultValues: ").Append(DefaultValues).Append("\n");
      
      sb.Append("  RichText: ").Append(RichText).Append("\n");
      
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
