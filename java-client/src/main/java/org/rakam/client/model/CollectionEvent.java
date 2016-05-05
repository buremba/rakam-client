package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import java.util.Map;
import org.rakam.client.model.InlineResponse200;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class CollectionEvent   {
  
  private String collection = null;
  private Map<String, InlineResponse200> properties = new HashMap<String, InlineResponse200>();

  
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
  public Map<String, InlineResponse200> getProperties() {
    return properties;
  }
  public void setProperties(Map<String, InlineResponse200> properties) {
    this.properties = properties;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CollectionEvent collectionEvent = (CollectionEvent) o;
    return Objects.equals(collection, collectionEvent.collection) &&
        Objects.equals(properties, collectionEvent.properties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(collection, properties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CollectionEvent {\n");
    
    sb.append("    collection: ").append(toIndentedString(collection)).append("\n");
    sb.append("    properties: ").append(toIndentedString(properties)).append("\n");
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

