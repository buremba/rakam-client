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
    public interface IEventexplorerApi
    {
        
        /// <summary>
        /// Perform simple query on event data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="execute"></param>
        /// <returns>QueryResult</returns>
        QueryResult Execute (Execute execute);
  
        /// <summary>
        /// Perform simple query on event data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="execute"></param>
        /// <returns>QueryResult</returns>
        System.Threading.Tasks.Task<QueryResult> ExecuteAsync (Execute execute);
        
        /// <summary>
        /// Event statistics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns></returns>
        List<string> GetEventDimensions (string project);
  
        /// <summary>
        /// Event statistics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns></returns>
        System.Threading.Tasks.Task<List<string>> GetEventDimensionsAsync (string project);
        
        /// <summary>
        /// Event statistics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns></returns>
        List<string> GetExtraDimensions (string project);
  
        /// <summary>
        /// Event statistics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns></returns>
        System.Threading.Tasks.Task<List<string>> GetExtraDimensionsAsync (string project);
        
        /// <summary>
        /// Event statistics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="collections"></param>
        /// <param name="dimension"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns>QueryResult</returns>
        QueryResult GetEventStatistics (string project, List<string> collections, string dimension, DateTime? startDate, DateTime? endDate);
  
        /// <summary>
        /// Event statistics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="collections"></param>
        /// <param name="dimension"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns>QueryResult</returns>
        System.Threading.Tasks.Task<QueryResult> GetEventStatisticsAsync (string project, List<string> collections, string dimension, DateTime? startDate, DateTime? endDate);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EventexplorerApi : IEventexplorerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventexplorerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EventexplorerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EventexplorerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventexplorerApi(String basePath)
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
        /// Perform simple query on event data 
        /// </summary>
        /// <param name="execute"></param> 
        /// <returns>QueryResult</returns>            
        public QueryResult Execute (Execute execute)
        {
            
            // verify the required parameter 'execute' is set
            if (execute == null) throw new ApiException(400, "Missing required parameter 'execute' when calling Execute");
            
    
            var path = "/event-explorer/analyze";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(execute); // http body (model) parameter
            
    
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
        /// Perform simple query on event data 
        /// </summary>
        /// <param name="execute"></param>
        /// <returns>QueryResult</returns>
        public async System.Threading.Tasks.Task<QueryResult> ExecuteAsync (Execute execute)
        {
            // verify the required parameter 'execute' is set
            if (execute == null) throw new ApiException(400, "Missing required parameter 'execute' when calling Execute");
            
    
            var path = "/event-explorer/analyze";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(execute); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Execute: " + response.Content, response.Content);

            return (QueryResult) ApiClient.Deserialize(response.Content, typeof(QueryResult), response.Headers);
        }
        
        /// <summary>
        /// Event statistics 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns></returns>            
        public List<string> GetEventDimensions (string project)
        {
            
    
            var path = "/event-explorer/event_dimensions";
    
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
            
            
            
            if (project != null) formParams.Add("project", ApiClient.ParameterToString(project)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventDimensions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventDimensions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Event statistics 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<List<string>> GetEventDimensionsAsync (string project)
        {
            
    
            var path = "/event-explorer/event_dimensions";
    
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
            
            
            
            if (project != null) formParams.Add("project", ApiClient.ParameterToString(project)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventDimensions: " + response.Content, response.Content);

            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
        
        /// <summary>
        /// Event statistics 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns></returns>            
        public List<string> GetExtraDimensions (string project)
        {
            
    
            var path = "/event-explorer/extra_dimensions";
    
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
            
            
            
            if (project != null) formParams.Add("project", ApiClient.ParameterToString(project)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExtraDimensions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExtraDimensions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Event statistics 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<List<string>> GetExtraDimensionsAsync (string project)
        {
            
    
            var path = "/event-explorer/extra_dimensions";
    
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
            
            
            
            if (project != null) formParams.Add("project", ApiClient.ParameterToString(project)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExtraDimensions: " + response.Content, response.Content);

            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
        
        /// <summary>
        /// Event statistics 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="collections"></param> 
        /// <param name="dimension"></param> 
        /// <param name="startDate"></param> 
        /// <param name="endDate"></param> 
        /// <returns>QueryResult</returns>            
        public QueryResult GetEventStatistics (string project, List<string> collections, string dimension, DateTime? startDate, DateTime? endDate)
        {
            
    
            var path = "/event-explorer/statistics";
    
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
            
            
            
            if (project != null) formParams.Add("project", ApiClient.ParameterToString(project)); // form parameter
            if (collections != null) formParams.Add("collections", ApiClient.ParameterToString(collections)); // form parameter
            if (dimension != null) formParams.Add("dimension", ApiClient.ParameterToString(dimension)); // form parameter
            if (startDate != null) formParams.Add("startDate", ApiClient.ParameterToString(startDate)); // form parameter
            if (endDate != null) formParams.Add("endDate", ApiClient.ParameterToString(endDate)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventStatistics: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventStatistics: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QueryResult) ApiClient.Deserialize(response.Content, typeof(QueryResult), response.Headers);
        }
    
        /// <summary>
        /// Event statistics 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="collections"></param>
        /// <param name="dimension"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns>QueryResult</returns>
        public async System.Threading.Tasks.Task<QueryResult> GetEventStatisticsAsync (string project, List<string> collections, string dimension, DateTime? startDate, DateTime? endDate)
        {
            
    
            var path = "/event-explorer/statistics";
    
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
            
            
            
            if (project != null) formParams.Add("project", ApiClient.ParameterToString(project)); // form parameter
            if (collections != null) formParams.Add("collections", ApiClient.ParameterToString(collections)); // form parameter
            if (dimension != null) formParams.Add("dimension", ApiClient.ParameterToString(dimension)); // form parameter
            if (startDate != null) formParams.Add("startDate", ApiClient.ParameterToString(startDate)); // form parameter
            if (endDate != null) formParams.Add("endDate", ApiClient.ParameterToString(endDate)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventStatistics: " + response.Content, response.Content);

            return (QueryResult) ApiClient.Deserialize(response.Content, typeof(QueryResult), response.Headers);
        }
        
    }
    
}
