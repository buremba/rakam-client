package org.rakam.client.model;

import org.rakam.StringUtil;
import org.rakam.client.model.EventContext;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
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
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Event {\n");
    
    sb.append("    project: ").append(StringUtil.toIndentedString(project)).append("\n");
    sb.append("    collection: ").append(StringUtil.toIndentedString(collection)).append("\n");
    sb.append("    api: ").append(StringUtil.toIndentedString(api)).append("\n");
    sb.append("    properties: ").append(StringUtil.toIndentedString(properties)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
