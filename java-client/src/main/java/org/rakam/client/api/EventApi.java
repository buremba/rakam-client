package org.rakam.client.api;

import org.rakam.ApiException;
import org.rakam.ApiClient;
import org.rakam.Configuration;
import org.rakam.Pair;
import org.rakam.TypeRef;

import org.rakam.client.model.*;

import java.util.*;

import org.rakam.client.model.EventList;
import org.rakam.client.model.Event;
import org.rakam.client.model.QueryResult;

import java.io.File;
import java.util.Map;
import java.util.HashMap;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-11-19T22:59:17.166+02:00")
public class EventApi {
  private ApiClient apiClient;

  public EventApi() {
    this(Configuration.getDefaultApiClient());
  }

  public EventApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Collect multiple events
   * 
   * @param eventList 
   * @return Integer
   */
  public Integer batchEvents (EventList eventList) throws ApiException {
    Object postBody = eventList;
    byte[] postBinaryBody = null;
    
     // verify the required parameter 'eventList' is set
     if (eventList == null) {
        throw new ApiException(400, "Missing the required parameter 'eventList' when calling batchEvents");
     }
     
    // create path and map variables
    String path = "/event/batch".replaceAll("\\{format\\}","json");

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

    String[] authNames = new String[] { "write_key" };

    

    
    
    TypeRef returnType = new TypeRef<Integer>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
    


  }
  
  /**
   * Collect event
   * 
   * @param event 
   * @return Integer
   */
  public Integer collectEvent (Event event) throws ApiException {
    Object postBody = event;
    byte[] postBinaryBody = null;
    
     // verify the required parameter 'event' is set
     if (event == null) {
        throw new ApiException(400, "Missing the required parameter 'event' when calling collectEvent");
     }
     
    // create path and map variables
    String path = "/event/collect".replaceAll("\\{format\\}","json");

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

    String[] authNames = new String[] { "write_key" };

    

    
    
    TypeRef returnType = new TypeRef<Integer>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
    


  }
  
  /**
   * Analyze events
   * 
   * @param project 
   * @param query 
   * @param limit 
   * @return QueryResult
   */
  public QueryResult execute (String project, String query, Integer limit) throws ApiException {
    Object postBody = null;
    byte[] postBinaryBody = null;
    
    // create path and map variables
    String path = "/query/execute".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (query != null)
      formParams.put("query", query);
    if (limit != null)
      formParams.put("limit", limit);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "read_key" };

    

    
    
    TypeRef returnType = new TypeRef<QueryResult>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
    


  }
  
}
