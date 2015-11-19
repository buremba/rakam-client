package org.rakam.client.model;

import org.rakam.StringUtil;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-11-19T22:59:17.166+02:00")
public class FunnelStep   {
  
  private String collection = null;
  private String filterExpression = null;

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("collection")
  public String getCollection() {
    return collection;
  }
  public void setCollection(String collection) {
    this.collection = collection;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("filterExpression")
  public String getFilterExpression() {
    return filterExpression;
  }
  public void setFilterExpression(String filterExpression) {
    this.filterExpression = filterExpression;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class FunnelStep {\n");
    
    sb.append("    collection: ").append(StringUtil.toIndentedString(collection)).append("\n");
    sb.append("    filterExpression: ").append(StringUtil.toIndentedString(filterExpression)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
