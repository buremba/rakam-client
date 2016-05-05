package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.Date;
import org.rakam.client.model.UserContext;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class UserMergeUser   {
  
  private String project = null;
  private String user = null;
  private UserContext api = null;
  private String anonymousId = null;
  private Date createdAt = null;
  private Date mergedAt = null;

  
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
  @JsonProperty("api")
  public UserContext getApi() {
    return api;
  }
  public void setApi(UserContext api) {
    this.api = api;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("anonymous_id")
  public String getAnonymousId() {
    return anonymousId;
  }
  public void setAnonymousId(String anonymousId) {
    this.anonymousId = anonymousId;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("created_at")
  public Date getCreatedAt() {
    return createdAt;
  }
  public void setCreatedAt(Date createdAt) {
    this.createdAt = createdAt;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("merged_at")
  public Date getMergedAt() {
    return mergedAt;
  }
  public void setMergedAt(Date mergedAt) {
    this.mergedAt = mergedAt;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UserMergeUser userMergeUser = (UserMergeUser) o;
    return Objects.equals(project, userMergeUser.project) &&
        Objects.equals(user, userMergeUser.user) &&
        Objects.equals(api, userMergeUser.api) &&
        Objects.equals(anonymousId, userMergeUser.anonymousId) &&
        Objects.equals(createdAt, userMergeUser.createdAt) &&
        Objects.equals(mergedAt, userMergeUser.mergedAt);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, user, api, anonymousId, createdAt, mergedAt);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UserMergeUser {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    user: ").append(toIndentedString(user)).append("\n");
    sb.append("    api: ").append(toIndentedString(api)).append("\n");
    sb.append("    anonymousId: ").append(toIndentedString(anonymousId)).append("\n");
    sb.append("    createdAt: ").append(toIndentedString(createdAt)).append("\n");
    sb.append("    mergedAt: ").append(toIndentedString(mergedAt)).append("\n");
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

