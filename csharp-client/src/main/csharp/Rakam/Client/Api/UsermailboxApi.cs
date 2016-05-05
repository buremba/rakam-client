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
    public interface IUsermailboxApi
    {
        
        /// <summary>
        /// Get user mailbox
        /// </summary>
        /// <remarks>
        /// Returns the last mails sent to the user
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="parent"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns>List&lt;List&lt;Message&gt;&gt;</returns>
        List<List<Message>> UserMailboxGet (string project = null, string user = null, int? parent = null, int? limit = null, long? offset = null);
  
        /// <summary>
        /// Get user mailbox
        /// </summary>
        /// <remarks>
        /// Returns the last mails sent to the user
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="parent"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns>ApiResponse of List&lt;List&lt;Message&gt;&gt;</returns>
        ApiResponse<List<List<Message>>> UserMailboxGetWithHttpInfo (string project = null, string user = null, int? parent = null, int? limit = null, long? offset = null);

        /// <summary>
        /// Get user mailbox
        /// </summary>
        /// <remarks>
        /// Returns the last mails sent to the user
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="parent"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns>Task of List&lt;List&lt;Message&gt;&gt;</returns>
        System.Threading.Tasks.Task<List<List<Message>>> UserMailboxGetAsync (string project = null, string user = null, int? parent = null, int? limit = null, long? offset = null);

        /// <summary>
        /// Get user mailbox
        /// </summary>
        /// <remarks>
        /// Returns the last mails sent to the user
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="parent"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns>Task of ApiResponse (List&lt;List&lt;Message&gt;&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<List<Message>>>> UserMailboxGetAsyncWithHttpInfo (string project = null, string user = null, int? parent = null, int? limit = null, long? offset = null);
        
        /// <summary>
        /// Get connected users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>List&lt;Dictionary&lt;string, Object&gt;&gt;</returns>
        List<Dictionary<string, Object>> UserMailboxGetConnectedUsers (string project = null);
  
        /// <summary>
        /// Get connected users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>ApiResponse of List&lt;Dictionary&lt;string, Object&gt;&gt;</returns>
        ApiResponse<List<Dictionary<string, Object>>> UserMailboxGetConnectedUsersWithHttpInfo (string project = null);

        /// <summary>
        /// Get connected users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of List&lt;Dictionary&lt;string, Object&gt;&gt;</returns>
        System.Threading.Tasks.Task<List<Dictionary<string, Object>>> UserMailboxGetConnectedUsersAsync (string project = null);

        /// <summary>
        /// Get connected users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (List&lt;Dictionary&lt;string, Object&gt;&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Dictionary<string, Object>>>> UserMailboxGetConnectedUsersAsyncWithHttpInfo (string project = null);
        
        /// <summary>
        /// Mark mail as read
        /// </summary>
        /// <remarks>
        /// Marks the specified mails as read.
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="messageIds"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse UserMailboxMarkAsRead (string project = null, string user = null, List<int?> messageIds = null);
  
        /// <summary>
        /// Mark mail as read
        /// </summary>
        /// <remarks>
        /// Marks the specified mails as read.
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="messageIds"></param>
        /// <returns>ApiResponse of JsonResponse</returns>
        ApiResponse<JsonResponse> UserMailboxMarkAsReadWithHttpInfo (string project = null, string user = null, List<int?> messageIds = null);

        /// <summary>
        /// Mark mail as read
        /// </summary>
        /// <remarks>
        /// Marks the specified mails as read.
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="messageIds"></param>
        /// <returns>Task of JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> UserMailboxMarkAsReadAsync (string project = null, string user = null, List<int?> messageIds = null);

        /// <summary>
        /// Mark mail as read
        /// </summary>
        /// <remarks>
        /// Marks the specified mails as read.
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="messageIds"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonResponse>> UserMailboxMarkAsReadAsyncWithHttpInfo (string project = null, string user = null, List<int?> messageIds = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsermailboxApi : IUsermailboxApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsermailboxApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsermailboxApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsermailboxApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsermailboxApi(Configuration configuration = null)
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
        /// Get user mailbox Returns the last mails sent to the user
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="user"></param> 
        /// <param name="parent"></param> 
        /// <param name="limit"></param> 
        /// <param name="offset"></param> 
        /// <returns>List&lt;List&lt;Message&gt;&gt;</returns>
        public List<List<Message>> UserMailboxGet (string project = null, string user = null, int? parent = null, int? limit = null, long? offset = null)
        {
             ApiResponse<List<List<Message>>> response = UserMailboxGetWithHttpInfo(project, user, parent, limit, offset);
             return response.Data;
        }

        /// <summary>
        /// Get user mailbox Returns the last mails sent to the user
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="user"></param> 
        /// <param name="parent"></param> 
        /// <param name="limit"></param> 
        /// <param name="offset"></param> 
        /// <returns>ApiResponse of List&lt;List&lt;Message&gt;&gt;</returns>
        public ApiResponse< List<List<Message>> > UserMailboxGetWithHttpInfo (string project = null, string user = null, int? parent = null, int? limit = null, long? offset = null)
        {
            
    
            var path_ = "/user/mailbox/get";
    
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
            if (parent != null) formParams.Add("parent", Configuration.ApiClient.ParameterToString(parent)); // form parameter
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
                throw new ApiException (statusCode, "Error calling UserMailboxGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserMailboxGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<List<Message>>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<List<Message>>) Configuration.ApiClient.Deserialize(response, typeof(List<List<Message>>)));
            
        }
    
        /// <summary>
        /// Get user mailbox Returns the last mails sent to the user
        /// </summary>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="parent"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns>Task of List&lt;List&lt;Message&gt;&gt;</returns>
        public async System.Threading.Tasks.Task<List<List<Message>>> UserMailboxGetAsync (string project = null, string user = null, int? parent = null, int? limit = null, long? offset = null)
        {
             ApiResponse<List<List<Message>>> response = await UserMailboxGetAsyncWithHttpInfo(project, user, parent, limit, offset);
             return response.Data;

        }

        /// <summary>
        /// Get user mailbox Returns the last mails sent to the user
        /// </summary>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="parent"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns>Task of ApiResponse (List&lt;List&lt;Message&gt;&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<List<Message>>>> UserMailboxGetAsyncWithHttpInfo (string project = null, string user = null, int? parent = null, int? limit = null, long? offset = null)
        {
            
    
            var path_ = "/user/mailbox/get";
    
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
            if (parent != null) formParams.Add("parent", Configuration.ApiClient.ParameterToString(parent)); // form parameter
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
                throw new ApiException (statusCode, "Error calling UserMailboxGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserMailboxGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<List<Message>>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<List<Message>>) Configuration.ApiClient.Deserialize(response, typeof(List<List<Message>>)));
            
        }
        
        /// <summary>
        /// Get connected users 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>List&lt;Dictionary&lt;string, Object&gt;&gt;</returns>
        public List<Dictionary<string, Object>> UserMailboxGetConnectedUsers (string project = null)
        {
             ApiResponse<List<Dictionary<string, Object>>> response = UserMailboxGetConnectedUsersWithHttpInfo(project);
             return response.Data;
        }

        /// <summary>
        /// Get connected users 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>ApiResponse of List&lt;Dictionary&lt;string, Object&gt;&gt;</returns>
        public ApiResponse< List<Dictionary<string, Object>> > UserMailboxGetConnectedUsersWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/user/mailbox/get_online_users";
    
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
                throw new ApiException (statusCode, "Error calling UserMailboxGetConnectedUsers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserMailboxGetConnectedUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<Dictionary<string, Object>>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Dictionary<string, Object>>) Configuration.ApiClient.Deserialize(response, typeof(List<Dictionary<string, Object>>)));
            
        }
    
        /// <summary>
        /// Get connected users 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of List&lt;Dictionary&lt;string, Object&gt;&gt;</returns>
        public async System.Threading.Tasks.Task<List<Dictionary<string, Object>>> UserMailboxGetConnectedUsersAsync (string project = null)
        {
             ApiResponse<List<Dictionary<string, Object>>> response = await UserMailboxGetConnectedUsersAsyncWithHttpInfo(project);
             return response.Data;

        }

        /// <summary>
        /// Get connected users 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (List&lt;Dictionary&lt;string, Object&gt;&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Dictionary<string, Object>>>> UserMailboxGetConnectedUsersAsyncWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/user/mailbox/get_online_users";
    
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
                throw new ApiException (statusCode, "Error calling UserMailboxGetConnectedUsers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserMailboxGetConnectedUsers: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<Dictionary<string, Object>>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Dictionary<string, Object>>) Configuration.ApiClient.Deserialize(response, typeof(List<Dictionary<string, Object>>)));
            
        }
        
        /// <summary>
        /// Mark mail as read Marks the specified mails as read.
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="user"></param> 
        /// <param name="messageIds"></param> 
        /// <returns>JsonResponse</returns>
        public JsonResponse UserMailboxMarkAsRead (string project = null, string user = null, List<int?> messageIds = null)
        {
             ApiResponse<JsonResponse> response = UserMailboxMarkAsReadWithHttpInfo(project, user, messageIds);
             return response.Data;
        }

        /// <summary>
        /// Mark mail as read Marks the specified mails as read.
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="user"></param> 
        /// <param name="messageIds"></param> 
        /// <returns>ApiResponse of JsonResponse</returns>
        public ApiResponse< JsonResponse > UserMailboxMarkAsReadWithHttpInfo (string project = null, string user = null, List<int?> messageIds = null)
        {
            
    
            var path_ = "/user/mailbox/mark_as_read";
    
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
            if (messageIds != null) formParams.Add("message_ids", Configuration.ApiClient.ParameterToString(messageIds)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling UserMailboxMarkAsRead: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserMailboxMarkAsRead: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
    
        /// <summary>
        /// Mark mail as read Marks the specified mails as read.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="messageIds"></param>
        /// <returns>Task of JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> UserMailboxMarkAsReadAsync (string project = null, string user = null, List<int?> messageIds = null)
        {
             ApiResponse<JsonResponse> response = await UserMailboxMarkAsReadAsyncWithHttpInfo(project, user, messageIds);
             return response.Data;

        }

        /// <summary>
        /// Mark mail as read Marks the specified mails as read.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="messageIds"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonResponse>> UserMailboxMarkAsReadAsyncWithHttpInfo (string project = null, string user = null, List<int?> messageIds = null)
        {
            
    
            var path_ = "/user/mailbox/mark_as_read";
    
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
            if (messageIds != null) formParams.Add("message_ids", Configuration.ApiClient.ParameterToString(messageIds)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling UserMailboxMarkAsRead: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserMailboxMarkAsRead: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
        
    }
    
}
