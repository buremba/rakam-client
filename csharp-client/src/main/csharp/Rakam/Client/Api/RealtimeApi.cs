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
    public interface IRealtimeApi
    {
        
        /// <summary>
        /// Create report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="name"></param>
        /// <param name="aggregation"></param>
        /// <param name="tableName"></param>
        /// <param name="collections"></param>
        /// <param name="filter"></param>
        /// <param name="measure"></param>
        /// <param name="dimensions"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse Create (string project, string name, string aggregation, string tableName, List<string> collections, string filter, string measure, List<string> dimensions);
  
        /// <summary>
        /// Create report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="name"></param>
        /// <param name="aggregation"></param>
        /// <param name="tableName"></param>
        /// <param name="collections"></param>
        /// <param name="filter"></param>
        /// <param name="measure"></param>
        /// <param name="dimensions"></param>
        /// <returns>JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> CreateAsync (string project, string name, string aggregation, string tableName, List<string> collections, string filter, string measure, List<string> dimensions);
        
        /// <summary>
        /// Delete report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="name"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse Delete (string project, string name);
  
        /// <summary>
        /// Delete report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="name"></param>
        /// <returns>JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> DeleteAsync (string project, string name);
        
        /// <summary>
        /// Get report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <param name="filter"></param>
        /// <param name="aggregation"></param>
        /// <param name="measure"></param>
        /// <param name="dimensions"></param>
        /// <param name="aggregate"></param>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <returns>Object</returns>
        Object Get (string project, string tableName, string filter, string aggregation, string measure, List<string> dimensions, bool? aggregate, DateTime? dateStart, DateTime? dateEnd);
  
        /// <summary>
        /// Get report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <param name="filter"></param>
        /// <param name="aggregation"></param>
        /// <param name="measure"></param>
        /// <param name="dimensions"></param>
        /// <param name="aggregate"></param>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> GetAsync (string project, string tableName, string filter, string aggregation, string measure, List<string> dimensions, bool? aggregate, DateTime? dateStart, DateTime? dateEnd);
        
        /// <summary>
        /// List reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns></returns>
        List<RealTimeReport> ListReports (string project);
  
        /// <summary>
        /// List reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns></returns>
        System.Threading.Tasks.Task<List<RealTimeReport>> ListReportsAsync (string project);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RealtimeApi : IRealtimeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RealtimeApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RealtimeApi(String basePath)
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
        /// Create report 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="name"></param> 
        /// <param name="aggregation"></param> 
        /// <param name="tableName"></param> 
        /// <param name="collections"></param> 
        /// <param name="filter"></param> 
        /// <param name="measure"></param> 
        /// <param name="dimensions"></param> 
        /// <returns>JsonResponse</returns>            
        public JsonResponse Create (string project, string name, string aggregation, string tableName, List<string> collections, string filter, string measure, List<string> dimensions)
        {
            
    
            var path = "/realtime/create";
    
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
            if (name != null) formParams.Add("name", ApiClient.ParameterToString(name)); // form parameter
            if (aggregation != null) formParams.Add("aggregation", ApiClient.ParameterToString(aggregation)); // form parameter
            if (tableName != null) formParams.Add("table_name", ApiClient.ParameterToString(tableName)); // form parameter
            if (collections != null) formParams.Add("collections", ApiClient.ParameterToString(collections)); // form parameter
            if (filter != null) formParams.Add("filter", ApiClient.ParameterToString(filter)); // form parameter
            if (measure != null) formParams.Add("measure", ApiClient.ParameterToString(measure)); // form parameter
            if (dimensions != null) formParams.Add("dimensions", ApiClient.ParameterToString(dimensions)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Create: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonResponse) ApiClient.Deserialize(response.Content, typeof(JsonResponse), response.Headers);
        }
    
        /// <summary>
        /// Create report 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="name"></param>
        /// <param name="aggregation"></param>
        /// <param name="tableName"></param>
        /// <param name="collections"></param>
        /// <param name="filter"></param>
        /// <param name="measure"></param>
        /// <param name="dimensions"></param>
        /// <returns>JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> CreateAsync (string project, string name, string aggregation, string tableName, List<string> collections, string filter, string measure, List<string> dimensions)
        {
            
    
            var path = "/realtime/create";
    
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
            if (name != null) formParams.Add("name", ApiClient.ParameterToString(name)); // form parameter
            if (aggregation != null) formParams.Add("aggregation", ApiClient.ParameterToString(aggregation)); // form parameter
            if (tableName != null) formParams.Add("table_name", ApiClient.ParameterToString(tableName)); // form parameter
            if (collections != null) formParams.Add("collections", ApiClient.ParameterToString(collections)); // form parameter
            if (filter != null) formParams.Add("filter", ApiClient.ParameterToString(filter)); // form parameter
            if (measure != null) formParams.Add("measure", ApiClient.ParameterToString(measure)); // form parameter
            if (dimensions != null) formParams.Add("dimensions", ApiClient.ParameterToString(dimensions)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Create: " + response.Content, response.Content);

            return (JsonResponse) ApiClient.Deserialize(response.Content, typeof(JsonResponse), response.Headers);
        }
        
        /// <summary>
        /// Delete report 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="name"></param> 
        /// <returns>JsonResponse</returns>            
        public JsonResponse Delete (string project, string name)
        {
            
    
            var path = "/realtime/delete";
    
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
            if (name != null) formParams.Add("name", ApiClient.ParameterToString(name)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Delete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Delete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonResponse) ApiClient.Deserialize(response.Content, typeof(JsonResponse), response.Headers);
        }
    
        /// <summary>
        /// Delete report 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="name"></param>
        /// <returns>JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> DeleteAsync (string project, string name)
        {
            
    
            var path = "/realtime/delete";
    
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
            if (name != null) formParams.Add("name", ApiClient.ParameterToString(name)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Delete: " + response.Content, response.Content);

            return (JsonResponse) ApiClient.Deserialize(response.Content, typeof(JsonResponse), response.Headers);
        }
        
        /// <summary>
        /// Get report 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="tableName"></param> 
        /// <param name="filter"></param> 
        /// <param name="aggregation"></param> 
        /// <param name="measure"></param> 
        /// <param name="dimensions"></param> 
        /// <param name="aggregate"></param> 
        /// <param name="dateStart"></param> 
        /// <param name="dateEnd"></param> 
        /// <returns>Object</returns>            
        public Object Get (string project, string tableName, string filter, string aggregation, string measure, List<string> dimensions, bool? aggregate, DateTime? dateStart, DateTime? dateEnd)
        {
            
    
            var path = "/realtime/get";
    
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
            if (tableName != null) formParams.Add("table_name", ApiClient.ParameterToString(tableName)); // form parameter
            if (filter != null) formParams.Add("filter", ApiClient.ParameterToString(filter)); // form parameter
            if (aggregation != null) formParams.Add("aggregation", ApiClient.ParameterToString(aggregation)); // form parameter
            if (measure != null) formParams.Add("measure", ApiClient.ParameterToString(measure)); // form parameter
            if (dimensions != null) formParams.Add("dimensions", ApiClient.ParameterToString(dimensions)); // form parameter
            if (aggregate != null) formParams.Add("aggregate", ApiClient.ParameterToString(aggregate)); // form parameter
            if (dateStart != null) formParams.Add("date_start", ApiClient.ParameterToString(dateStart)); // form parameter
            if (dateEnd != null) formParams.Add("date_end", ApiClient.ParameterToString(dateEnd)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Get: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Get report 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="tableName"></param>
        /// <param name="filter"></param>
        /// <param name="aggregation"></param>
        /// <param name="measure"></param>
        /// <param name="dimensions"></param>
        /// <param name="aggregate"></param>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> GetAsync (string project, string tableName, string filter, string aggregation, string measure, List<string> dimensions, bool? aggregate, DateTime? dateStart, DateTime? dateEnd)
        {
            
    
            var path = "/realtime/get";
    
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
            if (tableName != null) formParams.Add("table_name", ApiClient.ParameterToString(tableName)); // form parameter
            if (filter != null) formParams.Add("filter", ApiClient.ParameterToString(filter)); // form parameter
            if (aggregation != null) formParams.Add("aggregation", ApiClient.ParameterToString(aggregation)); // form parameter
            if (measure != null) formParams.Add("measure", ApiClient.ParameterToString(measure)); // form parameter
            if (dimensions != null) formParams.Add("dimensions", ApiClient.ParameterToString(dimensions)); // form parameter
            if (aggregate != null) formParams.Add("aggregate", ApiClient.ParameterToString(aggregate)); // form parameter
            if (dateStart != null) formParams.Add("date_start", ApiClient.ParameterToString(dateStart)); // form parameter
            if (dateEnd != null) formParams.Add("date_end", ApiClient.ParameterToString(dateEnd)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Get: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// List reports 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns></returns>            
        public List<RealTimeReport> ListReports (string project)
        {
            
    
            var path = "/realtime/list";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListReports: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListReports: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RealTimeReport>) ApiClient.Deserialize(response.Content, typeof(List<RealTimeReport>), response.Headers);
        }
    
        /// <summary>
        /// List reports 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<List<RealTimeReport>> ListReportsAsync (string project)
        {
            
    
            var path = "/realtime/list";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListReports: " + response.Content, response.Content);

            return (List<RealTimeReport>) ApiClient.Deserialize(response.Content, typeof(List<RealTimeReport>), response.Headers);
        }
        
    }
    
}
