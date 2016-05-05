package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.Date;
import org.rakam.client.model.RetentionAction;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class RetentionQuery   {
  
  private String project = null;
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
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private DateUnitEnum dateUnit = null;
  private Integer period = null;
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
  @JsonProperty("period")
  public Integer getPeriod() {
    return period;
  }
  public void setPeriod(Integer period) {
    this.period = period;
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
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RetentionQuery retentionQuery = (RetentionQuery) o;
    return Objects.equals(project, retentionQuery.project) &&
        Objects.equals(firstAction, retentionQuery.firstAction) &&
        Objects.equals(returningAction, retentionQuery.returningAction) &&
        Objects.equals(dimension, retentionQuery.dimension) &&
        Objects.equals(dateUnit, retentionQuery.dateUnit) &&
        Objects.equals(period, retentionQuery.period) &&
        Objects.equals(startDate, retentionQuery.startDate) &&
        Objects.equals(endDate, retentionQuery.endDate);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, firstAction, returningAction, dimension, dateUnit, period, startDate, endDate);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RetentionQuery {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    firstAction: ").append(toIndentedString(firstAction)).append("\n");
    sb.append("    returningAction: ").append(toIndentedString(returningAction)).append("\n");
    sb.append("    dimension: ").append(toIndentedString(dimension)).append("\n");
    sb.append("    dateUnit: ").append(toIndentedString(dateUnit)).append("\n");
    sb.append("    period: ").append(toIndentedString(period)).append("\n");
    sb.append("    startDate: ").append(toIndentedString(startDate)).append("\n");
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

