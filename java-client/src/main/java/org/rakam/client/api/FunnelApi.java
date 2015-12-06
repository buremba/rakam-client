package org.rakam.client.api;

import org.rakam.ApiException;
import org.rakam.ApiClient;
import org.rakam.Configuration;
import org.rakam.Pair;
import org.rakam.TypeRef;

import org.rakam.client.model.*;

import java.util.*;

import org.rakam.client.model.FunnelQuery;
import org.rakam.client.model.QueryResult;

import java.io.File;
import java.util.Map;
import java.util.HashMap;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-06T22:11:51.057+02:00")
public class FunnelApi {
  private ApiClient apiClient;

  public FunnelApi() {
    this(Configuration.getDefaultApiClient());
  }

  public FunnelApi(ApiClient apiClient) {
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
   * @param funnelQuery 
   * @return void
   */
  public void analyze (FunnelQuery funnelQuery) throws ApiException {
    Object postBody = funnelQuery;
    byte[] postBinaryBody = null;
    
     // verify the required parameter 'funnelQuery' is set
     if (funnelQuery == null) {
        throw new ApiException(400, "Missing the required parameter 'funnelQuery' when calling analyze");
     }
     
    // create path and map variables
    String path = "/funnel/analyze".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    

    final String[] accepts = {
      "text/event-stream"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "text/event-stream"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "read_key" };

    

    
    
    apiClient.invokeAPI(path, "GET", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, null);
    
    


  }
  
  /**
   * Execute query
   * 
   * @param funnelQuery 
   * @return QueryResult
   */
  public QueryResult analyze_1 (FunnelQuery funnelQuery) throws ApiException {
    Object postBody = funnelQuery;
    byte[] postBinaryBody = null;
    
     // verify the required parameter 'funnelQuery' is set
     if (funnelQuery == null) {
        throw new ApiException(400, "Missing the required parameter 'funnelQuery' when calling analyze_1");
     }
     
    // create path and map variables
    String path = "/funnel/analyze".replaceAll("\\{format\\}","json");

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

    

    
    
    TypeRef returnType = new TypeRef<QueryResult>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
    


  }
  
}
