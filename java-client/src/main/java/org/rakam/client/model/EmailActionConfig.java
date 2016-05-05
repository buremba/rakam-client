package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import java.util.Map;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class EmailActionConfig   {
  
  private String title = null;
  private String content = null;
  private String columnName = null;
  private Map<String, String> defaultValues = new HashMap<String, String>();
  private Boolean richText = false;

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("title")
  public String getTitle() {
    return title;
  }
  public void setTitle(String title) {
    this.title = title;
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
  @JsonProperty("columnName")
  public String getColumnName() {
    return columnName;
  }
  public void setColumnName(String columnName) {
    this.columnName = columnName;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("defaultValues")
  public Map<String, String> getDefaultValues() {
    return defaultValues;
  }
  public void setDefaultValues(Map<String, String> defaultValues) {
    this.defaultValues = defaultValues;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("richText")
  public Boolean getRichText() {
    return richText;
  }
  public void setRichText(Boolean richText) {
    this.richText = richText;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    EmailActionConfig emailActionConfig = (EmailActionConfig) o;
    return Objects.equals(title, emailActionConfig.title) &&
        Objects.equals(content, emailActionConfig.content) &&
        Objects.equals(columnName, emailActionConfig.columnName) &&
        Objects.equals(defaultValues, emailActionConfig.defaultValues) &&
        Objects.equals(richText, emailActionConfig.richText);
  }

  @Override
  public int hashCode() {
    return Objects.hash(title, content, columnName, defaultValues, richText);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class EmailActionConfig {\n");
    
    sb.append("    title: ").append(toIndentedString(title)).append("\n");
    sb.append("    content: ").append(toIndentedString(content)).append("\n");
    sb.append("    columnName: ").append(toIndentedString(columnName)).append("\n");
    sb.append("    defaultValues: ").append(toIndentedString(defaultValues)).append("\n");
    sb.append("    richText: ").append(toIndentedString(richText)).append("\n");
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

