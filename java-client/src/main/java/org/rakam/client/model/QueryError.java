package org.rakam.client.model;

import org.rakam.StringUtil;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
public class QueryError   {
  
  private String message = null;
  private String sqlState = null;
  private Integer errorCode = null;
  private String query = null;

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("message")
  public String getMessage() {
    return message;
  }
  public void setMessage(String message) {
    this.message = message;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("sqlState")
  public String getSqlState() {
    return sqlState;
  }
  public void setSqlState(String sqlState) {
    this.sqlState = sqlState;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("errorCode")
  public Integer getErrorCode() {
    return errorCode;
  }
  public void setErrorCode(Integer errorCode) {
    this.errorCode = errorCode;
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

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class QueryError {\n");
    
    sb.append("    message: ").append(StringUtil.toIndentedString(message)).append("\n");
    sb.append("    sqlState: ").append(StringUtil.toIndentedString(sqlState)).append("\n");
    sb.append("    errorCode: ").append(StringUtil.toIndentedString(errorCode)).append("\n");
    sb.append("    query: ").append(StringUtil.toIndentedString(query)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
