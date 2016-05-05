package org.rakam.client.api;

import com.sun.jersey.api.client.GenericType;

import org.rakam.ApiException;
import org.rakam.ApiClient;
import org.rakam.Configuration;
import org.rakam.Pair;

import org.rakam.client.model.UserEmailActionBatch;
import org.rakam.client.model.UserEmailActionSend;
import org.rakam.client.model.Message;
import org.rakam.client.model.UserMailboxActionBatchSendMessages;

import java.util.*;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
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
   * @param userEmailActionBatch 
   * @return Long
   */
  public Long userEmailActionBatch(UserEmailActionBatch userEmailActionBatch) throws ApiException {
    Object postBody = userEmailActionBatch;
    
     // verify the required parameter 'userEmailActionBatch' is set
     if (userEmailActionBatch == null) {
        throw new ApiException(400, "Missing the required parameter 'userEmailActionBatch' when calling userEmailActionBatch");
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

    String[] authNames = new String[] { "read_key" };

    
    GenericType<Long> returnType = new GenericType<Long>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Perform action for single user
   * 
   * @param userEmailActionSend 
   * @return Boolean
   */
  public Boolean userEmailActionSend(UserEmailActionSend userEmailActionSend) throws ApiException {
    Object postBody = userEmailActionSend;
    
     // verify the required parameter 'userEmailActionSend' is set
     if (userEmailActionSend == null) {
        throw new ApiException(400, "Missing the required parameter 'userEmailActionSend' when calling userEmailActionSend");
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

    String[] authNames = new String[] { "read_key" };

    
    GenericType<Boolean> returnType = new GenericType<Boolean>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
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
  public Message userMailboxActionSend(String project, String fromUser, String toUser, Integer parent, String message, Long timestamp) throws ApiException {
    Object postBody = null;
    
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

    
    GenericType<Message> returnType = new GenericType<Message>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Apply batch operation
   * 
   * @param userMailboxActionBatchSendMessages 
   * @return Long
   */
  public Long userMailboxActionBatchSendMessages(UserMailboxActionBatchSendMessages userMailboxActionBatchSendMessages) throws ApiException {
    Object postBody = userMailboxActionBatchSendMessages;
    
     // verify the required parameter 'userMailboxActionBatchSendMessages' is set
     if (userMailboxActionBatchSendMessages == null) {
        throw new ApiException(400, "Missing the required parameter 'userMailboxActionBatchSendMessages' when calling userMailboxActionBatchSendMessages");
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

    String[] authNames = new String[] { "read_key" };

    
    GenericType<Long> returnType = new GenericType<Long>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
}
