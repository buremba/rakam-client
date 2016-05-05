require "uri"

module RakamClient
  class RealtimeApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # Create report
    # 
    # @param real_time_report 
    # @param [Hash] opts the optional parameters
    # @return [JsonResponse]
    def realtime_create(real_time_report, opts = {})
      data, status_code, headers = realtime_create_with_http_info(real_time_report, opts)
      return data
    end

    # Create report
    # 
    # @param real_time_report 
    # @param [Hash] opts the optional parameters
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def realtime_create_with_http_info(real_time_report, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: RealtimeApi#realtime_create ..."
      end
      
      # verify the required parameter 'real_time_report' is set
      fail "Missing the required parameter 'real_time_report' when calling realtime_create" if real_time_report.nil?
      
      # resource path
      path = "/realtime/create".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(real_time_report)
      

      auth_names = ['master_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: RealtimeApi#realtime_create\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Delete report
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :table_name 
    # @return [JsonResponse]
    def realtime_delete(opts = {})
      data, status_code, headers = realtime_delete_with_http_info(opts)
      return data
    end

    # Delete report
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :table_name 
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def realtime_delete_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: RealtimeApi#realtime_delete ..."
      end
      
      # resource path
      path = "/realtime/delete".sub('{format}','json')

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
        @api_client.config.logger.debug "API called: RealtimeApi#realtime_delete\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get report
    # 
    # @param realtime_get 
    # @param [Hash] opts the optional parameters
    # @return [RealTimeQueryResult]
    def realtime_get(realtime_get, opts = {})
      data, status_code, headers = realtime_get_with_http_info(realtime_get, opts)
      return data
    end

    # Get report
    # 
    # @param realtime_get 
    # @param [Hash] opts the optional parameters
    # @return [Array<(RealTimeQueryResult, Fixnum, Hash)>] RealTimeQueryResult data, response status code and response headers
    def realtime_get_with_http_info(realtime_get, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: RealtimeApi#realtime_get ..."
      end
      
      # verify the required parameter 'realtime_get' is set
      fail "Missing the required parameter 'realtime_get' when calling realtime_get" if realtime_get.nil?
      
      # resource path
      path = "/realtime/get".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(realtime_get)
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'RealTimeQueryResult')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: RealtimeApi#realtime_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # List queries
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<ContinuousQuery>]
    def realtime_list(opts = {})
      data, status_code, headers = realtime_list_with_http_info(opts)
      return data
    end

    # List queries
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<(Array<ContinuousQuery>, Fixnum, Hash)>] Array<ContinuousQuery> data, response status code and response headers
    def realtime_list_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: RealtimeApi#realtime_list ..."
      end
      
      # resource path
      path = "/realtime/list".sub('{format}','json')

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
        @api_client.config.logger.debug "API called: RealtimeApi#realtime_list\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end




