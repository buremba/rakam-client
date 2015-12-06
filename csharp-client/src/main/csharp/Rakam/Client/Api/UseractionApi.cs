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
    public interface IUseractionApi
    {
        
        /// <summary>
        /// Apply batch operation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="batchSendEmails"></param>
        /// <returns>long?</returns>
        long? BatchSendEmails (BatchSendEmails batchSendEmails);
  
        /// <summary>
        /// Apply batch operation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="batchSendEmails"></param>
        /// <returns>long?</returns>
        System.Threading.Tasks.Task<long?> BatchSendEmailsAsync (BatchSendEmails batchSendEmails);
        
        /// <summary>
        /// Perform action for single user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="send"></param>
        /// <returns>bool?</returns>
        bool? Send (Send send);
  
        /// <summary>
        /// Perform action for single user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="send"></param>
        /// <returns>bool?</returns>
        System.Threading.Tasks.Task<bool?> SendAsync (Send send);
        
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
        Message Send_1 (string project, string fromUser, string toUser, int? parent, string message, long? timestamp);
  
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
        System.Threading.Tasks.Task<Message> Send_1Async (string project, string fromUser, string toUser, int? parent, string message, long? timestamp);
        
        /// <summary>
        /// Apply batch operation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="batchSendMessages"></param>
        /// <returns>long?</returns>
        long? BatchSendMessages (BatchSendMessages batchSendMessages);
  
        /// <summary>
        /// Apply batch operation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="batchSendMessages"></param>
        /// <returns>long?</returns>
        System.Threading.Tasks.Task<long?> BatchSendMessagesAsync (BatchSendMessages batchSendMessages);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UseractionApi : IUseractionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UseractionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UseractionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UseractionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UseractionApi(String basePath)
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
        /// Apply batch operation 
        /// </summary>
        /// <param name="batchSendEmails"></param> 
        /// <returns>long?</returns>            
        public long? BatchSendEmails (BatchSendEmails batchSendEmails)
        {
            
            // verify the required parameter 'batchSendEmails' is set
            if (batchSendEmails == null) throw new ApiException(400, "Missing required parameter 'batchSendEmails' when calling BatchSendEmails");
            
    
            var path = "/user/action/email/batch";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(batchSendEmails); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BatchSendEmails: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BatchSendEmails: " + response.ErrorMessage, response.ErrorMessage);
    
            return (long?) ApiClient.Deserialize(response.Content, typeof(long?), response.Headers);
        }
    
        /// <summary>
        /// Apply batch operation 
        /// </summary>
        /// <param name="batchSendEmails"></param>
        /// <returns>long?</returns>
        public async System.Threading.Tasks.Task<long?> BatchSendEmailsAsync (BatchSendEmails batchSendEmails)
        {
            // verify the required parameter 'batchSendEmails' is set
            if (batchSendEmails == null) throw new ApiException(400, "Missing required parameter 'batchSendEmails' when calling BatchSendEmails");
            
    
            var path = "/user/action/email/batch";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(batchSendEmails); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BatchSendEmails: " + response.Content, response.Content);

            return (long?) ApiClient.Deserialize(response.Content, typeof(long?), response.Headers);
        }
        
        /// <summary>
        /// Perform action for single user 
        /// </summary>
        /// <param name="send"></param> 
        /// <returns>bool?</returns>            
        public bool? Send (Send send)
        {
            
            // verify the required parameter 'send' is set
            if (send == null) throw new ApiException(400, "Missing required parameter 'send' when calling Send");
            
    
            var path = "/user/action/email/single";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(send); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Send: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Send: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
        /// <summary>
        /// Perform action for single user 
        /// </summary>
        /// <param name="send"></param>
        /// <returns>bool?</returns>
        public async System.Threading.Tasks.Task<bool?> SendAsync (Send send)
        {
            // verify the required parameter 'send' is set
            if (send == null) throw new ApiException(400, "Missing required parameter 'send' when calling Send");
            
    
            var path = "/user/action/email/single";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(send); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Send: " + response.Content, response.Content);

            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
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
        public Message Send_1 (string project, string fromUser, string toUser, int? parent, string message, long? timestamp)
        {
            
    
            var path = "/user/action/mailbox/action/mailbox/single";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Send_1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Send_1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Message) ApiClient.Deserialize(response.Content, typeof(Message), response.Headers);
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
        public async System.Threading.Tasks.Task<Message> Send_1Async (string project, string fromUser, string toUser, int? parent, string message, long? timestamp)
        {
            
    
            var path = "/user/action/mailbox/action/mailbox/single";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Send_1: " + response.Content, response.Content);

            return (Message) ApiClient.Deserialize(response.Content, typeof(Message), response.Headers);
        }
        
        /// <summary>
        /// Apply batch operation 
        /// </summary>
        /// <param name="batchSendMessages"></param> 
        /// <returns>long?</returns>            
        public long? BatchSendMessages (BatchSendMessages batchSendMessages)
        {
            
            // verify the required parameter 'batchSendMessages' is set
            if (batchSendMessages == null) throw new ApiException(400, "Missing required parameter 'batchSendMessages' when calling BatchSendMessages");
            
    
            var path = "/user/action/mailbox/batch";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(batchSendMessages); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BatchSendMessages: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BatchSendMessages: " + response.ErrorMessage, response.ErrorMessage);
    
            return (long?) ApiClient.Deserialize(response.Content, typeof(long?), response.Headers);
        }
    
        /// <summary>
        /// Apply batch operation 
        /// </summary>
        /// <param name="batchSendMessages"></param>
        /// <returns>long?</returns>
        public async System.Threading.Tasks.Task<long?> BatchSendMessagesAsync (BatchSendMessages batchSendMessages)
        {
            // verify the required parameter 'batchSendMessages' is set
            if (batchSendMessages == null) throw new ApiException(400, "Missing required parameter 'batchSendMessages' when calling BatchSendMessages");
            
    
            var path = "/user/action/mailbox/batch";
    
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
            
            
            
            
            postBody = ApiClient.Serialize(batchSendMessages); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BatchSendMessages: " + response.Content, response.Content);

            return (long?) ApiClient.Deserialize(response.Content, typeof(long?), response.Headers);
        }
        
    }
    
}
