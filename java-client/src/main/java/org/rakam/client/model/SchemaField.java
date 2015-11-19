package org.rakam.client.model;

import org.rakam.StringUtil;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-11-19T22:59:17.166+02:00")
public class SchemaField   {
  
  private String name = null;

public enum TypeEnum {
  STRING("STRING"),
  LONG("LONG"),
  DOUBLE("DOUBLE"),
  BOOLEAN("BOOLEAN"),
  DATE("DATE"),
  TIME("TIME"),
  TIMESTAMP("TIMESTAMP"),
  ARRAY_STRING("ARRAY_STRING"),
  ARRAY_LONG("ARRAY_LONG"),
  ARRAY_DOUBLE("ARRAY_DOUBLE"),
  ARRAY_BOOLEAN("ARRAY_BOOLEAN"),
  ARRAY_DATE("ARRAY_DATE"),
  ARRAY_TIME("ARRAY_TIME"),
  ARRAY_TIMESTAMP("ARRAY_TIMESTAMP");

  private String value;

  TypeEnum(String value) {
    this.value = value;
  }

  @Override
  public String toString() {
    return value;
  }
}

  private TypeEnum type = null;
  private Boolean nullable = null;
  private Boolean unique = null;
  private String descriptiveName = null;
  private String description = null;
  private String category = null;

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("name")
  public String getName() {
    return name;
  }
  public void setName(String name) {
    this.name = name;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("type")
  public TypeEnum getType() {
    return type;
  }
  public void setType(TypeEnum type) {
    this.type = type;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("nullable")
  public Boolean getNullable() {
    return nullable;
  }
  public void setNullable(Boolean nullable) {
    this.nullable = nullable;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("unique")
  public Boolean getUnique() {
    return unique;
  }
  public void setUnique(Boolean unique) {
    this.unique = unique;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("descriptiveName")
  public String getDescriptiveName() {
    return descriptiveName;
  }
  public void setDescriptiveName(String descriptiveName) {
    this.descriptiveName = descriptiveName;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("description")
  public String getDescription() {
    return description;
  }
  public void setDescription(String description) {
    this.description = description;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("category")
  public String getCategory() {
    return category;
  }
  public void setCategory(String category) {
    this.category = category;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class SchemaField {\n");
    
    sb.append("    name: ").append(StringUtil.toIndentedString(name)).append("\n");
    sb.append("    type: ").append(StringUtil.toIndentedString(type)).append("\n");
    sb.append("    nullable: ").append(StringUtil.toIndentedString(nullable)).append("\n");
    sb.append("    unique: ").append(StringUtil.toIndentedString(unique)).append("\n");
    sb.append("    descriptiveName: ").append(StringUtil.toIndentedString(descriptiveName)).append("\n");
    sb.append("    description: ").append(StringUtil.toIndentedString(description)).append("\n");
    sb.append("    category: ").append(StringUtil.toIndentedString(category)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
