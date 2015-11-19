package org.rakam.client.model;

import org.rakam.StringUtil;
import org.rakam.client.model.SchemaField;
import java.util.*;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-11-19T22:59:17.166+02:00")
public class MaterializedViewSchema   {
  
  private String name = null;
  private List<SchemaField> fields = new ArrayList<SchemaField>();

  
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
  @JsonProperty("fields")
  public List<SchemaField> getFields() {
    return fields;
  }
  public void setFields(List<SchemaField> fields) {
    this.fields = fields;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class MaterializedViewSchema {\n");
    
    sb.append("    name: ").append(StringUtil.toIndentedString(name)).append("\n");
    sb.append("    fields: ").append(StringUtil.toIndentedString(fields)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
