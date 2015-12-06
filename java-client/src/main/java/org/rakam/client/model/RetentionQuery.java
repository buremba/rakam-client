package org.rakam.client.model;

import org.rakam.StringUtil;
import org.rakam.client.model.RetentionAction;
import java.util.Date;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
public class RetentionQuery   {
  
  private String project = null;
  private String connectorField = null;
  private RetentionAction firstAction = null;
  private RetentionAction returningAction = null;
  private String dimension = null;

public enum DateUnitEnum {
  DAY("DAY"),
  WEEK("WEEK"),
  MONTH("MONTH");

  private String value;

  DateUnitEnum(String value) {
    this.value = value;
  }

  @Override
  public String toString() {
    return value;
  }
}

  private DateUnitEnum dateUnit = null;
  private Date startDate = null;
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
  @JsonProperty("first_action")
  public RetentionAction getFirstAction() {
    return firstAction;
  }
  public void setFirstAction(RetentionAction firstAction) {
    this.firstAction = firstAction;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("returning_action")
  public RetentionAction getReturningAction() {
    return returningAction;
  }
  public void setReturningAction(RetentionAction returningAction) {
    this.returningAction = returningAction;
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
  @JsonProperty("date_unit")
  public DateUnitEnum getDateUnit() {
    return dateUnit;
  }
  public void setDateUnit(DateUnitEnum dateUnit) {
    this.dateUnit = dateUnit;
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

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class RetentionQuery {\n");
    
    sb.append("    project: ").append(StringUtil.toIndentedString(project)).append("\n");
    sb.append("    connectorField: ").append(StringUtil.toIndentedString(connectorField)).append("\n");
    sb.append("    firstAction: ").append(StringUtil.toIndentedString(firstAction)).append("\n");
    sb.append("    returningAction: ").append(StringUtil.toIndentedString(returningAction)).append("\n");
    sb.append("    dimension: ").append(StringUtil.toIndentedString(dimension)).append("\n");
    sb.append("    dateUnit: ").append(StringUtil.toIndentedString(dateUnit)).append("\n");
    sb.append("    startDate: ").append(StringUtil.toIndentedString(startDate)).append("\n");
    sb.append("    endDate: ").append(StringUtil.toIndentedString(endDate)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
