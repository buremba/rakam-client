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
  public class Recipe {
    
    /// <summary>
    /// Gets or Sets Strategy
    /// </summary>
    [DataMember(Name="strategy", EmitDefaultValue=false)]
    public string Strategy { get; set; }

    
    /// <summary>
    /// Gets or Sets Project
    /// </summary>
    [DataMember(Name="project", EmitDefaultValue=false)]
    public string Project { get; set; }

    
    /// <summary>
    /// Gets or Sets Collections
    /// </summary>
    [DataMember(Name="collections", EmitDefaultValue=false)]
    public Dictionary<string, Collection> Collections { get; set; }

    
    /// <summary>
    /// Gets or Sets Reports
    /// </summary>
    [DataMember(Name="reports", EmitDefaultValue=false)]
    public List<ReportBuilder> Reports { get; set; }

    
    /// <summary>
    /// Gets or Sets MaterializedViews
    /// </summary>
    [DataMember(Name="materializedViews", EmitDefaultValue=false)]
    public List<MaterializedViewBuilder> MaterializedViews { get; set; }

    
    /// <summary>
    /// Gets or Sets ContinuousQueries
    /// </summary>
    [DataMember(Name="continuousQueries", EmitDefaultValue=false)]
    public List<ContinuousQueryBuilder> ContinuousQueries { get; set; }

    
    /// <summary>
    /// Gets or Sets ContinuousQueryBuilders
    /// </summary>
    [DataMember(Name="continuousQueryBuilders", EmitDefaultValue=false)]
    public List<ContinuousQueryBuilder> ContinuousQueryBuilders { get; set; }

    
    /// <summary>
    /// Gets or Sets MaterializedViewBuilders
    /// </summary>
    [DataMember(Name="materializedViewBuilders", EmitDefaultValue=false)]
    public List<MaterializedViewBuilder> MaterializedViewBuilders { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Recipe {\n");
      
      sb.Append("  Strategy: ").Append(Strategy).Append("\n");
      
      sb.Append("  Project: ").Append(Project).Append("\n");
      
      sb.Append("  Collections: ").Append(Collections).Append("\n");
      
      sb.Append("  Reports: ").Append(Reports).Append("\n");
      
      sb.Append("  MaterializedViews: ").Append(MaterializedViews).Append("\n");
      
      sb.Append("  ContinuousQueries: ").Append(ContinuousQueries).Append("\n");
      
      sb.Append("  ContinuousQueryBuilders: ").Append(ContinuousQueryBuilders).Append("\n");
      
      sb.Append("  MaterializedViewBuilders: ").Append(MaterializedViewBuilders).Append("\n");
      
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
