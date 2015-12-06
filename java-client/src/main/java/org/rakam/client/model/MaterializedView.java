package org.rakam.client.model;

import org.rakam.StringUtil;
import java.util.*;
import java.util.Map;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
public class MaterializedView   {
  
  private String project = null;
  private String name = null;
  private String tableName = null;
  private String query = null;
  private String updateInterval = null;
  private Map<String, Object> options = new HashMap<String, Object>();

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("project")
  public String getProject() {
    return project;
  }
  public void setProject(String project) {
    this.project = project;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("name")
  public String getName() {
    return name;
  }
  public void setName(String name) {
    this.name = name;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("table_name")
  public String getTableName() {
    return tableName;
  }
  public void setTableName(String tableName) {
    this.tableName = tableName;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("query")
  public String getQuery() {
    return query;
  }
  public void setQuery(String query) {
    this.query = query;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("update_interval")
  public String getUpdateInterval() {
    return updateInterval;
  }
  public void setUpdateInterval(String updateInterval) {
    this.updateInterval = updateInterval;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("options")
  public Map<String, Object> getOptions() {
    return options;
  }
  public void setOptions(Map<String, Object> options) {
    this.options = options;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class MaterializedView {\n");
    
    sb.append("    project: ").append(StringUtil.toIndentedString(project)).append("\n");
    sb.append("    name: ").append(StringUtil.toIndentedString(name)).append("\n");
    sb.append("    tableName: ").append(StringUtil.toIndentedString(tableName)).append("\n");
    sb.append("    query: ").append(StringUtil.toIndentedString(query)).append("\n");
    sb.append("    updateInterval: ").append(StringUtil.toIndentedString(updateInterval)).append("\n");
    sb.append("    options: ").append(StringUtil.toIndentedString(options)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
