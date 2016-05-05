package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import java.util.Date;
import org.rakam.client.model.Measure;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class RealtimeGet   {
  
  private String project = null;
  private String tableName = null;
  private String filter = null;
  private Measure measure = null;
  private List<String> dimensions = new ArrayList<String>();
  private Boolean aggregate = null;
  private Date dateStart = null;
  private Date dateEnd = null;

  
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
  @JsonProperty("dimensions")
  public List<String> getDimensions() {
    return dimensions;
  }
  public void setDimensions(List<String> dimensions) {
    this.dimensions = dimensions;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("aggregate")
  public Boolean getAggregate() {
    return aggregate;
  }
  public void setAggregate(Boolean aggregate) {
    this.aggregate = aggregate;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("date_start")
  public Date getDateStart() {
    return dateStart;
  }
  public void setDateStart(Date dateStart) {
    this.dateStart = dateStart;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("date_end")
  public Date getDateEnd() {
    return dateEnd;
  }
  public void setDateEnd(Date dateEnd) {
    this.dateEnd = dateEnd;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RealtimeGet realtimeGet = (RealtimeGet) o;
    return Objects.equals(project, realtimeGet.project) &&
        Objects.equals(tableName, realtimeGet.tableName) &&
        Objects.equals(filter, realtimeGet.filter) &&
        Objects.equals(measure, realtimeGet.measure) &&
        Objects.equals(dimensions, realtimeGet.dimensions) &&
        Objects.equals(aggregate, realtimeGet.aggregate) &&
        Objects.equals(dateStart, realtimeGet.dateStart) &&
        Objects.equals(dateEnd, realtimeGet.dateEnd);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, tableName, filter, measure, dimensions, aggregate, dateStart, dateEnd);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RealtimeGet {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    tableName: ").append(toIndentedString(tableName)).append("\n");
    sb.append("    filter: ").append(toIndentedString(filter)).append("\n");
    sb.append("    measure: ").append(toIndentedString(measure)).append("\n");
    sb.append("    dimensions: ").append(toIndentedString(dimensions)).append("\n");
    sb.append("    aggregate: ").append(toIndentedString(aggregate)).append("\n");
    sb.append("    dateStart: ").append(toIndentedString(dateStart)).append("\n");
    sb.append("    dateEnd: ").append(toIndentedString(dateEnd)).append("\n");
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

