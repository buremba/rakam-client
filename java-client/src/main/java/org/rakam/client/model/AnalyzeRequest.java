package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import java.util.Date;
import org.rakam.client.model.Measure;
import org.rakam.client.model.Reference;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class AnalyzeRequest   {
  
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
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AnalyzeRequest analyzeRequest = (AnalyzeRequest) o;
    return Objects.equals(project, analyzeRequest.project) &&
        Objects.equals(measure, analyzeRequest.measure) &&
        Objects.equals(grouping, analyzeRequest.grouping) &&
        Objects.equals(segment, analyzeRequest.segment) &&
        Objects.equals(filterExpression, analyzeRequest.filterExpression) &&
        Objects.equals(startDate, analyzeRequest.startDate) &&
        Objects.equals(endDate, analyzeRequest.endDate) &&
        Objects.equals(collections, analyzeRequest.collections);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, measure, grouping, segment, filterExpression, startDate, endDate, collections);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AnalyzeRequest {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    measure: ").append(toIndentedString(measure)).append("\n");
    sb.append("    grouping: ").append(toIndentedString(grouping)).append("\n");
    sb.append("    segment: ").append(toIndentedString(segment)).append("\n");
    sb.append("    filterExpression: ").append(toIndentedString(filterExpression)).append("\n");
    sb.append("    startDate: ").append(toIndentedString(startDate)).append("\n");
    sb.append("    endDate: ").append(toIndentedString(endDate)).append("\n");
    sb.append("    collections: ").append(toIndentedString(collections)).append("\n");
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

