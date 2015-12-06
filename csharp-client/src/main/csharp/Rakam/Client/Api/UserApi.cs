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
    public interface IUserApi
    {
        
        /// <summary>
        /// Create new user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="batchCreate"></param>
        /// <returns></returns>
        List<string> BatchCreate (BatchCreate batchCreate);
  
        /// <summary>
        /// Create new user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="batchCreate"></param>
        /// <returns></returns>
        System.Threading.Tasks.Task<List<string>> BatchCreateAsync (BatchCreate batchCreate);
        
        /// <summary>
        /// Create new user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="user"></param>
        /// <returns>string</returns>
        string Create (User user);
  
        /// <summary>
        /// Create new user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="user"></param>
        /// <returns>string</returns>
        System.Threading.Tasks.Task<string> CreateAsync (User user);
        
        /// <summary>
        /// Get user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <returns>User</returns>
        User GetUser (string project, string user);
  
        /// <summary>
        /// Get user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <returns>User</returns>
        System.Threading.Tasks.Task<User> GetUserAsync (string project, string user);
        
        /// <summary>
        /// Get events of the user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        List<CollectionEvent> GetEvents (string project, string user, int? limit, long? offset);
  
        /// <summary>
        /// Get events of the user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        System.Threading.Tasks.Task<List<CollectionEvent>> GetEventsAsync (string project, string user, int? limit, long? offset);
        
        /// <summary>
        /// Set user property
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse IncrementUserProperty (string project, string user);
  
        /// <summary>
        /// Set user property
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <returns>JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> IncrementUserPropertyAsync (string project, string user);
        
        /// <summary>
        /// Get user storage metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>MetadataResponse</returns>
        MetadataResponse GetMetadata (string project);
  
        /// <summary>
        /// Get user storage metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>MetadataResponse</returns>
        System.Threading.Tasks.Task<MetadataResponse> GetMetadataAsync (string project);
        
        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="searchUsers"></param>
        /// <returns>QueryResult</returns>
        QueryResult SearchUsers (SearchUsers searchUsers);
  
        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="searchUsers"></param>
        /// <returns>QueryResult</returns>
        System.Threading.Tasks.Task<QueryResult> SearchUsersAsync (SearchUsers searchUsers);
        
        /// <summary>
        /// Set user properties once
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="setUserProperties"></param>
        /// <returns></returns>
        void SetUserPropertiesOnce (SetUserProperties setUserProperties);
  
        /// <summary>
        /// Set user properties once
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="setUserProperties"></param>
        /// <returns></returns>
        System.Threading.Tasks.Task SetUserPropertiesOnceAsync (SetUserProperties setUserProperties);
        
        /// <summary>
        /// Set user properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="setUserProperties"></param>
        /// <returns>int?</returns>
        int? SetUserProperties (SetUserProperties setUserProperties);
  
        /// <summary>
        /// Set user properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="setUserProperties"></param>
        /// <returns>int?</returns>
        System.Threading.Tasks.Task<int?> SetUserPropertiesAsync (SetUserProperties setUserProperties);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserApi : IUserApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(String basePath)
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
        /// Create new user 
        /// </summary>
        /// <param name="batchCreate"></param> 
        /// <returns></returns>            
        public List<string> BatchCreate (BatchCreate batchCreate)
        {
            
            // verify the required parameter 'batchCreate' is set
            if (batchCreate == null) throw new ApiException(400, "Missing required parameter 'batchCreate' when calling BatchCreate");
            
    
            var path = "/user/batch/create";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(batchCreate); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BatchCreate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BatchCreate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Create new user 
        /// </summary>
        /// <param name="batchCreate"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<List<string>> BatchCreateAsync (BatchCreate batchCreate)
        {
            // verify the required parameter 'batchCreate' is set
            if (batchCreate == null) throw new ApiException(400, "Missing required parameter 'batchCreate' when calling BatchCreate");
            
    
            var path = "/user/batch/create";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(batchCreate); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BatchCreate: " + response.Content, response.Content);

            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
        
        /// <summary>
        /// Create new user 
        /// </summary>
        /// <param name="user"></param> 
        /// <returns>string</returns>            
        public string Create (User user)
        {
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling Create");
            
    
            var path = "/user/create";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(user); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Create: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Create new user 
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string</returns>
        public async System.Threading.Tasks.Task<string> CreateAsync (User user)
        {
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling Create");
            
    
            var path = "/user/create";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(user); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Create: " + response.Content, response.Content);

            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
        
        /// <summary>
        /// Get user 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="user"></param> 
        /// <returns>User</returns>            
        public User GetUser (string project, string user)
        {
            
    
            var path = "/user/get";
    
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
            if (user != null) formParams.Add("user", ApiClient.ParameterToString(user)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (User) ApiClient.Deserialize(response.Content, typeof(User), response.Headers);
        }
    
        /// <summary>
        /// Get user 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <returns>User</returns>
        public async System.Threading.Tasks.Task<User> GetUserAsync (string project, string user)
        {
            
    
            var path = "/user/get";
    
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
            if (user != null) formParams.Add("user", ApiClient.ParameterToString(user)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.Content, response.Content);

            return (User) ApiClient.Deserialize(response.Content, typeof(User), response.Headers);
        }
        
        /// <summary>
        /// Get events of the user 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="user"></param> 
        /// <param name="limit"></param> 
        /// <param name="offset"></param> 
        /// <returns></returns>            
        public List<CollectionEvent> GetEvents (string project, string user, int? limit, long? offset)
        {
            
    
            var path = "/user/get_events";
    
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
            if (user != null) formParams.Add("user", ApiClient.ParameterToString(user)); // form parameter
            if (limit != null) formParams.Add("limit", ApiClient.ParameterToString(limit)); // form parameter
            if (offset != null) formParams.Add("offset", ApiClient.ParameterToString(offset)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<CollectionEvent>) ApiClient.Deserialize(response.Content, typeof(List<CollectionEvent>), response.Headers);
        }
    
        /// <summary>
        /// Get events of the user 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<List<CollectionEvent>> GetEventsAsync (string project, string user, int? limit, long? offset)
        {
            
    
            var path = "/user/get_events";
    
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
            if (user != null) formParams.Add("user", ApiClient.ParameterToString(user)); // form parameter
            if (limit != null) formParams.Add("limit", ApiClient.ParameterToString(limit)); // form parameter
            if (offset != null) formParams.Add("offset", ApiClient.ParameterToString(offset)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEvents: " + response.Content, response.Content);

            return (List<CollectionEvent>) ApiClient.Deserialize(response.Content, typeof(List<CollectionEvent>), response.Headers);
        }
        
        /// <summary>
        /// Set user property 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="user"></param> 
        /// <returns>JsonResponse</returns>            
        public JsonResponse IncrementUserProperty (string project, string user)
        {
            
    
            var path = "/user/increment";
    
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
            if (user != null) formParams.Add("user", ApiClient.ParameterToString(user)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IncrementUserProperty: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IncrementUserProperty: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonResponse) ApiClient.Deserialize(response.Content, typeof(JsonResponse), response.Headers);
        }
    
        /// <summary>
        /// Set user property 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <returns>JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> IncrementUserPropertyAsync (string project, string user)
        {
            
    
            var path = "/user/increment";
    
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
            if (user != null) formParams.Add("user", ApiClient.ParameterToString(user)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IncrementUserProperty: " + response.Content, response.Content);

            return (JsonResponse) ApiClient.Deserialize(response.Content, typeof(JsonResponse), response.Headers);
        }
        
        /// <summary>
        /// Get user storage metadata 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>MetadataResponse</returns>            
        public MetadataResponse GetMetadata (string project)
        {
            
    
            var path = "/user/metadata";
    
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
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMetadata: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMetadata: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MetadataResponse) ApiClient.Deserialize(response.Content, typeof(MetadataResponse), response.Headers);
        }
    
        /// <summary>
        /// Get user storage metadata 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>MetadataResponse</returns>
        public async System.Threading.Tasks.Task<MetadataResponse> GetMetadataAsync (string project)
        {
            
    
            var path = "/user/metadata";
    
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
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMetadata: " + response.Content, response.Content);

            return (MetadataResponse) ApiClient.Deserialize(response.Content, typeof(MetadataResponse), response.Headers);
        }
        
        /// <summary>
        /// Search users 
        /// </summary>
        /// <param name="searchUsers"></param> 
        /// <returns>QueryResult</returns>            
        public QueryResult SearchUsers (SearchUsers searchUsers)
        {
            
            // verify the required parameter 'searchUsers' is set
            if (searchUsers == null) throw new ApiException(400, "Missing required parameter 'searchUsers' when calling SearchUsers");
            
    
            var path = "/user/search";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(searchUsers); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QueryResult) ApiClient.Deserialize(response.Content, typeof(QueryResult), response.Headers);
        }
    
        /// <summary>
        /// Search users 
        /// </summary>
        /// <param name="searchUsers"></param>
        /// <returns>QueryResult</returns>
        public async System.Threading.Tasks.Task<QueryResult> SearchUsersAsync (SearchUsers searchUsers)
        {
            // verify the required parameter 'searchUsers' is set
            if (searchUsers == null) throw new ApiException(400, "Missing required parameter 'searchUsers' when calling SearchUsers");
            
    
            var path = "/user/search";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(searchUsers); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchUsers: " + response.Content, response.Content);

            return (QueryResult) ApiClient.Deserialize(response.Content, typeof(QueryResult), response.Headers);
        }
        
        /// <summary>
        /// Set user properties once 
        /// </summary>
        /// <param name="setUserProperties"></param> 
        /// <returns></returns>            
        public void SetUserPropertiesOnce (SetUserProperties setUserProperties)
        {
            
            // verify the required parameter 'setUserProperties' is set
            if (setUserProperties == null) throw new ApiException(400, "Missing required parameter 'setUserProperties' when calling SetUserPropertiesOnce");
            
    
            var path = "/user/set_once";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(setUserProperties); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUserPropertiesOnce: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUserPropertiesOnce: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set user properties once 
        /// </summary>
        /// <param name="setUserProperties"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task SetUserPropertiesOnceAsync (SetUserProperties setUserProperties)
        {
            // verify the required parameter 'setUserProperties' is set
            if (setUserProperties == null) throw new ApiException(400, "Missing required parameter 'setUserProperties' when calling SetUserPropertiesOnce");
            
    
            var path = "/user/set_once";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(setUserProperties); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUserPropertiesOnce: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Set user properties 
        /// </summary>
        /// <param name="setUserProperties"></param> 
        /// <returns>int?</returns>            
        public int? SetUserProperties (SetUserProperties setUserProperties)
        {
            
            // verify the required parameter 'setUserProperties' is set
            if (setUserProperties == null) throw new ApiException(400, "Missing required parameter 'setUserProperties' when calling SetUserProperties");
            
    
            var path = "/user/set_property";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(setUserProperties); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUserProperties: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUserProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
        /// <summary>
        /// Set user properties 
        /// </summary>
        /// <param name="setUserProperties"></param>
        /// <returns>int?</returns>
        public async System.Threading.Tasks.Task<int?> SetUserPropertiesAsync (SetUserProperties setUserProperties)
        {
            // verify the required parameter 'setUserProperties' is set
            if (setUserProperties == null) throw new ApiException(400, "Missing required parameter 'setUserProperties' when calling SetUserProperties");
            
    
            var path = "/user/set_property";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(setUserProperties); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUserProperties: " + response.Content, response.Content);

            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
        
    }
    
}
