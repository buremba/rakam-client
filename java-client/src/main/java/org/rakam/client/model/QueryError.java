package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class QueryError   {
  
  private String message = null;
  private String sqlState = null;
  private Integer errorCode = null;
  private Integer errorLine = null;
  private Integer charPositionInLine = null;

  
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
  @JsonProperty("errorLine")
  public Integer getErrorLine() {
    return errorLine;
  }
  public void setErrorLine(Integer errorLine) {
    this.errorLine = errorLine;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("charPositionInLine")
  public Integer getCharPositionInLine() {
    return charPositionInLine;
  }
  public void setCharPositionInLine(Integer charPositionInLine) {
    this.charPositionInLine = charPositionInLine;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    QueryError queryError = (QueryError) o;
    return Objects.equals(message, queryError.message) &&
        Objects.equals(sqlState, queryError.sqlState) &&
        Objects.equals(errorCode, queryError.errorCode) &&
        Objects.equals(errorLine, queryError.errorLine) &&
        Objects.equals(charPositionInLine, queryError.charPositionInLine);
  }

  @Override
  public int hashCode() {
    return Objects.hash(message, sqlState, errorCode, errorLine, charPositionInLine);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class QueryError {\n");
    
    sb.append("    message: ").append(toIndentedString(message)).append("\n");
    sb.append("    sqlState: ").append(toIndentedString(sqlState)).append("\n");
    sb.append("    errorCode: ").append(toIndentedString(errorCode)).append("\n");
    sb.append("    errorLine: ").append(toIndentedString(errorLine)).append("\n");
    sb.append("    charPositionInLine: ").append(toIndentedString(charPositionInLine)).append("\n");
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

