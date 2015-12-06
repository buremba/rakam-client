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
    public interface IEventApi
    {
        
        /// <summary>
        /// Collect multiple events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="eventList"></param>
        /// <returns>int?</returns>
        int? BatchEvents (EventList eventList);
  
        /// <summary>
        /// Collect multiple events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="eventList"></param>
        /// <returns>int?</returns>
        System.Threading.Tasks.Task<int?> BatchEventsAsync (EventList eventList);
        
        /// <summary>
        /// Collect event
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_event"></param>
        /// <returns>int?</returns>
        int? CollectEvent (Event _event);
  
        /// <summary>
        /// Collect event
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_event"></param>
        /// <returns>int?</returns>
        System.Threading.Tasks.Task<int?> CollectEventAsync (Event _event);
        
        /// <summary>
        /// Analyze events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <returns>QueryResult</returns>
        QueryResult Execute (string project, string query, int? limit);
  
        /// <summary>
        /// Analyze events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <returns>QueryResult</returns>
        System.Threading.Tasks.Task<QueryResult> ExecuteAsync (string project, string query, int? limit);
        
        /// <summary>
        /// Explain query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="query"></param>
        /// <returns>Object</returns>
        Object Explain (string query);
  
        /// <summary>
        /// Explain query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="query"></param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ExplainAsync (string query);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EventApi : IEventApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EventApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EventApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventApi(String basePath)
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
        /// Collect multiple events 
        /// </summary>
        /// <param name="eventList"></param> 
        /// <returns>int?</returns>            
        public int? BatchEvents (EventList eventList)
        {
            
            // verify the required parameter 'eventList' is set
            if (eventList == null) throw new ApiException(400, "Missing required parameter 'eventList' when calling BatchEvents");
            
    
            var path = "/event/batch";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(eventList); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "write_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BatchEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BatchEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
        /// <summary>
        /// Collect multiple events 
        /// </summary>
        /// <param name="eventList"></param>
        /// <returns>int?</returns>
        public async System.Threading.Tasks.Task<int?> BatchEventsAsync (EventList eventList)
        {
            // verify the required parameter 'eventList' is set
            if (eventList == null) throw new ApiException(400, "Missing required parameter 'eventList' when calling BatchEvents");
            
    
            var path = "/event/batch";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(eventList); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "write_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BatchEvents: " + response.Content, response.Content);

            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
        
        /// <summary>
        /// Collect event 
        /// </summary>
        /// <param name="_event"></param> 
        /// <returns>int?</returns>            
        public int? CollectEvent (Event _event)
        {
            
            // verify the required parameter '_event' is set
            if (_event == null) throw new ApiException(400, "Missing required parameter '_event' when calling CollectEvent");
            
    
            var path = "/event/collect";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(_event); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "write_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CollectEvent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CollectEvent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
        /// <summary>
        /// Collect event 
        /// </summary>
        /// <param name="_event"></param>
        /// <returns>int?</returns>
        public async System.Threading.Tasks.Task<int?> CollectEventAsync (Event _event)
        {
            // verify the required parameter '_event' is set
            if (_event == null) throw new ApiException(400, "Missing required parameter '_event' when calling CollectEvent");
            
    
            var path = "/event/collect";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(_event); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "write_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CollectEvent: " + response.Content, response.Content);

            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
        
        /// <summary>
        /// Analyze events 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="query"></param> 
        /// <param name="limit"></param> 
        /// <returns>QueryResult</returns>            
        public QueryResult Execute (string project, string query, int? limit)
        {
            
    
            var path = "/query/execute";
    
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
            if (query != null) formParams.Add("query", ApiClient.ParameterToString(query)); // form parameter
            if (limit != null) formParams.Add("limit", ApiClient.ParameterToString(limit)); // form parameter
            
            
    
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
        /// Analyze events 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <returns>QueryResult</returns>
        public async System.Threading.Tasks.Task<QueryResult> ExecuteAsync (string project, string query, int? limit)
        {
            
    
            var path = "/query/execute";
    
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
            if (query != null) formParams.Add("query", ApiClient.ParameterToString(query)); // form parameter
            if (limit != null) formParams.Add("limit", ApiClient.ParameterToString(limit)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Execute: " + response.Content, response.Content);

            return (QueryResult) ApiClient.Deserialize(response.Content, typeof(QueryResult), response.Headers);
        }
        
        /// <summary>
        /// Explain query 
        /// </summary>
        /// <param name="query"></param> 
        /// <returns>Object</returns>            
        public Object Explain (string query)
        {
            
    
            var path = "/query/explain";
    
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
            
            
            
            if (query != null) formParams.Add("query", ApiClient.ParameterToString(query)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Explain: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Explain: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Explain query 
        /// </summary>
        /// <param name="query"></param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ExplainAsync (string query)
        {
            
    
            var path = "/query/explain";
    
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
            
            
            
            if (query != null) formParams.Add("query", ApiClient.ParameterToString(query)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Explain: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
    }
    
}
