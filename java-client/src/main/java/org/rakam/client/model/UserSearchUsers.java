package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import org.rakam.client.model.EventFilter;
import org.rakam.client.model.Sorting;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class UserSearchUsers   {
  
  private String project = null;
  private List<String> columns = new ArrayList<String>();
  private String filter = null;
  private List<EventFilter> eventFilters = new ArrayList<EventFilter>();
  private Sorting sorting = null;
  private String offset = null;
  private Integer limit = null;

  
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
  @JsonProperty("columns")
  public List<String> getColumns() {
    return columns;
  }
  public void setColumns(List<String> columns) {
    this.columns = columns;
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
  @JsonProperty("sorting")
  public Sorting getSorting() {
    return sorting;
  }
  public void setSorting(Sorting sorting) {
    this.sorting = sorting;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("offset")
  public String getOffset() {
    return offset;
  }
  public void setOffset(String offset) {
    this.offset = offset;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("limit")
  public Integer getLimit() {
    return limit;
  }
  public void setLimit(Integer limit) {
    this.limit = limit;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UserSearchUsers userSearchUsers = (UserSearchUsers) o;
    return Objects.equals(project, userSearchUsers.project) &&
        Objects.equals(columns, userSearchUsers.columns) &&
        Objects.equals(filter, userSearchUsers.filter) &&
        Objects.equals(eventFilters, userSearchUsers.eventFilters) &&
        Objects.equals(sorting, userSearchUsers.sorting) &&
        Objects.equals(offset, userSearchUsers.offset) &&
        Objects.equals(limit, userSearchUsers.limit);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, columns, filter, eventFilters, sorting, offset, limit);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UserSearchUsers {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    columns: ").append(toIndentedString(columns)).append("\n");
    sb.append("    filter: ").append(toIndentedString(filter)).append("\n");
    sb.append("    eventFilters: ").append(toIndentedString(eventFilters)).append("\n");
    sb.append("    sorting: ").append(toIndentedString(sorting)).append("\n");
    sb.append("    offset: ").append(toIndentedString(offset)).append("\n");
    sb.append("    limit: ").append(toIndentedString(limit)).append("\n");
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

