require "uri"

module RakamClient
  class EventApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
    end

    # Collect multiple events
    # 
    # @param event_list 
    # @param [Hash] opts the optional parameters
    # @return [Integer]
    def batch_events(event_list, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: EventApi#batch_events ..."
      end
      
      # verify the required parameter 'event_list' is set
      fail "Missing the required parameter 'event_list' when calling batch_events" if event_list.nil?
      
      # resource path
      path = "/event/batch".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(event_list)
      

      auth_names = ['write_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Integer')
      if Configuration.debugging
        Configuration.logger.debug "API called: EventApi#batch_events. Result: #{result.inspect}"
      end
      return result
    end

    # Collect event
    # 
    # @param event 
    # @param [Hash] opts the optional parameters
    # @return [Integer]
    def collect_event(event, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: EventApi#collect_event ..."
      end
      
      # verify the required parameter 'event' is set
      fail "Missing the required parameter 'event' when calling collect_event" if event.nil?
      
      # resource path
      path = "/event/collect".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(event)
      

      auth_names = ['write_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Integer')
      if Configuration.debugging
        Configuration.logger.debug "API called: EventApi#collect_event. Result: #{result.inspect}"
      end
      return result
    end

    # Analyze events
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :query 
    # @option opts [Integer] :limit 
    # @return [QueryResult]
    def execute(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: EventApi#execute ..."
      end
      
      # resource path
      path = "/query/execute".sub('{format}','json')

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
      form_params["limit"] = opts[:'limit'] if opts[:'limit']

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
        Configuration.logger.debug "API called: EventApi#execute. Result: #{result.inspect}"
      end
      return result
    end

    # Explain query
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :query 
    # @return [Object]
    def explain(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: EventApi#explain ..."
      end
      
      # resource path
      path = "/query/explain".sub('{format}','json')

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
      form_params["query"] = opts[:'query'] if opts[:'query']

      # http body (model)
      post_body = nil
      

      auth_names = ['read_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Object')
      if Configuration.debugging
        Configuration.logger.debug "API called: EventApi#explain. Result: #{result.inspect}"
      end
      return result
    end
  end
end




