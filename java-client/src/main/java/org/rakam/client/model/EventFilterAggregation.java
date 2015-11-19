package org.rakam.client.model;

import org.rakam.StringUtil;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-11-19T22:59:17.166+02:00")
public class EventFilterAggregation   {
  
  private String field = null;
  private Long minimum = null;
  private Long maximum = null;

public enum TypeEnum {
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

  TypeEnum(String value) {
    this.value = value;
  }

  @Override
  public String toString() {
    return value;
  }
}

  private TypeEnum type = null;

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("field")
  public String getField() {
    return field;
  }
  public void setField(String field) {
    this.field = field;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("minimum")
  public Long getMinimum() {
    return minimum;
  }
  public void setMinimum(Long minimum) {
    this.minimum = minimum;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("maximum")
  public Long getMaximum() {
    return maximum;
  }
  public void setMaximum(Long maximum) {
    this.maximum = maximum;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("type")
  public TypeEnum getType() {
    return type;
  }
  public void setType(TypeEnum type) {
    this.type = type;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class EventFilterAggregation {\n");
    
    sb.append("    field: ").append(StringUtil.toIndentedString(field)).append("\n");
    sb.append("    minimum: ").append(StringUtil.toIndentedString(minimum)).append("\n");
    sb.append("    maximum: ").append(StringUtil.toIndentedString(maximum)).append("\n");
    sb.append("    type: ").append(StringUtil.toIndentedString(type)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
