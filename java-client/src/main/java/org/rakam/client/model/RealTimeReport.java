package org.rakam.client.model;

import org.rakam.StringUtil;
import java.util.*;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-11-19T22:59:17.166+02:00")
public class RealTimeReport   {
  
  private String project = null;
  private String name = null;

public enum AggregationEnum {
  COUNT("COUNT"),
  COUNT_UNIQUE("COUNT_UNIQUE"),
  SUM("SUM"),
  MINIMUM("MINIMUM"),
  MAXIMUM("MAXIMUM"),
  APPROXIMATE_UNIQUE("APPROXIMATE_UNIQUE"),
  VARIANCE("VARIANCE"),
  POPULATION_VARIANCE("POPULATION_VARIANCE"),
  STANDARD_DEVIATION("STANDARD_DEVIATION"),
  AVERAGE("AVERAGE");

  private String value;

  AggregationEnum(String value) {
    this.value = value;
  }

  @Override
  public String toString() {
    return value;
  }
}

  private AggregationEnum aggregation = null;
  private String tableName = null;
  private List<String> collections = new ArrayList<String>();
  private String filter = null;
  private String measure = null;
  private List<String> dimensions = new ArrayList<String>();

  
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
  @JsonProperty("name")
  public String getName() {
    return name;
  }
  public void setName(String name) {
    this.name = name;
  }

  
  /**
   **/
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("aggregation")
  public AggregationEnum getAggregation() {
    return aggregation;
  }
  public void setAggregation(AggregationEnum aggregation) {
    this.aggregation = aggregation;
  }

  
  /**
   **/
  @ApiModelProperty(required = true, value = "")
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
  @JsonProperty("measure")
  public String getMeasure() {
    return measure;
  }
  public void setMeasure(String measure) {
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

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class RealTimeReport {\n");
    
    sb.append("    project: ").append(StringUtil.toIndentedString(project)).append("\n");
    sb.append("    name: ").append(StringUtil.toIndentedString(name)).append("\n");
    sb.append("    aggregation: ").append(StringUtil.toIndentedString(aggregation)).append("\n");
    sb.append("    tableName: ").append(StringUtil.toIndentedString(tableName)).append("\n");
    sb.append("    collections: ").append(StringUtil.toIndentedString(collections)).append("\n");
    sb.append("    filter: ").append(StringUtil.toIndentedString(filter)).append("\n");
    sb.append("    measure: ").append(StringUtil.toIndentedString(measure)).append("\n");
    sb.append("    dimensions: ").append(StringUtil.toIndentedString(dimensions)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
