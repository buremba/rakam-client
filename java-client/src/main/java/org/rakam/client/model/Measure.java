package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class Measure   {
  
  private String column = null;


  public enum AggregationEnum {
    COUNT("COUNT"),
    COUNT_UNIQUE("COUNT_UNIQUE"),
    SUM("SUM"),
    MINIMUM("MINIMUM"),
    MAXIMUM("MAXIMUM"),
    AVERAGE("AVERAGE"),
    APPROXIMATE_UNIQUE("APPROXIMATE_UNIQUE");

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

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("column")
  public String getColumn() {
    return column;
  }
  public void setColumn(String column) {
    this.column = column;
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

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Measure measure = (Measure) o;
    return Objects.equals(column, measure.column) &&
        Objects.equals(aggregation, measure.aggregation);
  }

  @Override
  public int hashCode() {
    return Objects.hash(column, aggregation);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Measure {\n");
    
    sb.append("    column: ").append(toIndentedString(column)).append("\n");
    sb.append("    aggregation: ").append(toIndentedString(aggregation)).append("\n");
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

