package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import org.rakam.client.model.Event;
import org.rakam.client.model.EventContext;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
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
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    EventList eventList = (EventList) o;
    return Objects.equals(api, eventList.api) &&
        Objects.equals(project, eventList.project) &&
        Objects.equals(events, eventList.events);
  }

  @Override
  public int hashCode() {
    return Objects.hash(api, project, events);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class EventList {\n");
    
    sb.append("    api: ").append(toIndentedString(api)).append("\n");
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    events: ").append(toIndentedString(events)).append("\n");
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

