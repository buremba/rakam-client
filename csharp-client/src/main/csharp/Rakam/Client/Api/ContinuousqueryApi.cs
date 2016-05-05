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
    public interface IContinuousqueryApi
    {
        
        /// <summary>
        /// Create stream
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="continuousQuery"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse ContinuousQueryCreate (ContinuousQuery continuousQuery);
  
        /// <summary>
        /// Create stream
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="continuousQuery"></param>
        /// <returns>ApiResponse of JsonResponse</returns>
        ApiResponse<JsonResponse> ContinuousQueryCreateWithHttpInfo (ContinuousQuery continuousQuery);

        /// <summary>
        /// Create stream
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="continuousQuery"></param>
        /// <returns>Task of JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> ContinuousQueryCreateAsync (ContinuousQuery continuousQuery);

        /// <summary>
        /// Create stream
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="continuousQuery"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonResponse>> ContinuousQueryCreateAsyncWithHttpInfo (ContinuousQuery continuousQuery);
        
        /// <summary>
        /// Delete stream
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse ContinuousQueryDelete (string project = null, string tableName = null);
  
        /// <summary>
        /// Delete stream
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>ApiResponse of JsonResponse</returns>
        ApiResponse<JsonResponse> ContinuousQueryDeleteWithHttpInfo (string project = null, string tableName = null);

        /// <summary>
        /// Delete stream
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> ContinuousQueryDeleteAsync (string project = null, string tableName = null);

        /// <summary>
        /// Delete stream
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonResponse>> ContinuousQueryDeleteAsyncWithHttpInfo (string project = null, string tableName = null);
        
        /// <summary>
        /// Get continuous query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>ContinuousQuery</returns>
        ContinuousQuery ContinuousQueryGet (string project = null, string tableName = null);
  
        /// <summary>
        /// Get continuous query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>ApiResponse of ContinuousQuery</returns>
        ApiResponse<ContinuousQuery> ContinuousQueryGetWithHttpInfo (string project = null, string tableName = null);

        /// <summary>
        /// Get continuous query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of ContinuousQuery</returns>
        System.Threading.Tasks.Task<ContinuousQuery> ContinuousQueryGetAsync (string project = null, string tableName = null);

        /// <summary>
        /// Get continuous query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of ApiResponse (ContinuousQuery)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContinuousQuery>> ContinuousQueryGetAsyncWithHttpInfo (string project = null, string tableName = null);
        
        /// <summary>
        /// List queries
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>List&lt;ContinuousQuery&gt;</returns>
        List<ContinuousQuery> ContinuousQueryListQueries (string project = null);
  
        /// <summary>
        /// List queries
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>ApiResponse of List&lt;ContinuousQuery&gt;</returns>
        ApiResponse<List<ContinuousQuery>> ContinuousQueryListQueriesWithHttpInfo (string project = null);

        /// <summary>
        /// List queries
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of List&lt;ContinuousQuery&gt;</returns>
        System.Threading.Tasks.Task<List<ContinuousQuery>> ContinuousQueryListQueriesAsync (string project = null);

        /// <summary>
        /// List queries
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (List&lt;ContinuousQuery&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ContinuousQuery>>> ContinuousQueryListQueriesAsyncWithHttpInfo (string project = null);
        
        /// <summary>
        /// Get query schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>List&lt;Collection&gt;</returns>
        List<Collection> ContinuousQuerySchema (string project = null, List<string> names = null);
  
        /// <summary>
        /// Get query schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>ApiResponse of List&lt;Collection&gt;</returns>
        ApiResponse<List<Collection>> ContinuousQuerySchemaWithHttpInfo (string project = null, List<string> names = null);

        /// <summary>
        /// Get query schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>Task of List&lt;Collection&gt;</returns>
        System.Threading.Tasks.Task<List<Collection>> ContinuousQuerySchemaAsync (string project = null, List<string> names = null);

        /// <summary>
        /// Get query schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>Task of ApiResponse (List&lt;Collection&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Collection>>> ContinuousQuerySchemaAsyncWithHttpInfo (string project = null, List<string> names = null);
        
        /// <summary>
        /// Test continuous query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <returns>bool?</returns>
        bool? ContinuousQueryTest (string project = null, string query = null);
  
        /// <summary>
        /// Test continuous query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <returns>ApiResponse of bool?</returns>
        ApiResponse<bool?> ContinuousQueryTestWithHttpInfo (string project = null, string query = null);

        /// <summary>
        /// Test continuous query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <returns>Task of bool?</returns>
        System.Threading.Tasks.Task<bool?> ContinuousQueryTestAsync (string project = null, string query = null);

        /// <summary>
        /// Test continuous query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <returns>Task of ApiResponse (bool?)</returns>
        System.Threading.Tasks.Task<ApiResponse<bool?>> ContinuousQueryTestAsyncWithHttpInfo (string project = null, string query = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContinuousqueryApi : IContinuousqueryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousqueryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContinuousqueryApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousqueryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ContinuousqueryApi(Configuration configuration = null)
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
        /// Create stream 
        /// </summary>
        /// <param name="continuousQuery"></param> 
        /// <returns>JsonResponse</returns>
        public JsonResponse ContinuousQueryCreate (ContinuousQuery continuousQuery)
        {
             ApiResponse<JsonResponse> response = ContinuousQueryCreateWithHttpInfo(continuousQuery);
             return response.Data;
        }

        /// <summary>
        /// Create stream 
        /// </summary>
        /// <param name="continuousQuery"></param> 
        /// <returns>ApiResponse of JsonResponse</returns>
        public ApiResponse< JsonResponse > ContinuousQueryCreateWithHttpInfo (ContinuousQuery continuousQuery)
        {
            
            // verify the required parameter 'continuousQuery' is set
            if (continuousQuery == null) throw new ApiException(400, "Missing required parameter 'continuousQuery' when calling ContinuousQueryCreate");
            
    
            var path_ = "/continuous-query/create";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(continuousQuery); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling ContinuousQueryCreate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContinuousQueryCreate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
    
        /// <summary>
        /// Create stream 
        /// </summary>
        /// <param name="continuousQuery"></param>
        /// <returns>Task of JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> ContinuousQueryCreateAsync (ContinuousQuery continuousQuery)
        {
             ApiResponse<JsonResponse> response = await ContinuousQueryCreateAsyncWithHttpInfo(continuousQuery);
             return response.Data;

        }

        /// <summary>
        /// Create stream 
        /// </summary>
        /// <param name="continuousQuery"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonResponse>> ContinuousQueryCreateAsyncWithHttpInfo (ContinuousQuery continuousQuery)
        {
            // verify the required parameter 'continuousQuery' is set
            if (continuousQuery == null) throw new ApiException(400, "Missing required parameter 'continuousQuery' when calling ContinuousQueryCreate");
            
    
            var path_ = "/continuous-query/create";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(continuousQuery); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling ContinuousQueryCreate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContinuousQueryCreate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
        
        /// <summary>
        /// Delete stream 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="tableName"></param> 
        /// <returns>JsonResponse</returns>
        public JsonResponse ContinuousQueryDelete (string project = null, string tableName = null)
        {
             ApiResponse<JsonResponse> response = ContinuousQueryDeleteWithHttpInfo(project, tableName);
             return response.Data;
        }

        /// <summary>
        /// Delete stream 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="tableName"></param> 
        /// <returns>ApiResponse of JsonResponse</returns>
        public ApiResponse< JsonResponse > ContinuousQueryDeleteWithHttpInfo (string project = null, string tableName = null)
        {
            
    
            var path_ = "/continuous-query/delete";
    
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
                throw new ApiException (statusCode, "Error calling ContinuousQueryDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContinuousQueryDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
    
        /// <summary>
        /// Delete stream 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> ContinuousQueryDeleteAsync (string project = null, string tableName = null)
        {
             ApiResponse<JsonResponse> response = await ContinuousQueryDeleteAsyncWithHttpInfo(project, tableName);
             return response.Data;

        }

        /// <summary>
        /// Delete stream 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonResponse>> ContinuousQueryDeleteAsyncWithHttpInfo (string project = null, string tableName = null)
        {
            
    
            var path_ = "/continuous-query/delete";
    
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
                throw new ApiException (statusCode, "Error calling ContinuousQueryDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContinuousQueryDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
        
        /// <summary>
        /// Get continuous query 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="tableName"></param> 
        /// <returns>ContinuousQuery</returns>
        public ContinuousQuery ContinuousQueryGet (string project = null, string tableName = null)
        {
             ApiResponse<ContinuousQuery> response = ContinuousQueryGetWithHttpInfo(project, tableName);
             return response.Data;
        }

        /// <summary>
        /// Get continuous query 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="tableName"></param> 
        /// <returns>ApiResponse of ContinuousQuery</returns>
        public ApiResponse< ContinuousQuery > ContinuousQueryGetWithHttpInfo (string project = null, string tableName = null)
        {
            
    
            var path_ = "/continuous-query/get";
    
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
                throw new ApiException (statusCode, "Error calling ContinuousQueryGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContinuousQueryGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ContinuousQuery>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContinuousQuery) Configuration.ApiClient.Deserialize(response, typeof(ContinuousQuery)));
            
        }
    
        /// <summary>
        /// Get continuous query 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of ContinuousQuery</returns>
        public async System.Threading.Tasks.Task<ContinuousQuery> ContinuousQueryGetAsync (string project = null, string tableName = null)
        {
             ApiResponse<ContinuousQuery> response = await ContinuousQueryGetAsyncWithHttpInfo(project, tableName);
             return response.Data;

        }

        /// <summary>
        /// Get continuous query 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of ApiResponse (ContinuousQuery)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContinuousQuery>> ContinuousQueryGetAsyncWithHttpInfo (string project = null, string tableName = null)
        {
            
    
            var path_ = "/continuous-query/get";
    
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
                throw new ApiException (statusCode, "Error calling ContinuousQueryGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContinuousQueryGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContinuousQuery>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContinuousQuery) Configuration.ApiClient.Deserialize(response, typeof(ContinuousQuery)));
            
        }
        
        /// <summary>
        /// List queries 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>List&lt;ContinuousQuery&gt;</returns>
        public List<ContinuousQuery> ContinuousQueryListQueries (string project = null)
        {
             ApiResponse<List<ContinuousQuery>> response = ContinuousQueryListQueriesWithHttpInfo(project);
             return response.Data;
        }

        /// <summary>
        /// List queries 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>ApiResponse of List&lt;ContinuousQuery&gt;</returns>
        public ApiResponse< List<ContinuousQuery> > ContinuousQueryListQueriesWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/continuous-query/list";
    
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
                throw new ApiException (statusCode, "Error calling ContinuousQueryListQueries: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContinuousQueryListQueries: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<ContinuousQuery>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ContinuousQuery>) Configuration.ApiClient.Deserialize(response, typeof(List<ContinuousQuery>)));
            
        }
    
        /// <summary>
        /// List queries 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of List&lt;ContinuousQuery&gt;</returns>
        public async System.Threading.Tasks.Task<List<ContinuousQuery>> ContinuousQueryListQueriesAsync (string project = null)
        {
             ApiResponse<List<ContinuousQuery>> response = await ContinuousQueryListQueriesAsyncWithHttpInfo(project);
             return response.Data;

        }

        /// <summary>
        /// List queries 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (List&lt;ContinuousQuery&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ContinuousQuery>>> ContinuousQueryListQueriesAsyncWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/continuous-query/list";
    
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
                throw new ApiException (statusCode, "Error calling ContinuousQueryListQueries: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContinuousQueryListQueries: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<ContinuousQuery>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ContinuousQuery>) Configuration.ApiClient.Deserialize(response, typeof(List<ContinuousQuery>)));
            
        }
        
        /// <summary>
        /// Get query schema 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="names"></param> 
        /// <returns>List&lt;Collection&gt;</returns>
        public List<Collection> ContinuousQuerySchema (string project = null, List<string> names = null)
        {
             ApiResponse<List<Collection>> response = ContinuousQuerySchemaWithHttpInfo(project, names);
             return response.Data;
        }

        /// <summary>
        /// Get query schema 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="names"></param> 
        /// <returns>ApiResponse of List&lt;Collection&gt;</returns>
        public ApiResponse< List<Collection> > ContinuousQuerySchemaWithHttpInfo (string project = null, List<string> names = null)
        {
            
    
            var path_ = "/continuous-query/schema";
    
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
                throw new ApiException (statusCode, "Error calling ContinuousQuerySchema: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContinuousQuerySchema: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<Collection>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Collection>) Configuration.ApiClient.Deserialize(response, typeof(List<Collection>)));
            
        }
    
        /// <summary>
        /// Get query schema 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>Task of List&lt;Collection&gt;</returns>
        public async System.Threading.Tasks.Task<List<Collection>> ContinuousQuerySchemaAsync (string project = null, List<string> names = null)
        {
             ApiResponse<List<Collection>> response = await ContinuousQuerySchemaAsyncWithHttpInfo(project, names);
             return response.Data;

        }

        /// <summary>
        /// Get query schema 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>Task of ApiResponse (List&lt;Collection&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Collection>>> ContinuousQuerySchemaAsyncWithHttpInfo (string project = null, List<string> names = null)
        {
            
    
            var path_ = "/continuous-query/schema";
    
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
                throw new ApiException (statusCode, "Error calling ContinuousQuerySchema: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContinuousQuerySchema: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<Collection>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Collection>) Configuration.ApiClient.Deserialize(response, typeof(List<Collection>)));
            
        }
        
        /// <summary>
        /// Test continuous query 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="query"></param> 
        /// <returns>bool?</returns>
        public bool? ContinuousQueryTest (string project = null, string query = null)
        {
             ApiResponse<bool?> response = ContinuousQueryTestWithHttpInfo(project, query);
             return response.Data;
        }

        /// <summary>
        /// Test continuous query 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="query"></param> 
        /// <returns>ApiResponse of bool?</returns>
        public ApiResponse< bool? > ContinuousQueryTestWithHttpInfo (string project = null, string query = null)
        {
            
    
            var path_ = "/continuous-query/test";
    
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
            if (query != null) formParams.Add("query", Configuration.ApiClient.ParameterToString(query)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling ContinuousQueryTest: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContinuousQueryTest: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<bool?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (bool?) Configuration.ApiClient.Deserialize(response, typeof(bool?)));
            
        }
    
        /// <summary>
        /// Test continuous query 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <returns>Task of bool?</returns>
        public async System.Threading.Tasks.Task<bool?> ContinuousQueryTestAsync (string project = null, string query = null)
        {
             ApiResponse<bool?> response = await ContinuousQueryTestAsyncWithHttpInfo(project, query);
             return response.Data;

        }

        /// <summary>
        /// Test continuous query 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <returns>Task of ApiResponse (bool?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<bool?>> ContinuousQueryTestAsyncWithHttpInfo (string project = null, string query = null)
        {
            
    
            var path_ = "/continuous-query/test";
    
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
            if (query != null) formParams.Add("query", Configuration.ApiClient.ParameterToString(query)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling ContinuousQueryTest: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContinuousQueryTest: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<bool?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (bool?) Configuration.ApiClient.Deserialize(response, typeof(bool?)));
            
        }
        
    }
    
}
