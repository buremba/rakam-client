package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import org.rakam.client.model.EventContext;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class Event   {
  
  private String project = null;
  private String collection = null;
  private EventContext api = null;
  private Object properties = null;

  
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
  @JsonProperty("collection")
  public String getCollection() {
    return collection;
  }
  public void setCollection(String collection) {
    this.collection = collection;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("api")
  public EventContext getApi() {
    return api;
  }
  public void setApi(EventContext api) {
    this.api = api;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("properties")
  public Object getProperties() {
    return properties;
  }
  public void setProperties(Object properties) {
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
    Event event = (Event) o;
    return Objects.equals(project, event.project) &&
        Objects.equals(collection, event.collection) &&
        Objects.equals(api, event.api) &&
        Objects.equals(properties, event.properties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, collection, api, properties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Event {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    collection: ").append(toIndentedString(collection)).append("\n");
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

