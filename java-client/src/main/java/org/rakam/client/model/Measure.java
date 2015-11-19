package org.rakam.client.model;

import org.rakam.StringUtil;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-11-19T22:59:17.166+02:00")
public class Measure   {
  
  private String column = null;

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

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("column")
  public String getColumn() {
    return column;
  }
  public void setColumn(String column) {
    this.column = column;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("aggregation")
  public AggregationEnum getAggregation() {
    return aggregation;
  }
  public void setAggregation(AggregationEnum aggregation) {
    this.aggregation = aggregation;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Measure {\n");
    
    sb.append("    column: ").append(StringUtil.toIndentedString(column)).append("\n");
    sb.append("    aggregation: ").append(StringUtil.toIndentedString(aggregation)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
