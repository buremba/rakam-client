package org.rakam.client.model;

import org.rakam.StringUtil;
import org.rakam.client.model.SchemaField;
import java.util.*;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
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
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class MetadataResponse {\n");
    
    sb.append("    columns: ").append(StringUtil.toIndentedString(columns)).append("\n");
    sb.append("    identifierColumn: ").append(StringUtil.toIndentedString(identifierColumn)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
