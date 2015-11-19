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
    public interface IFunnelApi
    {
        
        /// <summary>
        /// Execute query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="funnelQuery"></param>
        /// <returns></returns>
        void Analyze (FunnelQuery funnelQuery);
  
        /// <summary>
        /// Execute query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="funnelQuery"></param>
        /// <returns></returns>
        System.Threading.Tasks.Task AnalyzeAsync (FunnelQuery funnelQuery);
        
        /// <summary>
        /// Execute query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="funnelQuery"></param>
        /// <returns>QueryResult</returns>
        QueryResult Analyze_1 (FunnelQuery funnelQuery);
  
        /// <summary>
        /// Execute query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="funnelQuery"></param>
        /// <returns>QueryResult</returns>
        System.Threading.Tasks.Task<QueryResult> Analyze_1Async (FunnelQuery funnelQuery);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FunnelApi : IFunnelApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FunnelApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public FunnelApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FunnelApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FunnelApi(String basePath)
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
        /// <param name="funnelQuery"></param> 
        /// <returns></returns>            
        public void Analyze (FunnelQuery funnelQuery)
        {
            
            // verify the required parameter 'funnelQuery' is set
            if (funnelQuery == null) throw new ApiException(400, "Missing required parameter 'funnelQuery' when calling Analyze");
            
    
            var path = "/funnel/analyze";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "text/event-stream"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(funnelQuery); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Analyze: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Analyze: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Execute query 
        /// </summary>
        /// <param name="funnelQuery"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task AnalyzeAsync (FunnelQuery funnelQuery)
        {
            // verify the required parameter 'funnelQuery' is set
            if (funnelQuery == null) throw new ApiException(400, "Missing required parameter 'funnelQuery' when calling Analyze");
            
    
            var path = "/funnel/analyze";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "text/event-stream"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(funnelQuery); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Analyze: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Execute query 
        /// </summary>
        /// <param name="funnelQuery"></param> 
        /// <returns>QueryResult</returns>            
        public QueryResult Analyze_1 (FunnelQuery funnelQuery)
        {
            
            // verify the required parameter 'funnelQuery' is set
            if (funnelQuery == null) throw new ApiException(400, "Missing required parameter 'funnelQuery' when calling Analyze_1");
            
    
            var path = "/funnel/analyze";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(funnelQuery); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Analyze_1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Analyze_1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QueryResult) ApiClient.Deserialize(response.Content, typeof(QueryResult), response.Headers);
        }
    
        /// <summary>
        /// Execute query 
        /// </summary>
        /// <param name="funnelQuery"></param>
        /// <returns>QueryResult</returns>
        public async System.Threading.Tasks.Task<QueryResult> Analyze_1Async (FunnelQuery funnelQuery)
        {
            // verify the required parameter 'funnelQuery' is set
            if (funnelQuery == null) throw new ApiException(400, "Missing required parameter 'funnelQuery' when calling Analyze_1");
            
    
            var path = "/funnel/analyze";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(funnelQuery); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Analyze_1: " + response.Content, response.Content);

            return (QueryResult) ApiClient.Deserialize(response.Content, typeof(QueryResult), response.Headers);
        }
        
    }
    
}
