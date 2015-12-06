package org.rakam.client.model;

import org.rakam.StringUtil;
import java.util.*;
import org.rakam.client.model.EventFilter;
import org.rakam.client.model.Sorting;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
public class SearchUsers   {
  
  private String project = null;
  private List<String> columns = new ArrayList<String>();
  private String filter = null;
  private List<EventFilter> eventFilters = new ArrayList<EventFilter>();
  private Sorting sorting = null;
  private Integer offset = null;
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
  public Integer getOffset() {
    return offset;
  }
  public void setOffset(Integer offset) {
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
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class SearchUsers {\n");
    
    sb.append("    project: ").append(StringUtil.toIndentedString(project)).append("\n");
    sb.append("    columns: ").append(StringUtil.toIndentedString(columns)).append("\n");
    sb.append("    filter: ").append(StringUtil.toIndentedString(filter)).append("\n");
    sb.append("    eventFilters: ").append(StringUtil.toIndentedString(eventFilters)).append("\n");
    sb.append("    sorting: ").append(StringUtil.toIndentedString(sorting)).append("\n");
    sb.append("    offset: ").append(StringUtil.toIndentedString(offset)).append("\n");
    sb.append("    limit: ").append(StringUtil.toIndentedString(limit)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
