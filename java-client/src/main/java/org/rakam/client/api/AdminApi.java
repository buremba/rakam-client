package org.rakam.client.api;

import com.sun.jersey.api.client.GenericType;

import org.rakam.ApiException;
import org.rakam.ApiClient;
import org.rakam.Configuration;
import org.rakam.Pair;

import org.rakam.client.model.JsonResponse;
import org.rakam.client.model.Collection;
import org.rakam.client.model.SchemaField;
import org.rakam.client.model.ProjectAddFieldsToSchema;

import java.util.*;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-06T02:48:07.215+03:00")
public class AdminApi {
  private ApiClient apiClient;

  public AdminApi() {
    this(Configuration.getDefaultApiClient());
  }

  public AdminApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * List installed modules
   * 
   * @return void
   */
  public void adminGetConfigurations() throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/admin/configurations".replaceAll("\\{format\\}","json");

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

    
    apiClient.invokeAPI(path, "GET", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, null);
    
  }
  
  /**
   * List installed modules for ui
   * 
   * @return void
   */
  public void adminModules() throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/admin/modules".replaceAll("\\{format\\}","json");

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

    
    apiClient.invokeAPI(path, "GET", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, null);
    
  }
  
  /**
   * Get types
   * 
   * @return void
   */
  public void adminGetTypes() throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/admin/types".replaceAll("\\{format\\}","json");

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

    
    apiClient.invokeAPI(path, "GET", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, null);
    
  }
  
  /**
   * Get collection names
   * 
   * @param project 
   * @return List<String>
   */
  public List<String> projectCollections(String project) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/project/collection".replaceAll("\\{format\\}","json");

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

    
    GenericType<List<String>> returnType = new GenericType<List<String>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Create project
   * 
   * @param name 
   * @return JsonResponse
   */
  public JsonResponse projectCreateProject(String name) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/project/create".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (name != null)
      formParams.put("name", name);
    

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
   * Delete project
   * 
   * @param project 
   * @return JsonResponse
   */
  public JsonResponse projectDeleteProject(String project) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/project/delete".replaceAll("\\{format\\}","json");

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

    String[] authNames = new String[] { "master_key" };

    
    GenericType<JsonResponse> returnType = new GenericType<JsonResponse>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * List created projects
   * 
   * @return void
   */
  public void projectGetProjects() throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/project/list".replaceAll("\\{format\\}","json");

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

    
    apiClient.invokeAPI(path, "GET", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, null);
    
  }
  
  /**
   * Get collection schema
   * 
   * @param project 
   * @param names 
   * @return List<Collection>
   */
  public List<Collection> projectSchema(String project, List<String> names) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/project/schema".replaceAll("\\{format\\}","json");

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
   * Add fields to collections
   * 
   * @param projectAddFieldsToSchema 
   * @return List<SchemaField>
   */
  public List<SchemaField> projectAddFieldsToSchema(ProjectAddFieldsToSchema projectAddFieldsToSchema) throws ApiException {
    Object postBody = projectAddFieldsToSchema;
    
     // verify the required parameter 'projectAddFieldsToSchema' is set
     if (projectAddFieldsToSchema == null) {
        throw new ApiException(400, "Missing the required parameter 'projectAddFieldsToSchema' when calling projectAddFieldsToSchema");
     }
     
    // create path and map variables
    String path = "/project/schema/add".replaceAll("\\{format\\}","json");

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

    
    GenericType<List<SchemaField>> returnType = new GenericType<List<SchemaField>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Add fields to collections by transforming other schemas
   * 
   * @param project 
   * @param collection 
   * @param schemaType 
   * @param schema 
   * @return List<SchemaField>
   */
  public List<SchemaField> projectAddCustomFieldsToSchema(String project, String collection, String schemaType, String schema) throws ApiException {
    Object postBody = null;
    
    // create path and map variables
    String path = "/project/schema/add/custom".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    if (project != null)
      formParams.put("project", project);
    if (collection != null)
      formParams.put("collection", collection);
    if (schemaType != null)
      formParams.put("schema_type", schemaType);
    if (schema != null)
      formParams.put("schema", schema);
    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] { "master_key" };

    
    GenericType<List<SchemaField>> returnType = new GenericType<List<SchemaField>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
}
