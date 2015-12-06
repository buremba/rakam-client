package org.rakam.client.model;

import org.rakam.StringUtil;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
public class Message   {
  
  private Integer id = null;
  private String content = null;
  private Object fromUser = null;
  private Object toUser = null;
  private Integer parentId = null;
  private Boolean seen = null;
  private Long time = null;
  private String project = null;

  
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
  @JsonProperty("content")
  public String getContent() {
    return content;
  }
  public void setContent(String content) {
    this.content = content;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("from_user")
  public Object getFromUser() {
    return fromUser;
  }
  public void setFromUser(Object fromUser) {
    this.fromUser = fromUser;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("to_user")
  public Object getToUser() {
    return toUser;
  }
  public void setToUser(Object toUser) {
    this.toUser = toUser;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("parentId")
  public Integer getParentId() {
    return parentId;
  }
  public void setParentId(Integer parentId) {
    this.parentId = parentId;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("seen")
  public Boolean getSeen() {
    return seen;
  }
  public void setSeen(Boolean seen) {
    this.seen = seen;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("time")
  public Long getTime() {
    return time;
  }
  public void setTime(Long time) {
    this.time = time;
  }

  
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

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Message {\n");
    
    sb.append("    id: ").append(StringUtil.toIndentedString(id)).append("\n");
    sb.append("    content: ").append(StringUtil.toIndentedString(content)).append("\n");
    sb.append("    fromUser: ").append(StringUtil.toIndentedString(fromUser)).append("\n");
    sb.append("    toUser: ").append(StringUtil.toIndentedString(toUser)).append("\n");
    sb.append("    parentId: ").append(StringUtil.toIndentedString(parentId)).append("\n");
    sb.append("    seen: ").append(StringUtil.toIndentedString(seen)).append("\n");
    sb.append("    time: ").append(StringUtil.toIndentedString(time)).append("\n");
    sb.append("    project: ").append(StringUtil.toIndentedString(project)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
