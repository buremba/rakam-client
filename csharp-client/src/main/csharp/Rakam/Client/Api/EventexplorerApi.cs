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
    public interface IEventexplorerApi
    {
        
        /// <summary>
        /// Perform simple query on event data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="analyzeRequest"></param>
        /// <returns>QueryResult</returns>
        QueryResult EventExplorerAnalyze (AnalyzeRequest analyzeRequest);
  
        /// <summary>
        /// Perform simple query on event data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="analyzeRequest"></param>
        /// <returns>ApiResponse of QueryResult</returns>
        ApiResponse<QueryResult> EventExplorerAnalyzeWithHttpInfo (AnalyzeRequest analyzeRequest);

        /// <summary>
        /// Perform simple query on event data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="analyzeRequest"></param>
        /// <returns>Task of QueryResult</returns>
        System.Threading.Tasks.Task<QueryResult> EventExplorerAnalyzeAsync (AnalyzeRequest analyzeRequest);

        /// <summary>
        /// Perform simple query on event data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="analyzeRequest"></param>
        /// <returns>Task of ApiResponse (QueryResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResult>> EventExplorerAnalyzeAsyncWithHttpInfo (AnalyzeRequest analyzeRequest);
        
        /// <summary>
        /// Event statistics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        Dictionary<string, List<string>> EventExplorerGetExtraDimensions (string project = null);
  
        /// <summary>
        /// Event statistics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        ApiResponse<Dictionary<string, List<string>>> EventExplorerGetExtraDimensionsWithHttpInfo (string project = null);

        /// <summary>
        /// Event statistics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, List<string>>> EventExplorerGetExtraDimensionsAsync (string project = null);

        /// <summary>
        /// Event statistics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;string&gt;&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, List<string>>>> EventExplorerGetExtraDimensionsAsyncWithHttpInfo (string project = null);
        
        /// <summary>
        /// Create Pre-computed table
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="collections"></param>
        /// <param name="dimensions"></param>
        /// <param name="aggregations"></param>
        /// <param name="measures"></param>
        /// <param name="tableName"></param>
        /// <returns>PreCalculatedTable</returns>
        PreCalculatedTable EventExplorerCreatePreComputedTable (string project = null, List<string> collections = null, List<string> dimensions = null, List<string> aggregations = null, List<string> measures = null, string tableName = null);
  
        /// <summary>
        /// Create Pre-computed table
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="collections"></param>
        /// <param name="dimensions"></param>
        /// <param name="aggregations"></param>
        /// <param name="measures"></param>
        /// <param name="tableName"></param>
        /// <returns>ApiResponse of PreCalculatedTable</returns>
        ApiResponse<PreCalculatedTable> EventExplorerCreatePreComputedTableWithHttpInfo (string project = null, List<string> collections = null, List<string> dimensions = null, List<string> aggregations = null, List<string> measures = null, string tableName = null);

        /// <summary>
        /// Create Pre-computed table
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="collections"></param>
        /// <param name="dimensions"></param>
        /// <param name="aggregations"></param>
        /// <param name="measures"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of PreCalculatedTable</returns>
        System.Threading.Tasks.Task<PreCalculatedTable> EventExplorerCreatePreComputedTableAsync (string project = null, List<string> collections = null, List<string> dimensions = null, List<string> aggregations = null, List<string> measures = null, string tableName = null);

        /// <summary>
        /// Create Pre-computed table
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="collections"></param>
        /// <param name="dimensions"></param>
        /// <param name="aggregations"></param>
        /// <param name="measures"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of ApiResponse (PreCalculatedTable)</returns>
        System.Threading.Tasks.Task<ApiResponse<PreCalculatedTable>> EventExplorerCreatePreComputedTableAsyncWithHttpInfo (string project = null, List<string> collections = null, List<string> dimensions = null, List<string> aggregations = null, List<string> measures = null, string tableName = null);
        
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
        QueryResult EventExplorerGetEventStatistics (string project = null, List<string> collections = null, string dimension = null, DateTime? startDate = null, DateTime? endDate = null);
  
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
        /// <returns>ApiResponse of QueryResult</returns>
        ApiResponse<QueryResult> EventExplorerGetEventStatisticsWithHttpInfo (string project = null, List<string> collections = null, string dimension = null, DateTime? startDate = null, DateTime? endDate = null);

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
        /// <returns>Task of QueryResult</returns>
        System.Threading.Tasks.Task<QueryResult> EventExplorerGetEventStatisticsAsync (string project = null, List<string> collections = null, string dimension = null, DateTime? startDate = null, DateTime? endDate = null);

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
        /// <returns>Task of ApiResponse (QueryResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResult>> EventExplorerGetEventStatisticsAsyncWithHttpInfo (string project = null, List<string> collections = null, string dimension = null, DateTime? startDate = null, DateTime? endDate = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EventexplorerApi : IEventexplorerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventexplorerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventexplorerApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EventexplorerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EventexplorerApi(Configuration configuration = null)
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
        /// Perform simple query on event data 
        /// </summary>
        /// <param name="analyzeRequest"></param> 
        /// <returns>QueryResult</returns>
        public QueryResult EventExplorerAnalyze (AnalyzeRequest analyzeRequest)
        {
             ApiResponse<QueryResult> response = EventExplorerAnalyzeWithHttpInfo(analyzeRequest);
             return response.Data;
        }

        /// <summary>
        /// Perform simple query on event data 
        /// </summary>
        /// <param name="analyzeRequest"></param> 
        /// <returns>ApiResponse of QueryResult</returns>
        public ApiResponse< QueryResult > EventExplorerAnalyzeWithHttpInfo (AnalyzeRequest analyzeRequest)
        {
            
            // verify the required parameter 'analyzeRequest' is set
            if (analyzeRequest == null) throw new ApiException(400, "Missing required parameter 'analyzeRequest' when calling EventExplorerAnalyze");
            
    
            var path_ = "/event-explorer/analyze";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(analyzeRequest); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling EventExplorerAnalyze: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EventExplorerAnalyze: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueryResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResult) Configuration.ApiClient.Deserialize(response, typeof(QueryResult)));
            
        }
    
        /// <summary>
        /// Perform simple query on event data 
        /// </summary>
        /// <param name="analyzeRequest"></param>
        /// <returns>Task of QueryResult</returns>
        public async System.Threading.Tasks.Task<QueryResult> EventExplorerAnalyzeAsync (AnalyzeRequest analyzeRequest)
        {
             ApiResponse<QueryResult> response = await EventExplorerAnalyzeAsyncWithHttpInfo(analyzeRequest);
             return response.Data;

        }

        /// <summary>
        /// Perform simple query on event data 
        /// </summary>
        /// <param name="analyzeRequest"></param>
        /// <returns>Task of ApiResponse (QueryResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResult>> EventExplorerAnalyzeAsyncWithHttpInfo (AnalyzeRequest analyzeRequest)
        {
            // verify the required parameter 'analyzeRequest' is set
            if (analyzeRequest == null) throw new ApiException(400, "Missing required parameter 'analyzeRequest' when calling EventExplorerAnalyze");
            
    
            var path_ = "/event-explorer/analyze";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(analyzeRequest); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling EventExplorerAnalyze: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EventExplorerAnalyze: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueryResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResult) Configuration.ApiClient.Deserialize(response, typeof(QueryResult)));
            
        }
        
        /// <summary>
        /// Event statistics 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        public Dictionary<string, List<string>> EventExplorerGetExtraDimensions (string project = null)
        {
             ApiResponse<Dictionary<string, List<string>>> response = EventExplorerGetExtraDimensionsWithHttpInfo(project);
             return response.Data;
        }

        /// <summary>
        /// Event statistics 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        public ApiResponse< Dictionary<string, List<string>> > EventExplorerGetExtraDimensionsWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/event-explorer/extra_dimensions";
    
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
                throw new ApiException (statusCode, "Error calling EventExplorerGetExtraDimensions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EventExplorerGetExtraDimensions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Dictionary<string, List<string>>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dictionary<string, List<string>>) Configuration.ApiClient.Deserialize(response, typeof(Dictionary<string, List<string>>)));
            
        }
    
        /// <summary>
        /// Event statistics 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, List<string>>> EventExplorerGetExtraDimensionsAsync (string project = null)
        {
             ApiResponse<Dictionary<string, List<string>>> response = await EventExplorerGetExtraDimensionsAsyncWithHttpInfo(project);
             return response.Data;

        }

        /// <summary>
        /// Event statistics 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;string&gt;&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, List<string>>>> EventExplorerGetExtraDimensionsAsyncWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/event-explorer/extra_dimensions";
    
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
                throw new ApiException (statusCode, "Error calling EventExplorerGetExtraDimensions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EventExplorerGetExtraDimensions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Dictionary<string, List<string>>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dictionary<string, List<string>>) Configuration.ApiClient.Deserialize(response, typeof(Dictionary<string, List<string>>)));
            
        }
        
        /// <summary>
        /// Create Pre-computed table 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="collections"></param> 
        /// <param name="dimensions"></param> 
        /// <param name="aggregations"></param> 
        /// <param name="measures"></param> 
        /// <param name="tableName"></param> 
        /// <returns>PreCalculatedTable</returns>
        public PreCalculatedTable EventExplorerCreatePreComputedTable (string project = null, List<string> collections = null, List<string> dimensions = null, List<string> aggregations = null, List<string> measures = null, string tableName = null)
        {
             ApiResponse<PreCalculatedTable> response = EventExplorerCreatePreComputedTableWithHttpInfo(project, collections, dimensions, aggregations, measures, tableName);
             return response.Data;
        }

        /// <summary>
        /// Create Pre-computed table 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="collections"></param> 
        /// <param name="dimensions"></param> 
        /// <param name="aggregations"></param> 
        /// <param name="measures"></param> 
        /// <param name="tableName"></param> 
        /// <returns>ApiResponse of PreCalculatedTable</returns>
        public ApiResponse< PreCalculatedTable > EventExplorerCreatePreComputedTableWithHttpInfo (string project = null, List<string> collections = null, List<string> dimensions = null, List<string> aggregations = null, List<string> measures = null, string tableName = null)
        {
            
    
            var path_ = "/event-explorer/pre_calculate";
    
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
            if (collections != null) formParams.Add("collections", Configuration.ApiClient.ParameterToString(collections)); // form parameter
            if (dimensions != null) formParams.Add("dimensions", Configuration.ApiClient.ParameterToString(dimensions)); // form parameter
            if (aggregations != null) formParams.Add("aggregations", Configuration.ApiClient.ParameterToString(aggregations)); // form parameter
            if (measures != null) formParams.Add("measures", Configuration.ApiClient.ParameterToString(measures)); // form parameter
            if (tableName != null) formParams.Add("tableName", Configuration.ApiClient.ParameterToString(tableName)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling EventExplorerCreatePreComputedTable: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EventExplorerCreatePreComputedTable: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PreCalculatedTable>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PreCalculatedTable) Configuration.ApiClient.Deserialize(response, typeof(PreCalculatedTable)));
            
        }
    
        /// <summary>
        /// Create Pre-computed table 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="collections"></param>
        /// <param name="dimensions"></param>
        /// <param name="aggregations"></param>
        /// <param name="measures"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of PreCalculatedTable</returns>
        public async System.Threading.Tasks.Task<PreCalculatedTable> EventExplorerCreatePreComputedTableAsync (string project = null, List<string> collections = null, List<string> dimensions = null, List<string> aggregations = null, List<string> measures = null, string tableName = null)
        {
             ApiResponse<PreCalculatedTable> response = await EventExplorerCreatePreComputedTableAsyncWithHttpInfo(project, collections, dimensions, aggregations, measures, tableName);
             return response.Data;

        }

        /// <summary>
        /// Create Pre-computed table 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="collections"></param>
        /// <param name="dimensions"></param>
        /// <param name="aggregations"></param>
        /// <param name="measures"></param>
        /// <param name="tableName"></param>
        /// <returns>Task of ApiResponse (PreCalculatedTable)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PreCalculatedTable>> EventExplorerCreatePreComputedTableAsyncWithHttpInfo (string project = null, List<string> collections = null, List<string> dimensions = null, List<string> aggregations = null, List<string> measures = null, string tableName = null)
        {
            
    
            var path_ = "/event-explorer/pre_calculate";
    
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
            if (collections != null) formParams.Add("collections", Configuration.ApiClient.ParameterToString(collections)); // form parameter
            if (dimensions != null) formParams.Add("dimensions", Configuration.ApiClient.ParameterToString(dimensions)); // form parameter
            if (aggregations != null) formParams.Add("aggregations", Configuration.ApiClient.ParameterToString(aggregations)); // form parameter
            if (measures != null) formParams.Add("measures", Configuration.ApiClient.ParameterToString(measures)); // form parameter
            if (tableName != null) formParams.Add("tableName", Configuration.ApiClient.ParameterToString(tableName)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling EventExplorerCreatePreComputedTable: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EventExplorerCreatePreComputedTable: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PreCalculatedTable>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PreCalculatedTable) Configuration.ApiClient.Deserialize(response, typeof(PreCalculatedTable)));
            
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
        public QueryResult EventExplorerGetEventStatistics (string project = null, List<string> collections = null, string dimension = null, DateTime? startDate = null, DateTime? endDate = null)
        {
             ApiResponse<QueryResult> response = EventExplorerGetEventStatisticsWithHttpInfo(project, collections, dimension, startDate, endDate);
             return response.Data;
        }

        /// <summary>
        /// Event statistics 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="collections"></param> 
        /// <param name="dimension"></param> 
        /// <param name="startDate"></param> 
        /// <param name="endDate"></param> 
        /// <returns>ApiResponse of QueryResult</returns>
        public ApiResponse< QueryResult > EventExplorerGetEventStatisticsWithHttpInfo (string project = null, List<string> collections = null, string dimension = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            
    
            var path_ = "/event-explorer/statistics";
    
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
            if (collections != null) formParams.Add("collections", Configuration.ApiClient.ParameterToString(collections)); // form parameter
            if (dimension != null) formParams.Add("dimension", Configuration.ApiClient.ParameterToString(dimension)); // form parameter
            if (startDate != null) formParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate)); // form parameter
            if (endDate != null) formParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling EventExplorerGetEventStatistics: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EventExplorerGetEventStatistics: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueryResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResult) Configuration.ApiClient.Deserialize(response, typeof(QueryResult)));
            
        }
    
        /// <summary>
        /// Event statistics 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="collections"></param>
        /// <param name="dimension"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns>Task of QueryResult</returns>
        public async System.Threading.Tasks.Task<QueryResult> EventExplorerGetEventStatisticsAsync (string project = null, List<string> collections = null, string dimension = null, DateTime? startDate = null, DateTime? endDate = null)
        {
             ApiResponse<QueryResult> response = await EventExplorerGetEventStatisticsAsyncWithHttpInfo(project, collections, dimension, startDate, endDate);
             return response.Data;

        }

        /// <summary>
        /// Event statistics 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="collections"></param>
        /// <param name="dimension"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns>Task of ApiResponse (QueryResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResult>> EventExplorerGetEventStatisticsAsyncWithHttpInfo (string project = null, List<string> collections = null, string dimension = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            
    
            var path_ = "/event-explorer/statistics";
    
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
            if (collections != null) formParams.Add("collections", Configuration.ApiClient.ParameterToString(collections)); // form parameter
            if (dimension != null) formParams.Add("dimension", Configuration.ApiClient.ParameterToString(dimension)); // form parameter
            if (startDate != null) formParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate)); // form parameter
            if (endDate != null) formParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling EventExplorerGetEventStatistics: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EventExplorerGetEventStatistics: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueryResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResult) Configuration.ApiClient.Deserialize(response, typeof(QueryResult)));
            
        }
        
    }
    
}
