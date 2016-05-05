package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import org.rakam.client.model.EventFilterAggregation;
import org.rakam.client.model.Timeframe;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class EventFilter   {
  
  private String collection = null;
  private Timeframe timeframe = null;
  private EventFilterAggregation aggregation = null;
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
  @JsonProperty("timeframe")
  public Timeframe getTimeframe() {
    return timeframe;
  }
  public void setTimeframe(Timeframe timeframe) {
    this.timeframe = timeframe;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("aggregation")
  public EventFilterAggregation getAggregation() {
    return aggregation;
  }
  public void setAggregation(EventFilterAggregation aggregation) {
    this.aggregation = aggregation;
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
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    EventFilter eventFilter = (EventFilter) o;
    return Objects.equals(collection, eventFilter.collection) &&
        Objects.equals(timeframe, eventFilter.timeframe) &&
        Objects.equals(aggregation, eventFilter.aggregation) &&
        Objects.equals(filterExpression, eventFilter.filterExpression);
  }

  @Override
  public int hashCode() {
    return Objects.hash(collection, timeframe, aggregation, filterExpression);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class EventFilter {\n");
    
    sb.append("    collection: ").append(toIndentedString(collection)).append("\n");
    sb.append("    timeframe: ").append(toIndentedString(timeframe)).append("\n");
    sb.append("    aggregation: ").append(toIndentedString(aggregation)).append("\n");
    sb.append("    filterExpression: ").append(toIndentedString(filterExpression)).append("\n");
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

