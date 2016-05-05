package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import java.util.Map;
import org.rakam.client.model.InlineResponse200;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class ContinuousQuery   {
  
  private String project = null;
  private String name = null;
  private String query = null;
  private Map<String, InlineResponse200> options = new HashMap<String, InlineResponse200>();
  private String tableName = null;
  private List<String> partitionKeys = new ArrayList<String>();

  
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
  @JsonProperty("partitionKeys")
  public List<String> getPartitionKeys() {
    return partitionKeys;
  }
  public void setPartitionKeys(List<String> partitionKeys) {
    this.partitionKeys = partitionKeys;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ContinuousQuery continuousQuery = (ContinuousQuery) o;
    return Objects.equals(project, continuousQuery.project) &&
        Objects.equals(name, continuousQuery.name) &&
        Objects.equals(query, continuousQuery.query) &&
        Objects.equals(options, continuousQuery.options) &&
        Objects.equals(tableName, continuousQuery.tableName) &&
        Objects.equals(partitionKeys, continuousQuery.partitionKeys);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, name, query, options, tableName, partitionKeys);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ContinuousQuery {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    query: ").append(toIndentedString(query)).append("\n");
    sb.append("    options: ").append(toIndentedString(options)).append("\n");
    sb.append("    tableName: ").append(toIndentedString(tableName)).append("\n");
    sb.append("    partitionKeys: ").append(toIndentedString(partitionKeys)).append("\n");
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

