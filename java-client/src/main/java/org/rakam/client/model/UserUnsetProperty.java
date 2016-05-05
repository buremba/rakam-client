package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import org.rakam.client.model.UserContext;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class UserUnsetProperty   {
  
  private String project = null;
  private UserContext api = null;
  private String user = null;
  private List<String> property = new ArrayList<String>();

  
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
  @JsonProperty("api")
  public UserContext getApi() {
    return api;
  }
  public void setApi(UserContext api) {
    this.api = api;
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
  @JsonProperty("property")
  public List<String> getProperty() {
    return property;
  }
  public void setProperty(List<String> property) {
    this.property = property;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UserUnsetProperty userUnsetProperty = (UserUnsetProperty) o;
    return Objects.equals(project, userUnsetProperty.project) &&
        Objects.equals(api, userUnsetProperty.api) &&
        Objects.equals(user, userUnsetProperty.user) &&
        Objects.equals(property, userUnsetProperty.property);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, api, user, property);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UserUnsetProperty {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    api: ").append(toIndentedString(api)).append("\n");
    sb.append("    user: ").append(toIndentedString(user)).append("\n");
    sb.append("    property: ").append(toIndentedString(property)).append("\n");
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

