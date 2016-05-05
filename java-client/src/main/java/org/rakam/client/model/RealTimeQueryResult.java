package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class RealTimeQueryResult   {
  
  private Long start = null;
  private Long end = null;
  private Object result = null;

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("start")
  public Long getStart() {
    return start;
  }
  public void setStart(Long start) {
    this.start = start;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("end")
  public Long getEnd() {
    return end;
  }
  public void setEnd(Long end) {
    this.end = end;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("result")
  public Object getResult() {
    return result;
  }
  public void setResult(Object result) {
    this.result = result;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RealTimeQueryResult realTimeQueryResult = (RealTimeQueryResult) o;
    return Objects.equals(start, realTimeQueryResult.start) &&
        Objects.equals(end, realTimeQueryResult.end) &&
        Objects.equals(result, realTimeQueryResult.result);
  }

  @Override
  public int hashCode() {
    return Objects.hash(start, end, result);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RealTimeQueryResult {\n");
    
    sb.append("    start: ").append(toIndentedString(start)).append("\n");
    sb.append("    end: ").append(toIndentedString(end)).append("\n");
    sb.append("    result: ").append(toIndentedString(result)).append("\n");
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

