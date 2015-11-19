using System;
using System.IO;
using System.Collections.Generic;
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
        QueryResult Execute (RetentionQuery retentionQuery);
  
        /// <summary>
        /// Execute query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="retentionQuery"></param>
        /// <returns>QueryResult</returns>
        System.Threading.Tasks.Task<QueryResult> ExecuteAsync (RetentionQuery retentionQuery);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RetentionApi : IRetentionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RetentionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RetentionApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Execute query 
        /// </summary>
        /// <param name="retentionQuery"></param> 
        /// <returns>QueryResult</returns>            
        public QueryResult Execute (RetentionQuery retentionQuery)
        {
            
            // verify the required parameter 'retentionQuery' is set
            if (retentionQuery == null) throw new ApiException(400, "Missing required parameter 'retentionQuery' when calling Execute");
            
    
            var path = "/retention/analyze";
    
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(retentionQuery); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Execute: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Execute: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QueryResult) ApiClient.Deserialize(response.Content, typeof(QueryResult), response.Headers);
        }
    
        /// <summary>
        /// Execute query 
        /// </summary>
        /// <param name="retentionQuery"></param>
        /// <returns>QueryResult</returns>
        public async System.Threading.Tasks.Task<QueryResult> ExecuteAsync (RetentionQuery retentionQuery)
        {
            // verify the required parameter 'retentionQuery' is set
            if (retentionQuery == null) throw new ApiException(400, "Missing required parameter 'retentionQuery' when calling Execute");
            
    
            var path = "/retention/analyze";
    
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(retentionQuery); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Execute: " + response.Content, response.Content);

            return (QueryResult) ApiClient.Deserialize(response.Content, typeof(QueryResult), response.Headers);
        }
        
    }
    
}
