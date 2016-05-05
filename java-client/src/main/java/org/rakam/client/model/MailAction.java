package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import java.util.Map;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class MailAction   {
  
  private String message = null;
  private Map<String, String> variables = new HashMap<String, String>();
  private String fromUser = null;

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("message")
  public String getMessage() {
    return message;
  }
  public void setMessage(String message) {
    this.message = message;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("variables")
  public Map<String, String> getVariables() {
    return variables;
  }
  public void setVariables(Map<String, String> variables) {
    this.variables = variables;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("fromUser")
  public String getFromUser() {
    return fromUser;
  }
  public void setFromUser(String fromUser) {
    this.fromUser = fromUser;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MailAction mailAction = (MailAction) o;
    return Objects.equals(message, mailAction.message) &&
        Objects.equals(variables, mailAction.variables) &&
        Objects.equals(fromUser, mailAction.fromUser);
  }

  @Override
  public int hashCode() {
    return Objects.hash(message, variables, fromUser);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MailAction {\n");
    
    sb.append("    message: ").append(toIndentedString(message)).append("\n");
    sb.append("    variables: ").append(toIndentedString(variables)).append("\n");
    sb.append("    fromUser: ").append(toIndentedString(fromUser)).append("\n");
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

