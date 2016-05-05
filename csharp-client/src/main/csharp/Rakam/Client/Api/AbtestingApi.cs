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
    public interface IAbtestingApi
    {
        
        /// <summary>
        /// Create test
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="aBTestingReport"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse AbTestingCreate (ABTestingReport aBTestingReport);
  
        /// <summary>
        /// Create test
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="aBTestingReport"></param>
        /// <returns>ApiResponse of JsonResponse</returns>
        ApiResponse<JsonResponse> AbTestingCreateWithHttpInfo (ABTestingReport aBTestingReport);

        /// <summary>
        /// Create test
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="aBTestingReport"></param>
        /// <returns>Task of JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> AbTestingCreateAsync (ABTestingReport aBTestingReport);

        /// <summary>
        /// Create test
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="aBTestingReport"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonResponse>> AbTestingCreateAsyncWithHttpInfo (ABTestingReport aBTestingReport);
        
        /// <summary>
        /// Delete report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse AbTestingDelete (string project = null, int? id = null);
  
        /// <summary>
        /// Delete report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of JsonResponse</returns>
        ApiResponse<JsonResponse> AbTestingDeleteWithHttpInfo (string project = null, int? id = null);

        /// <summary>
        /// Delete report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>Task of JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> AbTestingDeleteAsync (string project = null, int? id = null);

        /// <summary>
        /// Delete report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonResponse>> AbTestingDeleteAsyncWithHttpInfo (string project = null, int? id = null);
        
        /// <summary>
        /// Get report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>ABTestingReport</returns>
        ABTestingReport AbTestingGet (string project = null, int? id = null);
  
        /// <summary>
        /// Get report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of ABTestingReport</returns>
        ApiResponse<ABTestingReport> AbTestingGetWithHttpInfo (string project = null, int? id = null);

        /// <summary>
        /// Get report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>Task of ABTestingReport</returns>
        System.Threading.Tasks.Task<ABTestingReport> AbTestingGetAsync (string project = null, int? id = null);

        /// <summary>
        /// Get report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (ABTestingReport)</returns>
        System.Threading.Tasks.Task<ApiResponse<ABTestingReport>> AbTestingGetAsyncWithHttpInfo (string project = null, int? id = null);
        
        /// <summary>
        /// List reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>List&lt;ABTestingReport&gt;</returns>
        List<ABTestingReport> AbTestingList (string project = null);
  
        /// <summary>
        /// List reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>ApiResponse of List&lt;ABTestingReport&gt;</returns>
        ApiResponse<List<ABTestingReport>> AbTestingListWithHttpInfo (string project = null);

        /// <summary>
        /// List reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of List&lt;ABTestingReport&gt;</returns>
        System.Threading.Tasks.Task<List<ABTestingReport>> AbTestingListAsync (string project = null);

        /// <summary>
        /// List reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (List&lt;ABTestingReport&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ABTestingReport>>> AbTestingListAsyncWithHttpInfo (string project = null);
        
        /// <summary>
        /// Update report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="aBTestingReport"></param>
        /// <returns>ABTestingReport</returns>
        ABTestingReport AbTestingUpdate (ABTestingReport aBTestingReport);
  
        /// <summary>
        /// Update report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="aBTestingReport"></param>
        /// <returns>ApiResponse of ABTestingReport</returns>
        ApiResponse<ABTestingReport> AbTestingUpdateWithHttpInfo (ABTestingReport aBTestingReport);

        /// <summary>
        /// Update report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="aBTestingReport"></param>
        /// <returns>Task of ABTestingReport</returns>
        System.Threading.Tasks.Task<ABTestingReport> AbTestingUpdateAsync (ABTestingReport aBTestingReport);

        /// <summary>
        /// Update report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="aBTestingReport"></param>
        /// <returns>Task of ApiResponse (ABTestingReport)</returns>
        System.Threading.Tasks.Task<ApiResponse<ABTestingReport>> AbTestingUpdateAsyncWithHttpInfo (ABTestingReport aBTestingReport);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AbtestingApi : IAbtestingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbtestingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AbtestingApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AbtestingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AbtestingApi(Configuration configuration = null)
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
        /// Create test 
        /// </summary>
        /// <param name="aBTestingReport"></param> 
        /// <returns>JsonResponse</returns>
        public JsonResponse AbTestingCreate (ABTestingReport aBTestingReport)
        {
             ApiResponse<JsonResponse> response = AbTestingCreateWithHttpInfo(aBTestingReport);
             return response.Data;
        }

        /// <summary>
        /// Create test 
        /// </summary>
        /// <param name="aBTestingReport"></param> 
        /// <returns>ApiResponse of JsonResponse</returns>
        public ApiResponse< JsonResponse > AbTestingCreateWithHttpInfo (ABTestingReport aBTestingReport)
        {
            
            // verify the required parameter 'aBTestingReport' is set
            if (aBTestingReport == null) throw new ApiException(400, "Missing required parameter 'aBTestingReport' when calling AbTestingCreate");
            
    
            var path_ = "/ab-testing/create";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(aBTestingReport); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling AbTestingCreate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AbTestingCreate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
    
        /// <summary>
        /// Create test 
        /// </summary>
        /// <param name="aBTestingReport"></param>
        /// <returns>Task of JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> AbTestingCreateAsync (ABTestingReport aBTestingReport)
        {
             ApiResponse<JsonResponse> response = await AbTestingCreateAsyncWithHttpInfo(aBTestingReport);
             return response.Data;

        }

        /// <summary>
        /// Create test 
        /// </summary>
        /// <param name="aBTestingReport"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonResponse>> AbTestingCreateAsyncWithHttpInfo (ABTestingReport aBTestingReport)
        {
            // verify the required parameter 'aBTestingReport' is set
            if (aBTestingReport == null) throw new ApiException(400, "Missing required parameter 'aBTestingReport' when calling AbTestingCreate");
            
    
            var path_ = "/ab-testing/create";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(aBTestingReport); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling AbTestingCreate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AbTestingCreate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
        
        /// <summary>
        /// Delete report 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="id"></param> 
        /// <returns>JsonResponse</returns>
        public JsonResponse AbTestingDelete (string project = null, int? id = null)
        {
             ApiResponse<JsonResponse> response = AbTestingDeleteWithHttpInfo(project, id);
             return response.Data;
        }

        /// <summary>
        /// Delete report 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="id"></param> 
        /// <returns>ApiResponse of JsonResponse</returns>
        public ApiResponse< JsonResponse > AbTestingDeleteWithHttpInfo (string project = null, int? id = null)
        {
            
    
            var path_ = "/ab-testing/delete";
    
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
            if (id != null) formParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling AbTestingDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AbTestingDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
    
        /// <summary>
        /// Delete report 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>Task of JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> AbTestingDeleteAsync (string project = null, int? id = null)
        {
             ApiResponse<JsonResponse> response = await AbTestingDeleteAsyncWithHttpInfo(project, id);
             return response.Data;

        }

        /// <summary>
        /// Delete report 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonResponse>> AbTestingDeleteAsyncWithHttpInfo (string project = null, int? id = null)
        {
            
    
            var path_ = "/ab-testing/delete";
    
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
            if (id != null) formParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling AbTestingDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AbTestingDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
        
        /// <summary>
        /// Get report 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="id"></param> 
        /// <returns>ABTestingReport</returns>
        public ABTestingReport AbTestingGet (string project = null, int? id = null)
        {
             ApiResponse<ABTestingReport> response = AbTestingGetWithHttpInfo(project, id);
             return response.Data;
        }

        /// <summary>
        /// Get report 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="id"></param> 
        /// <returns>ApiResponse of ABTestingReport</returns>
        public ApiResponse< ABTestingReport > AbTestingGetWithHttpInfo (string project = null, int? id = null)
        {
            
    
            var path_ = "/ab-testing/get";
    
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
            if (id != null) formParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling AbTestingGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AbTestingGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ABTestingReport>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ABTestingReport) Configuration.ApiClient.Deserialize(response, typeof(ABTestingReport)));
            
        }
    
        /// <summary>
        /// Get report 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>Task of ABTestingReport</returns>
        public async System.Threading.Tasks.Task<ABTestingReport> AbTestingGetAsync (string project = null, int? id = null)
        {
             ApiResponse<ABTestingReport> response = await AbTestingGetAsyncWithHttpInfo(project, id);
             return response.Data;

        }

        /// <summary>
        /// Get report 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (ABTestingReport)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ABTestingReport>> AbTestingGetAsyncWithHttpInfo (string project = null, int? id = null)
        {
            
    
            var path_ = "/ab-testing/get";
    
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
            if (id != null) formParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling AbTestingGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AbTestingGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ABTestingReport>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ABTestingReport) Configuration.ApiClient.Deserialize(response, typeof(ABTestingReport)));
            
        }
        
        /// <summary>
        /// List reports 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>List&lt;ABTestingReport&gt;</returns>
        public List<ABTestingReport> AbTestingList (string project = null)
        {
             ApiResponse<List<ABTestingReport>> response = AbTestingListWithHttpInfo(project);
             return response.Data;
        }

        /// <summary>
        /// List reports 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>ApiResponse of List&lt;ABTestingReport&gt;</returns>
        public ApiResponse< List<ABTestingReport> > AbTestingListWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/ab-testing/list";
    
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
                throw new ApiException (statusCode, "Error calling AbTestingList: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AbTestingList: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<ABTestingReport>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ABTestingReport>) Configuration.ApiClient.Deserialize(response, typeof(List<ABTestingReport>)));
            
        }
    
        /// <summary>
        /// List reports 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of List&lt;ABTestingReport&gt;</returns>
        public async System.Threading.Tasks.Task<List<ABTestingReport>> AbTestingListAsync (string project = null)
        {
             ApiResponse<List<ABTestingReport>> response = await AbTestingListAsyncWithHttpInfo(project);
             return response.Data;

        }

        /// <summary>
        /// List reports 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (List&lt;ABTestingReport&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ABTestingReport>>> AbTestingListAsyncWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/ab-testing/list";
    
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
                throw new ApiException (statusCode, "Error calling AbTestingList: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AbTestingList: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<ABTestingReport>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ABTestingReport>) Configuration.ApiClient.Deserialize(response, typeof(List<ABTestingReport>)));
            
        }
        
        /// <summary>
        /// Update report 
        /// </summary>
        /// <param name="aBTestingReport"></param> 
        /// <returns>ABTestingReport</returns>
        public ABTestingReport AbTestingUpdate (ABTestingReport aBTestingReport)
        {
             ApiResponse<ABTestingReport> response = AbTestingUpdateWithHttpInfo(aBTestingReport);
             return response.Data;
        }

        /// <summary>
        /// Update report 
        /// </summary>
        /// <param name="aBTestingReport"></param> 
        /// <returns>ApiResponse of ABTestingReport</returns>
        public ApiResponse< ABTestingReport > AbTestingUpdateWithHttpInfo (ABTestingReport aBTestingReport)
        {
            
            // verify the required parameter 'aBTestingReport' is set
            if (aBTestingReport == null) throw new ApiException(400, "Missing required parameter 'aBTestingReport' when calling AbTestingUpdate");
            
    
            var path_ = "/ab-testing/update";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(aBTestingReport); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling AbTestingUpdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AbTestingUpdate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ABTestingReport>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ABTestingReport) Configuration.ApiClient.Deserialize(response, typeof(ABTestingReport)));
            
        }
    
        /// <summary>
        /// Update report 
        /// </summary>
        /// <param name="aBTestingReport"></param>
        /// <returns>Task of ABTestingReport</returns>
        public async System.Threading.Tasks.Task<ABTestingReport> AbTestingUpdateAsync (ABTestingReport aBTestingReport)
        {
             ApiResponse<ABTestingReport> response = await AbTestingUpdateAsyncWithHttpInfo(aBTestingReport);
             return response.Data;

        }

        /// <summary>
        /// Update report 
        /// </summary>
        /// <param name="aBTestingReport"></param>
        /// <returns>Task of ApiResponse (ABTestingReport)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ABTestingReport>> AbTestingUpdateAsyncWithHttpInfo (ABTestingReport aBTestingReport)
        {
            // verify the required parameter 'aBTestingReport' is set
            if (aBTestingReport == null) throw new ApiException(400, "Missing required parameter 'aBTestingReport' when calling AbTestingUpdate");
            
    
            var path_ = "/ab-testing/update";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(aBTestingReport); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling AbTestingUpdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AbTestingUpdate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ABTestingReport>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ABTestingReport) Configuration.ApiClient.Deserialize(response, typeof(ABTestingReport)));
            
        }
        
    }
    
}
