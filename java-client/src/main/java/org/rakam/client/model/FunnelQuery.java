package org.rakam.client.model;

import org.rakam.StringUtil;
import java.util.*;
import java.util.Date;
import org.rakam.client.model.FunnelStep;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-11-19T22:59:17.166+02:00")
public class FunnelQuery   {
  
  private String project = null;
  private String connectorField = null;
  private List<FunnelStep> steps = new ArrayList<FunnelStep>();
  private String dimension = null;
  private Date startDate = null;
  private Date endDate = null;
  private Boolean enableOtherGrouping = null;

  
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
  @JsonProperty("connector_field")
  public String getConnectorField() {
    return connectorField;
  }
  public void setConnectorField(String connectorField) {
    this.connectorField = connectorField;
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
  @JsonProperty("endDate")
  public Date getEndDate() {
    return endDate;
  }
  public void setEndDate(Date endDate) {
    this.endDate = endDate;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("enableOtherGrouping")
  public Boolean getEnableOtherGrouping() {
    return enableOtherGrouping;
  }
  public void setEnableOtherGrouping(Boolean enableOtherGrouping) {
    this.enableOtherGrouping = enableOtherGrouping;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class FunnelQuery {\n");
    
    sb.append("    project: ").append(StringUtil.toIndentedString(project)).append("\n");
    sb.append("    connectorField: ").append(StringUtil.toIndentedString(connectorField)).append("\n");
    sb.append("    steps: ").append(StringUtil.toIndentedString(steps)).append("\n");
    sb.append("    dimension: ").append(StringUtil.toIndentedString(dimension)).append("\n");
    sb.append("    startDate: ").append(StringUtil.toIndentedString(startDate)).append("\n");
    sb.append("    endDate: ").append(StringUtil.toIndentedString(endDate)).append("\n");
    sb.append("    enableOtherGrouping: ").append(StringUtil.toIndentedString(enableOtherGrouping)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
