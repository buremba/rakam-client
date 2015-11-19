package org.rakam.client.model;

import org.rakam.StringUtil;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-11-19T22:59:17.166+02:00")
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
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class EventContext {\n");
    
    sb.append("    writeKey: ").append(StringUtil.toIndentedString(writeKey)).append("\n");
    sb.append("    apiVersion: ").append(StringUtil.toIndentedString(apiVersion)).append("\n");
    sb.append("    uploadTime: ").append(StringUtil.toIndentedString(uploadTime)).append("\n");
    sb.append("    checksum: ").append(StringUtil.toIndentedString(checksum)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
