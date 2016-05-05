require "uri"

module RakamClient
  class AdminApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # List installed modules
    # 
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def admin_get_configurations(opts = {})
      admin_get_configurations_with_http_info(opts)
      return nil
    end

    # List installed modules
    # 
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Fixnum, Hash)>] nil, response status code and response headers
    def admin_get_configurations_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AdminApi#admin_get_configurations ..."
      end
      
      # resource path
      path = "/admin/configurations".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = ['master_key']
      data, status_code, headers = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AdminApi#admin_get_configurations\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # List installed modules for ui
    # 
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def admin_modules(opts = {})
      admin_modules_with_http_info(opts)
      return nil
    end

    # List installed modules for ui
    # 
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Fixnum, Hash)>] nil, response status code and response headers
    def admin_modules_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AdminApi#admin_modules ..."
      end
      
      # resource path
      path = "/admin/modules".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = ['master_key']
      data, status_code, headers = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AdminApi#admin_modules\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get types
    # 
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def admin_get_types(opts = {})
      admin_get_types_with_http_info(opts)
      return nil
    end

    # Get types
    # 
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Fixnum, Hash)>] nil, response status code and response headers
    def admin_get_types_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AdminApi#admin_get_types ..."
      end
      
      # resource path
      path = "/admin/types".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = ['master_key']
      data, status_code, headers = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AdminApi#admin_get_types\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get collection names
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<String>]
    def project_collections(opts = {})
      data, status_code, headers = project_collections_with_http_info(opts)
      return data
    end

    # Get collection names
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<(Array<String>, Fixnum, Hash)>] Array<String> data, response status code and response headers
    def project_collections_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AdminApi#project_collections ..."
      end
      
      # resource path
      path = "/project/collection".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}
      form_params["project"] = opts[:'project'] if opts[:'project']

      # http body (model)
      post_body = nil
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<String>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AdminApi#project_collections\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Create project
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :name 
    # @return [JsonResponse]
    def project_create_project(opts = {})
      data, status_code, headers = project_create_project_with_http_info(opts)
      return data
    end

    # Create project
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :name 
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def project_create_project_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AdminApi#project_create_project ..."
      end
      
      # resource path
      path = "/project/create".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}
      form_params["name"] = opts[:'name'] if opts[:'name']

      # http body (model)
      post_body = nil
      

      auth_names = ['master_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AdminApi#project_create_project\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Delete project
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [JsonResponse]
    def project_delete_project(opts = {})
      data, status_code, headers = project_delete_project_with_http_info(opts)
      return data
    end

    # Delete project
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def project_delete_project_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AdminApi#project_delete_project ..."
      end
      
      # resource path
      path = "/project/delete".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}
      form_params["project"] = opts[:'project'] if opts[:'project']

      # http body (model)
      post_body = nil
      

      auth_names = ['master_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AdminApi#project_delete_project\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # List created projects
    # 
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def project_get_projects(opts = {})
      project_get_projects_with_http_info(opts)
      return nil
    end

    # List created projects
    # 
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Fixnum, Hash)>] nil, response status code and response headers
    def project_get_projects_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AdminApi#project_get_projects ..."
      end
      
      # resource path
      path = "/project/list".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AdminApi#project_get_projects\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get collection schema
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Array<String>] :names 
    # @return [Array<Collection>]
    def project_schema(opts = {})
      data, status_code, headers = project_schema_with_http_info(opts)
      return data
    end

    # Get collection schema
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Array<String>] :names 
    # @return [Array<(Array<Collection>, Fixnum, Hash)>] Array<Collection> data, response status code and response headers
    def project_schema_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AdminApi#project_schema ..."
      end
      
      # resource path
      path = "/project/schema".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}
      form_params["project"] = opts[:'project'] if opts[:'project']
      form_params["names"] = @api_client.build_collection_param(opts[:'names'], :multi) if opts[:'names']

      # http body (model)
      post_body = nil
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<Collection>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AdminApi#project_schema\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Add fields to collections
    # 
    # @param project_add_fields_to_schema 
    # @param [Hash] opts the optional parameters
    # @return [Array<SchemaField>]
    def project_add_fields_to_schema(project_add_fields_to_schema, opts = {})
      data, status_code, headers = project_add_fields_to_schema_with_http_info(project_add_fields_to_schema, opts)
      return data
    end

    # Add fields to collections
    # 
    # @param project_add_fields_to_schema 
    # @param [Hash] opts the optional parameters
    # @return [Array<(Array<SchemaField>, Fixnum, Hash)>] Array<SchemaField> data, response status code and response headers
    def project_add_fields_to_schema_with_http_info(project_add_fields_to_schema, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AdminApi#project_add_fields_to_schema ..."
      end
      
      # verify the required parameter 'project_add_fields_to_schema' is set
      fail "Missing the required parameter 'project_add_fields_to_schema' when calling project_add_fields_to_schema" if project_add_fields_to_schema.nil?
      
      # resource path
      path = "/project/schema/add".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(project_add_fields_to_schema)
      

      auth_names = ['master_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<SchemaField>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AdminApi#project_add_fields_to_schema\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Add fields to collections by transforming other schemas
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :collection 
    # @option opts [String] :schema_type 
    # @option opts [String] :schema 
    # @return [Array<SchemaField>]
    def project_add_custom_fields_to_schema(opts = {})
      data, status_code, headers = project_add_custom_fields_to_schema_with_http_info(opts)
      return data
    end

    # Add fields to collections by transforming other schemas
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :collection 
    # @option opts [String] :schema_type 
    # @option opts [String] :schema 
    # @return [Array<(Array<SchemaField>, Fixnum, Hash)>] Array<SchemaField> data, response status code and response headers
    def project_add_custom_fields_to_schema_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AdminApi#project_add_custom_fields_to_schema ..."
      end
      
      # resource path
      path = "/project/schema/add/custom".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}
      form_params["project"] = opts[:'project'] if opts[:'project']
      form_params["collection"] = opts[:'collection'] if opts[:'collection']
      form_params["schema_type"] = opts[:'schema_type'] if opts[:'schema_type']
      form_params["schema"] = opts[:'schema'] if opts[:'schema']

      # http body (model)
      post_body = nil
      

      auth_names = ['master_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<SchemaField>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AdminApi#project_add_custom_fields_to_schema\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end




