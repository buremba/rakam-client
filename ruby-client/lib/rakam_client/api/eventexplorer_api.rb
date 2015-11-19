require "uri"

module RakamClient
  class EventexplorerApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
    end

    # Perform simple query on event data
    # 
    # @param execute 
    # @param [Hash] opts the optional parameters
    # @return [QueryResult]
    def execute(execute, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: EventexplorerApi#execute ..."
      end
      
      # verify the required parameter 'execute' is set
      fail "Missing the required parameter 'execute' when calling execute" if execute.nil?
      
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
      post_body = @api_client.object_to_http_body(execute)
      

      auth_names = ['read_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'QueryResult')
      if Configuration.debugging
        Configuration.logger.debug "API called: EventexplorerApi#execute. Result: #{result.inspect}"
      end
      return result
    end

    # Event statistics
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<String>]
    def get_event_dimensions(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: EventexplorerApi#get_event_dimensions ..."
      end
      
      # resource path
      path = "/event-explorer/event_dimensions".sub('{format}','json')

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
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<String>')
      if Configuration.debugging
        Configuration.logger.debug "API called: EventexplorerApi#get_event_dimensions. Result: #{result.inspect}"
      end
      return result
    end

    # Event statistics
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<String>]
    def get_extra_dimensions(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: EventexplorerApi#get_extra_dimensions ..."
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
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<String>')
      if Configuration.debugging
        Configuration.logger.debug "API called: EventexplorerApi#get_extra_dimensions. Result: #{result.inspect}"
      end
      return result
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
    def get_event_statistics(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: EventexplorerApi#get_event_statistics ..."
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
      form_params["collections"] = opts[:'collections'] if opts[:'collections']
      form_params["dimension"] = opts[:'dimension'] if opts[:'dimension']
      form_params["startDate"] = opts[:'start_date'] if opts[:'start_date']
      form_params["endDate"] = opts[:'end_date'] if opts[:'end_date']

      # http body (model)
      post_body = nil
      

      auth_names = ['read_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'QueryResult')
      if Configuration.debugging
        Configuration.logger.debug "API called: EventexplorerApi#get_event_statistics. Result: #{result.inspect}"
      end
      return result
    end
  end
end




