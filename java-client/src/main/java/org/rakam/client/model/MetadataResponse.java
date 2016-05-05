package org.rakam.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.*;
import org.rakam.client.model.SchemaField;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class MetadataResponse   {
  
  private List<SchemaField> columns = new ArrayList<SchemaField>();
  private String identifierColumn = null;

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("columns")
  public List<SchemaField> getColumns() {
    return columns;
  }
  public void setColumns(List<SchemaField> columns) {
    this.columns = columns;
  }

  
  /**
   **/
  
  @ApiModelProperty(value = "")
  @JsonProperty("identifierColumn")
  public String getIdentifierColumn() {
    return identifierColumn;
  }
  public void setIdentifierColumn(String identifierColumn) {
    this.identifierColumn = identifierColumn;
  }

  

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MetadataResponse metadataResponse = (MetadataResponse) o;
    return Objects.equals(columns, metadataResponse.columns) &&
        Objects.equals(identifierColumn, metadataResponse.identifierColumn);
  }

  @Override
  public int hashCode() {
    return Objects.hash(columns, identifierColumn);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MetadataResponse {\n");
    
    sb.append("    columns: ").append(toIndentedString(columns)).append("\n");
    sb.append("    identifierColumn: ").append(toIndentedString(identifierColumn)).append("\n");
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

