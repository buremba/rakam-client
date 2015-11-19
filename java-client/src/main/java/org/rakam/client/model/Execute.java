package org.rakam.client.model;

import org.rakam.StringUtil;
import org.rakam.client.model.Reference;
import org.rakam.client.model.Measure;
import java.util.*;
import java.util.Date;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-11-19T22:59:17.166+02:00")
public class Execute   {
  
  private String project = null;
  private Measure measure = null;
  private Reference grouping = null;
  private Reference segment = null;
  private String filterExpression = null;
  private Date startDate = null;
  private Date endDate = null;
  private List<String> collections = new ArrayList<String>();

  
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
  @JsonProperty("measure")
  public Measure getMeasure() {
    return measure;
  }
  public void setMeasure(Measure measure) {
    this.measure = measure;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("grouping")
  public Reference getGrouping() {
    return grouping;
  }
  public void setGrouping(Reference grouping) {
    this.grouping = grouping;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("segment")
  public Reference getSegment() {
    return segment;
  }
  public void setSegment(Reference segment) {
    this.segment = segment;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("filterExpression")
  public String getFilterExpression() {
    return filterExpression;
  }
  public void setFilterExpression(String filterExpression) {
    this.filterExpression = filterExpression;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("startDate")
  public Date getStartDate() {
    return startDate;
  }
  public void setStartDate(Date startDate) {
    this.startDate = startDate;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("endDate")
  public Date getEndDate() {
    return endDate;
  }
  public void setEndDate(Date endDate) {
    this.endDate = endDate;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("collections")
  public List<String> getCollections() {
    return collections;
  }
  public void setCollections(List<String> collections) {
    this.collections = collections;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Execute {\n");
    
    sb.append("    project: ").append(StringUtil.toIndentedString(project)).append("\n");
    sb.append("    measure: ").append(StringUtil.toIndentedString(measure)).append("\n");
    sb.append("    grouping: ").append(StringUtil.toIndentedString(grouping)).append("\n");
    sb.append("    segment: ").append(StringUtil.toIndentedString(segment)).append("\n");
    sb.append("    filterExpression: ").append(StringUtil.toIndentedString(filterExpression)).append("\n");
    sb.append("    startDate: ").append(StringUtil.toIndentedString(startDate)).append("\n");
    sb.append("    endDate: ").append(StringUtil.toIndentedString(endDate)).append("\n");
    sb.append("    collections: ").append(StringUtil.toIndentedString(collections)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
