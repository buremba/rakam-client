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
    public interface IRetentionApi
    {
        
        /// <summary>
        /// Execute query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="retentionQuery"></param>
        /// <returns>QueryResult</returns>
        QueryResult RetentionAnalyzerExecute (RetentionQuery retentionQuery);
  
        /// <summary>
        /// Execute query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="retentionQuery"></param>
        /// <returns>ApiResponse of QueryResult</returns>
        ApiResponse<QueryResult> RetentionAnalyzerExecuteWithHttpInfo (RetentionQuery retentionQuery);

        /// <summary>
        /// Execute query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="retentionQuery"></param>
        /// <returns>Task of QueryResult</returns>
        System.Threading.Tasks.Task<QueryResult> RetentionAnalyzerExecuteAsync (RetentionQuery retentionQuery);

        /// <summary>
        /// Execute query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="retentionQuery"></param>
        /// <returns>Task of ApiResponse (QueryResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResult>> RetentionAnalyzerExecuteAsyncWithHttpInfo (RetentionQuery retentionQuery);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RetentionApi : IRetentionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RetentionApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RetentionApi(Configuration configuration = null)
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
        /// Execute query 
        /// </summary>
        /// <param name="retentionQuery"></param> 
        /// <returns>QueryResult</returns>
        public QueryResult RetentionAnalyzerExecute (RetentionQuery retentionQuery)
        {
             ApiResponse<QueryResult> response = RetentionAnalyzerExecuteWithHttpInfo(retentionQuery);
             return response.Data;
        }

        /// <summary>
        /// Execute query 
        /// </summary>
        /// <param name="retentionQuery"></param> 
        /// <returns>ApiResponse of QueryResult</returns>
        public ApiResponse< QueryResult > RetentionAnalyzerExecuteWithHttpInfo (RetentionQuery retentionQuery)
        {
            
            // verify the required parameter 'retentionQuery' is set
            if (retentionQuery == null) throw new ApiException(400, "Missing required parameter 'retentionQuery' when calling RetentionAnalyzerExecute");
            
    
            var path_ = "/retention/analyze";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(retentionQuery); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling RetentionAnalyzerExecute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RetentionAnalyzerExecute: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueryResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResult) Configuration.ApiClient.Deserialize(response, typeof(QueryResult)));
            
        }
    
        /// <summary>
        /// Execute query 
        /// </summary>
        /// <param name="retentionQuery"></param>
        /// <returns>Task of QueryResult</returns>
        public async System.Threading.Tasks.Task<QueryResult> RetentionAnalyzerExecuteAsync (RetentionQuery retentionQuery)
        {
             ApiResponse<QueryResult> response = await RetentionAnalyzerExecuteAsyncWithHttpInfo(retentionQuery);
             return response.Data;

        }

        /// <summary>
        /// Execute query 
        /// </summary>
        /// <param name="retentionQuery"></param>
        /// <returns>Task of ApiResponse (QueryResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResult>> RetentionAnalyzerExecuteAsyncWithHttpInfo (RetentionQuery retentionQuery)
        {
            // verify the required parameter 'retentionQuery' is set
            if (retentionQuery == null) throw new ApiException(400, "Missing required parameter 'retentionQuery' when calling RetentionAnalyzerExecute");
            
    
            var path_ = "/retention/analyze";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(retentionQuery); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling RetentionAnalyzerExecute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RetentionAnalyzerExecute: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueryResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResult) Configuration.ApiClient.Deserialize(response, typeof(QueryResult)));
            
        }
        
    }
    
}
