package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class Message   {
  
  private Integer id = null;
  private String content = null;
  private Object fromUser = null;
  private Object toUser = null;
  private Integer parentId = null;
  private Boolean seen = false;
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
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Message message = (Message) o;
    return Objects.equals(id, message.id) &&
        Objects.equals(content, message.content) &&
        Objects.equals(fromUser, message.fromUser) &&
        Objects.equals(toUser, message.toUser) &&
        Objects.equals(parentId, message.parentId) &&
        Objects.equals(seen, message.seen) &&
        Objects.equals(time, message.time) &&
        Objects.equals(project, message.project);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, content, fromUser, toUser, parentId, seen, time, project);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Message {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    content: ").append(toIndentedString(content)).append("\n");
    sb.append("    fromUser: ").append(toIndentedString(fromUser)).append("\n");
    sb.append("    toUser: ").append(toIndentedString(toUser)).append("\n");
    sb.append("    parentId: ").append(toIndentedString(parentId)).append("\n");
    sb.append("    seen: ").append(toIndentedString(seen)).append("\n");
    sb.append("    time: ").append(toIndentedString(time)).append("\n");
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
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

