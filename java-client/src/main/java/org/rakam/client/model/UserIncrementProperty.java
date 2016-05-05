package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import org.rakam.client.model.UserContext;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class UserIncrementProperty   {
  
  private String project = null;
  private UserContext api = null;
  private String user = null;
  private String property = null;
  private Double  = null;

  
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
  public String getProperty() {
    return property;
  }
  public void setProperty(String property) {
    this.property = property;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("")
  public Double get() {
    return ;
  }
  public void set(Double ) {
    this. = ;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UserIncrementProperty userIncrementProperty = (UserIncrementProperty) o;
    return Objects.equals(project, userIncrementProperty.project) &&
        Objects.equals(api, userIncrementProperty.api) &&
        Objects.equals(user, userIncrementProperty.user) &&
        Objects.equals(property, userIncrementProperty.property) &&
        Objects.equals(, userIncrementProperty.);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, api, user, property, );
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UserIncrementProperty {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    api: ").append(toIndentedString(api)).append("\n");
    sb.append("    user: ").append(toIndentedString(user)).append("\n");
    sb.append("    property: ").append(toIndentedString(property)).append("\n");
    sb.append("    : ").append(toIndentedString()).append("\n");
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

