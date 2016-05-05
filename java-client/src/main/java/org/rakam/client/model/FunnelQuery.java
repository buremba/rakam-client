package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import java.util.Date;
import org.rakam.client.model.FunnelStep;
import org.rakam.client.model.FunnelWindow;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class FunnelQuery   {
  
  private String project = null;
  private List<FunnelStep> steps = new ArrayList<FunnelStep>();
  private String dimension = null;
  private Date startDate = null;
  private FunnelWindow window = null;
  private Date endDate = null;

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("project")
  public String getProject() {
    return project;
  }
  public void setProject(String project) {
    this.project = project;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("steps")
  public List<FunnelStep> getSteps() {
    return steps;
  }
  public void setSteps(List<FunnelStep> steps) {
    this.steps = steps;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("dimension")
  public String getDimension() {
    return dimension;
  }
  public void setDimension(String dimension) {
    this.dimension = dimension;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("startDate")
  public Date getStartDate() {
    return startDate;
  }
  public void setStartDate(Date startDate) {
    this.startDate = startDate;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("window")
  public FunnelWindow getWindow() {
    return window;
  }
  public void setWindow(FunnelWindow window) {
    this.window = window;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("endDate")
  public Date getEndDate() {
    return endDate;
  }
  public void setEndDate(Date endDate) {
    this.endDate = endDate;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FunnelQuery funnelQuery = (FunnelQuery) o;
    return Objects.equals(project, funnelQuery.project) &&
        Objects.equals(steps, funnelQuery.steps) &&
        Objects.equals(dimension, funnelQuery.dimension) &&
        Objects.equals(startDate, funnelQuery.startDate) &&
        Objects.equals(window, funnelQuery.window) &&
        Objects.equals(endDate, funnelQuery.endDate);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, steps, dimension, startDate, window, endDate);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FunnelQuery {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    steps: ").append(toIndentedString(steps)).append("\n");
    sb.append("    dimension: ").append(toIndentedString(dimension)).append("\n");
    sb.append("    startDate: ").append(toIndentedString(startDate)).append("\n");
    sb.append("    window: ").append(toIndentedString(window)).append("\n");
    sb.append("    endDate: ").append(toIndentedString(endDate)).append("\n");
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

