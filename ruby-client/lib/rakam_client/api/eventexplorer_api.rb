require "uri"

module RakamClient
  class EventexplorerApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # Perform simple query on event data
    # 
    # @param analyze_request 
    # @param [Hash] opts the optional parameters
    # @return [QueryResult]
    def event_explorer_analyze(analyze_request, opts = {})
      data, status_code, headers = event_explorer_analyze_with_http_info(analyze_request, opts)
      return data
    end

    # Perform simple query on event data
    # 
    # @param analyze_request 
    # @param [Hash] opts the optional parameters
    # @return [Array<(QueryResult, Fixnum, Hash)>] QueryResult data, response status code and response headers
    def event_explorer_analyze_with_http_info(analyze_request, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: EventexplorerApi#event_explorer_analyze ..."
      end
      
      # verify the required parameter 'analyze_request' is set
      fail "Missing the required parameter 'analyze_request' when calling event_explorer_analyze" if analyze_request.nil?
      
      # resource path
      path = "/event-explorer/analyze".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(analyze_request)
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'QueryResult')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EventexplorerApi#event_explorer_analyze\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Event statistics
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Hash<String, Array<String>>]
    def event_explorer_get_extra_dimensions(opts = {})
      data, status_code, headers = event_explorer_get_extra_dimensions_with_http_info(opts)
      return data
    end

    # Event statistics
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<(Hash<String, Array<String>>, Fixnum, Hash)>] Hash<String, Array<String>> data, response status code and response headers
    def event_explorer_get_extra_dimensions_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: EventexplorerApi#event_explorer_get_extra_dimensions ..."
      end
      
      # resource path
      path = "/event-explorer/extra_dimensions".sub('{format}','json')

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
        :return_type => 'Hash<String, Array<String>>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EventexplorerApi#event_explorer_get_extra_dimensions\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Create Pre-computed table
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Array<String>] :collections 
    # @option opts [Array<String>] :dimensions 
    # @option opts [Array<String>] :aggregations 
    # @option opts [Array<String>] :measures 
    # @option opts [String] :table_name 
    # @return [PreCalculatedTable]
    def event_explorer_create_pre_computed_table(opts = {})
      data, status_code, headers = event_explorer_create_pre_computed_table_with_http_info(opts)
      return data
    end

    # Create Pre-computed table
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Array<String>] :collections 
    # @option opts [Array<String>] :dimensions 
    # @option opts [Array<String>] :aggregations 
    # @option opts [Array<String>] :measures 
    # @option opts [String] :table_name 
    # @return [Array<(PreCalculatedTable, Fixnum, Hash)>] PreCalculatedTable data, response status code and response headers
    def event_explorer_create_pre_computed_table_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: EventexplorerApi#event_explorer_create_pre_computed_table ..."
      end
      
      # resource path
      path = "/event-explorer/pre_calculate".sub('{format}','json')

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
      form_params["collections"] = @api_client.build_collection_param(opts[:'collections'], :multi) if opts[:'collections']
      form_params["dimensions"] = @api_client.build_collection_param(opts[:'dimensions'], :multi) if opts[:'dimensions']
      form_params["aggregations"] = @api_client.build_collection_param(opts[:'aggregations'], :multi) if opts[:'aggregations']
      form_params["measures"] = @api_client.build_collection_param(opts[:'measures'], :multi) if opts[:'measures']
      form_params["tableName"] = opts[:'table_name'] if opts[:'table_name']

      # http body (model)
      post_body = nil
      

      auth_names = ['master_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'PreCalculatedTable')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EventexplorerApi#event_explorer_create_pre_computed_table\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Event statistics
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Array<String>] :collections 
    # @option opts [String] :dimension 
    # @option opts [Date] :start_date 
    # @option opts [Date] :end_date 
    # @return [QueryResult]
    def event_explorer_get_event_statistics(opts = {})
      data, status_code, headers = event_explorer_get_event_statistics_with_http_info(opts)
      return data
    end

    # Event statistics
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Array<String>] :collections 
    # @option opts [String] :dimension 
    # @option opts [Date] :start_date 
    # @option opts [Date] :end_date 
    # @return [Array<(QueryResult, Fixnum, Hash)>] QueryResult data, response status code and response headers
    def event_explorer_get_event_statistics_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: EventexplorerApi#event_explorer_get_event_statistics ..."
      end
      
      # resource path
      path = "/event-explorer/statistics".sub('{format}','json')

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
      form_params["collections"] = @api_client.build_collection_param(opts[:'collections'], :multi) if opts[:'collections']
      form_params["dimension"] = opts[:'dimension'] if opts[:'dimension']
      form_params["startDate"] = opts[:'start_date'] if opts[:'start_date']
      form_params["endDate"] = opts[:'end_date'] if opts[:'end_date']

      # http body (model)
      post_body = nil
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'QueryResult')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EventexplorerApi#event_explorer_get_event_statistics\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end




