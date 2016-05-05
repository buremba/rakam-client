package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class SchemaField   {
  
  private String name = null;


  public enum TypeEnum {
    STRING("STRING"),
    INTEGER("INTEGER"),
    DECIMAL("DECIMAL"),
    DOUBLE("DOUBLE"),
    LONG("LONG"),
    BOOLEAN("BOOLEAN"),
    DATE("DATE"),
    TIME("TIME"),
    TIMESTAMP("TIMESTAMP"),
    BINARY("BINARY"),
    ARRAY_STRING("ARRAY_STRING"),
    ARRAY_INTEGER("ARRAY_INTEGER"),
    ARRAY_DECIMAL("ARRAY_DECIMAL"),
    ARRAY_DOUBLE("ARRAY_DOUBLE"),
    ARRAY_LONG("ARRAY_LONG"),
    ARRAY_BOOLEAN("ARRAY_BOOLEAN"),
    ARRAY_DATE("ARRAY_DATE"),
    ARRAY_TIME("ARRAY_TIME"),
    ARRAY_TIMESTAMP("ARRAY_TIMESTAMP"),
    ARRAY_BINARY("ARRAY_BINARY"),
    MAP_STRING("MAP_STRING"),
    MAP_INTEGER("MAP_INTEGER"),
    MAP_DECIMAL("MAP_DECIMAL"),
    MAP_DOUBLE("MAP_DOUBLE"),
    MAP_LONG("MAP_LONG"),
    MAP_BOOLEAN("MAP_BOOLEAN"),
    MAP_DATE("MAP_DATE"),
    MAP_TIME("MAP_TIME"),
    MAP_TIMESTAMP("MAP_TIMESTAMP"),
    MAP_BINARY("MAP_BINARY");

    private String value;

    TypeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private TypeEnum type = null;
  private Boolean unique = false;
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
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SchemaField schemaField = (SchemaField) o;
    return Objects.equals(name, schemaField.name) &&
        Objects.equals(type, schemaField.type) &&
        Objects.equals(unique, schemaField.unique) &&
        Objects.equals(descriptiveName, schemaField.descriptiveName) &&
        Objects.equals(description, schemaField.description) &&
        Objects.equals(category, schemaField.category);
  }

  @Override
  public int hashCode() {
    return Objects.hash(name, type, unique, descriptiveName, description, category);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SchemaField {\n");
    
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
    sb.append("    unique: ").append(toIndentedString(unique)).append("\n");
    sb.append("    descriptiveName: ").append(toIndentedString(descriptiveName)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    category: ").append(toIndentedString(category)).append("\n");
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

