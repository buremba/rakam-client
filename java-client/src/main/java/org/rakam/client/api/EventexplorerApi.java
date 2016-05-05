package org.rakam.client.api;

import com.sun.jersey.api.client.GenericType;

import org.rakam.ApiException;
import org.rakam.ApiClient;
import org.rakam.Configuration;
import org.rakam.Pair;

import org.rakam.client.model.QueryResult;
import org.rakam.client.model.AnalyzeRequest;
import java.util.*;
import org.rakam.client.model.PreCalculatedTable;
import java.util.Date;

import java.util.*;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class EventexplorerApi {
  private ApiClient apiClient;

  public EventexplorerApi() {
    this(Configuration.getDefaultApiClient());
  }

  public EventexplorerApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Perform simple query on event data
   * 
   * @param analyzeRequest 
   * @return QueryResult
   */
  public QueryResult eventExplorerAnalyze(AnalyzeRequest analyzeRequest) throws ApiException {
    Object postBody = analyzeRequest;
    
     // verify the required parameter 'analyzeRequest' is set
     if (analyzeRequest == null) {
        throw new ApiException(400, "Missing the required parameter 'analyzeRequest' when calling eventExplorerAnalyze");
     }
     
    // create path and map variables
    String path = "/event-explorer/analyze".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "read_key" };

    
    GenericType<QueryResult> returnType = new GenericType<QueryResult>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Event statistics
   * 
   * @param project 
   * @return Map<String, List<String>>
   */
  public Map<String, List<String>> eventExplorerGetExtraDimensions(String project) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/event-explorer/extra_dimensions".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "read_key" };

    
    GenericType<Map<String, List<String>>> returnType = new GenericType<Map<String, List<String>>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Create Pre-computed table
   * 
   * @param project 
   * @param collections 
   * @param dimensions 
   * @param aggregations 
   * @param measures 
   * @param tableName 
   * @return PreCalculatedTable
   */
  public PreCalculatedTable eventExplorerCreatePreComputedTable(String project, List<String> collections, List<String> dimensions, List<String> aggregations, List<String> measures, String tableName) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/event-explorer/pre_calculate".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (collections != null)
      formParams.put("collections", collections);
    if (dimensions != null)
      formParams.put("dimensions", dimensions);
    if (aggregations != null)
      formParams.put("aggregations", aggregations);
    if (measures != null)
      formParams.put("measures", measures);
    if (tableName != null)
      formParams.put("tableName", tableName);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "master_key" };

    
    GenericType<PreCalculatedTable> returnType = new GenericType<PreCalculatedTable>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Event statistics
   * 
   * @param project 
   * @param collections 
   * @param dimension 
   * @param startDate 
   * @param endDate 
   * @return QueryResult
   */
  public QueryResult eventExplorerGetEventStatistics(String project, List<String> collections, String dimension, Date startDate, Date endDate) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/event-explorer/statistics".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (collections != null)
      formParams.put("collections", collections);
    if (dimension != null)
      formParams.put("dimension", dimension);
    if (startDate != null)
      formParams.put("startDate", startDate);
    if (endDate != null)
      formParams.put("endDate", endDate);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "read_key" };

    
    GenericType<QueryResult> returnType = new GenericType<QueryResult>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
}
