using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Rakam.Client.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMaterializedviewApi
    {
        
        /// <summary>
        /// Create view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="materializedView"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse MaterializedViewCreate (MaterializedView materializedView);
  
        /// <summary>
        /// Create view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="materializedView"></param>
        /// <returns>ApiResponse of JsonResponse</returns>
        ApiResponse<JsonResponse> MaterializedViewCreateWithHttpInfo (MaterializedView materializedView);

        /// <summary>
        /// Create view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="materializedView"></param>
        /// <returns>Task of JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> MaterializedViewCreateAsync (MaterializedView materializedView);

        /// <summary>
        /// Create view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="materializedView"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonResponse>> MaterializedViewCreateAsyncWithHttpInfo (MaterializedView materializedView);
        
        /// <summary>
        /// Delete materialized view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse MaterializedViewDelete (string project = null, string tableName = null);
  
        /// <summary>
        /// Delete materialized view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>ApiResponse of JsonResponse</returns>
        ApiResponse<JsonResponse> MaterializedViewDeleteWithHttpInfo (string project = null, string tableName = null);

        /// <summary>
        /// Delete materialized view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> MaterializedViewDeleteAsync (string project = null, string tableName = null);

        /// <summary>
        /// Delete materialized view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonResponse>> MaterializedViewDeleteAsyncWithHttpInfo (string project = null, string tableName = null);
        
        /// <summary>
        /// Get view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>MaterializedView</returns>
        MaterializedView MaterializedViewGet (string project = null, string tableName = null);
  
        /// <summary>
        /// Get view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>ApiResponse of MaterializedView</returns>
        ApiResponse<MaterializedView> MaterializedViewGetWithHttpInfo (string project = null, string tableName = null);

        /// <summary>
        /// Get view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of MaterializedView</returns>
        System.Threading.Tasks.Task<MaterializedView> MaterializedViewGetAsync (string project = null, string tableName = null);

        /// <summary>
        /// Get view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of ApiResponse (MaterializedView)</returns>
        System.Threading.Tasks.Task<ApiResponse<MaterializedView>> MaterializedViewGetAsyncWithHttpInfo (string project = null, string tableName = null);
        
        /// <summary>
        /// List views
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>List&lt;MaterializedView&gt;</returns>
        List<MaterializedView> MaterializedViewListViews (string project = null);
  
        /// <summary>
        /// List views
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>ApiResponse of List&lt;MaterializedView&gt;</returns>
        ApiResponse<List<MaterializedView>> MaterializedViewListViewsWithHttpInfo (string project = null);

        /// <summary>
        /// List views
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of List&lt;MaterializedView&gt;</returns>
        System.Threading.Tasks.Task<List<MaterializedView>> MaterializedViewListViewsAsync (string project = null);

        /// <summary>
        /// List views
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (List&lt;MaterializedView&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<MaterializedView>>> MaterializedViewListViewsAsyncWithHttpInfo (string project = null);
        
        /// <summary>
        /// Get schemas
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>List&lt;MaterializedViewSchema&gt;</returns>
        List<MaterializedViewSchema> MaterializedViewSchema (string project = null, List<string> names = null);
  
        /// <summary>
        /// Get schemas
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>ApiResponse of List&lt;MaterializedViewSchema&gt;</returns>
        ApiResponse<List<MaterializedViewSchema>> MaterializedViewSchemaWithHttpInfo (string project = null, List<string> names = null);

        /// <summary>
        /// Get schemas
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>Task of List&lt;MaterializedViewSchema&gt;</returns>
        System.Threading.Tasks.Task<List<MaterializedViewSchema>> MaterializedViewSchemaAsync (string project = null, List<string> names = null);

        /// <summary>
        /// Get schemas
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>Task of ApiResponse (List&lt;MaterializedViewSchema&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<MaterializedViewSchema>>> MaterializedViewSchemaAsyncWithHttpInfo (string project = null, List<string> names = null);
        
        /// <summary>
        /// Update view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        void MaterializedViewUpdate ();
  
        /// <summary>
        /// Update view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> MaterializedViewUpdateWithHttpInfo ();

        /// <summary>
        /// Update view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task MaterializedViewUpdateAsync ();

        /// <summary>
        /// Update view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> MaterializedViewUpdateAsyncWithHttpInfo ();
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MaterializedviewApi : IMaterializedviewApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterializedviewApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MaterializedviewApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterializedviewApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MaterializedviewApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Create view 
        /// </summary>
        /// <param name="materializedView"></param> 
        /// <returns>JsonResponse</returns>
        public JsonResponse MaterializedViewCreate (MaterializedView materializedView)
        {
             ApiResponse<JsonResponse> response = MaterializedViewCreateWithHttpInfo(materializedView);
             return response.Data;
        }

        /// <summary>
        /// Create view 
        /// </summary>
        /// <param name="materializedView"></param> 
        /// <returns>ApiResponse of JsonResponse</returns>
        public ApiResponse< JsonResponse > MaterializedViewCreateWithHttpInfo (MaterializedView materializedView)
        {
            
            // verify the required parameter 'materializedView' is set
            if (materializedView == null) throw new ApiException(400, "Missing required parameter 'materializedView' when calling MaterializedViewCreate");
            
    
            var path_ = "/materialized-view/create";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(materializedView); // http body (model) parameter
            

            
            // authentication (master_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("master_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["master_key"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MaterializedViewCreate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MaterializedViewCreate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
    
        /// <summary>
        /// Create view 
        /// </summary>
        /// <param name="materializedView"></param>
        /// <returns>Task of JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> MaterializedViewCreateAsync (MaterializedView materializedView)
        {
             ApiResponse<JsonResponse> response = await MaterializedViewCreateAsyncWithHttpInfo(materializedView);
             return response.Data;

        }

        /// <summary>
        /// Create view 
        /// </summary>
        /// <param name="materializedView"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonResponse>> MaterializedViewCreateAsyncWithHttpInfo (MaterializedView materializedView)
        {
            // verify the required parameter 'materializedView' is set
            if (materializedView == null) throw new ApiException(400, "Missing required parameter 'materializedView' when calling MaterializedViewCreate");
            
    
            var path_ = "/materialized-view/create";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(materializedView); // http body (model) parameter
            

            
            // authentication (master_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("master_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["master_key"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MaterializedViewCreate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MaterializedViewCreate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
        
        /// <summary>
        /// Delete materialized view 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="tableName"></param> 
        /// <returns>JsonResponse</returns>
        public JsonResponse MaterializedViewDelete (string project = null, string tableName = null)
        {
             ApiResponse<JsonResponse> response = MaterializedViewDeleteWithHttpInfo(project, tableName);
             return response.Data;
        }

        /// <summary>
        /// Delete materialized view 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="tableName"></param> 
        /// <returns>ApiResponse of JsonResponse</returns>
        public ApiResponse< JsonResponse > MaterializedViewDeleteWithHttpInfo (string project = null, string tableName = null)
        {
            
    
            var path_ = "/materialized-view/delete";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            if (project != null) formParams.Add("project", Configuration.ApiClient.ParameterToString(project)); // form parameter
            if (tableName != null) formParams.Add("table_name", Configuration.ApiClient.ParameterToString(tableName)); // form parameter
            
            

            
            // authentication (master_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("master_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["master_key"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MaterializedViewDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MaterializedViewDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
    
        /// <summary>
        /// Delete materialized view 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> MaterializedViewDeleteAsync (string project = null, string tableName = null)
        {
             ApiResponse<JsonResponse> response = await MaterializedViewDeleteAsyncWithHttpInfo(project, tableName);
             return response.Data;

        }

        /// <summary>
        /// Delete materialized view 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonResponse>> MaterializedViewDeleteAsyncWithHttpInfo (string project = null, string tableName = null)
        {
            
    
            var path_ = "/materialized-view/delete";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            if (project != null) formParams.Add("project", Configuration.ApiClient.ParameterToString(project)); // form parameter
            if (tableName != null) formParams.Add("table_name", Configuration.ApiClient.ParameterToString(tableName)); // form parameter
            
            

            
            // authentication (master_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("master_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["master_key"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MaterializedViewDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MaterializedViewDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
        
        /// <summary>
        /// Get view 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="tableName"></param> 
        /// <returns>MaterializedView</returns>
        public MaterializedView MaterializedViewGet (string project = null, string tableName = null)
        {
             ApiResponse<MaterializedView> response = MaterializedViewGetWithHttpInfo(project, tableName);
             return response.Data;
        }

        /// <summary>
        /// Get view 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="tableName"></param> 
        /// <returns>ApiResponse of MaterializedView</returns>
        public ApiResponse< MaterializedView > MaterializedViewGetWithHttpInfo (string project = null, string tableName = null)
        {
            
    
            var path_ = "/materialized-view/get";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            if (project != null) formParams.Add("project", Configuration.ApiClient.ParameterToString(project)); // form parameter
            if (tableName != null) formParams.Add("table_name", Configuration.ApiClient.ParameterToString(tableName)); // form parameter
            
            

            
            // authentication (read_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("read_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["read_key"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MaterializedViewGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MaterializedViewGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<MaterializedView>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaterializedView) Configuration.ApiClient.Deserialize(response, typeof(MaterializedView)));
            
        }
    
        /// <summary>
        /// Get view 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of MaterializedView</returns>
        public async System.Threading.Tasks.Task<MaterializedView> MaterializedViewGetAsync (string project = null, string tableName = null)
        {
             ApiResponse<MaterializedView> response = await MaterializedViewGetAsyncWithHttpInfo(project, tableName);
             return response.Data;

        }

        /// <summary>
        /// Get view 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of ApiResponse (MaterializedView)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MaterializedView>> MaterializedViewGetAsyncWithHttpInfo (string project = null, string tableName = null)
        {
            
    
            var path_ = "/materialized-view/get";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            if (project != null) formParams.Add("project", Configuration.ApiClient.ParameterToString(project)); // form parameter
            if (tableName != null) formParams.Add("table_name", Configuration.ApiClient.ParameterToString(tableName)); // form parameter
            
            

            
            // authentication (read_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("read_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["read_key"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MaterializedViewGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MaterializedViewGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<MaterializedView>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaterializedView) Configuration.ApiClient.Deserialize(response, typeof(MaterializedView)));
            
        }
        
        /// <summary>
        /// List views 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>List&lt;MaterializedView&gt;</returns>
        public List<MaterializedView> MaterializedViewListViews (string project = null)
        {
             ApiResponse<List<MaterializedView>> response = MaterializedViewListViewsWithHttpInfo(project);
             return response.Data;
        }

        /// <summary>
        /// List views 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>ApiResponse of List&lt;MaterializedView&gt;</returns>
        public ApiResponse< List<MaterializedView> > MaterializedViewListViewsWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/materialized-view/list";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            if (project != null) formParams.Add("project", Configuration.ApiClient.ParameterToString(project)); // form parameter
            
            

            
            // authentication (read_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("read_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["read_key"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MaterializedViewListViews: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MaterializedViewListViews: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<MaterializedView>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<MaterializedView>) Configuration.ApiClient.Deserialize(response, typeof(List<MaterializedView>)));
            
        }
    
        /// <summary>
        /// List views 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of List&lt;MaterializedView&gt;</returns>
        public async System.Threading.Tasks.Task<List<MaterializedView>> MaterializedViewListViewsAsync (string project = null)
        {
             ApiResponse<List<MaterializedView>> response = await MaterializedViewListViewsAsyncWithHttpInfo(project);
             return response.Data;

        }

        /// <summary>
        /// List views 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (List&lt;MaterializedView&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<MaterializedView>>> MaterializedViewListViewsAsyncWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/materialized-view/list";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            if (project != null) formParams.Add("project", Configuration.ApiClient.ParameterToString(project)); // form parameter
            
            

            
            // authentication (read_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("read_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["read_key"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MaterializedViewListViews: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MaterializedViewListViews: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<MaterializedView>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<MaterializedView>) Configuration.ApiClient.Deserialize(response, typeof(List<MaterializedView>)));
            
        }
        
        /// <summary>
        /// Get schemas 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="names"></param> 
        /// <returns>List&lt;MaterializedViewSchema&gt;</returns>
        public List<MaterializedViewSchema> MaterializedViewSchema (string project = null, List<string> names = null)
        {
             ApiResponse<List<MaterializedViewSchema>> response = MaterializedViewSchemaWithHttpInfo(project, names);
             return response.Data;
        }

        /// <summary>
        /// Get schemas 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="names"></param> 
        /// <returns>ApiResponse of List&lt;MaterializedViewSchema&gt;</returns>
        public ApiResponse< List<MaterializedViewSchema> > MaterializedViewSchemaWithHttpInfo (string project = null, List<string> names = null)
        {
            
    
            var path_ = "/materialized-view/schema";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            if (project != null) formParams.Add("project", Configuration.ApiClient.ParameterToString(project)); // form parameter
            if (names != null) formParams.Add("names", Configuration.ApiClient.ParameterToString(names)); // form parameter
            
            

            
            // authentication (read_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("read_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["read_key"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MaterializedViewSchema: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MaterializedViewSchema: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<MaterializedViewSchema>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<MaterializedViewSchema>) Configuration.ApiClient.Deserialize(response, typeof(List<MaterializedViewSchema>)));
            
        }
    
        /// <summary>
        /// Get schemas 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>Task of List&lt;MaterializedViewSchema&gt;</returns>
        public async System.Threading.Tasks.Task<List<MaterializedViewSchema>> MaterializedViewSchemaAsync (string project = null, List<string> names = null)
        {
             ApiResponse<List<MaterializedViewSchema>> response = await MaterializedViewSchemaAsyncWithHttpInfo(project, names);
             return response.Data;

        }

        /// <summary>
        /// Get schemas 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>Task of ApiResponse (List&lt;MaterializedViewSchema&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<MaterializedViewSchema>>> MaterializedViewSchemaAsyncWithHttpInfo (string project = null, List<string> names = null)
        {
            
    
            var path_ = "/materialized-view/schema";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            if (project != null) formParams.Add("project", Configuration.ApiClient.ParameterToString(project)); // form parameter
            if (names != null) formParams.Add("names", Configuration.ApiClient.ParameterToString(names)); // form parameter
            
            

            
            // authentication (read_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("read_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["read_key"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MaterializedViewSchema: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MaterializedViewSchema: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<MaterializedViewSchema>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<MaterializedViewSchema>) Configuration.ApiClient.Deserialize(response, typeof(List<MaterializedViewSchema>)));
            
        }
        
        /// <summary>
        /// Update view 
        /// </summary>
        /// <returns></returns>
        public void MaterializedViewUpdate ()
        {
             MaterializedViewUpdateWithHttpInfo();
        }

        /// <summary>
        /// Update view 
        /// </summary>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> MaterializedViewUpdateWithHttpInfo ()
        {
            
    
            var path_ = "/materialized-view/update";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (master_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("master_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["master_key"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MaterializedViewUpdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MaterializedViewUpdate: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Update view 
        /// </summary>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task MaterializedViewUpdateAsync ()
        {
             await MaterializedViewUpdateAsyncWithHttpInfo();

        }

        /// <summary>
        /// Update view 
        /// </summary>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> MaterializedViewUpdateAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/materialized-view/update";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (master_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("master_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["master_key"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MaterializedViewUpdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MaterializedViewUpdate: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
