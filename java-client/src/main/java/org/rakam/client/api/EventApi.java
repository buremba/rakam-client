package org.rakam.client.api;

import com.sun.jersey.api.client.GenericType;

import org.rakam.ApiException;
import org.rakam.ApiClient;
import org.rakam.Configuration;
import org.rakam.Pair;

import org.rakam.client.model.EventList;
import org.rakam.client.model.QueryResult;
import org.rakam.client.model.Event;
import org.rakam.client.model.InlineResponse200;
import org.rakam.client.model.SchemaField;

import java.util.*;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
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
  public Integer collectEventBatchEvents(EventList eventList) throws ApiException {
    Object postBody = eventList;
    
     // verify the required parameter 'eventList' is set
     if (eventList == null) {
        throw new ApiException(400, "Missing the required parameter 'eventList' when calling collectEventBatchEvents");
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

    
    GenericType<Integer> returnType = new GenericType<Integer>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Send Bulk events
   * 
   * @param eventList 
   * @return Integer
   */
  public Integer collectEventBulkEvents(EventList eventList) throws ApiException {
    Object postBody = eventList;
    
     // verify the required parameter 'eventList' is set
     if (eventList == null) {
        throw new ApiException(400, "Missing the required parameter 'eventList' when calling collectEventBulkEvents");
     }
     
    // create path and map variables
    String path = "/event/bulk".replaceAll("\\{format\\}","json");

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

    
    GenericType<Integer> returnType = new GenericType<Integer>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Commit Bulk events
   * 
   * @param project 
   * @param collection 
   * @return QueryResult
   */
  public QueryResult collectEventCommitBulkEvents(String project, String collection) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/event/bulk/commit".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (collection != null)
      formParams.put("collection", collection);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "master_key" };

    
    GenericType<QueryResult> returnType = new GenericType<QueryResult>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Send Bulk events
   * 
   * @param eventList 
   * @return Integer
   */
  public Integer collectEventBulkEventsRemote(EventList eventList) throws ApiException {
    Object postBody = eventList;
    
     // verify the required parameter 'eventList' is set
     if (eventList == null) {
        throw new ApiException(400, "Missing the required parameter 'eventList' when calling collectEventBulkEventsRemote");
     }
     
    // create path and map variables
    String path = "/event/bulk/remote".replaceAll("\\{format\\}","json");

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

    
    GenericType<Integer> returnType = new GenericType<Integer>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Collect event
   * 
   * @param event 
   * @return Integer
   */
  public Integer collectEventCollectEvent(Event event) throws ApiException {
    Object postBody = event;
    
     // verify the required parameter 'event' is set
     if (event == null) {
        throw new ApiException(400, "Missing the required parameter 'event' when calling collectEventCollectEvent");
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

    
    GenericType<Integer> returnType = new GenericType<Integer>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Analyze events
   * 
   * @param project 
   * @param query 
   * @param limit 
   * @return QueryResult
   */
  public QueryResult queryExecute(String project, String query, Integer limit) throws ApiException {
    Object postBody = null;
    
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

    
    GenericType<QueryResult> returnType = new GenericType<QueryResult>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Explain query
   * 
   * @param query 
   * @return InlineResponse200
   */
  public InlineResponse200 queryExplain(String query) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/query/explain".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (query != null)
      formParams.put("query", query);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "read_key" };

    
    GenericType<InlineResponse200> returnType = new GenericType<InlineResponse200>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Test query
   * 
   * @param project 
   * @param query 
   * @return List<SchemaField>
   */
  public List<SchemaField> queryMetadata(String project, String query) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/query/metadata".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (query != null)
      formParams.put("query", query);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "read_key" };

    
    GenericType<List<SchemaField>> returnType = new GenericType<List<SchemaField>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
}
