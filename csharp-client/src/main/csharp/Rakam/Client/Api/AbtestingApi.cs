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
    public interface IAbtestingApi
    {
        
        /// <summary>
        /// Create test
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>JsonResponse</returns>
        JsonResponse Create ();
  
        /// <summary>
        /// Create test
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> CreateAsync ();
        
        /// <summary>
        /// Delete report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse Delete (string project, int? id);
  
        /// <summary>
        /// Delete report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> DeleteAsync (string project, int? id);
        
        /// <summary>
        /// Get report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>ABTestingReport</returns>
        ABTestingReport Get (string project, int? id);
  
        /// <summary>
        /// Get report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>ABTestingReport</returns>
        System.Threading.Tasks.Task<ABTestingReport> GetAsync (string project, int? id);
        
        /// <summary>
        /// List reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns></returns>
        List<ABTestingReport> List (string project);
  
        /// <summary>
        /// List reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns></returns>
        System.Threading.Tasks.Task<List<ABTestingReport>> ListAsync (string project);
        
        /// <summary>
        /// Update report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ABTestingReport</returns>
        ABTestingReport Update ();
  
        /// <summary>
        /// Update report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ABTestingReport</returns>
        System.Threading.Tasks.Task<ABTestingReport> UpdateAsync ();
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AbtestingApi : IAbtestingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbtestingApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AbtestingApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AbtestingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AbtestingApi(String basePath)
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
        /// Create test 
        /// </summary>
        /// <returns>JsonResponse</returns>            
        public JsonResponse Create ()
        {
            
    
            var path = "/ab-testing/create";
    
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
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "master_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Create: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonResponse) ApiClient.Deserialize(response.Content, typeof(JsonResponse), response.Headers);
        }
    
        /// <summary>
        /// Create test 
        /// </summary>
        /// <returns>JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> CreateAsync ()
        {
            
    
            var path = "/ab-testing/create";
    
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
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "master_key" };
    
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
        /// <param name="id"></param> 
        /// <returns>JsonResponse</returns>            
        public JsonResponse Delete (string project, int? id)
        {
            
    
            var path = "/ab-testing/delete";
    
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
            if (id != null) formParams.Add("id", ApiClient.ParameterToString(id)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "master_key" };
    
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
        /// <param name="id"></param>
        /// <returns>JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> DeleteAsync (string project, int? id)
        {
            
    
            var path = "/ab-testing/delete";
    
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
            if (id != null) formParams.Add("id", ApiClient.ParameterToString(id)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "master_key" };
    
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
        /// <param name="id"></param> 
        /// <returns>ABTestingReport</returns>            
        public ABTestingReport Get (string project, int? id)
        {
            
    
            var path = "/ab-testing/get";
    
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
            if (id != null) formParams.Add("id", ApiClient.ParameterToString(id)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Get: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ABTestingReport) ApiClient.Deserialize(response.Content, typeof(ABTestingReport), response.Headers);
        }
    
        /// <summary>
        /// Get report 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="id"></param>
        /// <returns>ABTestingReport</returns>
        public async System.Threading.Tasks.Task<ABTestingReport> GetAsync (string project, int? id)
        {
            
    
            var path = "/ab-testing/get";
    
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
            if (id != null) formParams.Add("id", ApiClient.ParameterToString(id)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Get: " + response.Content, response.Content);

            return (ABTestingReport) ApiClient.Deserialize(response.Content, typeof(ABTestingReport), response.Headers);
        }
        
        /// <summary>
        /// List reports 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns></returns>            
        public List<ABTestingReport> List (string project)
        {
            
    
            var path = "/ab-testing/list";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling List: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling List: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ABTestingReport>) ApiClient.Deserialize(response.Content, typeof(List<ABTestingReport>), response.Headers);
        }
    
        /// <summary>
        /// List reports 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<List<ABTestingReport>> ListAsync (string project)
        {
            
    
            var path = "/ab-testing/list";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling List: " + response.Content, response.Content);

            return (List<ABTestingReport>) ApiClient.Deserialize(response.Content, typeof(List<ABTestingReport>), response.Headers);
        }
        
        /// <summary>
        /// Update report 
        /// </summary>
        /// <returns>ABTestingReport</returns>            
        public ABTestingReport Update ()
        {
            
    
            var path = "/ab-testing/update";
    
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
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "master_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Update: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Update: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ABTestingReport) ApiClient.Deserialize(response.Content, typeof(ABTestingReport), response.Headers);
        }
    
        /// <summary>
        /// Update report 
        /// </summary>
        /// <returns>ABTestingReport</returns>
        public async System.Threading.Tasks.Task<ABTestingReport> UpdateAsync ()
        {
            
    
            var path = "/ab-testing/update";
    
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
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "master_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Update: " + response.Content, response.Content);

            return (ABTestingReport) ApiClient.Deserialize(response.Content, typeof(ABTestingReport), response.Headers);
        }
        
    }
    
}
