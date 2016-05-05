package org.rakam.client.api;

import com.sun.jersey.api.client.GenericType;

import org.rakam.ApiException;
import org.rakam.ApiClient;
import org.rakam.Configuration;
import org.rakam.Pair;

import org.rakam.client.model.UserBatchCreate;
import org.rakam.client.model.User;
import org.rakam.client.model.UserCreateSegment;
import org.rakam.client.model.JsonResponse;
import org.rakam.client.model.CollectionEvent;
import java.util.Date;
import org.rakam.client.model.UserIncrementProperty;
import org.rakam.client.model.UserMergeUser;
import org.rakam.client.model.MetadataResponse;
import org.rakam.client.model.QueryResult;
import org.rakam.client.model.UserSearchUsers;
import org.rakam.client.model.SetUserProperties;
import org.rakam.client.model.UserUnsetProperty;

import java.util.*;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class UserApi {
  private ApiClient apiClient;

  public UserApi() {
    this(Configuration.getDefaultApiClient());
  }

  public UserApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Create new user
   * 
   * @param userBatchCreate 
   * @return List<String>
   */
  public List<String> userBatchCreate(UserBatchCreate userBatchCreate) throws ApiException {
    Object postBody = userBatchCreate;
    
     // verify the required parameter 'userBatchCreate' is set
     if (userBatchCreate == null) {
        throw new ApiException(400, "Missing the required parameter 'userBatchCreate' when calling userBatchCreate");
     }
     
    // create path and map variables
    String path = "/user/batch/create".replaceAll("\\{format\\}","json");

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

    
    GenericType<List<String>> returnType = new GenericType<List<String>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Create new user
   * 
   * @param user 
   * @return String
   */
  public String userCreate(User user) throws ApiException {
    Object postBody = user;
    
     // verify the required parameter 'user' is set
     if (user == null) {
        throw new ApiException(400, "Missing the required parameter 'user' when calling userCreate");
     }
     
    // create path and map variables
    String path = "/user/create".replaceAll("\\{format\\}","json");

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

    
    GenericType<String> returnType = new GenericType<String>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Get events of the user
   * 
   * @param userCreateSegment 
   * @return JsonResponse
   */
  public JsonResponse userCreateSegment(UserCreateSegment userCreateSegment) throws ApiException {
    Object postBody = userCreateSegment;
    
     // verify the required parameter 'userCreateSegment' is set
     if (userCreateSegment == null) {
        throw new ApiException(400, "Missing the required parameter 'userCreateSegment' when calling userCreateSegment");
     }
     
    // create path and map variables
    String path = "/user/create_segment".replaceAll("\\{format\\}","json");

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

    
    GenericType<JsonResponse> returnType = new GenericType<JsonResponse>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Get user
   * 
   * @param project 
   * @param user 
   * @return User
   */
  public User userGetUser(String project, String user) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/user/get".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (user != null)
      formParams.put("user", user);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "read_key" };

    
    GenericType<User> returnType = new GenericType<User>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Get events of the user
   * 
   * @param project 
   * @param user 
   * @param limit 
   * @param offset 
   * @return List<CollectionEvent>
   */
  public List<CollectionEvent> userGetEvents(String project, String user, Integer limit, Date offset) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/user/get_events".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (user != null)
      formParams.put("user", user);
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

    
    GenericType<List<CollectionEvent>> returnType = new GenericType<List<CollectionEvent>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Set user property
   * 
   * @param userIncrementProperty 
   * @return JsonResponse
   */
  public JsonResponse userIncrementProperty(UserIncrementProperty userIncrementProperty) throws ApiException {
    Object postBody = userIncrementProperty;
    
     // verify the required parameter 'userIncrementProperty' is set
     if (userIncrementProperty == null) {
        throw new ApiException(400, "Missing the required parameter 'userIncrementProperty' when calling userIncrementProperty");
     }
     
    // create path and map variables
    String path = "/user/increment_property".replaceAll("\\{format\\}","json");

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

    
    GenericType<JsonResponse> returnType = new GenericType<JsonResponse>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Merge user with anonymous id
   * 
   * @param userMergeUser 
   * @return Boolean
   */
  public Boolean userMergeUser(UserMergeUser userMergeUser) throws ApiException {
    Object postBody = userMergeUser;
    
     // verify the required parameter 'userMergeUser' is set
     if (userMergeUser == null) {
        throw new ApiException(400, "Missing the required parameter 'userMergeUser' when calling userMergeUser");
     }
     
    // create path and map variables
    String path = "/user/merge".replaceAll("\\{format\\}","json");

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
   * Get user storage metadata
   * 
   * @param project 
   * @return MetadataResponse
   */
  public MetadataResponse userGetMetadata(String project) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/user/metadata".replaceAll("\\{format\\}","json");

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

    
    GenericType<MetadataResponse> returnType = new GenericType<MetadataResponse>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Search users
   * 
   * @param userSearchUsers 
   * @return QueryResult
   */
  public QueryResult userSearchUsers(UserSearchUsers userSearchUsers) throws ApiException {
    Object postBody = userSearchUsers;
    
     // verify the required parameter 'userSearchUsers' is set
     if (userSearchUsers == null) {
        throw new ApiException(400, "Missing the required parameter 'userSearchUsers' when calling userSearchUsers");
     }
     
    // create path and map variables
    String path = "/user/search".replaceAll("\\{format\\}","json");

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

    
    GenericType<QueryResult> returnType = new GenericType<QueryResult>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Set user properties
   * 
   * @param setUserProperties 
   * @return Integer
   */
  public Integer userSetProperties(SetUserProperties setUserProperties) throws ApiException {
    Object postBody = setUserProperties;
    
     // verify the required parameter 'setUserProperties' is set
     if (setUserProperties == null) {
        throw new ApiException(400, "Missing the required parameter 'setUserProperties' when calling userSetProperties");
     }
     
    // create path and map variables
    String path = "/user/set_properties".replaceAll("\\{format\\}","json");

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

    
    GenericType<Integer> returnType = new GenericType<Integer>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Set user properties once
   * 
   * @param setUserProperties 
   * @return void
   */
  public void userSetPropertiesOnce(SetUserProperties setUserProperties) throws ApiException {
    Object postBody = setUserProperties;
    
     // verify the required parameter 'setUserProperties' is set
     if (setUserProperties == null) {
        throw new ApiException(400, "Missing the required parameter 'setUserProperties' when calling userSetPropertiesOnce");
     }
     
    // create path and map variables
    String path = "/user/set_properties_once".replaceAll("\\{format\\}","json");

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

    
    apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, null);
    
  }
  
  /**
   * Unset user property
   * 
   * @param userUnsetProperty 
   * @return JsonResponse
   */
  public JsonResponse userUnsetProperty(UserUnsetProperty userUnsetProperty) throws ApiException {
    Object postBody = userUnsetProperty;
    
     // verify the required parameter 'userUnsetProperty' is set
     if (userUnsetProperty == null) {
        throw new ApiException(400, "Missing the required parameter 'userUnsetProperty' when calling userUnsetProperty");
     }
     
    // create path and map variables
    String path = "/user/unset_properties".replaceAll("\\{format\\}","json");

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

    
    GenericType<JsonResponse> returnType = new GenericType<JsonResponse>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
}
