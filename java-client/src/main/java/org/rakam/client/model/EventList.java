package org.rakam.client.model;

import org.rakam.StringUtil;
import org.rakam.client.model.EventContext;
import org.rakam.client.model.Event;
import java.util.*;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
public class EventList   {
  
  private EventContext api = null;
  private String project = null;
  private List<Event> events = new ArrayList<Event>();

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("api")
  public EventContext getApi() {
    return api;
  }
  public void setApi(EventContext api) {
    this.api = api;
  }

  
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
  @JsonProperty("events")
  public List<Event> getEvents() {
    return events;
  }
  public void setEvents(List<Event> events) {
    this.events = events;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class EventList {\n");
    
    sb.append("    api: ").append(StringUtil.toIndentedString(api)).append("\n");
    sb.append("    project: ").append(StringUtil.toIndentedString(project)).append("\n");
    sb.append("    events: ").append(StringUtil.toIndentedString(events)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
