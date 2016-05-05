package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class OLAPTable   {
  
  private String project = null;
  private List<String> collections = new ArrayList<String>();
  private List<String> dimensions = new ArrayList<String>();


  public enum AggregationsEnum {
    COUNT("COUNT"),
    COUNT_UNIQUE("COUNT_UNIQUE"),
    SUM("SUM"),
    MINIMUM("MINIMUM"),
    MAXIMUM("MAXIMUM"),
    AVERAGE("AVERAGE"),
    APPROXIMATE_UNIQUE("APPROXIMATE_UNIQUE");

    private String value;

    AggregationsEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private List<AggregationsEnum> aggregations = new ArrayList<AggregationsEnum>();
  private List<String> measures = new ArrayList<String>();
  private String tableName = null;

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("project")
  public String getProject() {
    return project;
  }
  public void setProject(String project) {
    this.project = project;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("collections")
  public List<String> getCollections() {
    return collections;
  }
  public void setCollections(List<String> collections) {
    this.collections = collections;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("dimensions")
  public List<String> getDimensions() {
    return dimensions;
  }
  public void setDimensions(List<String> dimensions) {
    this.dimensions = dimensions;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("aggregations")
  public List<AggregationsEnum> getAggregations() {
    return aggregations;
  }
  public void setAggregations(List<AggregationsEnum> aggregations) {
    this.aggregations = aggregations;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("measures")
  public List<String> getMeasures() {
    return measures;
  }
  public void setMeasures(List<String> measures) {
    this.measures = measures;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("tableName")
  public String getTableName() {
    return tableName;
  }
  public void setTableName(String tableName) {
    this.tableName = tableName;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    OLAPTable oLAPTable = (OLAPTable) o;
    return Objects.equals(project, oLAPTable.project) &&
        Objects.equals(collections, oLAPTable.collections) &&
        Objects.equals(dimensions, oLAPTable.dimensions) &&
        Objects.equals(aggregations, oLAPTable.aggregations) &&
        Objects.equals(measures, oLAPTable.measures) &&
        Objects.equals(tableName, oLAPTable.tableName);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, collections, dimensions, aggregations, measures, tableName);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class OLAPTable {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    collections: ").append(toIndentedString(collections)).append("\n");
    sb.append("    dimensions: ").append(toIndentedString(dimensions)).append("\n");
    sb.append("    aggregations: ").append(toIndentedString(aggregations)).append("\n");
    sb.append("    measures: ").append(toIndentedString(measures)).append("\n");
    sb.append("    tableName: ").append(toIndentedString(tableName)).append("\n");
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

