package org.rakam.client.model;

import org.rakam.StringUtil;
import org.rakam.client.model.EmailActionConfig;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
public class Send   {
  
  private String project = null;
  private String user = null;
  private EmailActionConfig config = null;

  
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
  @JsonProperty("user")
  public String getUser() {
    return user;
  }
  public void setUser(String user) {
    this.user = user;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("config")
  public EmailActionConfig getConfig() {
    return config;
  }
  public void setConfig(EmailActionConfig config) {
    this.config = config;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Send {\n");
    
    sb.append("    project: ").append(StringUtil.toIndentedString(project)).append("\n");
    sb.append("    user: ").append(StringUtil.toIndentedString(user)).append("\n");
    sb.append("    config: ").append(StringUtil.toIndentedString(config)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
