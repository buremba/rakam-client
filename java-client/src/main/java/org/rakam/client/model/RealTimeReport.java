package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import org.rakam.client.model.Measure;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class RealTimeReport   {
  
  private String project = null;
  private String name = null;
  private List<Measure> measures = new ArrayList<Measure>();
  private String tableName = null;
  private List<String> collections = new ArrayList<String>();
  private String filter = null;
  private List<String> dimensions = new ArrayList<String>();

  
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
  @JsonProperty("measures")
  public List<Measure> getMeasures() {
    return measures;
  }
  public void setMeasures(List<Measure> measures) {
    this.measures = measures;
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
  @JsonProperty("collections")
  public List<String> getCollections() {
    return collections;
  }
  public void setCollections(List<String> collections) {
    this.collections = collections;
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
  @JsonProperty("dimensions")
  public List<String> getDimensions() {
    return dimensions;
  }
  public void setDimensions(List<String> dimensions) {
    this.dimensions = dimensions;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RealTimeReport realTimeReport = (RealTimeReport) o;
    return Objects.equals(project, realTimeReport.project) &&
        Objects.equals(name, realTimeReport.name) &&
        Objects.equals(measures, realTimeReport.measures) &&
        Objects.equals(tableName, realTimeReport.tableName) &&
        Objects.equals(collections, realTimeReport.collections) &&
        Objects.equals(filter, realTimeReport.filter) &&
        Objects.equals(dimensions, realTimeReport.dimensions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, name, measures, tableName, collections, filter, dimensions);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RealTimeReport {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    measures: ").append(toIndentedString(measures)).append("\n");
    sb.append("    tableName: ").append(toIndentedString(tableName)).append("\n");
    sb.append("    collections: ").append(toIndentedString(collections)).append("\n");
    sb.append("    filter: ").append(toIndentedString(filter)).append("\n");
    sb.append("    dimensions: ").append(toIndentedString(dimensions)).append("\n");
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

