package org.rakam.client.model;

import org.rakam.StringUtil;
import java.util.*;
import java.util.Map;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
public class CollectionEvent   {
  
  private String collection = null;
  private Map<String, Object> properties = new HashMap<String, Object>();

  
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
  @JsonProperty("properties")
  public Map<String, Object> getProperties() {
    return properties;
  }
  public void setProperties(Map<String, Object> properties) {
    this.properties = properties;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class CollectionEvent {\n");
    
    sb.append("    collection: ").append(StringUtil.toIndentedString(collection)).append("\n");
    sb.append("    properties: ").append(StringUtil.toIndentedString(properties)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
