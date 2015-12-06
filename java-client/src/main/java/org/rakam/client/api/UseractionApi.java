package org.rakam.client.api;

import org.rakam.ApiException;
import org.rakam.ApiClient;
import org.rakam.Configuration;
import org.rakam.Pair;
import org.rakam.TypeRef;

import org.rakam.client.model.*;

import java.util.*;

import org.rakam.client.model.BatchSendEmails;
import org.rakam.client.model.Send;
import org.rakam.client.model.Message;
import org.rakam.client.model.BatchSendMessages;

import java.io.File;
import java.util.Map;
import java.util.HashMap;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
public class UseractionApi {
  private ApiClient apiClient;

  public UseractionApi() {
    this(Configuration.getDefaultApiClient());
  }

  public UseractionApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Apply batch operation
   * 
   * @param batchSendEmails 
   * @return Long
   */
  public Long batchSendEmails (BatchSendEmails batchSendEmails) throws ApiException {
    Object postBody = batchSendEmails;
    byte[] postBinaryBody = null;
    
     // verify the required parameter 'batchSendEmails' is set
     if (batchSendEmails == null) {
        throw new ApiException(400, "Missing the required parameter 'batchSendEmails' when calling batchSendEmails");
     }
     
    // create path and map variables
    String path = "/user/action/email/batch".replaceAll("\\{format\\}","json");

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

    String[] authNames = new String[] {  };

    

    
    
    TypeRef returnType = new TypeRef<Long>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
    


  }
  
  /**
   * Perform action for single user
   * 
   * @param send 
   * @return Boolean
   */
  public Boolean send (Send send) throws ApiException {
    Object postBody = send;
    byte[] postBinaryBody = null;
    
     // verify the required parameter 'send' is set
     if (send == null) {
        throw new ApiException(400, "Missing the required parameter 'send' when calling send");
     }
     
    // create path and map variables
    String path = "/user/action/email/single".replaceAll("\\{format\\}","json");

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

    String[] authNames = new String[] {  };

    

    
    
    TypeRef returnType = new TypeRef<Boolean>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
    


  }
  
  /**
   * Send message to user
   * Sends a mail to users mailbox
   * @param project 
   * @param fromUser 
   * @param toUser 
   * @param parent 
   * @param message 
   * @param timestamp 
   * @return Message
   */
  public Message send_1 (String project, String fromUser, String toUser, Integer parent, String message, Long timestamp) throws ApiException {
    Object postBody = null;
    byte[] postBinaryBody = null;
    
    // create path and map variables
    String path = "/user/action/mailbox/action/mailbox/single".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (fromUser != null)
      formParams.put("from_user", fromUser);
    if (toUser != null)
      formParams.put("to_user", toUser);
    if (parent != null)
      formParams.put("parent", parent);
    if (message != null)
      formParams.put("message", message);
    if (timestamp != null)
      formParams.put("timestamp", timestamp);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "write_key" };

    

    
    
    TypeRef returnType = new TypeRef<Message>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
    


  }
  
  /**
   * Apply batch operation
   * 
   * @param batchSendMessages 
   * @return Long
   */
  public Long batchSendMessages (BatchSendMessages batchSendMessages) throws ApiException {
    Object postBody = batchSendMessages;
    byte[] postBinaryBody = null;
    
     // verify the required parameter 'batchSendMessages' is set
     if (batchSendMessages == null) {
        throw new ApiException(400, "Missing the required parameter 'batchSendMessages' when calling batchSendMessages");
     }
     
    // create path and map variables
    String path = "/user/action/mailbox/batch".replaceAll("\\{format\\}","json");

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

    String[] authNames = new String[] {  };

    

    
    
    TypeRef returnType = new TypeRef<Long>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
    


  }
  
}
