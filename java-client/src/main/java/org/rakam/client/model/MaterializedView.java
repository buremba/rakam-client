package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import java.util.Date;
import java.util.Map;
import org.rakam.client.model.InlineResponse200;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class MaterializedView   {
  
  private String project = null;
  private String name = null;
  private String query = null;
  private Boolean incremental = false;
  private Map<String, InlineResponse200> options = new HashMap<String, InlineResponse200>();
  private String tableName = null;
  private String updateInterval = null;
  private Date lastUpdate = null;

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("project")
  public String getProject() {
    return project;
  }
  public void setProject(String project) {
    this.project = project;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("name")
  public String getName() {
    return name;
  }
  public void setName(String name) {
    this.name = name;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
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
  @JsonProperty("incremental")
  public Boolean getIncremental() {
    return incremental;
  }
  public void setIncremental(Boolean incremental) {
    this.incremental = incremental;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("options")
  public Map<String, InlineResponse200> getOptions() {
    return options;
  }
  public void setOptions(Map<String, InlineResponse200> options) {
    this.options = options;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("tableName")
  public String getTableName() {
    return tableName;
  }
  public void setTableName(String tableName) {
    this.tableName = tableName;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("updateInterval")
  public String getUpdateInterval() {
    return updateInterval;
  }
  public void setUpdateInterval(String updateInterval) {
    this.updateInterval = updateInterval;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("lastUpdate")
  public Date getLastUpdate() {
    return lastUpdate;
  }
  public void setLastUpdate(Date lastUpdate) {
    this.lastUpdate = lastUpdate;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MaterializedView materializedView = (MaterializedView) o;
    return Objects.equals(project, materializedView.project) &&
        Objects.equals(name, materializedView.name) &&
        Objects.equals(query, materializedView.query) &&
        Objects.equals(incremental, materializedView.incremental) &&
        Objects.equals(options, materializedView.options) &&
        Objects.equals(tableName, materializedView.tableName) &&
        Objects.equals(updateInterval, materializedView.updateInterval) &&
        Objects.equals(lastUpdate, materializedView.lastUpdate);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, name, query, incremental, options, tableName, updateInterval, lastUpdate);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MaterializedView {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    query: ").append(toIndentedString(query)).append("\n");
    sb.append("    incremental: ").append(toIndentedString(incremental)).append("\n");
    sb.append("    options: ").append(toIndentedString(options)).append("\n");
    sb.append("    tableName: ").append(toIndentedString(tableName)).append("\n");
    sb.append("    updateInterval: ").append(toIndentedString(updateInterval)).append("\n");
    sb.append("    lastUpdate: ").append(toIndentedString(lastUpdate)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}

