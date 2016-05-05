package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
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
    AVERAGE("AVERAGE"),
    APPROXIMATE_UNIQUE("APPROXIMATE_UNIQUE");

    private String value;

    TypeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
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
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    EventFilterAggregation eventFilterAggregation = (EventFilterAggregation) o;
    return Objects.equals(field, eventFilterAggregation.field) &&
        Objects.equals(minimum, eventFilterAggregation.minimum) &&
        Objects.equals(maximum, eventFilterAggregation.maximum) &&
        Objects.equals(type, eventFilterAggregation.type);
  }

  @Override
  public int hashCode() {
    return Objects.hash(field, minimum, maximum, type);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class EventFilterAggregation {\n");
    
    sb.append("    field: ").append(toIndentedString(field)).append("\n");
    sb.append("    minimum: ").append(toIndentedString(minimum)).append("\n");
    sb.append("    maximum: ").append(toIndentedString(maximum)).append("\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
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

