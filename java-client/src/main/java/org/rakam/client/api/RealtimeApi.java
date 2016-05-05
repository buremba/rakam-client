package org.rakam.client.api;

import com.sun.jersey.api.client.GenericType;

import org.rakam.ApiException;
import org.rakam.ApiClient;
import org.rakam.Configuration;
import org.rakam.Pair;

import org.rakam.client.model.RealTimeReport;
import org.rakam.client.model.JsonResponse;
import org.rakam.client.model.RealTimeQueryResult;
import org.rakam.client.model.RealtimeGet;
import org.rakam.client.model.ContinuousQuery;

import java.util.*;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
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
   * @param realTimeReport 
   * @return JsonResponse
   */
  public JsonResponse realtimeCreate(RealTimeReport realTimeReport) throws ApiException {
    Object postBody = realTimeReport;
    
     // verify the required parameter 'realTimeReport' is set
     if (realTimeReport == null) {
        throw new ApiException(400, "Missing the required parameter 'realTimeReport' when calling realtimeCreate");
     }
     
    // create path and map variables
    String path = "/realtime/create".replaceAll("\\{format\\}","json");

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

    String[] authNames = new String[] { "master_key" };

    
    GenericType<JsonResponse> returnType = new GenericType<JsonResponse>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Delete report
   * 
   * @param project 
   * @param tableName 
   * @return JsonResponse
   */
  public JsonResponse realtimeDelete(String project, String tableName) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/realtime/delete".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (tableName != null)
      formParams.put("table_name", tableName);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "master_key" };

    
    GenericType<JsonResponse> returnType = new GenericType<JsonResponse>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Get report
   * 
   * @param realtimeGet 
   * @return RealTimeQueryResult
   */
  public RealTimeQueryResult realtimeGet(RealtimeGet realtimeGet) throws ApiException {
    Object postBody = realtimeGet;
    
     // verify the required parameter 'realtimeGet' is set
     if (realtimeGet == null) {
        throw new ApiException(400, "Missing the required parameter 'realtimeGet' when calling realtimeGet");
     }
     
    // create path and map variables
    String path = "/realtime/get".replaceAll("\\{format\\}","json");

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

    
    GenericType<RealTimeQueryResult> returnType = new GenericType<RealTimeQueryResult>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * List queries
   * 
   * @param project 
   * @return List<ContinuousQuery>
   */
  public List<ContinuousQuery> realtimeList(String project) throws ApiException {
    Object postBody = null;
    
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

    
    GenericType<List<ContinuousQuery>> returnType = new GenericType<List<ContinuousQuery>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
}
