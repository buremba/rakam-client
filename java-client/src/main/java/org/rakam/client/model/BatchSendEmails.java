package org.rakam.client.model;

import org.rakam.StringUtil;
import java.util.*;
import org.rakam.client.model.EmailActionConfig;
import org.rakam.client.model.EventFilter;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
public class BatchSendEmails   {
  
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
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class BatchSendEmails {\n");
    
    sb.append("    project: ").append(StringUtil.toIndentedString(project)).append("\n");
    sb.append("    filter: ").append(StringUtil.toIndentedString(filter)).append("\n");
    sb.append("    eventFilters: ").append(StringUtil.toIndentedString(eventFilters)).append("\n");
    sb.append("    config: ").append(StringUtil.toIndentedString(config)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
