package org.rakam.client.model;

import org.rakam.StringUtil;
import java.util.*;
import java.util.Map;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-11-19T22:59:17.166+02:00")
public class ContinuousQueryBuilder   {
  
  private String name = null;
  private String query = null;
  private List<String> collections = new ArrayList<String>();
  private Map<String, Object> options = new HashMap<String, Object>();
  private String tableName = null;
  private List<String> partitionKeys = new ArrayList<String>();

  
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

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class ContinuousQueryBuilder {\n");
    
    sb.append("    name: ").append(StringUtil.toIndentedString(name)).append("\n");
    sb.append("    query: ").append(StringUtil.toIndentedString(query)).append("\n");
    sb.append("    collections: ").append(StringUtil.toIndentedString(collections)).append("\n");
    sb.append("    options: ").append(StringUtil.toIndentedString(options)).append("\n");
    sb.append("    tableName: ").append(StringUtil.toIndentedString(tableName)).append("\n");
    sb.append("    partitionKeys: ").append(StringUtil.toIndentedString(partitionKeys)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
