package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class Goal   {
  
  private String collection = null;
  private String filter = null;

  
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

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Goal goal = (Goal) o;
    return Objects.equals(collection, goal.collection) &&
        Objects.equals(filter, goal.filter);
  }

  @Override
  public int hashCode() {
    return Objects.hash(collection, filter);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Goal {\n");
    
    sb.append("    collection: ").append(toIndentedString(collection)).append("\n");
    sb.append("    filter: ").append(toIndentedString(filter)).append("\n");
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

