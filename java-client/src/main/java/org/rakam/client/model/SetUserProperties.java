package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import java.util.Map;
import org.rakam.client.model.InlineResponse200;
import org.rakam.client.model.UserContext;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class SetUserProperties   {
  
  private String project = null;
  private String user = null;
  private UserContext api = null;
  private Map<String, InlineResponse200> properties = new HashMap<String, InlineResponse200>();

  
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
  @JsonProperty("properties")
  public Map<String, InlineResponse200> getProperties() {
    return properties;
  }
  public void setProperties(Map<String, InlineResponse200> properties) {
    this.properties = properties;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SetUserProperties setUserProperties = (SetUserProperties) o;
    return Objects.equals(project, setUserProperties.project) &&
        Objects.equals(user, setUserProperties.user) &&
        Objects.equals(api, setUserProperties.api) &&
        Objects.equals(properties, setUserProperties.properties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, user, api, properties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SetUserProperties {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    user: ").append(toIndentedString(user)).append("\n");
    sb.append("    api: ").append(toIndentedString(api)).append("\n");
    sb.append("    properties: ").append(toIndentedString(properties)).append("\n");
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

