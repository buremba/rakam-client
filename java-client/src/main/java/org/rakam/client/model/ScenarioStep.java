package org.rakam.client.model;

import org.rakam.StringUtil;
import org.rakam.client.model.Threshold;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-11-19T22:59:17.166+02:00")
public class ScenarioStep   {
  
  private String collection = null;
  private String filter = null;
  private Threshold threshold = null;

  
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
  @JsonProperty("threshold")
  public Threshold getThreshold() {
    return threshold;
  }
  public void setThreshold(Threshold threshold) {
    this.threshold = threshold;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class ScenarioStep {\n");
    
    sb.append("    collection: ").append(StringUtil.toIndentedString(collection)).append("\n");
    sb.append("    filter: ").append(StringUtil.toIndentedString(filter)).append("\n");
    sb.append("    threshold: ").append(StringUtil.toIndentedString(threshold)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
