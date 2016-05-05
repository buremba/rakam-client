package org.rakam.client.api;

import com.sun.jersey.api.client.GenericType;

import org.rakam.ApiException;
import org.rakam.ApiClient;
import org.rakam.Configuration;
import org.rakam.Pair;

import org.rakam.client.model.ABTestingReport;
import org.rakam.client.model.JsonResponse;

import java.util.*;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class AbtestingApi {
  private ApiClient apiClient;

  public AbtestingApi() {
    this(Configuration.getDefaultApiClient());
  }

  public AbtestingApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Create test
   * 
   * @param aBTestingReport 
   * @return JsonResponse
   */
  public JsonResponse abTestingCreate(ABTestingReport aBTestingReport) throws ApiException {
    Object postBody = aBTestingReport;
    
     // verify the required parameter 'aBTestingReport' is set
     if (aBTestingReport == null) {
        throw new ApiException(400, "Missing the required parameter 'aBTestingReport' when calling abTestingCreate");
     }
     
    // create path and map variables
    String path = "/ab-testing/create".replaceAll("\\{format\\}","json");

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
   * @param id 
   * @return JsonResponse
   */
  public JsonResponse abTestingDelete(String project, Integer id) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/ab-testing/delete".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (id != null)
      formParams.put("id", id);
    

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
   * @param project 
   * @param id 
   * @return ABTestingReport
   */
  public ABTestingReport abTestingGet(String project, Integer id) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/ab-testing/get".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (id != null)
      formParams.put("id", id);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "read_key" };

    
    GenericType<ABTestingReport> returnType = new GenericType<ABTestingReport>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * List reports
   * 
   * @param project 
   * @return List<ABTestingReport>
   */
  public List<ABTestingReport> abTestingList(String project) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/ab-testing/list".replaceAll("\\{format\\}","json");

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

    
    GenericType<List<ABTestingReport>> returnType = new GenericType<List<ABTestingReport>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Update report
   * 
   * @param aBTestingReport 
   * @return ABTestingReport
   */
  public ABTestingReport abTestingUpdate(ABTestingReport aBTestingReport) throws ApiException {
    Object postBody = aBTestingReport;
    
     // verify the required parameter 'aBTestingReport' is set
     if (aBTestingReport == null) {
        throw new ApiException(400, "Missing the required parameter 'aBTestingReport' when calling abTestingUpdate");
     }
     
    // create path and map variables
    String path = "/ab-testing/update".replaceAll("\\{format\\}","json");

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

    
    GenericType<ABTestingReport> returnType = new GenericType<ABTestingReport>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
}
