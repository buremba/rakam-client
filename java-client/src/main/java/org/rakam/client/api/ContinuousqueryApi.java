package org.rakam.client.api;

import com.sun.jersey.api.client.GenericType;

import org.rakam.ApiException;
import org.rakam.ApiClient;
import org.rakam.Configuration;
import org.rakam.Pair;

import org.rakam.client.model.ContinuousQuery;
import org.rakam.client.model.JsonResponse;
import org.rakam.client.model.Collection;

import java.util.*;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class ContinuousqueryApi {
  private ApiClient apiClient;

  public ContinuousqueryApi() {
    this(Configuration.getDefaultApiClient());
  }

  public ContinuousqueryApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Create stream
   * 
   * @param continuousQuery 
   * @return JsonResponse
   */
  public JsonResponse continuousQueryCreate(ContinuousQuery continuousQuery) throws ApiException {
    Object postBody = continuousQuery;
    
     // verify the required parameter 'continuousQuery' is set
     if (continuousQuery == null) {
        throw new ApiException(400, "Missing the required parameter 'continuousQuery' when calling continuousQueryCreate");
     }
     
    // create path and map variables
    String path = "/continuous-query/create".replaceAll("\\{format\\}","json");

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
   * Delete stream
   * 
   * @param project 
   * @param tableName 
   * @return JsonResponse
   */
  public JsonResponse continuousQueryDelete(String project, String tableName) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/continuous-query/delete".replaceAll("\\{format\\}","json");

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
   * Get continuous query
   * 
   * @param project 
   * @param tableName 
   * @return ContinuousQuery
   */
  public ContinuousQuery continuousQueryGet(String project, String tableName) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/continuous-query/get".replaceAll("\\{format\\}","json");

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

    String[] authNames = new String[] { "read_key" };

    
    GenericType<ContinuousQuery> returnType = new GenericType<ContinuousQuery>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * List queries
   * 
   * @param project 
   * @return List<ContinuousQuery>
   */
  public List<ContinuousQuery> continuousQueryListQueries(String project) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/continuous-query/list".replaceAll("\\{format\\}","json");

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
  
  /**
   * Get query schema
   * 
   * @param project 
   * @param names 
   * @return List<Collection>
   */
  public List<Collection> continuousQuerySchema(String project, List<String> names) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/continuous-query/schema".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (names != null)
      formParams.put("names", names);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "read_key" };

    
    GenericType<List<Collection>> returnType = new GenericType<List<Collection>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Test continuous query
   * 
   * @param project 
   * @param query 
   * @return Boolean
   */
  public Boolean continuousQueryTest(String project, String query) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/continuous-query/test".replaceAll("\\{format\\}","json");

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

    
    GenericType<Boolean> returnType = new GenericType<Boolean>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
}
