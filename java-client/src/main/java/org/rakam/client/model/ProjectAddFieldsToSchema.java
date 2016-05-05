package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import org.rakam.client.model.SchemaField;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class ProjectAddFieldsToSchema   {
  
  private String project = null;
  private String collection = null;
  private List<SchemaField> fields = new ArrayList<SchemaField>();

  
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
  @JsonProperty("collection")
  public String getCollection() {
    return collection;
  }
  public void setCollection(String collection) {
    this.collection = collection;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("fields")
  public List<SchemaField> getFields() {
    return fields;
  }
  public void setFields(List<SchemaField> fields) {
    this.fields = fields;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ProjectAddFieldsToSchema projectAddFieldsToSchema = (ProjectAddFieldsToSchema) o;
    return Objects.equals(project, projectAddFieldsToSchema.project) &&
        Objects.equals(collection, projectAddFieldsToSchema.collection) &&
        Objects.equals(fields, projectAddFieldsToSchema.fields);
  }

  @Override
  public int hashCode() {
    return Objects.hash(project, collection, fields);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ProjectAddFieldsToSchema {\n");
    
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    collection: ").append(toIndentedString(collection)).append("\n");
    sb.append("    fields: ").append(toIndentedString(fields)).append("\n");
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

