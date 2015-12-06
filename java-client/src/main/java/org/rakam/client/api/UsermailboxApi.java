package org.rakam.client.api;

import org.rakam.ApiException;
import org.rakam.ApiClient;
import org.rakam.Configuration;
import org.rakam.Pair;
import org.rakam.TypeRef;

import org.rakam.client.model.*;

import java.util.*;

import java.util.*;
import java.util.Map;
import org.rakam.client.model.JsonResponse;

import java.io.File;
import java.util.Map;
import java.util.HashMap;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
public class UsermailboxApi {
  private ApiClient apiClient;

  public UsermailboxApi() {
    this(Configuration.getDefaultApiClient());
  }

  public UsermailboxApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Get user mailbox
   * Returns the last mails sent to the user
   * @param project 
   * @param user 
   * @param parent 
   * @param limit 
   * @param offset 
   * @return List<List<Message>>
   */
  public List<List<Message>> get (String project, String user, Integer parent, Integer limit, Long offset) throws ApiException {
    Object postBody = null;
    byte[] postBinaryBody = null;
    
    // create path and map variables
    String path = "/user/mailbox/get".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (user != null)
      formParams.put("user", user);
    if (parent != null)
      formParams.put("parent", parent);
    if (limit != null)
      formParams.put("limit", limit);
    if (offset != null)
      formParams.put("offset", offset);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "read_key" };

    

    
    
    TypeRef returnType = new TypeRef<List<List<Message>>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
    


  }
  
  /**
   * Get connected users
   * 
   * @param project 
   * @return List<Map<String, Object>>
   */
  public List<Map<String, Object>> getConnectedUsers (String project) throws ApiException {
    Object postBody = null;
    byte[] postBinaryBody = null;
    
    // create path and map variables
    String path = "/user/mailbox/get_online_users".replaceAll("\\{format\\}","json");

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

    

    
    
    TypeRef returnType = new TypeRef<List<Map<String, Object>>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
    


  }
  
  /**
   * Mark mail as read
   * Marks the specified mails as read.
   * @param project 
   * @param user 
   * @param messageIds 
   * @return JsonResponse
   */
  public JsonResponse markAsRead (String project, String user, List<String> messageIds) throws ApiException {
    Object postBody = null;
    byte[] postBinaryBody = null;
    
    // create path and map variables
    String path = "/user/mailbox/mark_as_read".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (user != null)
      formParams.put("user", user);
    if (messageIds != null)
      formParams.put("message_ids", messageIds);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "write_key" };

    

    
    
    TypeRef returnType = new TypeRef<JsonResponse>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
    


  }
  
}
