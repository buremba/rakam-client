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
public class User   {
  
  private String project = null;
  private String id = null;
  private UserContext api = null;
  private Map<String, InlineResponse200> properties = new HashMap<String, InlineResponse200>();

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("project")
  public String getProject() {
    return project;
  }
  public void setProject(String project) {
    this.project = project;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("id")
  public String getId() {
    return id;
  }
  public void setId(String id) {
    this.id = id;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("api")
  public UserContext getApi() {
    return api;
  }
  public void setApi(UserContext api) {
    this.api = api;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
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
    User user = (User) o;
    return Objects.equals(project, user.project) &&
        Objects.equals(id, user.id) &&
        Objects.equals(api, user.api) &&
        Objects.equals(properties, user.properties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, id, api, properties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class User {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
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

