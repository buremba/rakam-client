package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.Date;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class Timeframe   {
  
  private Date start = null;
  private Date end = null;

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("start")
  public Date getStart() {
    return start;
  }
  public void setStart(Date start) {
    this.start = start;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("end")
  public Date getEnd() {
    return end;
  }
  public void setEnd(Date end) {
    this.end = end;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Timeframe timeframe = (Timeframe) o;
    return Objects.equals(start, timeframe.start) &&
        Objects.equals(end, timeframe.end);
  }

  @Override
  public int hashCode() {
    return Objects.hash(start, end);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Timeframe {\n");
    
    sb.append("    start: ").append(toIndentedString(start)).append("\n");
    sb.append("    end: ").append(toIndentedString(end)).append("\n");
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

