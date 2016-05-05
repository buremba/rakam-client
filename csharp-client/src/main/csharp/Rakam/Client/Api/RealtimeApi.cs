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
    public interface IRealtimeApi
    {
        
        /// <summary>
        /// Create report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="realTimeReport"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse RealtimeCreate (RealTimeReport realTimeReport);
  
        /// <summary>
        /// Create report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="realTimeReport"></param>
        /// <returns>ApiResponse of JsonResponse</returns>
        ApiResponse<JsonResponse> RealtimeCreateWithHttpInfo (RealTimeReport realTimeReport);

        /// <summary>
        /// Create report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="realTimeReport"></param>
        /// <returns>Task of JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> RealtimeCreateAsync (RealTimeReport realTimeReport);

        /// <summary>
        /// Create report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="realTimeReport"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonResponse>> RealtimeCreateAsyncWithHttpInfo (RealTimeReport realTimeReport);
        
        /// <summary>
        /// Delete report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse RealtimeDelete (string project = null, string tableName = null);
  
        /// <summary>
        /// Delete report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>ApiResponse of JsonResponse</returns>
        ApiResponse<JsonResponse> RealtimeDeleteWithHttpInfo (string project = null, string tableName = null);

        /// <summary>
        /// Delete report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> RealtimeDeleteAsync (string project = null, string tableName = null);

        /// <summary>
        /// Delete report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonResponse>> RealtimeDeleteAsyncWithHttpInfo (string project = null, string tableName = null);
        
        /// <summary>
        /// Get report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="realtimeGet"></param>
        /// <returns>RealTimeQueryResult</returns>
        RealTimeQueryResult RealtimeGet (RealtimeGet realtimeGet);
  
        /// <summary>
        /// Get report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="realtimeGet"></param>
        /// <returns>ApiResponse of RealTimeQueryResult</returns>
        ApiResponse<RealTimeQueryResult> RealtimeGetWithHttpInfo (RealtimeGet realtimeGet);

        /// <summary>
        /// Get report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="realtimeGet"></param>
        /// <returns>Task of RealTimeQueryResult</returns>
        System.Threading.Tasks.Task<RealTimeQueryResult> RealtimeGetAsync (RealtimeGet realtimeGet);

        /// <summary>
        /// Get report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="realtimeGet"></param>
        /// <returns>Task of ApiResponse (RealTimeQueryResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<RealTimeQueryResult>> RealtimeGetAsyncWithHttpInfo (RealtimeGet realtimeGet);
        
        /// <summary>
        /// List queries
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>List&lt;ContinuousQuery&gt;</returns>
        List<ContinuousQuery> RealtimeList (string project = null);
  
        /// <summary>
        /// List queries
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>ApiResponse of List&lt;ContinuousQuery&gt;</returns>
        ApiResponse<List<ContinuousQuery>> RealtimeListWithHttpInfo (string project = null);

        /// <summary>
        /// List queries
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of List&lt;ContinuousQuery&gt;</returns>
        System.Threading.Tasks.Task<List<ContinuousQuery>> RealtimeListAsync (string project = null);

        /// <summary>
        /// List queries
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (List&lt;ContinuousQuery&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ContinuousQuery>>> RealtimeListAsyncWithHttpInfo (string project = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RealtimeApi : IRealtimeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RealtimeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RealtimeApi(Configuration configuration = null)
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
        /// Create report 
        /// </summary>
        /// <param name="realTimeReport"></param> 
        /// <returns>JsonResponse</returns>
        public JsonResponse RealtimeCreate (RealTimeReport realTimeReport)
        {
             ApiResponse<JsonResponse> response = RealtimeCreateWithHttpInfo(realTimeReport);
             return response.Data;
        }

        /// <summary>
        /// Create report 
        /// </summary>
        /// <param name="realTimeReport"></param> 
        /// <returns>ApiResponse of JsonResponse</returns>
        public ApiResponse< JsonResponse > RealtimeCreateWithHttpInfo (RealTimeReport realTimeReport)
        {
            
            // verify the required parameter 'realTimeReport' is set
            if (realTimeReport == null) throw new ApiException(400, "Missing required parameter 'realTimeReport' when calling RealtimeCreate");
            
    
            var path_ = "/realtime/create";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(realTimeReport); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling RealtimeCreate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RealtimeCreate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
    
        /// <summary>
        /// Create report 
        /// </summary>
        /// <param name="realTimeReport"></param>
        /// <returns>Task of JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> RealtimeCreateAsync (RealTimeReport realTimeReport)
        {
             ApiResponse<JsonResponse> response = await RealtimeCreateAsyncWithHttpInfo(realTimeReport);
             return response.Data;

        }

        /// <summary>
        /// Create report 
        /// </summary>
        /// <param name="realTimeReport"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonResponse>> RealtimeCreateAsyncWithHttpInfo (RealTimeReport realTimeReport)
        {
            // verify the required parameter 'realTimeReport' is set
            if (realTimeReport == null) throw new ApiException(400, "Missing required parameter 'realTimeReport' when calling RealtimeCreate");
            
    
            var path_ = "/realtime/create";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(realTimeReport); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling RealtimeCreate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RealtimeCreate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
        
        /// <summary>
        /// Delete report 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="tableName"></param> 
        /// <returns>JsonResponse</returns>
        public JsonResponse RealtimeDelete (string project = null, string tableName = null)
        {
             ApiResponse<JsonResponse> response = RealtimeDeleteWithHttpInfo(project, tableName);
             return response.Data;
        }

        /// <summary>
        /// Delete report 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="tableName"></param> 
        /// <returns>ApiResponse of JsonResponse</returns>
        public ApiResponse< JsonResponse > RealtimeDeleteWithHttpInfo (string project = null, string tableName = null)
        {
            
    
            var path_ = "/realtime/delete";
    
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
                throw new ApiException (statusCode, "Error calling RealtimeDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RealtimeDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
    
        /// <summary>
        /// Delete report 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> RealtimeDeleteAsync (string project = null, string tableName = null)
        {
             ApiResponse<JsonResponse> response = await RealtimeDeleteAsyncWithHttpInfo(project, tableName);
             return response.Data;

        }

        /// <summary>
        /// Delete report 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonResponse>> RealtimeDeleteAsyncWithHttpInfo (string project = null, string tableName = null)
        {
            
    
            var path_ = "/realtime/delete";
    
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
                throw new ApiException (statusCode, "Error calling RealtimeDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RealtimeDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
        
        /// <summary>
        /// Get report 
        /// </summary>
        /// <param name="realtimeGet"></param> 
        /// <returns>RealTimeQueryResult</returns>
        public RealTimeQueryResult RealtimeGet (RealtimeGet realtimeGet)
        {
             ApiResponse<RealTimeQueryResult> response = RealtimeGetWithHttpInfo(realtimeGet);
             return response.Data;
        }

        /// <summary>
        /// Get report 
        /// </summary>
        /// <param name="realtimeGet"></param> 
        /// <returns>ApiResponse of RealTimeQueryResult</returns>
        public ApiResponse< RealTimeQueryResult > RealtimeGetWithHttpInfo (RealtimeGet realtimeGet)
        {
            
            // verify the required parameter 'realtimeGet' is set
            if (realtimeGet == null) throw new ApiException(400, "Missing required parameter 'realtimeGet' when calling RealtimeGet");
            
    
            var path_ = "/realtime/get";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(realtimeGet); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling RealtimeGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RealtimeGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<RealTimeQueryResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RealTimeQueryResult) Configuration.ApiClient.Deserialize(response, typeof(RealTimeQueryResult)));
            
        }
    
        /// <summary>
        /// Get report 
        /// </summary>
        /// <param name="realtimeGet"></param>
        /// <returns>Task of RealTimeQueryResult</returns>
        public async System.Threading.Tasks.Task<RealTimeQueryResult> RealtimeGetAsync (RealtimeGet realtimeGet)
        {
             ApiResponse<RealTimeQueryResult> response = await RealtimeGetAsyncWithHttpInfo(realtimeGet);
             return response.Data;

        }

        /// <summary>
        /// Get report 
        /// </summary>
        /// <param name="realtimeGet"></param>
        /// <returns>Task of ApiResponse (RealTimeQueryResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RealTimeQueryResult>> RealtimeGetAsyncWithHttpInfo (RealtimeGet realtimeGet)
        {
            // verify the required parameter 'realtimeGet' is set
            if (realtimeGet == null) throw new ApiException(400, "Missing required parameter 'realtimeGet' when calling RealtimeGet");
            
    
            var path_ = "/realtime/get";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(realtimeGet); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling RealtimeGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RealtimeGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RealTimeQueryResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RealTimeQueryResult) Configuration.ApiClient.Deserialize(response, typeof(RealTimeQueryResult)));
            
        }
        
        /// <summary>
        /// List queries 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>List&lt;ContinuousQuery&gt;</returns>
        public List<ContinuousQuery> RealtimeList (string project = null)
        {
             ApiResponse<List<ContinuousQuery>> response = RealtimeListWithHttpInfo(project);
             return response.Data;
        }

        /// <summary>
        /// List queries 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>ApiResponse of List&lt;ContinuousQuery&gt;</returns>
        public ApiResponse< List<ContinuousQuery> > RealtimeListWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/realtime/list";
    
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
                throw new ApiException (statusCode, "Error calling RealtimeList: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RealtimeList: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<ContinuousQuery>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ContinuousQuery>) Configuration.ApiClient.Deserialize(response, typeof(List<ContinuousQuery>)));
            
        }
    
        /// <summary>
        /// List queries 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of List&lt;ContinuousQuery&gt;</returns>
        public async System.Threading.Tasks.Task<List<ContinuousQuery>> RealtimeListAsync (string project = null)
        {
             ApiResponse<List<ContinuousQuery>> response = await RealtimeListAsyncWithHttpInfo(project);
             return response.Data;

        }

        /// <summary>
        /// List queries 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (List&lt;ContinuousQuery&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ContinuousQuery>>> RealtimeListAsyncWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/realtime/list";
    
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
                throw new ApiException (statusCode, "Error calling RealtimeList: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RealtimeList: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<ContinuousQuery>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ContinuousQuery>) Configuration.ApiClient.Deserialize(response, typeof(List<ContinuousQuery>)));
            
        }
        
    }
    
}
