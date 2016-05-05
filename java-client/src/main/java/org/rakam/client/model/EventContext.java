package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class EventContext   {
  
  private String writeKey = null;
  private String apiVersion = null;
  private Long uploadTime = null;
  private String checksum = null;

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("writeKey")
  public String getWriteKey() {
    return writeKey;
  }
  public void setWriteKey(String writeKey) {
    this.writeKey = writeKey;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("apiVersion")
  public String getApiVersion() {
    return apiVersion;
  }
  public void setApiVersion(String apiVersion) {
    this.apiVersion = apiVersion;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("uploadTime")
  public Long getUploadTime() {
    return uploadTime;
  }
  public void setUploadTime(Long uploadTime) {
    this.uploadTime = uploadTime;
  }

  
  /**
   **/
  
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("checksum")
  public String getChecksum() {
    return checksum;
  }
  public void setChecksum(String checksum) {
    this.checksum = checksum;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    EventContext eventContext = (EventContext) o;
    return Objects.equals(writeKey, eventContext.writeKey) &&
        Objects.equals(apiVersion, eventContext.apiVersion) &&
        Objects.equals(uploadTime, eventContext.uploadTime) &&
        Objects.equals(checksum, eventContext.checksum);
  }

  @Override
  public int hashCode() {
    return Objects.hash(writeKey, apiVersion, uploadTime, checksum);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class EventContext {\n");
    
    sb.append("    writeKey: ").append(toIndentedString(writeKey)).append("\n");
    sb.append("    apiVersion: ").append(toIndentedString(apiVersion)).append("\n");
    sb.append("    uploadTime: ").append(toIndentedString(uploadTime)).append("\n");
    sb.append("    checksum: ").append(toIndentedString(checksum)).append("\n");
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

