package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import java.util.Map;
import org.rakam.client.model.InlineResponse200;
import org.rakam.client.model.QueryError;
import org.rakam.client.model.SchemaField;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class QueryResult   {
  
  private List<SchemaField> metadata = new ArrayList<SchemaField>();
  private List<List<Object>> result = new ArrayList<List<Object>>();
  private QueryError error = null;
  private Map<String, InlineResponse200> properties = new HashMap<String, InlineResponse200>();
  private Boolean failed = false;

  
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
  public Map<String, InlineResponse200> getProperties() {
    return properties;
  }
  public void setProperties(Map<String, InlineResponse200> properties) {
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
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    QueryResult queryResult = (QueryResult) o;
    return Objects.equals(metadata, queryResult.metadata) &&
        Objects.equals(result, queryResult.result) &&
        Objects.equals(error, queryResult.error) &&
        Objects.equals(properties, queryResult.properties) &&
        Objects.equals(failed, queryResult.failed);
  }

  @Override
  public int hashCode() {
    return Objects.hash(metadata, result, error, properties, failed);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class QueryResult {\n");
    
    sb.append("    metadata: ").append(toIndentedString(metadata)).append("\n");
    sb.append("    result: ").append(toIndentedString(result)).append("\n");
    sb.append("    error: ").append(toIndentedString(error)).append("\n");
    sb.append("    properties: ").append(toIndentedString(properties)).append("\n");
    sb.append("    failed: ").append(toIndentedString(failed)).append("\n");
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

