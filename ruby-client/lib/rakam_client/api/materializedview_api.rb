require "uri"

module RakamClient
  class MaterializedviewApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
    end

    # Create view
    # 
    # @param materialized_view 
    # @param [Hash] opts the optional parameters
    # @return [JsonResponse]
    def create(materialized_view, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: MaterializedviewApi#create ..."
      end
      
      # verify the required parameter 'materialized_view' is set
      fail "Missing the required parameter 'materialized_view' when calling create" if materialized_view.nil?
      
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
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: MaterializedviewApi#create. Result: #{result.inspect}"
      end
      return result
    end

    # Delete materialized view
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :name 
    # @return [JsonResponse]
    def delete(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: MaterializedviewApi#delete ..."
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
      form_params["name"] = opts[:'name'] if opts[:'name']

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: MaterializedviewApi#delete. Result: #{result.inspect}"
      end
      return result
    end

    # Get view
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :name 
    # @return [Object]
    def get(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: MaterializedviewApi#get ..."
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
      form_params["name"] = opts[:'name'] if opts[:'name']

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Object')
      if Configuration.debugging
        Configuration.logger.debug "API called: MaterializedviewApi#get. Result: #{result.inspect}"
      end
      return result
    end

    # List views
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Object]
    def list_views(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: MaterializedviewApi#list_views ..."
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
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Object')
      if Configuration.debugging
        Configuration.logger.debug "API called: MaterializedviewApi#list_views. Result: #{result.inspect}"
      end
      return result
    end

    # Get schemas
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<MaterializedViewSchema>]
    def schema(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: MaterializedviewApi#schema ..."
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

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<MaterializedViewSchema>')
      if Configuration.debugging
        Configuration.logger.debug "API called: MaterializedviewApi#schema. Result: #{result.inspect}"
      end
      return result
    end

    # Update view
    # 
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def update(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: MaterializedviewApi#update ..."
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
      

      auth_names = []
      @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names)
      if Configuration.debugging
        Configuration.logger.debug "API called: MaterializedviewApi#update"
      end
      return nil
    end
  end
end




