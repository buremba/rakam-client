package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import org.rakam.client.model.Goal;
import org.rakam.client.model.Variant;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class ABTestingReport   {
  
  private String project = null;
  private String name = null;
  private List<Variant> variants = new ArrayList<Variant>();
  private Goal goal = null;
  private Object options = null;
  private Integer id = null;
  private String collectionName = null;
  private String connectorField = null;

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("project")
  public String getProject() {
    return project;
  }
  public void setProject(String project) {
    this.project = project;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("name")
  public String getName() {
    return name;
  }
  public void setName(String name) {
    this.name = name;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("variants")
  public List<Variant> getVariants() {
    return variants;
  }
  public void setVariants(List<Variant> variants) {
    this.variants = variants;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("goal")
  public Goal getGoal() {
    return goal;
  }
  public void setGoal(Goal goal) {
    this.goal = goal;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("options")
  public Object getOptions() {
    return options;
  }
  public void setOptions(Object options) {
    this.options = options;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("id")
  public Integer getId() {
    return id;
  }
  public void setId(Integer id) {
    this.id = id;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("collectionName")
  public String getCollectionName() {
    return collectionName;
  }
  public void setCollectionName(String collectionName) {
    this.collectionName = collectionName;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("connectorField")
  public String getConnectorField() {
    return connectorField;
  }
  public void setConnectorField(String connectorField) {
    this.connectorField = connectorField;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ABTestingReport aBTestingReport = (ABTestingReport) o;
    return Objects.equals(project, aBTestingReport.project) &&
        Objects.equals(name, aBTestingReport.name) &&
        Objects.equals(variants, aBTestingReport.variants) &&
        Objects.equals(goal, aBTestingReport.goal) &&
        Objects.equals(options, aBTestingReport.options) &&
        Objects.equals(id, aBTestingReport.id) &&
        Objects.equals(collectionName, aBTestingReport.collectionName) &&
        Objects.equals(connectorField, aBTestingReport.connectorField);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, name, variants, goal, options, id, collectionName, connectorField);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ABTestingReport {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    variants: ").append(toIndentedString(variants)).append("\n");
    sb.append("    goal: ").append(toIndentedString(goal)).append("\n");
    sb.append("    options: ").append(toIndentedString(options)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    collectionName: ").append(toIndentedString(collectionName)).append("\n");
    sb.append("    connectorField: ").append(toIndentedString(connectorField)).append("\n");
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

