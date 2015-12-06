package org.rakam.client.model;

import org.rakam.StringUtil;
import org.rakam.client.model.Variant;
import org.rakam.client.model.Goal;
import java.util.*;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
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
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class ABTestingReport {\n");
    
    sb.append("    project: ").append(StringUtil.toIndentedString(project)).append("\n");
    sb.append("    name: ").append(StringUtil.toIndentedString(name)).append("\n");
    sb.append("    variants: ").append(StringUtil.toIndentedString(variants)).append("\n");
    sb.append("    goal: ").append(StringUtil.toIndentedString(goal)).append("\n");
    sb.append("    options: ").append(StringUtil.toIndentedString(options)).append("\n");
    sb.append("    id: ").append(StringUtil.toIndentedString(id)).append("\n");
    sb.append("    collectionName: ").append(StringUtil.toIndentedString(collectionName)).append("\n");
    sb.append("    connectorField: ").append(StringUtil.toIndentedString(connectorField)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
