package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import org.rakam.client.model.EmailActionConfig;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class UserEmailActionSend   {
  
  private String project = null;
  private String user = null;
  private EmailActionConfig config = null;

  
  /**
   **/
  
  @ApiModelProperty(value = "")
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
  @JsonProperty("user")
  public String getUser() {
    return user;
  }
  public void setUser(String user) {
    this.user = user;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("config")
  public EmailActionConfig getConfig() {
    return config;
  }
  public void setConfig(EmailActionConfig config) {
    this.config = config;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UserEmailActionSend userEmailActionSend = (UserEmailActionSend) o;
    return Objects.equals(project, userEmailActionSend.project) &&
        Objects.equals(user, userEmailActionSend.user) &&
        Objects.equals(config, userEmailActionSend.config);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, user, config);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UserEmailActionSend {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    user: ").append(toIndentedString(user)).append("\n");
    sb.append("    config: ").append(toIndentedString(config)).append("\n");
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

