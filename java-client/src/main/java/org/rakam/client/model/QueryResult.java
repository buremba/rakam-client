package org.rakam.client.model;

import org.rakam.StringUtil;
import org.rakam.client.model.SchemaField;
import java.util.*;
import org.rakam.client.model.QueryError;
import java.util.Map;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
public class QueryResult   {
  
  private List<SchemaField> metadata = new ArrayList<SchemaField>();
  private List<List<Object>> result = new ArrayList<List<Object>>();
  private QueryError error = null;
  private Map<String, Object> properties = new HashMap<String, Object>();
  private Boolean failed = null;

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("metadata")
  public List<SchemaField> getMetadata() {
    return metadata;
  }
  public void setMetadata(List<SchemaField> metadata) {
    this.metadata = metadata;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("result")
  public List<List<Object>> getResult() {
    return result;
  }
  public void setResult(List<List<Object>> result) {
    this.result = result;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("error")
  public QueryError getError() {
    return error;
  }
  public void setError(QueryError error) {
    this.error = error;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("properties")
  public Map<String, Object> getProperties() {
    return properties;
  }
  public void setProperties(Map<String, Object> properties) {
    this.properties = properties;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("failed")
  public Boolean getFailed() {
    return failed;
  }
  public void setFailed(Boolean failed) {
    this.failed = failed;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class QueryResult {\n");
    
    sb.append("    metadata: ").append(StringUtil.toIndentedString(metadata)).append("\n");
    sb.append("    result: ").append(StringUtil.toIndentedString(result)).append("\n");
    sb.append("    error: ").append(StringUtil.toIndentedString(error)).append("\n");
    sb.append("    properties: ").append(StringUtil.toIndentedString(properties)).append("\n");
    sb.append("    failed: ").append(StringUtil.toIndentedString(failed)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
