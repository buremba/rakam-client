package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import org.rakam.client.model.ScenarioStep;
import org.rakam.client.model.SerializableAction;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class AutomationRule   {
  
  private String project = null;
  private Boolean isActive = false;
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
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AutomationRule automationRule = (AutomationRule) o;
    return Objects.equals(project, automationRule.project) &&
        Objects.equals(isActive, automationRule.isActive) &&
        Objects.equals(scenarios, automationRule.scenarios) &&
        Objects.equals(actions, automationRule.actions) &&
        Objects.equals(customData, automationRule.customData) &&
        Objects.equals(id, automationRule.id);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, isActive, scenarios, actions, customData, id);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AutomationRule {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    isActive: ").append(toIndentedString(isActive)).append("\n");
    sb.append("    scenarios: ").append(toIndentedString(scenarios)).append("\n");
    sb.append("    actions: ").append(toIndentedString(actions)).append("\n");
    sb.append("    customData: ").append(toIndentedString(customData)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
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

