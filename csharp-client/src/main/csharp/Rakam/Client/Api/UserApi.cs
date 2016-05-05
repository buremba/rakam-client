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
    public interface IUserApi
    {
        
        /// <summary>
        /// Create new user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userBatchCreate"></param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> UserBatchCreate (UserBatchCreate userBatchCreate);
  
        /// <summary>
        /// Create new user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userBatchCreate"></param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> UserBatchCreateWithHttpInfo (UserBatchCreate userBatchCreate);

        /// <summary>
        /// Create new user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userBatchCreate"></param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> UserBatchCreateAsync (UserBatchCreate userBatchCreate);

        /// <summary>
        /// Create new user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userBatchCreate"></param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> UserBatchCreateAsyncWithHttpInfo (UserBatchCreate userBatchCreate);
        
        /// <summary>
        /// Create new user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="user"></param>
        /// <returns>string</returns>
        string UserCreate (User user);
  
        /// <summary>
        /// Create new user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="user"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> UserCreateWithHttpInfo (User user);

        /// <summary>
        /// Create new user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="user"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> UserCreateAsync (User user);

        /// <summary>
        /// Create new user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="user"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> UserCreateAsyncWithHttpInfo (User user);
        
        /// <summary>
        /// Get events of the user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userCreateSegment"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse UserCreateSegment (UserCreateSegment userCreateSegment);
  
        /// <summary>
        /// Get events of the user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userCreateSegment"></param>
        /// <returns>ApiResponse of JsonResponse</returns>
        ApiResponse<JsonResponse> UserCreateSegmentWithHttpInfo (UserCreateSegment userCreateSegment);

        /// <summary>
        /// Get events of the user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userCreateSegment"></param>
        /// <returns>Task of JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> UserCreateSegmentAsync (UserCreateSegment userCreateSegment);

        /// <summary>
        /// Get events of the user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userCreateSegment"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonResponse>> UserCreateSegmentAsyncWithHttpInfo (UserCreateSegment userCreateSegment);
        
        /// <summary>
        /// Get user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <returns>User</returns>
        User UserGetUser (string project = null, string user = null);
  
        /// <summary>
        /// Get user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> UserGetUserWithHttpInfo (string project = null, string user = null);

        /// <summary>
        /// Get user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> UserGetUserAsync (string project = null, string user = null);

        /// <summary>
        /// Get user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> UserGetUserAsyncWithHttpInfo (string project = null, string user = null);
        
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
        /// <returns>List&lt;CollectionEvent&gt;</returns>
        List<CollectionEvent> UserGetEvents (string project = null, string user = null, int? limit = null, DateTime? offset = null);
  
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
        /// <returns>ApiResponse of List&lt;CollectionEvent&gt;</returns>
        ApiResponse<List<CollectionEvent>> UserGetEventsWithHttpInfo (string project = null, string user = null, int? limit = null, DateTime? offset = null);

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
        /// <returns>Task of List&lt;CollectionEvent&gt;</returns>
        System.Threading.Tasks.Task<List<CollectionEvent>> UserGetEventsAsync (string project = null, string user = null, int? limit = null, DateTime? offset = null);

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
        /// <returns>Task of ApiResponse (List&lt;CollectionEvent&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CollectionEvent>>> UserGetEventsAsyncWithHttpInfo (string project = null, string user = null, int? limit = null, DateTime? offset = null);
        
        /// <summary>
        /// Set user property
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userIncrementProperty"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse UserIncrementProperty (UserIncrementProperty userIncrementProperty);
  
        /// <summary>
        /// Set user property
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userIncrementProperty"></param>
        /// <returns>ApiResponse of JsonResponse</returns>
        ApiResponse<JsonResponse> UserIncrementPropertyWithHttpInfo (UserIncrementProperty userIncrementProperty);

        /// <summary>
        /// Set user property
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userIncrementProperty"></param>
        /// <returns>Task of JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> UserIncrementPropertyAsync (UserIncrementProperty userIncrementProperty);

        /// <summary>
        /// Set user property
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userIncrementProperty"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonResponse>> UserIncrementPropertyAsyncWithHttpInfo (UserIncrementProperty userIncrementProperty);
        
        /// <summary>
        /// Merge user with anonymous id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userMergeUser"></param>
        /// <returns>bool?</returns>
        bool? UserMergeUser (UserMergeUser userMergeUser);
  
        /// <summary>
        /// Merge user with anonymous id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userMergeUser"></param>
        /// <returns>ApiResponse of bool?</returns>
        ApiResponse<bool?> UserMergeUserWithHttpInfo (UserMergeUser userMergeUser);

        /// <summary>
        /// Merge user with anonymous id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userMergeUser"></param>
        /// <returns>Task of bool?</returns>
        System.Threading.Tasks.Task<bool?> UserMergeUserAsync (UserMergeUser userMergeUser);

        /// <summary>
        /// Merge user with anonymous id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userMergeUser"></param>
        /// <returns>Task of ApiResponse (bool?)</returns>
        System.Threading.Tasks.Task<ApiResponse<bool?>> UserMergeUserAsyncWithHttpInfo (UserMergeUser userMergeUser);
        
        /// <summary>
        /// Get user storage metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>MetadataResponse</returns>
        MetadataResponse UserGetMetadata (string project = null);
  
        /// <summary>
        /// Get user storage metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>ApiResponse of MetadataResponse</returns>
        ApiResponse<MetadataResponse> UserGetMetadataWithHttpInfo (string project = null);

        /// <summary>
        /// Get user storage metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of MetadataResponse</returns>
        System.Threading.Tasks.Task<MetadataResponse> UserGetMetadataAsync (string project = null);

        /// <summary>
        /// Get user storage metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (MetadataResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MetadataResponse>> UserGetMetadataAsyncWithHttpInfo (string project = null);
        
        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userSearchUsers"></param>
        /// <returns>QueryResult</returns>
        QueryResult UserSearchUsers (UserSearchUsers userSearchUsers);
  
        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userSearchUsers"></param>
        /// <returns>ApiResponse of QueryResult</returns>
        ApiResponse<QueryResult> UserSearchUsersWithHttpInfo (UserSearchUsers userSearchUsers);

        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userSearchUsers"></param>
        /// <returns>Task of QueryResult</returns>
        System.Threading.Tasks.Task<QueryResult> UserSearchUsersAsync (UserSearchUsers userSearchUsers);

        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userSearchUsers"></param>
        /// <returns>Task of ApiResponse (QueryResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResult>> UserSearchUsersAsyncWithHttpInfo (UserSearchUsers userSearchUsers);
        
        /// <summary>
        /// Set user properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="setUserProperties"></param>
        /// <returns>int?</returns>
        int? UserSetProperties (SetUserProperties setUserProperties);
  
        /// <summary>
        /// Set user properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="setUserProperties"></param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> UserSetPropertiesWithHttpInfo (SetUserProperties setUserProperties);

        /// <summary>
        /// Set user properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="setUserProperties"></param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> UserSetPropertiesAsync (SetUserProperties setUserProperties);

        /// <summary>
        /// Set user properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="setUserProperties"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> UserSetPropertiesAsyncWithHttpInfo (SetUserProperties setUserProperties);
        
        /// <summary>
        /// Set user properties once
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="setUserProperties"></param>
        /// <returns></returns>
        void UserSetPropertiesOnce (SetUserProperties setUserProperties);
  
        /// <summary>
        /// Set user properties once
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="setUserProperties"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UserSetPropertiesOnceWithHttpInfo (SetUserProperties setUserProperties);

        /// <summary>
        /// Set user properties once
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="setUserProperties"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UserSetPropertiesOnceAsync (SetUserProperties setUserProperties);

        /// <summary>
        /// Set user properties once
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="setUserProperties"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UserSetPropertiesOnceAsyncWithHttpInfo (SetUserProperties setUserProperties);
        
        /// <summary>
        /// Unset user property
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userUnsetProperty"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse UserUnsetProperty (UserUnsetProperty userUnsetProperty);
  
        /// <summary>
        /// Unset user property
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userUnsetProperty"></param>
        /// <returns>ApiResponse of JsonResponse</returns>
        ApiResponse<JsonResponse> UserUnsetPropertyWithHttpInfo (UserUnsetProperty userUnsetProperty);

        /// <summary>
        /// Unset user property
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userUnsetProperty"></param>
        /// <returns>Task of JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> UserUnsetPropertyAsync (UserUnsetProperty userUnsetProperty);

        /// <summary>
        /// Unset user property
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userUnsetProperty"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonResponse>> UserUnsetPropertyAsyncWithHttpInfo (UserUnsetProperty userUnsetProperty);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserApi : IUserApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserApi(Configuration configuration = null)
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
        /// Create new user 
        /// </summary>
        /// <param name="userBatchCreate"></param> 
        /// <returns>List&lt;string&gt;</returns>
        public List<string> UserBatchCreate (UserBatchCreate userBatchCreate)
        {
             ApiResponse<List<string>> response = UserBatchCreateWithHttpInfo(userBatchCreate);
             return response.Data;
        }

        /// <summary>
        /// Create new user 
        /// </summary>
        /// <param name="userBatchCreate"></param> 
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > UserBatchCreateWithHttpInfo (UserBatchCreate userBatchCreate)
        {
            
            // verify the required parameter 'userBatchCreate' is set
            if (userBatchCreate == null) throw new ApiException(400, "Missing required parameter 'userBatchCreate' when calling UserBatchCreate");
            
    
            var path_ = "/user/batch/create";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userBatchCreate); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserBatchCreate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserBatchCreate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
    
        /// <summary>
        /// Create new user 
        /// </summary>
        /// <param name="userBatchCreate"></param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> UserBatchCreateAsync (UserBatchCreate userBatchCreate)
        {
             ApiResponse<List<string>> response = await UserBatchCreateAsyncWithHttpInfo(userBatchCreate);
             return response.Data;

        }

        /// <summary>
        /// Create new user 
        /// </summary>
        /// <param name="userBatchCreate"></param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> UserBatchCreateAsyncWithHttpInfo (UserBatchCreate userBatchCreate)
        {
            // verify the required parameter 'userBatchCreate' is set
            if (userBatchCreate == null) throw new ApiException(400, "Missing required parameter 'userBatchCreate' when calling UserBatchCreate");
            
    
            var path_ = "/user/batch/create";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userBatchCreate); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserBatchCreate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserBatchCreate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
        
        /// <summary>
        /// Create new user 
        /// </summary>
        /// <param name="user"></param> 
        /// <returns>string</returns>
        public string UserCreate (User user)
        {
             ApiResponse<string> response = UserCreateWithHttpInfo(user);
             return response.Data;
        }

        /// <summary>
        /// Create new user 
        /// </summary>
        /// <param name="user"></param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > UserCreateWithHttpInfo (User user)
        {
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling UserCreate");
            
    
            var path_ = "/user/create";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(user); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserCreate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserCreate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Create new user 
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> UserCreateAsync (User user)
        {
             ApiResponse<string> response = await UserCreateAsyncWithHttpInfo(user);
             return response.Data;

        }

        /// <summary>
        /// Create new user 
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> UserCreateAsyncWithHttpInfo (User user)
        {
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling UserCreate");
            
    
            var path_ = "/user/create";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(user); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserCreate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserCreate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get events of the user 
        /// </summary>
        /// <param name="userCreateSegment"></param> 
        /// <returns>JsonResponse</returns>
        public JsonResponse UserCreateSegment (UserCreateSegment userCreateSegment)
        {
             ApiResponse<JsonResponse> response = UserCreateSegmentWithHttpInfo(userCreateSegment);
             return response.Data;
        }

        /// <summary>
        /// Get events of the user 
        /// </summary>
        /// <param name="userCreateSegment"></param> 
        /// <returns>ApiResponse of JsonResponse</returns>
        public ApiResponse< JsonResponse > UserCreateSegmentWithHttpInfo (UserCreateSegment userCreateSegment)
        {
            
            // verify the required parameter 'userCreateSegment' is set
            if (userCreateSegment == null) throw new ApiException(400, "Missing required parameter 'userCreateSegment' when calling UserCreateSegment");
            
    
            var path_ = "/user/create_segment";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userCreateSegment); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling UserCreateSegment: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserCreateSegment: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
    
        /// <summary>
        /// Get events of the user 
        /// </summary>
        /// <param name="userCreateSegment"></param>
        /// <returns>Task of JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> UserCreateSegmentAsync (UserCreateSegment userCreateSegment)
        {
             ApiResponse<JsonResponse> response = await UserCreateSegmentAsyncWithHttpInfo(userCreateSegment);
             return response.Data;

        }

        /// <summary>
        /// Get events of the user 
        /// </summary>
        /// <param name="userCreateSegment"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonResponse>> UserCreateSegmentAsyncWithHttpInfo (UserCreateSegment userCreateSegment)
        {
            // verify the required parameter 'userCreateSegment' is set
            if (userCreateSegment == null) throw new ApiException(400, "Missing required parameter 'userCreateSegment' when calling UserCreateSegment");
            
    
            var path_ = "/user/create_segment";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userCreateSegment); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling UserCreateSegment: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserCreateSegment: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
        
        /// <summary>
        /// Get user 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="user"></param> 
        /// <returns>User</returns>
        public User UserGetUser (string project = null, string user = null)
        {
             ApiResponse<User> response = UserGetUserWithHttpInfo(project, user);
             return response.Data;
        }

        /// <summary>
        /// Get user 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="user"></param> 
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > UserGetUserWithHttpInfo (string project = null, string user = null)
        {
            
    
            var path_ = "/user/get";
    
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
            if (user != null) formParams.Add("user", Configuration.ApiClient.ParameterToString(user)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling UserGetUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserGetUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(response, typeof(User)));
            
        }
    
        /// <summary>
        /// Get user 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> UserGetUserAsync (string project = null, string user = null)
        {
             ApiResponse<User> response = await UserGetUserAsyncWithHttpInfo(project, user);
             return response.Data;

        }

        /// <summary>
        /// Get user 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> UserGetUserAsyncWithHttpInfo (string project = null, string user = null)
        {
            
    
            var path_ = "/user/get";
    
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
            if (user != null) formParams.Add("user", Configuration.ApiClient.ParameterToString(user)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling UserGetUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserGetUser: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(response, typeof(User)));
            
        }
        
        /// <summary>
        /// Get events of the user 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="user"></param> 
        /// <param name="limit"></param> 
        /// <param name="offset"></param> 
        /// <returns>List&lt;CollectionEvent&gt;</returns>
        public List<CollectionEvent> UserGetEvents (string project = null, string user = null, int? limit = null, DateTime? offset = null)
        {
             ApiResponse<List<CollectionEvent>> response = UserGetEventsWithHttpInfo(project, user, limit, offset);
             return response.Data;
        }

        /// <summary>
        /// Get events of the user 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="user"></param> 
        /// <param name="limit"></param> 
        /// <param name="offset"></param> 
        /// <returns>ApiResponse of List&lt;CollectionEvent&gt;</returns>
        public ApiResponse< List<CollectionEvent> > UserGetEventsWithHttpInfo (string project = null, string user = null, int? limit = null, DateTime? offset = null)
        {
            
    
            var path_ = "/user/get_events";
    
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
            if (user != null) formParams.Add("user", Configuration.ApiClient.ParameterToString(user)); // form parameter
            if (limit != null) formParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // form parameter
            if (offset != null) formParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling UserGetEvents: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserGetEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<CollectionEvent>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CollectionEvent>) Configuration.ApiClient.Deserialize(response, typeof(List<CollectionEvent>)));
            
        }
    
        /// <summary>
        /// Get events of the user 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns>Task of List&lt;CollectionEvent&gt;</returns>
        public async System.Threading.Tasks.Task<List<CollectionEvent>> UserGetEventsAsync (string project = null, string user = null, int? limit = null, DateTime? offset = null)
        {
             ApiResponse<List<CollectionEvent>> response = await UserGetEventsAsyncWithHttpInfo(project, user, limit, offset);
             return response.Data;

        }

        /// <summary>
        /// Get events of the user 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns>Task of ApiResponse (List&lt;CollectionEvent&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CollectionEvent>>> UserGetEventsAsyncWithHttpInfo (string project = null, string user = null, int? limit = null, DateTime? offset = null)
        {
            
    
            var path_ = "/user/get_events";
    
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
            if (user != null) formParams.Add("user", Configuration.ApiClient.ParameterToString(user)); // form parameter
            if (limit != null) formParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // form parameter
            if (offset != null) formParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling UserGetEvents: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserGetEvents: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<CollectionEvent>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CollectionEvent>) Configuration.ApiClient.Deserialize(response, typeof(List<CollectionEvent>)));
            
        }
        
        /// <summary>
        /// Set user property 
        /// </summary>
        /// <param name="userIncrementProperty"></param> 
        /// <returns>JsonResponse</returns>
        public JsonResponse UserIncrementProperty (UserIncrementProperty userIncrementProperty)
        {
             ApiResponse<JsonResponse> response = UserIncrementPropertyWithHttpInfo(userIncrementProperty);
             return response.Data;
        }

        /// <summary>
        /// Set user property 
        /// </summary>
        /// <param name="userIncrementProperty"></param> 
        /// <returns>ApiResponse of JsonResponse</returns>
        public ApiResponse< JsonResponse > UserIncrementPropertyWithHttpInfo (UserIncrementProperty userIncrementProperty)
        {
            
            // verify the required parameter 'userIncrementProperty' is set
            if (userIncrementProperty == null) throw new ApiException(400, "Missing required parameter 'userIncrementProperty' when calling UserIncrementProperty");
            
    
            var path_ = "/user/increment_property";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userIncrementProperty); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserIncrementProperty: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserIncrementProperty: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
    
        /// <summary>
        /// Set user property 
        /// </summary>
        /// <param name="userIncrementProperty"></param>
        /// <returns>Task of JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> UserIncrementPropertyAsync (UserIncrementProperty userIncrementProperty)
        {
             ApiResponse<JsonResponse> response = await UserIncrementPropertyAsyncWithHttpInfo(userIncrementProperty);
             return response.Data;

        }

        /// <summary>
        /// Set user property 
        /// </summary>
        /// <param name="userIncrementProperty"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonResponse>> UserIncrementPropertyAsyncWithHttpInfo (UserIncrementProperty userIncrementProperty)
        {
            // verify the required parameter 'userIncrementProperty' is set
            if (userIncrementProperty == null) throw new ApiException(400, "Missing required parameter 'userIncrementProperty' when calling UserIncrementProperty");
            
    
            var path_ = "/user/increment_property";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userIncrementProperty); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserIncrementProperty: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserIncrementProperty: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
        
        /// <summary>
        /// Merge user with anonymous id 
        /// </summary>
        /// <param name="userMergeUser"></param> 
        /// <returns>bool?</returns>
        public bool? UserMergeUser (UserMergeUser userMergeUser)
        {
             ApiResponse<bool?> response = UserMergeUserWithHttpInfo(userMergeUser);
             return response.Data;
        }

        /// <summary>
        /// Merge user with anonymous id 
        /// </summary>
        /// <param name="userMergeUser"></param> 
        /// <returns>ApiResponse of bool?</returns>
        public ApiResponse< bool? > UserMergeUserWithHttpInfo (UserMergeUser userMergeUser)
        {
            
            // verify the required parameter 'userMergeUser' is set
            if (userMergeUser == null) throw new ApiException(400, "Missing required parameter 'userMergeUser' when calling UserMergeUser");
            
    
            var path_ = "/user/merge";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userMergeUser); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling UserMergeUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserMergeUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<bool?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (bool?) Configuration.ApiClient.Deserialize(response, typeof(bool?)));
            
        }
    
        /// <summary>
        /// Merge user with anonymous id 
        /// </summary>
        /// <param name="userMergeUser"></param>
        /// <returns>Task of bool?</returns>
        public async System.Threading.Tasks.Task<bool?> UserMergeUserAsync (UserMergeUser userMergeUser)
        {
             ApiResponse<bool?> response = await UserMergeUserAsyncWithHttpInfo(userMergeUser);
             return response.Data;

        }

        /// <summary>
        /// Merge user with anonymous id 
        /// </summary>
        /// <param name="userMergeUser"></param>
        /// <returns>Task of ApiResponse (bool?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<bool?>> UserMergeUserAsyncWithHttpInfo (UserMergeUser userMergeUser)
        {
            // verify the required parameter 'userMergeUser' is set
            if (userMergeUser == null) throw new ApiException(400, "Missing required parameter 'userMergeUser' when calling UserMergeUser");
            
    
            var path_ = "/user/merge";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userMergeUser); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling UserMergeUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserMergeUser: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<bool?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (bool?) Configuration.ApiClient.Deserialize(response, typeof(bool?)));
            
        }
        
        /// <summary>
        /// Get user storage metadata 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>MetadataResponse</returns>
        public MetadataResponse UserGetMetadata (string project = null)
        {
             ApiResponse<MetadataResponse> response = UserGetMetadataWithHttpInfo(project);
             return response.Data;
        }

        /// <summary>
        /// Get user storage metadata 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>ApiResponse of MetadataResponse</returns>
        public ApiResponse< MetadataResponse > UserGetMetadataWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/user/metadata";
    
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
                throw new ApiException (statusCode, "Error calling UserGetMetadata: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserGetMetadata: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<MetadataResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MetadataResponse) Configuration.ApiClient.Deserialize(response, typeof(MetadataResponse)));
            
        }
    
        /// <summary>
        /// Get user storage metadata 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of MetadataResponse</returns>
        public async System.Threading.Tasks.Task<MetadataResponse> UserGetMetadataAsync (string project = null)
        {
             ApiResponse<MetadataResponse> response = await UserGetMetadataAsyncWithHttpInfo(project);
             return response.Data;

        }

        /// <summary>
        /// Get user storage metadata 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (MetadataResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MetadataResponse>> UserGetMetadataAsyncWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/user/metadata";
    
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
                throw new ApiException (statusCode, "Error calling UserGetMetadata: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserGetMetadata: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<MetadataResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MetadataResponse) Configuration.ApiClient.Deserialize(response, typeof(MetadataResponse)));
            
        }
        
        /// <summary>
        /// Search users 
        /// </summary>
        /// <param name="userSearchUsers"></param> 
        /// <returns>QueryResult</returns>
        public QueryResult UserSearchUsers (UserSearchUsers userSearchUsers)
        {
             ApiResponse<QueryResult> response = UserSearchUsersWithHttpInfo(userSearchUsers);
             return response.Data;
        }

        /// <summary>
        /// Search users 
        /// </summary>
        /// <param name="userSearchUsers"></param> 
        /// <returns>ApiResponse of QueryResult</returns>
        public ApiResponse< QueryResult > UserSearchUsersWithHttpInfo (UserSearchUsers userSearchUsers)
        {
            
            // verify the required parameter 'userSearchUsers' is set
            if (userSearchUsers == null) throw new ApiException(400, "Missing required parameter 'userSearchUsers' when calling UserSearchUsers");
            
    
            var path_ = "/user/search";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userSearchUsers); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling UserSearchUsers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserSearchUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueryResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResult) Configuration.ApiClient.Deserialize(response, typeof(QueryResult)));
            
        }
    
        /// <summary>
        /// Search users 
        /// </summary>
        /// <param name="userSearchUsers"></param>
        /// <returns>Task of QueryResult</returns>
        public async System.Threading.Tasks.Task<QueryResult> UserSearchUsersAsync (UserSearchUsers userSearchUsers)
        {
             ApiResponse<QueryResult> response = await UserSearchUsersAsyncWithHttpInfo(userSearchUsers);
             return response.Data;

        }

        /// <summary>
        /// Search users 
        /// </summary>
        /// <param name="userSearchUsers"></param>
        /// <returns>Task of ApiResponse (QueryResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResult>> UserSearchUsersAsyncWithHttpInfo (UserSearchUsers userSearchUsers)
        {
            // verify the required parameter 'userSearchUsers' is set
            if (userSearchUsers == null) throw new ApiException(400, "Missing required parameter 'userSearchUsers' when calling UserSearchUsers");
            
    
            var path_ = "/user/search";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userSearchUsers); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling UserSearchUsers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserSearchUsers: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueryResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResult) Configuration.ApiClient.Deserialize(response, typeof(QueryResult)));
            
        }
        
        /// <summary>
        /// Set user properties 
        /// </summary>
        /// <param name="setUserProperties"></param> 
        /// <returns>int?</returns>
        public int? UserSetProperties (SetUserProperties setUserProperties)
        {
             ApiResponse<int?> response = UserSetPropertiesWithHttpInfo(setUserProperties);
             return response.Data;
        }

        /// <summary>
        /// Set user properties 
        /// </summary>
        /// <param name="setUserProperties"></param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > UserSetPropertiesWithHttpInfo (SetUserProperties setUserProperties)
        {
            
            // verify the required parameter 'setUserProperties' is set
            if (setUserProperties == null) throw new ApiException(400, "Missing required parameter 'setUserProperties' when calling UserSetProperties");
            
    
            var path_ = "/user/set_properties";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(setUserProperties); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserSetProperties: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserSetProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
    
        /// <summary>
        /// Set user properties 
        /// </summary>
        /// <param name="setUserProperties"></param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> UserSetPropertiesAsync (SetUserProperties setUserProperties)
        {
             ApiResponse<int?> response = await UserSetPropertiesAsyncWithHttpInfo(setUserProperties);
             return response.Data;

        }

        /// <summary>
        /// Set user properties 
        /// </summary>
        /// <param name="setUserProperties"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> UserSetPropertiesAsyncWithHttpInfo (SetUserProperties setUserProperties)
        {
            // verify the required parameter 'setUserProperties' is set
            if (setUserProperties == null) throw new ApiException(400, "Missing required parameter 'setUserProperties' when calling UserSetProperties");
            
    
            var path_ = "/user/set_properties";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(setUserProperties); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserSetProperties: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserSetProperties: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
        
        /// <summary>
        /// Set user properties once 
        /// </summary>
        /// <param name="setUserProperties"></param> 
        /// <returns></returns>
        public void UserSetPropertiesOnce (SetUserProperties setUserProperties)
        {
             UserSetPropertiesOnceWithHttpInfo(setUserProperties);
        }

        /// <summary>
        /// Set user properties once 
        /// </summary>
        /// <param name="setUserProperties"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UserSetPropertiesOnceWithHttpInfo (SetUserProperties setUserProperties)
        {
            
            // verify the required parameter 'setUserProperties' is set
            if (setUserProperties == null) throw new ApiException(400, "Missing required parameter 'setUserProperties' when calling UserSetPropertiesOnce");
            
    
            var path_ = "/user/set_properties_once";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(setUserProperties); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserSetPropertiesOnce: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserSetPropertiesOnce: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Set user properties once 
        /// </summary>
        /// <param name="setUserProperties"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UserSetPropertiesOnceAsync (SetUserProperties setUserProperties)
        {
             await UserSetPropertiesOnceAsyncWithHttpInfo(setUserProperties);

        }

        /// <summary>
        /// Set user properties once 
        /// </summary>
        /// <param name="setUserProperties"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UserSetPropertiesOnceAsyncWithHttpInfo (SetUserProperties setUserProperties)
        {
            // verify the required parameter 'setUserProperties' is set
            if (setUserProperties == null) throw new ApiException(400, "Missing required parameter 'setUserProperties' when calling UserSetPropertiesOnce");
            
    
            var path_ = "/user/set_properties_once";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(setUserProperties); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserSetPropertiesOnce: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserSetPropertiesOnce: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Unset user property 
        /// </summary>
        /// <param name="userUnsetProperty"></param> 
        /// <returns>JsonResponse</returns>
        public JsonResponse UserUnsetProperty (UserUnsetProperty userUnsetProperty)
        {
             ApiResponse<JsonResponse> response = UserUnsetPropertyWithHttpInfo(userUnsetProperty);
             return response.Data;
        }

        /// <summary>
        /// Unset user property 
        /// </summary>
        /// <param name="userUnsetProperty"></param> 
        /// <returns>ApiResponse of JsonResponse</returns>
        public ApiResponse< JsonResponse > UserUnsetPropertyWithHttpInfo (UserUnsetProperty userUnsetProperty)
        {
            
            // verify the required parameter 'userUnsetProperty' is set
            if (userUnsetProperty == null) throw new ApiException(400, "Missing required parameter 'userUnsetProperty' when calling UserUnsetProperty");
            
    
            var path_ = "/user/unset_properties";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userUnsetProperty); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserUnsetProperty: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserUnsetProperty: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
    
        /// <summary>
        /// Unset user property 
        /// </summary>
        /// <param name="userUnsetProperty"></param>
        /// <returns>Task of JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> UserUnsetPropertyAsync (UserUnsetProperty userUnsetProperty)
        {
             ApiResponse<JsonResponse> response = await UserUnsetPropertyAsyncWithHttpInfo(userUnsetProperty);
             return response.Data;

        }

        /// <summary>
        /// Unset user property 
        /// </summary>
        /// <param name="userUnsetProperty"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonResponse>> UserUnsetPropertyAsyncWithHttpInfo (UserUnsetProperty userUnsetProperty)
        {
            // verify the required parameter 'userUnsetProperty' is set
            if (userUnsetProperty == null) throw new ApiException(400, "Missing required parameter 'userUnsetProperty' when calling UserUnsetProperty");
            
    
            var path_ = "/user/unset_properties";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userUnsetProperty); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserUnsetProperty: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserUnsetProperty: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
        
    }
    
}
