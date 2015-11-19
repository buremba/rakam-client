package org.rakam.client.api;

import org.rakam.ApiException;
import org.rakam.ApiClient;
import org.rakam.Configuration;
import org.rakam.Pair;
import org.rakam.TypeRef;

import org.rakam.client.model.*;

import java.util.*;

import org.rakam.client.model.JsonResponse;
import java.util.Date;
import org.rakam.client.model.RealTimeReport;

import java.io.File;
import java.util.Map;
import java.util.HashMap;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-11-19T22:59:17.166+02:00")
public class RealtimeApi {
  private ApiClient apiClient;

  public RealtimeApi() {
    this(Configuration.getDefaultApiClient());
  }

  public RealtimeApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Create report
   * 
   * @param project 
   * @param name 
   * @param aggregation 
   * @param tableName 
   * @param collections 
   * @param filter 
   * @param measure 
   * @param dimensions 
   * @return JsonResponse
   */
  public JsonResponse create (String project, String name, String aggregation, String tableName, List<String> collections, String filter, String measure, List<String> dimensions) throws ApiException {
    Object postBody = null;
    byte[] postBinaryBody = null;
    
    // create path and map variables
    String path = "/realtime/create".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (name != null)
      formParams.put("name", name);
    if (aggregation != null)
      formParams.put("aggregation", aggregation);
    if (tableName != null)
      formParams.put("table_name", tableName);
    if (collections != null)
      formParams.put("collections", collections);
    if (filter != null)
      formParams.put("filter", filter);
    if (measure != null)
      formParams.put("measure", measure);
    if (dimensions != null)
      formParams.put("dimensions", dimensions);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "read_key" };

    

    
    
    TypeRef returnType = new TypeRef<JsonResponse>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
    


  }
  
  /**
   * Delete report
   * 
   * @param project 
   * @param name 
   * @return JsonResponse
   */
  public JsonResponse delete (String project, String name) throws ApiException {
    Object postBody = null;
    byte[] postBinaryBody = null;
    
    // create path and map variables
    String path = "/realtime/delete".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (name != null)
      formParams.put("name", name);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "read_key" };

    

    
    
    TypeRef returnType = new TypeRef<JsonResponse>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
    


  }
  
  /**
   * Get report
   * 
   * @param project 
   * @param tableName 
   * @param filter 
   * @param aggregation 
   * @param measure 
   * @param dimensions 
   * @param aggregate 
   * @param dateStart 
   * @param dateEnd 
   * @return Object
   */
  public Object get (String project, String tableName, String filter, String aggregation, String measure, List<String> dimensions, Boolean aggregate, Date dateStart, Date dateEnd) throws ApiException {
    Object postBody = null;
    byte[] postBinaryBody = null;
    
    // create path and map variables
    String path = "/realtime/get".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (tableName != null)
      formParams.put("table_name", tableName);
    if (filter != null)
      formParams.put("filter", filter);
    if (aggregation != null)
      formParams.put("aggregation", aggregation);
    if (measure != null)
      formParams.put("measure", measure);
    if (dimensions != null)
      formParams.put("dimensions", dimensions);
    if (aggregate != null)
      formParams.put("aggregate", aggregate);
    if (dateStart != null)
      formParams.put("date_start", dateStart);
    if (dateEnd != null)
      formParams.put("date_end", dateEnd);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "read_key" };

    

    
    
    TypeRef returnType = new TypeRef<Object>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
    


  }
  
  /**
   * List reports
   * 
   * @param project 
   * @return List<RealTimeReport>
   */
  public List<RealTimeReport> listReports (String project) throws ApiException {
    Object postBody = null;
    byte[] postBinaryBody = null;
    
    // create path and map variables
    String path = "/realtime/list".replaceAll("\\{format\\}","json");

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

    

    
    
    TypeRef returnType = new TypeRef<List<RealTimeReport>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
    


  }
  
}
