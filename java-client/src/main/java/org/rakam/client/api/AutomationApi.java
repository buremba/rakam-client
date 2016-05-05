package org.rakam.client.api;

import com.sun.jersey.api.client.GenericType;

import org.rakam.ApiException;
import org.rakam.ApiClient;
import org.rakam.Configuration;
import org.rakam.Pair;

import org.rakam.client.model.JsonResponse;
import org.rakam.client.model.AutomationRule;

import java.util.*;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class AutomationApi {
  private ApiClient apiClient;

  public AutomationApi() {
    this(Configuration.getDefaultApiClient());
  }

  public AutomationApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Activate rule
   * 
   * @param project 
   * @param id 
   * @return JsonResponse
   */
  public JsonResponse automationActivateRule(String project, Integer id) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/automation/activate".replaceAll("\\{format\\}","json");

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
   * Add scenario
   * 
   * @param automationRule 
   * @return JsonResponse
   */
  public JsonResponse automationAddRule(AutomationRule automationRule) throws ApiException {
    Object postBody = automationRule;
    
     // verify the required parameter 'automationRule' is set
     if (automationRule == null) {
        throw new ApiException(400, "Missing the required parameter 'automationRule' when calling automationAddRule");
     }
     
    // create path and map variables
    String path = "/automation/add".replaceAll("\\{format\\}","json");

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
   * Deactivate rule
   * 
   * @param project 
   * @param id 
   * @return JsonResponse
   */
  public JsonResponse automationDeactivateRule(String project, Integer id) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/automation/deactivate".replaceAll("\\{format\\}","json");

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
   * List scenarios
   * 
   * @param project 
   * @return List<AutomationRule>
   */
  public List<AutomationRule> automationListRules(String project) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/automation/list".replaceAll("\\{format\\}","json");

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

    
    GenericType<List<AutomationRule>> returnType = new GenericType<List<AutomationRule>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Remove rule
   * 
   * @param project 
   * @param id 
   * @return JsonResponse
   */
  public JsonResponse automationRemoveRule(String project, Integer id) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/automation/remove".replaceAll("\\{format\\}","json");

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
  
}
