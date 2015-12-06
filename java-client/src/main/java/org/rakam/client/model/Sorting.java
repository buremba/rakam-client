package org.rakam.client.model;

import org.rakam.StringUtil;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
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
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Sorting {\n");
    
    sb.append("    column: ").append(StringUtil.toIndentedString(column)).append("\n");
    sb.append("    order: ").append(StringUtil.toIndentedString(order)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
