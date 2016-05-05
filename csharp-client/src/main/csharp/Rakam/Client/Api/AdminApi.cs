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
    public interface IAdminApi
    {
        
        /// <summary>
        /// List installed modules
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        void AdminGetConfigurations ();
  
        /// <summary>
        /// List installed modules
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AdminGetConfigurationsWithHttpInfo ();

        /// <summary>
        /// List installed modules
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AdminGetConfigurationsAsync ();

        /// <summary>
        /// List installed modules
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AdminGetConfigurationsAsyncWithHttpInfo ();
        
        /// <summary>
        /// List installed modules for ui
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        void AdminModules ();
  
        /// <summary>
        /// List installed modules for ui
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AdminModulesWithHttpInfo ();

        /// <summary>
        /// List installed modules for ui
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AdminModulesAsync ();

        /// <summary>
        /// List installed modules for ui
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AdminModulesAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        void AdminGetTypes ();
  
        /// <summary>
        /// Get types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AdminGetTypesWithHttpInfo ();

        /// <summary>
        /// Get types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AdminGetTypesAsync ();

        /// <summary>
        /// Get types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AdminGetTypesAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get collection names
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> ProjectCollections (string project = null);
  
        /// <summary>
        /// Get collection names
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> ProjectCollectionsWithHttpInfo (string project = null);

        /// <summary>
        /// Get collection names
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> ProjectCollectionsAsync (string project = null);

        /// <summary>
        /// Get collection names
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> ProjectCollectionsAsyncWithHttpInfo (string project = null);
        
        /// <summary>
        /// Create project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse ProjectCreateProject (string name = null);
  
        /// <summary>
        /// Create project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <returns>ApiResponse of JsonResponse</returns>
        ApiResponse<JsonResponse> ProjectCreateProjectWithHttpInfo (string name = null);

        /// <summary>
        /// Create project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <returns>Task of JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> ProjectCreateProjectAsync (string name = null);

        /// <summary>
        /// Create project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonResponse>> ProjectCreateProjectAsyncWithHttpInfo (string name = null);
        
        /// <summary>
        /// Delete project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>JsonResponse</returns>
        JsonResponse ProjectDeleteProject (string project = null);
  
        /// <summary>
        /// Delete project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>ApiResponse of JsonResponse</returns>
        ApiResponse<JsonResponse> ProjectDeleteProjectWithHttpInfo (string project = null);

        /// <summary>
        /// Delete project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of JsonResponse</returns>
        System.Threading.Tasks.Task<JsonResponse> ProjectDeleteProjectAsync (string project = null);

        /// <summary>
        /// Delete project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonResponse>> ProjectDeleteProjectAsyncWithHttpInfo (string project = null);
        
        /// <summary>
        /// List created projects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        void ProjectGetProjects ();
  
        /// <summary>
        /// List created projects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ProjectGetProjectsWithHttpInfo ();

        /// <summary>
        /// List created projects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProjectGetProjectsAsync ();

        /// <summary>
        /// List created projects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ProjectGetProjectsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get collection schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>List&lt;Collection&gt;</returns>
        List<Collection> ProjectSchema (string project = null, List<string> names = null);
  
        /// <summary>
        /// Get collection schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>ApiResponse of List&lt;Collection&gt;</returns>
        ApiResponse<List<Collection>> ProjectSchemaWithHttpInfo (string project = null, List<string> names = null);

        /// <summary>
        /// Get collection schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>Task of List&lt;Collection&gt;</returns>
        System.Threading.Tasks.Task<List<Collection>> ProjectSchemaAsync (string project = null, List<string> names = null);

        /// <summary>
        /// Get collection schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>Task of ApiResponse (List&lt;Collection&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Collection>>> ProjectSchemaAsyncWithHttpInfo (string project = null, List<string> names = null);
        
        /// <summary>
        /// Add fields to collections
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="projectAddFieldsToSchema"></param>
        /// <returns>List&lt;SchemaField&gt;</returns>
        List<SchemaField> ProjectAddFieldsToSchema (ProjectAddFieldsToSchema projectAddFieldsToSchema);
  
        /// <summary>
        /// Add fields to collections
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="projectAddFieldsToSchema"></param>
        /// <returns>ApiResponse of List&lt;SchemaField&gt;</returns>
        ApiResponse<List<SchemaField>> ProjectAddFieldsToSchemaWithHttpInfo (ProjectAddFieldsToSchema projectAddFieldsToSchema);

        /// <summary>
        /// Add fields to collections
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="projectAddFieldsToSchema"></param>
        /// <returns>Task of List&lt;SchemaField&gt;</returns>
        System.Threading.Tasks.Task<List<SchemaField>> ProjectAddFieldsToSchemaAsync (ProjectAddFieldsToSchema projectAddFieldsToSchema);

        /// <summary>
        /// Add fields to collections
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="projectAddFieldsToSchema"></param>
        /// <returns>Task of ApiResponse (List&lt;SchemaField&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SchemaField>>> ProjectAddFieldsToSchemaAsyncWithHttpInfo (ProjectAddFieldsToSchema projectAddFieldsToSchema);
        
        /// <summary>
        /// Add fields to collections by transforming other schemas
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="collection"></param>
        /// <param name="schemaType"></param>
        /// <param name="schema"></param>
        /// <returns>List&lt;SchemaField&gt;</returns>
        List<SchemaField> ProjectAddCustomFieldsToSchema (string project = null, string collection = null, string schemaType = null, string schema = null);
  
        /// <summary>
        /// Add fields to collections by transforming other schemas
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="collection"></param>
        /// <param name="schemaType"></param>
        /// <param name="schema"></param>
        /// <returns>ApiResponse of List&lt;SchemaField&gt;</returns>
        ApiResponse<List<SchemaField>> ProjectAddCustomFieldsToSchemaWithHttpInfo (string project = null, string collection = null, string schemaType = null, string schema = null);

        /// <summary>
        /// Add fields to collections by transforming other schemas
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="collection"></param>
        /// <param name="schemaType"></param>
        /// <param name="schema"></param>
        /// <returns>Task of List&lt;SchemaField&gt;</returns>
        System.Threading.Tasks.Task<List<SchemaField>> ProjectAddCustomFieldsToSchemaAsync (string project = null, string collection = null, string schemaType = null, string schema = null);

        /// <summary>
        /// Add fields to collections by transforming other schemas
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="project"></param>
        /// <param name="collection"></param>
        /// <param name="schemaType"></param>
        /// <param name="schema"></param>
        /// <returns>Task of ApiResponse (List&lt;SchemaField&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SchemaField>>> ProjectAddCustomFieldsToSchemaAsyncWithHttpInfo (string project = null, string collection = null, string schemaType = null, string schema = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AdminApi : IAdminApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AdminApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AdminApi(Configuration configuration = null)
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
        /// List installed modules 
        /// </summary>
        /// <returns></returns>
        public void AdminGetConfigurations ()
        {
             AdminGetConfigurationsWithHttpInfo();
        }

        /// <summary>
        /// List installed modules 
        /// </summary>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AdminGetConfigurationsWithHttpInfo ()
        {
            
    
            var path_ = "/admin/configurations";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AdminGetConfigurations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AdminGetConfigurations: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// List installed modules 
        /// </summary>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AdminGetConfigurationsAsync ()
        {
             await AdminGetConfigurationsAsyncWithHttpInfo();

        }

        /// <summary>
        /// List installed modules 
        /// </summary>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AdminGetConfigurationsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/admin/configurations";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AdminGetConfigurations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AdminGetConfigurations: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// List installed modules for ui 
        /// </summary>
        /// <returns></returns>
        public void AdminModules ()
        {
             AdminModulesWithHttpInfo();
        }

        /// <summary>
        /// List installed modules for ui 
        /// </summary>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AdminModulesWithHttpInfo ()
        {
            
    
            var path_ = "/admin/modules";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AdminModules: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AdminModules: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// List installed modules for ui 
        /// </summary>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AdminModulesAsync ()
        {
             await AdminModulesAsyncWithHttpInfo();

        }

        /// <summary>
        /// List installed modules for ui 
        /// </summary>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AdminModulesAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/admin/modules";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AdminModules: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AdminModules: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get types 
        /// </summary>
        /// <returns></returns>
        public void AdminGetTypes ()
        {
             AdminGetTypesWithHttpInfo();
        }

        /// <summary>
        /// Get types 
        /// </summary>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AdminGetTypesWithHttpInfo ()
        {
            
    
            var path_ = "/admin/types";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AdminGetTypes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AdminGetTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Get types 
        /// </summary>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AdminGetTypesAsync ()
        {
             await AdminGetTypesAsyncWithHttpInfo();

        }

        /// <summary>
        /// Get types 
        /// </summary>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AdminGetTypesAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/admin/types";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AdminGetTypes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AdminGetTypes: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get collection names 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>List&lt;string&gt;</returns>
        public List<string> ProjectCollections (string project = null)
        {
             ApiResponse<List<string>> response = ProjectCollectionsWithHttpInfo(project);
             return response.Data;
        }

        /// <summary>
        /// Get collection names 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > ProjectCollectionsWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/project/collection";
    
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
                throw new ApiException (statusCode, "Error calling ProjectCollections: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProjectCollections: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
    
        /// <summary>
        /// Get collection names 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> ProjectCollectionsAsync (string project = null)
        {
             ApiResponse<List<string>> response = await ProjectCollectionsAsyncWithHttpInfo(project);
             return response.Data;

        }

        /// <summary>
        /// Get collection names 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> ProjectCollectionsAsyncWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/project/collection";
    
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
                throw new ApiException (statusCode, "Error calling ProjectCollections: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProjectCollections: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
        
        /// <summary>
        /// Create project 
        /// </summary>
        /// <param name="name"></param> 
        /// <returns>JsonResponse</returns>
        public JsonResponse ProjectCreateProject (string name = null)
        {
             ApiResponse<JsonResponse> response = ProjectCreateProjectWithHttpInfo(name);
             return response.Data;
        }

        /// <summary>
        /// Create project 
        /// </summary>
        /// <param name="name"></param> 
        /// <returns>ApiResponse of JsonResponse</returns>
        public ApiResponse< JsonResponse > ProjectCreateProjectWithHttpInfo (string name = null)
        {
            
    
            var path_ = "/project/create";
    
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
            
            
            
            if (name != null) formParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProjectCreateProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProjectCreateProject: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
    
        /// <summary>
        /// Create project 
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Task of JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> ProjectCreateProjectAsync (string name = null)
        {
             ApiResponse<JsonResponse> response = await ProjectCreateProjectAsyncWithHttpInfo(name);
             return response.Data;

        }

        /// <summary>
        /// Create project 
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonResponse>> ProjectCreateProjectAsyncWithHttpInfo (string name = null)
        {
            
    
            var path_ = "/project/create";
    
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
            
            
            
            if (name != null) formParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProjectCreateProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProjectCreateProject: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
        
        /// <summary>
        /// Delete project 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>JsonResponse</returns>
        public JsonResponse ProjectDeleteProject (string project = null)
        {
             ApiResponse<JsonResponse> response = ProjectDeleteProjectWithHttpInfo(project);
             return response.Data;
        }

        /// <summary>
        /// Delete project 
        /// </summary>
        /// <param name="project"></param> 
        /// <returns>ApiResponse of JsonResponse</returns>
        public ApiResponse< JsonResponse > ProjectDeleteProjectWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/project/delete";
    
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
                throw new ApiException (statusCode, "Error calling ProjectDeleteProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProjectDeleteProject: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
    
        /// <summary>
        /// Delete project 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of JsonResponse</returns>
        public async System.Threading.Tasks.Task<JsonResponse> ProjectDeleteProjectAsync (string project = null)
        {
             ApiResponse<JsonResponse> response = await ProjectDeleteProjectAsyncWithHttpInfo(project);
             return response.Data;

        }

        /// <summary>
        /// Delete project 
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Task of ApiResponse (JsonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonResponse>> ProjectDeleteProjectAsyncWithHttpInfo (string project = null)
        {
            
    
            var path_ = "/project/delete";
    
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
                throw new ApiException (statusCode, "Error calling ProjectDeleteProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProjectDeleteProject: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<JsonResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonResponse) Configuration.ApiClient.Deserialize(response, typeof(JsonResponse)));
            
        }
        
        /// <summary>
        /// List created projects 
        /// </summary>
        /// <returns></returns>
        public void ProjectGetProjects ()
        {
             ProjectGetProjectsWithHttpInfo();
        }

        /// <summary>
        /// List created projects 
        /// </summary>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ProjectGetProjectsWithHttpInfo ()
        {
            
    
            var path_ = "/project/list";
    
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
            
            
            
            
            

            
            // authentication (read_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("read_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["read_key"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ProjectGetProjects: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProjectGetProjects: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// List created projects 
        /// </summary>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProjectGetProjectsAsync ()
        {
             await ProjectGetProjectsAsyncWithHttpInfo();

        }

        /// <summary>
        /// List created projects 
        /// </summary>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ProjectGetProjectsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/project/list";
    
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
            
            
            
            
            

            
            // authentication (read_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("read_key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["read_key"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ProjectGetProjects: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProjectGetProjects: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get collection schema 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="names"></param> 
        /// <returns>List&lt;Collection&gt;</returns>
        public List<Collection> ProjectSchema (string project = null, List<string> names = null)
        {
             ApiResponse<List<Collection>> response = ProjectSchemaWithHttpInfo(project, names);
             return response.Data;
        }

        /// <summary>
        /// Get collection schema 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="names"></param> 
        /// <returns>ApiResponse of List&lt;Collection&gt;</returns>
        public ApiResponse< List<Collection> > ProjectSchemaWithHttpInfo (string project = null, List<string> names = null)
        {
            
    
            var path_ = "/project/schema";
    
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
            if (names != null) formParams.Add("names", Configuration.ApiClient.ParameterToString(names)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProjectSchema: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProjectSchema: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<Collection>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Collection>) Configuration.ApiClient.Deserialize(response, typeof(List<Collection>)));
            
        }
    
        /// <summary>
        /// Get collection schema 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>Task of List&lt;Collection&gt;</returns>
        public async System.Threading.Tasks.Task<List<Collection>> ProjectSchemaAsync (string project = null, List<string> names = null)
        {
             ApiResponse<List<Collection>> response = await ProjectSchemaAsyncWithHttpInfo(project, names);
             return response.Data;

        }

        /// <summary>
        /// Get collection schema 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="names"></param>
        /// <returns>Task of ApiResponse (List&lt;Collection&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Collection>>> ProjectSchemaAsyncWithHttpInfo (string project = null, List<string> names = null)
        {
            
    
            var path_ = "/project/schema";
    
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
            if (names != null) formParams.Add("names", Configuration.ApiClient.ParameterToString(names)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProjectSchema: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProjectSchema: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<Collection>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Collection>) Configuration.ApiClient.Deserialize(response, typeof(List<Collection>)));
            
        }
        
        /// <summary>
        /// Add fields to collections 
        /// </summary>
        /// <param name="projectAddFieldsToSchema"></param> 
        /// <returns>List&lt;SchemaField&gt;</returns>
        public List<SchemaField> ProjectAddFieldsToSchema (ProjectAddFieldsToSchema projectAddFieldsToSchema)
        {
             ApiResponse<List<SchemaField>> response = ProjectAddFieldsToSchemaWithHttpInfo(projectAddFieldsToSchema);
             return response.Data;
        }

        /// <summary>
        /// Add fields to collections 
        /// </summary>
        /// <param name="projectAddFieldsToSchema"></param> 
        /// <returns>ApiResponse of List&lt;SchemaField&gt;</returns>
        public ApiResponse< List<SchemaField> > ProjectAddFieldsToSchemaWithHttpInfo (ProjectAddFieldsToSchema projectAddFieldsToSchema)
        {
            
            // verify the required parameter 'projectAddFieldsToSchema' is set
            if (projectAddFieldsToSchema == null) throw new ApiException(400, "Missing required parameter 'projectAddFieldsToSchema' when calling ProjectAddFieldsToSchema");
            
    
            var path_ = "/project/schema/add";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(projectAddFieldsToSchema); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling ProjectAddFieldsToSchema: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProjectAddFieldsToSchema: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<SchemaField>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SchemaField>) Configuration.ApiClient.Deserialize(response, typeof(List<SchemaField>)));
            
        }
    
        /// <summary>
        /// Add fields to collections 
        /// </summary>
        /// <param name="projectAddFieldsToSchema"></param>
        /// <returns>Task of List&lt;SchemaField&gt;</returns>
        public async System.Threading.Tasks.Task<List<SchemaField>> ProjectAddFieldsToSchemaAsync (ProjectAddFieldsToSchema projectAddFieldsToSchema)
        {
             ApiResponse<List<SchemaField>> response = await ProjectAddFieldsToSchemaAsyncWithHttpInfo(projectAddFieldsToSchema);
             return response.Data;

        }

        /// <summary>
        /// Add fields to collections 
        /// </summary>
        /// <param name="projectAddFieldsToSchema"></param>
        /// <returns>Task of ApiResponse (List&lt;SchemaField&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SchemaField>>> ProjectAddFieldsToSchemaAsyncWithHttpInfo (ProjectAddFieldsToSchema projectAddFieldsToSchema)
        {
            // verify the required parameter 'projectAddFieldsToSchema' is set
            if (projectAddFieldsToSchema == null) throw new ApiException(400, "Missing required parameter 'projectAddFieldsToSchema' when calling ProjectAddFieldsToSchema");
            
    
            var path_ = "/project/schema/add";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(projectAddFieldsToSchema); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling ProjectAddFieldsToSchema: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProjectAddFieldsToSchema: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<SchemaField>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SchemaField>) Configuration.ApiClient.Deserialize(response, typeof(List<SchemaField>)));
            
        }
        
        /// <summary>
        /// Add fields to collections by transforming other schemas 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="collection"></param> 
        /// <param name="schemaType"></param> 
        /// <param name="schema"></param> 
        /// <returns>List&lt;SchemaField&gt;</returns>
        public List<SchemaField> ProjectAddCustomFieldsToSchema (string project = null, string collection = null, string schemaType = null, string schema = null)
        {
             ApiResponse<List<SchemaField>> response = ProjectAddCustomFieldsToSchemaWithHttpInfo(project, collection, schemaType, schema);
             return response.Data;
        }

        /// <summary>
        /// Add fields to collections by transforming other schemas 
        /// </summary>
        /// <param name="project"></param> 
        /// <param name="collection"></param> 
        /// <param name="schemaType"></param> 
        /// <param name="schema"></param> 
        /// <returns>ApiResponse of List&lt;SchemaField&gt;</returns>
        public ApiResponse< List<SchemaField> > ProjectAddCustomFieldsToSchemaWithHttpInfo (string project = null, string collection = null, string schemaType = null, string schema = null)
        {
            
    
            var path_ = "/project/schema/add/custom";
    
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
            if (collection != null) formParams.Add("collection", Configuration.ApiClient.ParameterToString(collection)); // form parameter
            if (schemaType != null) formParams.Add("schema_type", Configuration.ApiClient.ParameterToString(schemaType)); // form parameter
            if (schema != null) formParams.Add("schema", Configuration.ApiClient.ParameterToString(schema)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProjectAddCustomFieldsToSchema: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProjectAddCustomFieldsToSchema: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<SchemaField>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SchemaField>) Configuration.ApiClient.Deserialize(response, typeof(List<SchemaField>)));
            
        }
    
        /// <summary>
        /// Add fields to collections by transforming other schemas 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="collection"></param>
        /// <param name="schemaType"></param>
        /// <param name="schema"></param>
        /// <returns>Task of List&lt;SchemaField&gt;</returns>
        public async System.Threading.Tasks.Task<List<SchemaField>> ProjectAddCustomFieldsToSchemaAsync (string project = null, string collection = null, string schemaType = null, string schema = null)
        {
             ApiResponse<List<SchemaField>> response = await ProjectAddCustomFieldsToSchemaAsyncWithHttpInfo(project, collection, schemaType, schema);
             return response.Data;

        }

        /// <summary>
        /// Add fields to collections by transforming other schemas 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="collection"></param>
        /// <param name="schemaType"></param>
        /// <param name="schema"></param>
        /// <returns>Task of ApiResponse (List&lt;SchemaField&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SchemaField>>> ProjectAddCustomFieldsToSchemaAsyncWithHttpInfo (string project = null, string collection = null, string schemaType = null, string schema = null)
        {
            
    
            var path_ = "/project/schema/add/custom";
    
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
            if (collection != null) formParams.Add("collection", Configuration.ApiClient.ParameterToString(collection)); // form parameter
            if (schemaType != null) formParams.Add("schema_type", Configuration.ApiClient.ParameterToString(schemaType)); // form parameter
            if (schema != null) formParams.Add("schema", Configuration.ApiClient.ParameterToString(schema)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProjectAddCustomFieldsToSchema: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProjectAddCustomFieldsToSchema: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<SchemaField>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SchemaField>) Configuration.ApiClient.Deserialize(response, typeof(List<SchemaField>)));
            
        }
        
    }
    
}
