package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class Sorting   {
  
  private String column = null;


  public enum OrderEnum {
    ASC("asc"),
    DESC("desc");

    private String value;

    OrderEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private OrderEnum order = null;

  
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
  @JsonProperty("order")
  public OrderEnum getOrder() {
    return order;
  }
  public void setOrder(OrderEnum order) {
    this.order = order;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Sorting sorting = (Sorting) o;
    return Objects.equals(column, sorting.column) &&
        Objects.equals(order, sorting.order);
  }

  @Override
  public int hashCode() {
    return Objects.hash(column, order);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Sorting {\n");
    
    sb.append("    column: ").append(toIndentedString(column)).append("\n");
    sb.append("    order: ").append(toIndentedString(order)).append("\n");
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

