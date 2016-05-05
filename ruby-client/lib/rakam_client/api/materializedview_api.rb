require "uri"

module RakamClient
  class MaterializedviewApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # Create view
    # 
    # @param materialized_view 
    # @param [Hash] opts the optional parameters
    # @return [JsonResponse]
    def materialized_view_create(materialized_view, opts = {})
      data, status_code, headers = materialized_view_create_with_http_info(materialized_view, opts)
      return data
    end

    # Create view
    # 
    # @param materialized_view 
    # @param [Hash] opts the optional parameters
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def materialized_view_create_with_http_info(materialized_view, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: MaterializedviewApi#materialized_view_create ..."
      end
      
      # verify the required parameter 'materialized_view' is set
      fail "Missing the required parameter 'materialized_view' when calling materialized_view_create" if materialized_view.nil?
      
      # resource path
      path = "/materialized-view/create".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(materialized_view)
      

      auth_names = ['master_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: MaterializedviewApi#materialized_view_create\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Delete materialized view
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :table_name 
    # @return [JsonResponse]
    def materialized_view_delete(opts = {})
      data, status_code, headers = materialized_view_delete_with_http_info(opts)
      return data
    end

    # Delete materialized view
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :table_name 
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def materialized_view_delete_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: MaterializedviewApi#materialized_view_delete ..."
      end
      
      # resource path
      path = "/materialized-view/delete".sub('{format}','json')

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
      form_params["table_name"] = opts[:'table_name'] if opts[:'table_name']

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
        @api_client.config.logger.debug "API called: MaterializedviewApi#materialized_view_delete\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get view
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :table_name 
    # @return [MaterializedView]
    def materialized_view_get(opts = {})
      data, status_code, headers = materialized_view_get_with_http_info(opts)
      return data
    end

    # Get view
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :table_name 
    # @return [Array<(MaterializedView, Fixnum, Hash)>] MaterializedView data, response status code and response headers
    def materialized_view_get_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: MaterializedviewApi#materialized_view_get ..."
      end
      
      # resource path
      path = "/materialized-view/get".sub('{format}','json')

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
      form_params["table_name"] = opts[:'table_name'] if opts[:'table_name']

      # http body (model)
      post_body = nil
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'MaterializedView')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: MaterializedviewApi#materialized_view_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # List views
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<MaterializedView>]
    def materialized_view_list_views(opts = {})
      data, status_code, headers = materialized_view_list_views_with_http_info(opts)
      return data
    end

    # List views
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<(Array<MaterializedView>, Fixnum, Hash)>] Array<MaterializedView> data, response status code and response headers
    def materialized_view_list_views_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: MaterializedviewApi#materialized_view_list_views ..."
      end
      
      # resource path
      path = "/materialized-view/list".sub('{format}','json')

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
        :return_type => 'Array<MaterializedView>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: MaterializedviewApi#materialized_view_list_views\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get schemas
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Array<String>] :names 
    # @return [Array<MaterializedViewSchema>]
    def materialized_view_schema(opts = {})
      data, status_code, headers = materialized_view_schema_with_http_info(opts)
      return data
    end

    # Get schemas
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Array<String>] :names 
    # @return [Array<(Array<MaterializedViewSchema>, Fixnum, Hash)>] Array<MaterializedViewSchema> data, response status code and response headers
    def materialized_view_schema_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: MaterializedviewApi#materialized_view_schema ..."
      end
      
      # resource path
      path = "/materialized-view/schema".sub('{format}','json')

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
        :return_type => 'Array<MaterializedViewSchema>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: MaterializedviewApi#materialized_view_schema\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Update view
    # 
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def materialized_view_update(opts = {})
      materialized_view_update_with_http_info(opts)
      return nil
    end

    # Update view
    # 
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Fixnum, Hash)>] nil, response status code and response headers
    def materialized_view_update_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: MaterializedviewApi#materialized_view_update ..."
      end
      
      # resource path
      path = "/materialized-view/update".sub('{format}','json')

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
        @api_client.config.logger.debug "API called: MaterializedviewApi#materialized_view_update\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end




