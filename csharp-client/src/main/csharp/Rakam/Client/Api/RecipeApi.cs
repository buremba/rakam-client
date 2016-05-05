using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Rakam.Client.Client;

namespace Rakam.Client.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRecipeApi
    {
        
        /// <summary>
        /// Export recipe
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        void RecipeExport ();
  
        /// <summary>
        /// Export recipe
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RecipeExportWithHttpInfo ();

        /// <summary>
        /// Export recipe
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RecipeExportAsync ();

        /// <summary>
        /// Export recipe
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RecipeExportAsyncWithHttpInfo ();
        
        /// <summary>
        /// Install recipe
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        void RecipeInstall ();
  
        /// <summary>
        /// Install recipe
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RecipeInstallWithHttpInfo ();

        /// <summary>
        /// Install recipe
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RecipeInstallAsync ();

        /// <summary>
        /// Install recipe
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RecipeInstallAsyncWithHttpInfo ();
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RecipeApi : IRecipeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RecipeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RecipeApi(Configuration configuration = null)
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
        /// Export recipe 
        /// </summary>
        /// <returns></returns>
        public void RecipeExport ()
        {
             RecipeExportWithHttpInfo();
        }

        /// <summary>
        /// Export recipe 
        /// </summary>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RecipeExportWithHttpInfo ()
        {
            
    
            var path_ = "/recipe/export";
    
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
                throw new ApiException (statusCode, "Error calling RecipeExport: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RecipeExport: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Export recipe 
        /// </summary>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RecipeExportAsync ()
        {
             await RecipeExportAsyncWithHttpInfo();

        }

        /// <summary>
        /// Export recipe 
        /// </summary>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RecipeExportAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/recipe/export";
    
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
                throw new ApiException (statusCode, "Error calling RecipeExport: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RecipeExport: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Install recipe 
        /// </summary>
        /// <returns></returns>
        public void RecipeInstall ()
        {
             RecipeInstallWithHttpInfo();
        }

        /// <summary>
        /// Install recipe 
        /// </summary>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RecipeInstallWithHttpInfo ()
        {
            
    
            var path_ = "/recipe/install";
    
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
                throw new ApiException (statusCode, "Error calling RecipeInstall: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RecipeInstall: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Install recipe 
        /// </summary>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RecipeInstallAsync ()
        {
             await RecipeInstallAsyncWithHttpInfo();

        }

        /// <summary>
        /// Install recipe 
        /// </summary>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RecipeInstallAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/recipe/install";
    
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
                throw new ApiException (statusCode, "Error calling RecipeInstall: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RecipeInstall: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
