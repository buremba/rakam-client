package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class Threshold   {
  


  public enum AggregationEnum {
    COUNT("count"),
    SUM("sum");

    private String value;

    AggregationEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
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
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Threshold threshold = (Threshold) o;
    return Objects.equals(aggregation, threshold.aggregation) &&
        Objects.equals(fieldName, threshold.fieldName) &&
        Objects.equals(value, threshold.value);
  }

  @Override
  public int hashCode() {
    return Objects.hash(aggregation, fieldName, value);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Threshold {\n");
    
    sb.append("    aggregation: ").append(toIndentedString(aggregation)).append("\n");
    sb.append("    fieldName: ").append(toIndentedString(fieldName)).append("\n");
    sb.append("    value: ").append(toIndentedString(value)).append("\n");
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

