package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import org.rakam.client.model.EmailActionConfig;
import org.rakam.client.model.EventFilter;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class UserEmailActionBatch   {
  
  private String project = null;
  private String filter = null;
  private List<EventFilter> eventFilters = new ArrayList<EventFilter>();
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
  @JsonProperty("filter")
  public String getFilter() {
    return filter;
  }
  public void setFilter(String filter) {
    this.filter = filter;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("event_filters")
  public List<EventFilter> getEventFilters() {
    return eventFilters;
  }
  public void setEventFilters(List<EventFilter> eventFilters) {
    this.eventFilters = eventFilters;
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
    UserEmailActionBatch userEmailActionBatch = (UserEmailActionBatch) o;
    return Objects.equals(project, userEmailActionBatch.project) &&
        Objects.equals(filter, userEmailActionBatch.filter) &&
        Objects.equals(eventFilters, userEmailActionBatch.eventFilters) &&
        Objects.equals(config, userEmailActionBatch.config);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, filter, eventFilters, config);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UserEmailActionBatch {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    filter: ").append(toIndentedString(filter)).append("\n");
    sb.append("    eventFilters: ").append(toIndentedString(eventFilters)).append("\n");
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

