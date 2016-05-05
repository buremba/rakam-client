require "uri"

module RakamClient
  class ContinuousqueryApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # Create stream
    # 
    # @param continuous_query 
    # @param [Hash] opts the optional parameters
    # @return [JsonResponse]
    def continuous_query_create(continuous_query, opts = {})
      data, status_code, headers = continuous_query_create_with_http_info(continuous_query, opts)
      return data
    end

    # Create stream
    # 
    # @param continuous_query 
    # @param [Hash] opts the optional parameters
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def continuous_query_create_with_http_info(continuous_query, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: ContinuousqueryApi#continuous_query_create ..."
      end
      
      # verify the required parameter 'continuous_query' is set
      fail "Missing the required parameter 'continuous_query' when calling continuous_query_create" if continuous_query.nil?
      
      # resource path
      path = "/continuous-query/create".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(continuous_query)
      

      auth_names = ['master_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: ContinuousqueryApi#continuous_query_create\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Delete stream
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :table_name 
    # @return [JsonResponse]
    def continuous_query_delete(opts = {})
      data, status_code, headers = continuous_query_delete_with_http_info(opts)
      return data
    end

    # Delete stream
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :table_name 
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def continuous_query_delete_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: ContinuousqueryApi#continuous_query_delete ..."
      end
      
      # resource path
      path = "/continuous-query/delete".sub('{format}','json')

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
        @api_client.config.logger.debug "API called: ContinuousqueryApi#continuous_query_delete\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get continuous query
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :table_name 
    # @return [ContinuousQuery]
    def continuous_query_get(opts = {})
      data, status_code, headers = continuous_query_get_with_http_info(opts)
      return data
    end

    # Get continuous query
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :table_name 
    # @return [Array<(ContinuousQuery, Fixnum, Hash)>] ContinuousQuery data, response status code and response headers
    def continuous_query_get_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: ContinuousqueryApi#continuous_query_get ..."
      end
      
      # resource path
      path = "/continuous-query/get".sub('{format}','json')

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
        :return_type => 'ContinuousQuery')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: ContinuousqueryApi#continuous_query_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # List queries
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<ContinuousQuery>]
    def continuous_query_list_queries(opts = {})
      data, status_code, headers = continuous_query_list_queries_with_http_info(opts)
      return data
    end

    # List queries
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<(Array<ContinuousQuery>, Fixnum, Hash)>] Array<ContinuousQuery> data, response status code and response headers
    def continuous_query_list_queries_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: ContinuousqueryApi#continuous_query_list_queries ..."
      end
      
      # resource path
      path = "/continuous-query/list".sub('{format}','json')

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
        :return_type => 'Array<ContinuousQuery>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: ContinuousqueryApi#continuous_query_list_queries\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get query schema
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Array<String>] :names 
    # @return [Array<Collection>]
    def continuous_query_schema(opts = {})
      data, status_code, headers = continuous_query_schema_with_http_info(opts)
      return data
    end

    # Get query schema
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Array<String>] :names 
    # @return [Array<(Array<Collection>, Fixnum, Hash)>] Array<Collection> data, response status code and response headers
    def continuous_query_schema_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: ContinuousqueryApi#continuous_query_schema ..."
      end
      
      # resource path
      path = "/continuous-query/schema".sub('{format}','json')

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
        @api_client.config.logger.debug "API called: ContinuousqueryApi#continuous_query_schema\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Test continuous query
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :query 
    # @return [BOOLEAN]
    def continuous_query_test(opts = {})
      data, status_code, headers = continuous_query_test_with_http_info(opts)
      return data
    end

    # Test continuous query
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :query 
    # @return [Array<(BOOLEAN, Fixnum, Hash)>] BOOLEAN data, response status code and response headers
    def continuous_query_test_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: ContinuousqueryApi#continuous_query_test ..."
      end
      
      # resource path
      path = "/continuous-query/test".sub('{format}','json')

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
      form_params["query"] = opts[:'query'] if opts[:'query']

      # http body (model)
      post_body = nil
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BOOLEAN')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: ContinuousqueryApi#continuous_query_test\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end




