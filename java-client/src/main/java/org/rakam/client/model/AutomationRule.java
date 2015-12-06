package org.rakam.client.model;

import org.rakam.StringUtil;
import org.rakam.client.model.SerializableAction;
import java.util.*;
import org.rakam.client.model.ScenarioStep;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
public class AutomationRule   {
  
  private String project = null;
  private Boolean isActive = null;
  private List<ScenarioStep> scenarios = new ArrayList<ScenarioStep>();
  private List<SerializableAction> actions = new ArrayList<SerializableAction>();
  private String customData = null;
  private Integer id = null;

  
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
  @ApiModelProperty(value = "")
  @JsonProperty("is_active")
  public Boolean getIsActive() {
    return isActive;
  }
  public void setIsActive(Boolean isActive) {
    this.isActive = isActive;
  }

  
  /**
   **/
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("scenarios")
  public List<ScenarioStep> getScenarios() {
    return scenarios;
  }
  public void setScenarios(List<ScenarioStep> scenarios) {
    this.scenarios = scenarios;
  }

  
  /**
   **/
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("actions")
  public List<SerializableAction> getActions() {
    return actions;
  }
  public void setActions(List<SerializableAction> actions) {
    this.actions = actions;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("custom_data")
  public String getCustomData() {
    return customData;
  }
  public void setCustomData(String customData) {
    this.customData = customData;
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

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class AutomationRule {\n");
    
    sb.append("    project: ").append(StringUtil.toIndentedString(project)).append("\n");
    sb.append("    isActive: ").append(StringUtil.toIndentedString(isActive)).append("\n");
    sb.append("    scenarios: ").append(StringUtil.toIndentedString(scenarios)).append("\n");
    sb.append("    actions: ").append(StringUtil.toIndentedString(actions)).append("\n");
    sb.append("    customData: ").append(StringUtil.toIndentedString(customData)).append("\n");
    sb.append("    id: ").append(StringUtil.toIndentedString(id)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
