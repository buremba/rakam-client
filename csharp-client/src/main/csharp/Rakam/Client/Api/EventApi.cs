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
        int? CollectEventBatchEvents (EventList eventList);
  
        /// <summary>
        /// Collect multiple events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="eventList"></param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> CollectEventBatchEventsWithHttpInfo (EventList eventList);

        /// <summary>
        /// Collect multiple events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="eventList"></param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> CollectEventBatchEventsAsync (EventList eventList);

        /// <summary>
        /// Collect multiple events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="eventList"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> CollectEventBatchEventsAsyncWithHttpInfo (EventList eventList);
        
        /// <summary>
        /// Send Bulk events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="eventList"></param>
        /// <returns>int?</returns>
        int? CollectEventBulkEvents (EventList eventList);
  
        /// <summary>
        /// Send Bulk events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="eventList"></param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> CollectEventBulkEventsWithHttpInfo (EventList eventList);

        /// <summary>
        /// Send Bulk events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="eventList"></param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> CollectEventBulkEventsAsync (EventList eventList);

        /// <summary>
        /// Send Bulk events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="eventList"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> CollectEventBulkEventsAsyncWithHttpInfo (EventList eventList);
        
        /// <summary>
        /// Commit Bulk events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="collection"></param>
        /// <returns>QueryResult</returns>
        QueryResult CollectEventCommitBulkEvents (string project = null, string collection = null);
  
        /// <summary>
        /// Commit Bulk events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="collection"></param>
        /// <returns>ApiResponse of QueryResult</returns>
        ApiResponse<QueryResult> CollectEventCommitBulkEventsWithHttpInfo (string project = null, string collection = null);

        /// <summary>
        /// Commit Bulk events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="collection"></param>
        /// <returns>Task of QueryResult</returns>
        System.Threading.Tasks.Task<QueryResult> CollectEventCommitBulkEventsAsync (string project = null, string collection = null);

        /// <summary>
        /// Commit Bulk events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="collection"></param>
        /// <returns>Task of ApiResponse (QueryResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResult>> CollectEventCommitBulkEventsAsyncWithHttpInfo (string project = null, string collection = null);
        
        /// <summary>
        /// Send Bulk events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="eventList"></param>
        /// <returns>int?</returns>
        int? CollectEventBulkEventsRemote (EventList eventList);
  
        /// <summary>
        /// Send Bulk events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="eventList"></param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> CollectEventBulkEventsRemoteWithHttpInfo (EventList eventList);

        /// <summary>
        /// Send Bulk events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="eventList"></param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> CollectEventBulkEventsRemoteAsync (EventList eventList);

        /// <summary>
        /// Send Bulk events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="eventList"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> CollectEventBulkEventsRemoteAsyncWithHttpInfo (EventList eventList);
        
        /// <summary>
        /// Collect event
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_event"></param>
        /// <returns>int?</returns>
        int? CollectEventCollectEvent (Event _event);
  
        /// <summary>
        /// Collect event
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_event"></param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> CollectEventCollectEventWithHttpInfo (Event _event);

        /// <summary>
        /// Collect event
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_event"></param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> CollectEventCollectEventAsync (Event _event);

        /// <summary>
        /// Collect event
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_event"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> CollectEventCollectEventAsyncWithHttpInfo (Event _event);
        
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
        QueryResult QueryExecute (string project = null, string query = null, int? limit = null);
  
        /// <summary>
        /// Analyze events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <returns>ApiResponse of QueryResult</returns>
        ApiResponse<QueryResult> QueryExecuteWithHttpInfo (string project = null, string query = null, int? limit = null);

        /// <summary>
        /// Analyze events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <returns>Task of QueryResult</returns>
        System.Threading.Tasks.Task<QueryResult> QueryExecuteAsync (string project = null, string query = null, int? limit = null);

        /// <summary>
        /// Analyze events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <returns>Task of ApiResponse (QueryResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResult>> QueryExecuteAsyncWithHttpInfo (string project = null, string query = null, int? limit = null);
        
        /// <summary>
        /// Explain query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="query"></param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 QueryExplain (string query = null);
  
        /// <summary>
        /// Explain query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="query"></param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> QueryExplainWithHttpInfo (string query = null);

        /// <summary>
        /// Explain query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="query"></param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> QueryExplainAsync (string query = null);

        /// <summary>
        /// Explain query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="query"></param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> QueryExplainAsyncWithHttpInfo (string query = null);
        
        /// <summary>
        /// Test query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <returns>List&lt;SchemaField&gt;</returns>
        List<SchemaField> QueryMetadata (string project = null, string query = null);
  
        /// <summary>
        /// Test query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <returns>ApiResponse of List&lt;SchemaField&gt;</returns>
        ApiResponse<List<SchemaField>> QueryMetadataWithHttpInfo (string project = null, string query = null);

        /// <summary>
        /// Test query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <returns>Task of List&lt;SchemaField&gt;</returns>
        System.Threading.Tasks.Task<List<SchemaField>> QueryMetadataAsync (string project = null, string query = null);

        /// <summary>
        /// Test query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <returns>Task of ApiResponse (List&lt;SchemaField&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SchemaField>>> QueryMetadataAsyncWithHttpInfo (string project = null, string query = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EventApi : IEventApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EventApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EventApi(Configuration configuration = null)
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
        /// Collect multiple events 
        /// </summary>
        /// <param name="eventList"></param> 
        /// <returns>int?</returns>
        public int? CollectEventBatchEvents (EventList eventList)
        {
             ApiResponse<int?> response = CollectEventBatchEventsWithHttpInfo(eventList);
             return response.Data;
        }

        /// <summary>
        /// Collect multiple events 
        /// </summary>
        /// <param name="eventList"></param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > CollectEventBatchEventsWithHttpInfo (EventList eventList)
        {
            
            // verify the required parameter 'eventList' is set
            if (eventList == null) throw new ApiException(400, "Missing required parameter 'eventList' when calling CollectEventBatchEvents");
            
    
            var path_ = "/event/batch";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(eventList); // http body (model) parameter
            

            
            // authentication (write_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("write_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["write_key"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CollectEventBatchEvents: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CollectEventBatchEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
    
        /// <summary>
        /// Collect multiple events 
        /// </summary>
        /// <param name="eventList"></param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> CollectEventBatchEventsAsync (EventList eventList)
        {
             ApiResponse<int?> response = await CollectEventBatchEventsAsyncWithHttpInfo(eventList);
             return response.Data;

        }

        /// <summary>
        /// Collect multiple events 
        /// </summary>
        /// <param name="eventList"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> CollectEventBatchEventsAsyncWithHttpInfo (EventList eventList)
        {
            // verify the required parameter 'eventList' is set
            if (eventList == null) throw new ApiException(400, "Missing required parameter 'eventList' when calling CollectEventBatchEvents");
            
    
            var path_ = "/event/batch";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(eventList); // http body (model) parameter
            

            
            // authentication (write_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("write_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["write_key"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CollectEventBatchEvents: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CollectEventBatchEvents: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
        
        /// <summary>
        /// Send Bulk events 
        /// </summary>
        /// <param name="eventList"></param> 
        /// <returns>int?</returns>
        public int? CollectEventBulkEvents (EventList eventList)
        {
             ApiResponse<int?> response = CollectEventBulkEventsWithHttpInfo(eventList);
             return response.Data;
        }

        /// <summary>
        /// Send Bulk events 
        /// </summary>
        /// <param name="eventList"></param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > CollectEventBulkEventsWithHttpInfo (EventList eventList)
        {
            
            // verify the required parameter 'eventList' is set
            if (eventList == null) throw new ApiException(400, "Missing required parameter 'eventList' when calling CollectEventBulkEvents");
            
    
            var path_ = "/event/bulk";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(eventList); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling CollectEventBulkEvents: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CollectEventBulkEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
    
        /// <summary>
        /// Send Bulk events 
        /// </summary>
        /// <param name="eventList"></param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> CollectEventBulkEventsAsync (EventList eventList)
        {
             ApiResponse<int?> response = await CollectEventBulkEventsAsyncWithHttpInfo(eventList);
             return response.Data;

        }

        /// <summary>
        /// Send Bulk events 
        /// </summary>
        /// <param name="eventList"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> CollectEventBulkEventsAsyncWithHttpInfo (EventList eventList)
        {
            // verify the required parameter 'eventList' is set
            if (eventList == null) throw new ApiException(400, "Missing required parameter 'eventList' when calling CollectEventBulkEvents");
            
    
            var path_ = "/event/bulk";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(eventList); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling CollectEventBulkEvents: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CollectEventBulkEvents: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
        
        /// <summary>
        /// Commit Bulk events 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="collection"></param> 
        /// <returns>QueryResult</returns>
        public QueryResult CollectEventCommitBulkEvents (string project = null, string collection = null)
        {
             ApiResponse<QueryResult> response = CollectEventCommitBulkEventsWithHttpInfo(project, collection);
             return response.Data;
        }

        /// <summary>
        /// Commit Bulk events 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="collection"></param> 
        /// <returns>ApiResponse of QueryResult</returns>
        public ApiResponse< QueryResult > CollectEventCommitBulkEventsWithHttpInfo (string project = null, string collection = null)
        {
            
    
            var path_ = "/event/bulk/commit";
    
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
            if (collection != null) formParams.Add("collection", Configuration.ApiClient.ParameterToString(collection)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling CollectEventCommitBulkEvents: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CollectEventCommitBulkEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueryResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResult) Configuration.ApiClient.Deserialize(response, typeof(QueryResult)));
            
        }
    
        /// <summary>
        /// Commit Bulk events 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="collection"></param>
        /// <returns>Task of QueryResult</returns>
        public async System.Threading.Tasks.Task<QueryResult> CollectEventCommitBulkEventsAsync (string project = null, string collection = null)
        {
             ApiResponse<QueryResult> response = await CollectEventCommitBulkEventsAsyncWithHttpInfo(project, collection);
             return response.Data;

        }

        /// <summary>
        /// Commit Bulk events 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="collection"></param>
        /// <returns>Task of ApiResponse (QueryResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResult>> CollectEventCommitBulkEventsAsyncWithHttpInfo (string project = null, string collection = null)
        {
            
    
            var path_ = "/event/bulk/commit";
    
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
            if (collection != null) formParams.Add("collection", Configuration.ApiClient.ParameterToString(collection)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling CollectEventCommitBulkEvents: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CollectEventCommitBulkEvents: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueryResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResult) Configuration.ApiClient.Deserialize(response, typeof(QueryResult)));
            
        }
        
        /// <summary>
        /// Send Bulk events 
        /// </summary>
        /// <param name="eventList"></param> 
        /// <returns>int?</returns>
        public int? CollectEventBulkEventsRemote (EventList eventList)
        {
             ApiResponse<int?> response = CollectEventBulkEventsRemoteWithHttpInfo(eventList);
             return response.Data;
        }

        /// <summary>
        /// Send Bulk events 
        /// </summary>
        /// <param name="eventList"></param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > CollectEventBulkEventsRemoteWithHttpInfo (EventList eventList)
        {
            
            // verify the required parameter 'eventList' is set
            if (eventList == null) throw new ApiException(400, "Missing required parameter 'eventList' when calling CollectEventBulkEventsRemote");
            
    
            var path_ = "/event/bulk/remote";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(eventList); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling CollectEventBulkEventsRemote: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CollectEventBulkEventsRemote: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
    
        /// <summary>
        /// Send Bulk events 
        /// </summary>
        /// <param name="eventList"></param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> CollectEventBulkEventsRemoteAsync (EventList eventList)
        {
             ApiResponse<int?> response = await CollectEventBulkEventsRemoteAsyncWithHttpInfo(eventList);
             return response.Data;

        }

        /// <summary>
        /// Send Bulk events 
        /// </summary>
        /// <param name="eventList"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> CollectEventBulkEventsRemoteAsyncWithHttpInfo (EventList eventList)
        {
            // verify the required parameter 'eventList' is set
            if (eventList == null) throw new ApiException(400, "Missing required parameter 'eventList' when calling CollectEventBulkEventsRemote");
            
    
            var path_ = "/event/bulk/remote";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(eventList); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling CollectEventBulkEventsRemote: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CollectEventBulkEventsRemote: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
        
        /// <summary>
        /// Collect event 
        /// </summary>
        /// <param name="_event"></param> 
        /// <returns>int?</returns>
        public int? CollectEventCollectEvent (Event _event)
        {
             ApiResponse<int?> response = CollectEventCollectEventWithHttpInfo(_event);
             return response.Data;
        }

        /// <summary>
        /// Collect event 
        /// </summary>
        /// <param name="_event"></param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > CollectEventCollectEventWithHttpInfo (Event _event)
        {
            
            // verify the required parameter '_event' is set
            if (_event == null) throw new ApiException(400, "Missing required parameter '_event' when calling CollectEventCollectEvent");
            
    
            var path_ = "/event/collect";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(_event); // http body (model) parameter
            

            
            // authentication (write_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("write_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["write_key"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CollectEventCollectEvent: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CollectEventCollectEvent: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
    
        /// <summary>
        /// Collect event 
        /// </summary>
        /// <param name="_event"></param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> CollectEventCollectEventAsync (Event _event)
        {
             ApiResponse<int?> response = await CollectEventCollectEventAsyncWithHttpInfo(_event);
             return response.Data;

        }

        /// <summary>
        /// Collect event 
        /// </summary>
        /// <param name="_event"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> CollectEventCollectEventAsyncWithHttpInfo (Event _event)
        {
            // verify the required parameter '_event' is set
            if (_event == null) throw new ApiException(400, "Missing required parameter '_event' when calling CollectEventCollectEvent");
            
    
            var path_ = "/event/collect";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(_event); // http body (model) parameter
            

            
            // authentication (write_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("write_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["write_key"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CollectEventCollectEvent: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CollectEventCollectEvent: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
        
        /// <summary>
        /// Analyze events 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="query"></param> 
        /// <param name="limit"></param> 
        /// <returns>QueryResult</returns>
        public QueryResult QueryExecute (string project = null, string query = null, int? limit = null)
        {
             ApiResponse<QueryResult> response = QueryExecuteWithHttpInfo(project, query, limit);
             return response.Data;
        }

        /// <summary>
        /// Analyze events 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="query"></param> 
        /// <param name="limit"></param> 
        /// <returns>ApiResponse of QueryResult</returns>
        public ApiResponse< QueryResult > QueryExecuteWithHttpInfo (string project = null, string query = null, int? limit = null)
        {
            
    
            var path_ = "/query/execute";
    
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
            if (limit != null) formParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling QueryExecute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QueryExecute: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueryResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResult) Configuration.ApiClient.Deserialize(response, typeof(QueryResult)));
            
        }
    
        /// <summary>
        /// Analyze events 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <returns>Task of QueryResult</returns>
        public async System.Threading.Tasks.Task<QueryResult> QueryExecuteAsync (string project = null, string query = null, int? limit = null)
        {
             ApiResponse<QueryResult> response = await QueryExecuteAsyncWithHttpInfo(project, query, limit);
             return response.Data;

        }

        /// <summary>
        /// Analyze events 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <returns>Task of ApiResponse (QueryResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResult>> QueryExecuteAsyncWithHttpInfo (string project = null, string query = null, int? limit = null)
        {
            
    
            var path_ = "/query/execute";
    
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
            if (limit != null) formParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling QueryExecute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QueryExecute: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueryResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResult) Configuration.ApiClient.Deserialize(response, typeof(QueryResult)));
            
        }
        
        /// <summary>
        /// Explain query 
        /// </summary>
        /// <param name="query"></param> 
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 QueryExplain (string query = null)
        {
             ApiResponse<InlineResponse200> response = QueryExplainWithHttpInfo(query);
             return response.Data;
        }

        /// <summary>
        /// Explain query 
        /// </summary>
        /// <param name="query"></param> 
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > QueryExplainWithHttpInfo (string query = null)
        {
            
    
            var path_ = "/query/explain";
    
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
                throw new ApiException (statusCode, "Error calling QueryExplain: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QueryExplain: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse200>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse200)));
            
        }
    
        /// <summary>
        /// Explain query 
        /// </summary>
        /// <param name="query"></param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> QueryExplainAsync (string query = null)
        {
             ApiResponse<InlineResponse200> response = await QueryExplainAsyncWithHttpInfo(query);
             return response.Data;

        }

        /// <summary>
        /// Explain query 
        /// </summary>
        /// <param name="query"></param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> QueryExplainAsyncWithHttpInfo (string query = null)
        {
            
    
            var path_ = "/query/explain";
    
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
                throw new ApiException (statusCode, "Error calling QueryExplain: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QueryExplain: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse200>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse200)));
            
        }
        
        /// <summary>
        /// Test query 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="query"></param> 
        /// <returns>List&lt;SchemaField&gt;</returns>
        public List<SchemaField> QueryMetadata (string project = null, string query = null)
        {
             ApiResponse<List<SchemaField>> response = QueryMetadataWithHttpInfo(project, query);
             return response.Data;
        }

        /// <summary>
        /// Test query 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="query"></param> 
        /// <returns>ApiResponse of List&lt;SchemaField&gt;</returns>
        public ApiResponse< List<SchemaField> > QueryMetadataWithHttpInfo (string project = null, string query = null)
        {
            
    
            var path_ = "/query/metadata";
    
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
                throw new ApiException (statusCode, "Error calling QueryMetadata: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QueryMetadata: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<SchemaField>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SchemaField>) Configuration.ApiClient.Deserialize(response, typeof(List<SchemaField>)));
            
        }
    
        /// <summary>
        /// Test query 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <returns>Task of List&lt;SchemaField&gt;</returns>
        public async System.Threading.Tasks.Task<List<SchemaField>> QueryMetadataAsync (string project = null, string query = null)
        {
             ApiResponse<List<SchemaField>> response = await QueryMetadataAsyncWithHttpInfo(project, query);
             return response.Data;

        }

        /// <summary>
        /// Test query 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <returns>Task of ApiResponse (List&lt;SchemaField&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SchemaField>>> QueryMetadataAsyncWithHttpInfo (string project = null, string query = null)
        {
            
    
            var path_ = "/query/metadata";
    
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
                throw new ApiException (statusCode, "Error calling QueryMetadata: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QueryMetadata: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<SchemaField>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SchemaField>) Configuration.ApiClient.Deserialize(response, typeof(List<SchemaField>)));
            
        }
        
    }
    
}
