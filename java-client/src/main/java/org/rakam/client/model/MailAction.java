package org.rakam.client.model;

import org.rakam.StringUtil;
import java.util.*;
import java.util.Map;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
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
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class MailAction {\n");
    
    sb.append("    message: ").append(StringUtil.toIndentedString(message)).append("\n");
    sb.append("    variables: ").append(StringUtil.toIndentedString(variables)).append("\n");
    sb.append("    fromUser: ").append(StringUtil.toIndentedString(fromUser)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
