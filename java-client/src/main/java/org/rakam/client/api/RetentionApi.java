package org.rakam.client.api;

import com.sun.jersey.api.client.GenericType;

import org.rakam.ApiException;
import org.rakam.ApiClient;
import org.rakam.Configuration;
import org.rakam.Pair;

import org.rakam.client.model.QueryResult;
import org.rakam.client.model.RetentionQuery;

import java.util.*;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class RetentionApi {
  private ApiClient apiClient;

  public RetentionApi() {
    this(Configuration.getDefaultApiClient());
  }

  public RetentionApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Execute query
   * 
   * @param retentionQuery 
   * @return QueryResult
   */
  public QueryResult retentionAnalyzerExecute(RetentionQuery retentionQuery) throws ApiException {
    Object postBody = retentionQuery;
    
     // verify the required parameter 'retentionQuery' is set
     if (retentionQuery == null) {
        throw new ApiException(400, "Missing the required parameter 'retentionQuery' when calling retentionAnalyzerExecute");
     }
     
    // create path and map variables
    String path = "/retention/analyze".replaceAll("\\{format\\}","json");

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
  
}
