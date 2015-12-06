package org.rakam.client.model;

import org.rakam.StringUtil;
import java.util.*;
import java.util.Map;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
public class EmailActionConfig   {
  
  private String title = null;
  private String content = null;
  private String columnName = null;
  private Map<String, String> defaultValues = new HashMap<String, String>();
  private Boolean richText = null;

  
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
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class EmailActionConfig {\n");
    
    sb.append("    title: ").append(StringUtil.toIndentedString(title)).append("\n");
    sb.append("    content: ").append(StringUtil.toIndentedString(content)).append("\n");
    sb.append("    columnName: ").append(StringUtil.toIndentedString(columnName)).append("\n");
    sb.append("    defaultValues: ").append(StringUtil.toIndentedString(defaultValues)).append("\n");
    sb.append("    richText: ").append(StringUtil.toIndentedString(richText)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
