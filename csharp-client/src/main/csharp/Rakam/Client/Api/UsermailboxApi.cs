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
        /// <returns></returns>
        List<List<Message>> Get (string project, string user, int? parent, int? limit, long? offset);
  
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
        /// <returns></returns>
        System.Threading.Tasks.Task<List<List<Message>>> GetAsync (string project, string user, int? parent, int? limit, long? offset);
        
        /// <summary>
        /// Get connected users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns></returns>
        List<Dictionary<string, Object>> GetConnectedUsers (string project);
  
        /// <summary>
        /// Get connected users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns></returns>
        System.Threading.Tasks.Task<List<Dictionary<string, Object>>> GetConnectedUsersAsync (string project);
        
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
        JsonResponse MarkAsRead (string project, string user, List<string> messageIds);
  
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
        System.Threading.Tasks.Task<JsonResponse> MarkAsReadAsync (string project, string user, List<string> messageIds);
        
        /// <summary>
        /// Send mail to user
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
        Message Send (string project, string fromUser, string toUser, int? parent, string message, long? timestamp);
  
        /// <summary>
        /// Send mail to user
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
        System.Threading.Tasks.Task<Message> SendAsync (string project, string fromUser, string toUser, int? parent, string message, long? timestamp);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsermailboxApi : IUsermailboxApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsermailboxApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsermailboxApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsermailboxApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsermailboxApi(String basePath)
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
        /// Get user mailbox Returns the last mails sent to the user
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="user"></param> 
        /// <param name="parent"></param> 
        /// <param name="limit"></param> 
        /// <param name="offset"></param> 
        /// <returns></returns>            
        public List<List<Message>> Get (string project, string user, int? parent, int? limit, long? offset)
        {
            
    
            var path = "/user/mailbox/get";
    
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
            if (parent != null) formParams.Add("parent", ApiClient.ParameterToString(parent)); // form parameter
            if (limit != null) formParams.Add("limit", ApiClient.ParameterToString(limit)); // form parameter
            if (offset != null) formParams.Add("offset", ApiClient.ParameterToString(offset)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Get: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<List<Message>>) ApiClient.Deserialize(response.Content, typeof(List<List<Message>>), response.Headers);
        }
    
        /// <summary>
        /// Get user mailbox Returns the last mails sent to the user
        /// </summary>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="parent"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<List<List<Message>>> GetAsync (string project, string user, int? parent, int? limit, long? offset)
        {
            
    
            var path = "/user/mailbox/get";
    
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
            if (parent != null) formParams.Add("parent", ApiClient.ParameterToString(parent)); // form parameter
            if (limit != null) formParams.Add("limit", ApiClient.ParameterToString(limit)); // form parameter
            if (offset != null) formParams.Add("offset", ApiClient.ParameterToString(offset)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "read_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Get: " + response.Content, response.Content);

            return (List<List<Message>>) ApiClient.Deserialize(response.Content, typeof(List<List<Message>>), response.Headers);
        }
        
        /// <summary>
        /// Get connected users 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns></returns>            
        public List<Dictionary<string, Object>> GetConnectedUsers (string project)
        {
            
    
            var path = "/user/mailbox/getOnlineUsers";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetConnectedUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetConnectedUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Dictionary<string, Object>>) ApiClient.Deserialize(response.Content, typeof(List<Dictionary<string, Object>>), response.Headers);
        }
    
        /// <summary>
        /// Get connected users 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<List<Dictionary<string, Object>>> GetConnectedUsersAsync (string project)
        {
            
    
            var path = "/user/mailbox/getOnlineUsers";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetConnectedUsers: " + response.Content, response.Content);

            return (List<Dictionary<string, Object>>) ApiClient.Deserialize(response.Content, typeof(List<Dictionary<string, Object>>), response.Headers);
        }
        
        /// <summary>
        /// Mark mail as read Marks the specified mails as read.
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="user"></param> 
        /// <param name="messageIds"></param> 
        /// <returns>JsonResponse</returns>            
        public JsonResponse MarkAsRead (string project, string user, List<string> messageIds)
        {
            
    
            var path = "/user/mailbox/mark_as_read";
    
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
            if (messageIds != null) formParams.Add("message_ids", ApiClient.ParameterToString(messageIds)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "write_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarkAsRead: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarkAsRead: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonResponse) ApiClient.Deserialize(response.Content, typeof(JsonResponse), response.Headers);
        }
    
        /// <summary>
        /// Mark mail as read Marks the specified mails as read.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="user"></param>
        /// <param name="messageIds"></param>
        /// <returns>JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> MarkAsReadAsync (string project, string user, List<string> messageIds)
        {
            
    
            var path = "/user/mailbox/mark_as_read";
    
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
            if (messageIds != null) formParams.Add("message_ids", ApiClient.ParameterToString(messageIds)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "write_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarkAsRead: " + response.Content, response.Content);

            return (JsonResponse) ApiClient.Deserialize(response.Content, typeof(JsonResponse), response.Headers);
        }
        
        /// <summary>
        /// Send mail to user Sends a mail to users mailbox
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="fromUser"></param> 
        /// <param name="toUser"></param> 
        /// <param name="parent"></param> 
        /// <param name="message"></param> 
        /// <param name="timestamp"></param> 
        /// <returns>Message</returns>            
        public Message Send (string project, string fromUser, string toUser, int? parent, string message, long? timestamp)
        {
            
    
            var path = "/user/mailbox/send";
    
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
            if (fromUser != null) formParams.Add("from_user", ApiClient.ParameterToString(fromUser)); // form parameter
            if (toUser != null) formParams.Add("to_user", ApiClient.ParameterToString(toUser)); // form parameter
            if (parent != null) formParams.Add("parent", ApiClient.ParameterToString(parent)); // form parameter
            if (message != null) formParams.Add("message", ApiClient.ParameterToString(message)); // form parameter
            if (timestamp != null) formParams.Add("timestamp", ApiClient.ParameterToString(timestamp)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "write_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Send: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Send: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Message) ApiClient.Deserialize(response.Content, typeof(Message), response.Headers);
        }
    
        /// <summary>
        /// Send mail to user Sends a mail to users mailbox
        /// </summary>
        /// <param name="project"></param>
        /// <param name="fromUser"></param>
        /// <param name="toUser"></param>
        /// <param name="parent"></param>
        /// <param name="message"></param>
        /// <param name="timestamp"></param>
        /// <returns>Message</returns>
        public async System.Threading.Tasks.Task<Message> SendAsync (string project, string fromUser, string toUser, int? parent, string message, long? timestamp)
        {
            
    
            var path = "/user/mailbox/send";
    
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
            if (fromUser != null) formParams.Add("from_user", ApiClient.ParameterToString(fromUser)); // form parameter
            if (toUser != null) formParams.Add("to_user", ApiClient.ParameterToString(toUser)); // form parameter
            if (parent != null) formParams.Add("parent", ApiClient.ParameterToString(parent)); // form parameter
            if (message != null) formParams.Add("message", ApiClient.ParameterToString(message)); // form parameter
            if (timestamp != null) formParams.Add("timestamp", ApiClient.ParameterToString(timestamp)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "write_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Send: " + response.Content, response.Content);

            return (Message) ApiClient.Deserialize(response.Content, typeof(Message), response.Headers);
        }
        
    }
    
}
