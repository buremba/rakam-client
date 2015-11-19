package org.rakam.client.model;

import org.rakam.StringUtil;
import org.rakam.client.model.MaterializedViewBuilder;
import org.rakam.client.model.ContinuousQueryBuilder;
import org.rakam.client.model.ReportBuilder;
import org.rakam.client.model.Collection;
import java.util.*;
import java.util.Map;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-11-19T22:59:17.166+02:00")
public class Recipe   {
  

public enum StrategyEnum {
  DEFAULT("DEFAULT"),
  SPECIFIC("SPECIFIC");

  private String value;

  StrategyEnum(String value) {
    this.value = value;
  }

  @Override
  public String toString() {
    return value;
  }
}

  private StrategyEnum strategy = null;
  private String project = null;
  private Map<String, Collection> collections = new HashMap<String, Collection>();
  private List<ReportBuilder> reports = new ArrayList<ReportBuilder>();
  private List<MaterializedViewBuilder> materializedViews = new ArrayList<MaterializedViewBuilder>();
  private List<ContinuousQueryBuilder> continuousQueries = new ArrayList<ContinuousQueryBuilder>();
  private List<ContinuousQueryBuilder> continuousQueryBuilders = new ArrayList<ContinuousQueryBuilder>();
  private List<MaterializedViewBuilder> materializedViewBuilders = new ArrayList<MaterializedViewBuilder>();

  
  /**
   **/
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("strategy")
  public StrategyEnum getStrategy() {
    return strategy;
  }
  public void setStrategy(StrategyEnum strategy) {
    this.strategy = strategy;
  }

  
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
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("collections")
  public Map<String, Collection> getCollections() {
    return collections;
  }
  public void setCollections(Map<String, Collection> collections) {
    this.collections = collections;
  }

  
  /**
   **/
  @ApiModelProperty(required = true, value = "")
  @JsonProperty("reports")
  public List<ReportBuilder> getReports() {
    return reports;
  }
  public void setReports(List<ReportBuilder> reports) {
    this.reports = reports;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("materializedViews")
  public List<MaterializedViewBuilder> getMaterializedViews() {
    return materializedViews;
  }
  public void setMaterializedViews(List<MaterializedViewBuilder> materializedViews) {
    this.materializedViews = materializedViews;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("continuousQueries")
  public List<ContinuousQueryBuilder> getContinuousQueries() {
    return continuousQueries;
  }
  public void setContinuousQueries(List<ContinuousQueryBuilder> continuousQueries) {
    this.continuousQueries = continuousQueries;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("continuousQueryBuilders")
  public List<ContinuousQueryBuilder> getContinuousQueryBuilders() {
    return continuousQueryBuilders;
  }
  public void setContinuousQueryBuilders(List<ContinuousQueryBuilder> continuousQueryBuilders) {
    this.continuousQueryBuilders = continuousQueryBuilders;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("materializedViewBuilders")
  public List<MaterializedViewBuilder> getMaterializedViewBuilders() {
    return materializedViewBuilders;
  }
  public void setMaterializedViewBuilders(List<MaterializedViewBuilder> materializedViewBuilders) {
    this.materializedViewBuilders = materializedViewBuilders;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Recipe {\n");
    
    sb.append("    strategy: ").append(StringUtil.toIndentedString(strategy)).append("\n");
    sb.append("    project: ").append(StringUtil.toIndentedString(project)).append("\n");
    sb.append("    collections: ").append(StringUtil.toIndentedString(collections)).append("\n");
    sb.append("    reports: ").append(StringUtil.toIndentedString(reports)).append("\n");
    sb.append("    materializedViews: ").append(StringUtil.toIndentedString(materializedViews)).append("\n");
    sb.append("    continuousQueries: ").append(StringUtil.toIndentedString(continuousQueries)).append("\n");
    sb.append("    continuousQueryBuilders: ").append(StringUtil.toIndentedString(continuousQueryBuilders)).append("\n");
    sb.append("    materializedViewBuilders: ").append(StringUtil.toIndentedString(materializedViewBuilders)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
