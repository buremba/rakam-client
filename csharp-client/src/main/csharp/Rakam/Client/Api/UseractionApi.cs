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
    public interface IUseractionApi
    {
        
        /// <summary>
        /// Apply batch operation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userEmailActionBatch"></param>
        /// <returns>long?</returns>
        long? UserEmailActionBatch (UserEmailActionBatch userEmailActionBatch);
  
        /// <summary>
        /// Apply batch operation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userEmailActionBatch"></param>
        /// <returns>ApiResponse of long?</returns>
        ApiResponse<long?> UserEmailActionBatchWithHttpInfo (UserEmailActionBatch userEmailActionBatch);

        /// <summary>
        /// Apply batch operation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userEmailActionBatch"></param>
        /// <returns>Task of long?</returns>
        System.Threading.Tasks.Task<long?> UserEmailActionBatchAsync (UserEmailActionBatch userEmailActionBatch);

        /// <summary>
        /// Apply batch operation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userEmailActionBatch"></param>
        /// <returns>Task of ApiResponse (long?)</returns>
        System.Threading.Tasks.Task<ApiResponse<long?>> UserEmailActionBatchAsyncWithHttpInfo (UserEmailActionBatch userEmailActionBatch);
        
        /// <summary>
        /// Perform action for single user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userEmailActionSend"></param>
        /// <returns>bool?</returns>
        bool? UserEmailActionSend (UserEmailActionSend userEmailActionSend);
  
        /// <summary>
        /// Perform action for single user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userEmailActionSend"></param>
        /// <returns>ApiResponse of bool?</returns>
        ApiResponse<bool?> UserEmailActionSendWithHttpInfo (UserEmailActionSend userEmailActionSend);

        /// <summary>
        /// Perform action for single user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userEmailActionSend"></param>
        /// <returns>Task of bool?</returns>
        System.Threading.Tasks.Task<bool?> UserEmailActionSendAsync (UserEmailActionSend userEmailActionSend);

        /// <summary>
        /// Perform action for single user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userEmailActionSend"></param>
        /// <returns>Task of ApiResponse (bool?)</returns>
        System.Threading.Tasks.Task<ApiResponse<bool?>> UserEmailActionSendAsyncWithHttpInfo (UserEmailActionSend userEmailActionSend);
        
        /// <summary>
        /// Send message to user
        /// </summary>
        /// <remarks>
        /// Sends a mail to users mailbox
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="fromUser"></param>
        /// <param name="toUser"></param>
        /// <param name="parent"></param>
        /// <param name="message"></param>
        /// <param name="timestamp"></param>
        /// <returns>Message</returns>
        Message UserMailboxActionSend (string project = null, string fromUser = null, string toUser = null, int? parent = null, string message = null, long? timestamp = null);
  
        /// <summary>
        /// Send message to user
        /// </summary>
        /// <remarks>
        /// Sends a mail to users mailbox
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="fromUser"></param>
        /// <param name="toUser"></param>
        /// <param name="parent"></param>
        /// <param name="message"></param>
        /// <param name="timestamp"></param>
        /// <returns>ApiResponse of Message</returns>
        ApiResponse<Message> UserMailboxActionSendWithHttpInfo (string project = null, string fromUser = null, string toUser = null, int? parent = null, string message = null, long? timestamp = null);

        /// <summary>
        /// Send message to user
        /// </summary>
        /// <remarks>
        /// Sends a mail to users mailbox
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="fromUser"></param>
        /// <param name="toUser"></param>
        /// <param name="parent"></param>
        /// <param name="message"></param>
        /// <param name="timestamp"></param>
        /// <returns>Task of Message</returns>
        System.Threading.Tasks.Task<Message> UserMailboxActionSendAsync (string project = null, string fromUser = null, string toUser = null, int? parent = null, string message = null, long? timestamp = null);

        /// <summary>
        /// Send message to user
        /// </summary>
        /// <remarks>
        /// Sends a mail to users mailbox
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="fromUser"></param>
        /// <param name="toUser"></param>
        /// <param name="parent"></param>
        /// <param name="message"></param>
        /// <param name="timestamp"></param>
        /// <returns>Task of ApiResponse (Message)</returns>
        System.Threading.Tasks.Task<ApiResponse<Message>> UserMailboxActionSendAsyncWithHttpInfo (string project = null, string fromUser = null, string toUser = null, int? parent = null, string message = null, long? timestamp = null);
        
        /// <summary>
        /// Apply batch operation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userMailboxActionBatchSendMessages"></param>
        /// <returns>long?</returns>
        long? UserMailboxActionBatchSendMessages (UserMailboxActionBatchSendMessages userMailboxActionBatchSendMessages);
  
        /// <summary>
        /// Apply batch operation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userMailboxActionBatchSendMessages"></param>
        /// <returns>ApiResponse of long?</returns>
        ApiResponse<long?> UserMailboxActionBatchSendMessagesWithHttpInfo (UserMailboxActionBatchSendMessages userMailboxActionBatchSendMessages);

        /// <summary>
        /// Apply batch operation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userMailboxActionBatchSendMessages"></param>
        /// <returns>Task of long?</returns>
        System.Threading.Tasks.Task<long?> UserMailboxActionBatchSendMessagesAsync (UserMailboxActionBatchSendMessages userMailboxActionBatchSendMessages);

        /// <summary>
        /// Apply batch operation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userMailboxActionBatchSendMessages"></param>
        /// <returns>Task of ApiResponse (long?)</returns>
        System.Threading.Tasks.Task<ApiResponse<long?>> UserMailboxActionBatchSendMessagesAsyncWithHttpInfo (UserMailboxActionBatchSendMessages userMailboxActionBatchSendMessages);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UseractionApi : IUseractionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UseractionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UseractionApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UseractionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UseractionApi(Configuration configuration = null)
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
        /// Apply batch operation 
        /// </summary>
        /// <param name="userEmailActionBatch"></param> 
        /// <returns>long?</returns>
        public long? UserEmailActionBatch (UserEmailActionBatch userEmailActionBatch)
        {
             ApiResponse<long?> response = UserEmailActionBatchWithHttpInfo(userEmailActionBatch);
             return response.Data;
        }

        /// <summary>
        /// Apply batch operation 
        /// </summary>
        /// <param name="userEmailActionBatch"></param> 
        /// <returns>ApiResponse of long?</returns>
        public ApiResponse< long? > UserEmailActionBatchWithHttpInfo (UserEmailActionBatch userEmailActionBatch)
        {
            
            // verify the required parameter 'userEmailActionBatch' is set
            if (userEmailActionBatch == null) throw new ApiException(400, "Missing required parameter 'userEmailActionBatch' when calling UserEmailActionBatch");
            
    
            var path_ = "/user/action/email/batch";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userEmailActionBatch); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling UserEmailActionBatch: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserEmailActionBatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<long?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (long?) Configuration.ApiClient.Deserialize(response, typeof(long?)));
            
        }
    
        /// <summary>
        /// Apply batch operation 
        /// </summary>
        /// <param name="userEmailActionBatch"></param>
        /// <returns>Task of long?</returns>
        public async System.Threading.Tasks.Task<long?> UserEmailActionBatchAsync (UserEmailActionBatch userEmailActionBatch)
        {
             ApiResponse<long?> response = await UserEmailActionBatchAsyncWithHttpInfo(userEmailActionBatch);
             return response.Data;

        }

        /// <summary>
        /// Apply batch operation 
        /// </summary>
        /// <param name="userEmailActionBatch"></param>
        /// <returns>Task of ApiResponse (long?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<long?>> UserEmailActionBatchAsyncWithHttpInfo (UserEmailActionBatch userEmailActionBatch)
        {
            // verify the required parameter 'userEmailActionBatch' is set
            if (userEmailActionBatch == null) throw new ApiException(400, "Missing required parameter 'userEmailActionBatch' when calling UserEmailActionBatch");
            
    
            var path_ = "/user/action/email/batch";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userEmailActionBatch); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling UserEmailActionBatch: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserEmailActionBatch: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<long?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (long?) Configuration.ApiClient.Deserialize(response, typeof(long?)));
            
        }
        
        /// <summary>
        /// Perform action for single user 
        /// </summary>
        /// <param name="userEmailActionSend"></param> 
        /// <returns>bool?</returns>
        public bool? UserEmailActionSend (UserEmailActionSend userEmailActionSend)
        {
             ApiResponse<bool?> response = UserEmailActionSendWithHttpInfo(userEmailActionSend);
             return response.Data;
        }

        /// <summary>
        /// Perform action for single user 
        /// </summary>
        /// <param name="userEmailActionSend"></param> 
        /// <returns>ApiResponse of bool?</returns>
        public ApiResponse< bool? > UserEmailActionSendWithHttpInfo (UserEmailActionSend userEmailActionSend)
        {
            
            // verify the required parameter 'userEmailActionSend' is set
            if (userEmailActionSend == null) throw new ApiException(400, "Missing required parameter 'userEmailActionSend' when calling UserEmailActionSend");
            
    
            var path_ = "/user/action/email/single";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userEmailActionSend); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling UserEmailActionSend: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserEmailActionSend: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<bool?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (bool?) Configuration.ApiClient.Deserialize(response, typeof(bool?)));
            
        }
    
        /// <summary>
        /// Perform action for single user 
        /// </summary>
        /// <param name="userEmailActionSend"></param>
        /// <returns>Task of bool?</returns>
        public async System.Threading.Tasks.Task<bool?> UserEmailActionSendAsync (UserEmailActionSend userEmailActionSend)
        {
             ApiResponse<bool?> response = await UserEmailActionSendAsyncWithHttpInfo(userEmailActionSend);
             return response.Data;

        }

        /// <summary>
        /// Perform action for single user 
        /// </summary>
        /// <param name="userEmailActionSend"></param>
        /// <returns>Task of ApiResponse (bool?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<bool?>> UserEmailActionSendAsyncWithHttpInfo (UserEmailActionSend userEmailActionSend)
        {
            // verify the required parameter 'userEmailActionSend' is set
            if (userEmailActionSend == null) throw new ApiException(400, "Missing required parameter 'userEmailActionSend' when calling UserEmailActionSend");
            
    
            var path_ = "/user/action/email/single";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userEmailActionSend); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling UserEmailActionSend: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserEmailActionSend: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<bool?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (bool?) Configuration.ApiClient.Deserialize(response, typeof(bool?)));
            
        }
        
        /// <summary>
        /// Send message to user Sends a mail to users mailbox
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="fromUser"></param> 
        /// <param name="toUser"></param> 
        /// <param name="parent"></param> 
        /// <param name="message"></param> 
        /// <param name="timestamp"></param> 
        /// <returns>Message</returns>
        public Message UserMailboxActionSend (string project = null, string fromUser = null, string toUser = null, int? parent = null, string message = null, long? timestamp = null)
        {
             ApiResponse<Message> response = UserMailboxActionSendWithHttpInfo(project, fromUser, toUser, parent, message, timestamp);
             return response.Data;
        }

        /// <summary>
        /// Send message to user Sends a mail to users mailbox
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="fromUser"></param> 
        /// <param name="toUser"></param> 
        /// <param name="parent"></param> 
        /// <param name="message"></param> 
        /// <param name="timestamp"></param> 
        /// <returns>ApiResponse of Message</returns>
        public ApiResponse< Message > UserMailboxActionSendWithHttpInfo (string project = null, string fromUser = null, string toUser = null, int? parent = null, string message = null, long? timestamp = null)
        {
            
    
            var path_ = "/user/action/mailbox/action/mailbox/single";
    
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
            if (fromUser != null) formParams.Add("from_user", Configuration.ApiClient.ParameterToString(fromUser)); // form parameter
            if (toUser != null) formParams.Add("to_user", Configuration.ApiClient.ParameterToString(toUser)); // form parameter
            if (parent != null) formParams.Add("parent", Configuration.ApiClient.ParameterToString(parent)); // form parameter
            if (message != null) formParams.Add("message", Configuration.ApiClient.ParameterToString(message)); // form parameter
            if (timestamp != null) formParams.Add("timestamp", Configuration.ApiClient.ParameterToString(timestamp)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling UserMailboxActionSend: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserMailboxActionSend: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Message>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Message) Configuration.ApiClient.Deserialize(response, typeof(Message)));
            
        }
    
        /// <summary>
        /// Send message to user Sends a mail to users mailbox
        /// </summary>
        /// <param name="project"></param>
        /// <param name="fromUser"></param>
        /// <param name="toUser"></param>
        /// <param name="parent"></param>
        /// <param name="message"></param>
        /// <param name="timestamp"></param>
        /// <returns>Task of Message</returns>
        public async System.Threading.Tasks.Task<Message> UserMailboxActionSendAsync (string project = null, string fromUser = null, string toUser = null, int? parent = null, string message = null, long? timestamp = null)
        {
             ApiResponse<Message> response = await UserMailboxActionSendAsyncWithHttpInfo(project, fromUser, toUser, parent, message, timestamp);
             return response.Data;

        }

        /// <summary>
        /// Send message to user Sends a mail to users mailbox
        /// </summary>
        /// <param name="project"></param>
        /// <param name="fromUser"></param>
        /// <param name="toUser"></param>
        /// <param name="parent"></param>
        /// <param name="message"></param>
        /// <param name="timestamp"></param>
        /// <returns>Task of ApiResponse (Message)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Message>> UserMailboxActionSendAsyncWithHttpInfo (string project = null, string fromUser = null, string toUser = null, int? parent = null, string message = null, long? timestamp = null)
        {
            
    
            var path_ = "/user/action/mailbox/action/mailbox/single";
    
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
            if (fromUser != null) formParams.Add("from_user", Configuration.ApiClient.ParameterToString(fromUser)); // form parameter
            if (toUser != null) formParams.Add("to_user", Configuration.ApiClient.ParameterToString(toUser)); // form parameter
            if (parent != null) formParams.Add("parent", Configuration.ApiClient.ParameterToString(parent)); // form parameter
            if (message != null) formParams.Add("message", Configuration.ApiClient.ParameterToString(message)); // form parameter
            if (timestamp != null) formParams.Add("timestamp", Configuration.ApiClient.ParameterToString(timestamp)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling UserMailboxActionSend: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserMailboxActionSend: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Message>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Message) Configuration.ApiClient.Deserialize(response, typeof(Message)));
            
        }
        
        /// <summary>
        /// Apply batch operation 
        /// </summary>
        /// <param name="userMailboxActionBatchSendMessages"></param> 
        /// <returns>long?</returns>
        public long? UserMailboxActionBatchSendMessages (UserMailboxActionBatchSendMessages userMailboxActionBatchSendMessages)
        {
             ApiResponse<long?> response = UserMailboxActionBatchSendMessagesWithHttpInfo(userMailboxActionBatchSendMessages);
             return response.Data;
        }

        /// <summary>
        /// Apply batch operation 
        /// </summary>
        /// <param name="userMailboxActionBatchSendMessages"></param> 
        /// <returns>ApiResponse of long?</returns>
        public ApiResponse< long? > UserMailboxActionBatchSendMessagesWithHttpInfo (UserMailboxActionBatchSendMessages userMailboxActionBatchSendMessages)
        {
            
            // verify the required parameter 'userMailboxActionBatchSendMessages' is set
            if (userMailboxActionBatchSendMessages == null) throw new ApiException(400, "Missing required parameter 'userMailboxActionBatchSendMessages' when calling UserMailboxActionBatchSendMessages");
            
    
            var path_ = "/user/action/mailbox/batch";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userMailboxActionBatchSendMessages); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling UserMailboxActionBatchSendMessages: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserMailboxActionBatchSendMessages: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<long?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (long?) Configuration.ApiClient.Deserialize(response, typeof(long?)));
            
        }
    
        /// <summary>
        /// Apply batch operation 
        /// </summary>
        /// <param name="userMailboxActionBatchSendMessages"></param>
        /// <returns>Task of long?</returns>
        public async System.Threading.Tasks.Task<long?> UserMailboxActionBatchSendMessagesAsync (UserMailboxActionBatchSendMessages userMailboxActionBatchSendMessages)
        {
             ApiResponse<long?> response = await UserMailboxActionBatchSendMessagesAsyncWithHttpInfo(userMailboxActionBatchSendMessages);
             return response.Data;

        }

        /// <summary>
        /// Apply batch operation 
        /// </summary>
        /// <param name="userMailboxActionBatchSendMessages"></param>
        /// <returns>Task of ApiResponse (long?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<long?>> UserMailboxActionBatchSendMessagesAsyncWithHttpInfo (UserMailboxActionBatchSendMessages userMailboxActionBatchSendMessages)
        {
            // verify the required parameter 'userMailboxActionBatchSendMessages' is set
            if (userMailboxActionBatchSendMessages == null) throw new ApiException(400, "Missing required parameter 'userMailboxActionBatchSendMessages' when calling UserMailboxActionBatchSendMessages");
            
    
            var path_ = "/user/action/mailbox/batch";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(userMailboxActionBatchSendMessages); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling UserMailboxActionBatchSendMessages: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserMailboxActionBatchSendMessages: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<long?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (long?) Configuration.ApiClient.Deserialize(response, typeof(long?)));
            
        }
        
    }
    
}
