package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import org.rakam.client.model.EventFilter;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class UserCreateSegment   {
  
  private String project = null;
  private String name = null;
  private String tableName = null;
  private String filterExpression = null;
  private List<EventFilter> eventFilters = new ArrayList<EventFilter>();
  private String cacheEviction = null;

  
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
  @JsonProperty("name")
  public String getName() {
    return name;
  }
  public void setName(String name) {
    this.name = name;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("table_name")
  public String getTableName() {
    return tableName;
  }
  public void setTableName(String tableName) {
    this.tableName = tableName;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("filter_expression")
  public String getFilterExpression() {
    return filterExpression;
  }
  public void setFilterExpression(String filterExpression) {
    this.filterExpression = filterExpression;
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
  @JsonProperty("cache_eviction")
  public String getCacheEviction() {
    return cacheEviction;
  }
  public void setCacheEviction(String cacheEviction) {
    this.cacheEviction = cacheEviction;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UserCreateSegment userCreateSegment = (UserCreateSegment) o;
    return Objects.equals(project, userCreateSegment.project) &&
        Objects.equals(name, userCreateSegment.name) &&
        Objects.equals(tableName, userCreateSegment.tableName) &&
        Objects.equals(filterExpression, userCreateSegment.filterExpression) &&
        Objects.equals(eventFilters, userCreateSegment.eventFilters) &&
        Objects.equals(cacheEviction, userCreateSegment.cacheEviction);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, name, tableName, filterExpression, eventFilters, cacheEviction);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UserCreateSegment {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    tableName: ").append(toIndentedString(tableName)).append("\n");
    sb.append("    filterExpression: ").append(toIndentedString(filterExpression)).append("\n");
    sb.append("    eventFilters: ").append(toIndentedString(eventFilters)).append("\n");
    sb.append("    cacheEviction: ").append(toIndentedString(cacheEviction)).append("\n");
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

