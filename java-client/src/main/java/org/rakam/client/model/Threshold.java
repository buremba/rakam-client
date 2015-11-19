package org.rakam.client.model;

import org.rakam.StringUtil;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-11-19T22:59:17.166+02:00")
public class Threshold   {
  

public enum AggregationEnum {
  COUNT("count"),
  SUM("sum");

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
  private String fieldName = null;
  private Long value = null;

  
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

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("fieldName")
  public String getFieldName() {
    return fieldName;
  }
  public void setFieldName(String fieldName) {
    this.fieldName = fieldName;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("value")
  public Long getValue() {
    return value;
  }
  public void setValue(Long value) {
    this.value = value;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Threshold {\n");
    
    sb.append("    aggregation: ").append(StringUtil.toIndentedString(aggregation)).append("\n");
    sb.append("    fieldName: ").append(StringUtil.toIndentedString(fieldName)).append("\n");
    sb.append("    value: ").append(StringUtil.toIndentedString(value)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
