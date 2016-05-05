require "uri"

module RakamClient
  class AbtestingApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # Create test
    # 
    # @param ab_testing_report 
    # @param [Hash] opts the optional parameters
    # @return [JsonResponse]
    def ab_testing_create(ab_testing_report, opts = {})
      data, status_code, headers = ab_testing_create_with_http_info(ab_testing_report, opts)
      return data
    end

    # Create test
    # 
    # @param ab_testing_report 
    # @param [Hash] opts the optional parameters
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def ab_testing_create_with_http_info(ab_testing_report, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AbtestingApi#ab_testing_create ..."
      end
      
      # verify the required parameter 'ab_testing_report' is set
      fail "Missing the required parameter 'ab_testing_report' when calling ab_testing_create" if ab_testing_report.nil?
      
      # resource path
      path = "/ab-testing/create".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(ab_testing_report)
      

      auth_names = ['master_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AbtestingApi#ab_testing_create\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Delete report
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Integer] :id 
    # @return [JsonResponse]
    def ab_testing_delete(opts = {})
      data, status_code, headers = ab_testing_delete_with_http_info(opts)
      return data
    end

    # Delete report
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Integer] :id 
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def ab_testing_delete_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AbtestingApi#ab_testing_delete ..."
      end
      
      # resource path
      path = "/ab-testing/delete".sub('{format}','json')

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
      form_params["id"] = opts[:'id'] if opts[:'id']

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
        @api_client.config.logger.debug "API called: AbtestingApi#ab_testing_delete\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get report
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Integer] :id 
    # @return [ABTestingReport]
    def ab_testing_get(opts = {})
      data, status_code, headers = ab_testing_get_with_http_info(opts)
      return data
    end

    # Get report
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Integer] :id 
    # @return [Array<(ABTestingReport, Fixnum, Hash)>] ABTestingReport data, response status code and response headers
    def ab_testing_get_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AbtestingApi#ab_testing_get ..."
      end
      
      # resource path
      path = "/ab-testing/get".sub('{format}','json')

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
      form_params["id"] = opts[:'id'] if opts[:'id']

      # http body (model)
      post_body = nil
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'ABTestingReport')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AbtestingApi#ab_testing_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # List reports
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<ABTestingReport>]
    def ab_testing_list(opts = {})
      data, status_code, headers = ab_testing_list_with_http_info(opts)
      return data
    end

    # List reports
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<(Array<ABTestingReport>, Fixnum, Hash)>] Array<ABTestingReport> data, response status code and response headers
    def ab_testing_list_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AbtestingApi#ab_testing_list ..."
      end
      
      # resource path
      path = "/ab-testing/list".sub('{format}','json')

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
        :return_type => 'Array<ABTestingReport>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AbtestingApi#ab_testing_list\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Update report
    # 
    # @param ab_testing_report 
    # @param [Hash] opts the optional parameters
    # @return [ABTestingReport]
    def ab_testing_update(ab_testing_report, opts = {})
      data, status_code, headers = ab_testing_update_with_http_info(ab_testing_report, opts)
      return data
    end

    # Update report
    # 
    # @param ab_testing_report 
    # @param [Hash] opts the optional parameters
    # @return [Array<(ABTestingReport, Fixnum, Hash)>] ABTestingReport data, response status code and response headers
    def ab_testing_update_with_http_info(ab_testing_report, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AbtestingApi#ab_testing_update ..."
      end
      
      # verify the required parameter 'ab_testing_report' is set
      fail "Missing the required parameter 'ab_testing_report' when calling ab_testing_update" if ab_testing_report.nil?
      
      # resource path
      path = "/ab-testing/update".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(ab_testing_report)
      

      auth_names = ['master_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'ABTestingReport')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AbtestingApi#ab_testing_update\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end




