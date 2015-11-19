package org.rakam.client.model;

import org.rakam.StringUtil;
import java.util.*;
import java.util.Map;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-11-19T22:59:17.166+02:00")
public class ContinuousQuery   {
  
  private String project = null;
  private String name = null;
  private List<String> collections = new ArrayList<String>();
  private Map<String, Object> options = new HashMap<String, Object>();
  private String tableName = null;
  private List<String> partitionKeys = new ArrayList<String>();
  private String rawQuery = null;

  
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
  @JsonProperty("collections")
  public List<String> getCollections() {
    return collections;
  }
  public void setCollections(List<String> collections) {
    this.collections = collections;
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

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("rawQuery")
  public String getRawQuery() {
    return rawQuery;
  }
  public void setRawQuery(String rawQuery) {
    this.rawQuery = rawQuery;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class ContinuousQuery {\n");
    
    sb.append("    project: ").append(StringUtil.toIndentedString(project)).append("\n");
    sb.append("    name: ").append(StringUtil.toIndentedString(name)).append("\n");
    sb.append("    collections: ").append(StringUtil.toIndentedString(collections)).append("\n");
    sb.append("    options: ").append(StringUtil.toIndentedString(options)).append("\n");
    sb.append("    tableName: ").append(StringUtil.toIndentedString(tableName)).append("\n");
    sb.append("    partitionKeys: ").append(StringUtil.toIndentedString(partitionKeys)).append("\n");
    sb.append("    rawQuery: ").append(StringUtil.toIndentedString(rawQuery)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
