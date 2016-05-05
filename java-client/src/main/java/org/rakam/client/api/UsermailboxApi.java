package org.rakam.client.api;

import com.sun.jersey.api.client.GenericType;

import org.rakam.ApiException;
import org.rakam.ApiClient;
import org.rakam.Configuration;
import org.rakam.Pair;

import java.util.*;
import java.util.Map;
import org.rakam.client.model.JsonResponse;

import java.util.*;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
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
  public List<List<Message>> userMailboxGet(String project, String user, Integer parent, Integer limit, Long offset) throws ApiException {
    Object postBody = null;
    
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

    
    GenericType<List<List<Message>>> returnType = new GenericType<List<List<Message>>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Get connected users
   * 
   * @param project 
   * @return List<Map<String, Object>>
   */
  public List<Map<String, Object>> userMailboxGetConnectedUsers(String project) throws ApiException {
    Object postBody = null;
    
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

    
    GenericType<List<Map<String, Object>>> returnType = new GenericType<List<Map<String, Object>>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Mark mail as read
   * Marks the specified mails as read.
   * @param project 
   * @param user 
   * @param messageIds 
   * @return JsonResponse
   */
  public JsonResponse userMailboxMarkAsRead(String project, String user, List<Integer> messageIds) throws ApiException {
    Object postBody = null;
    
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

    
    GenericType<JsonResponse> returnType = new GenericType<JsonResponse>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
}
