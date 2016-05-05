require "uri"

module RakamClient
  class EventApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # Collect multiple events
    # 
    # @param event_list 
    # @param [Hash] opts the optional parameters
    # @return [Integer]
    def collect_event_batch_events(event_list, opts = {})
      data, status_code, headers = collect_event_batch_events_with_http_info(event_list, opts)
      return data
    end

    # Collect multiple events
    # 
    # @param event_list 
    # @param [Hash] opts the optional parameters
    # @return [Array<(Integer, Fixnum, Hash)>] Integer data, response status code and response headers
    def collect_event_batch_events_with_http_info(event_list, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: EventApi#collect_event_batch_events ..."
      end
      
      # verify the required parameter 'event_list' is set
      fail "Missing the required parameter 'event_list' when calling collect_event_batch_events" if event_list.nil?
      
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
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Integer')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EventApi#collect_event_batch_events\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Send Bulk events
    # 
    # @param event_list 
    # @param [Hash] opts the optional parameters
    # @return [Integer]
    def collect_event_bulk_events(event_list, opts = {})
      data, status_code, headers = collect_event_bulk_events_with_http_info(event_list, opts)
      return data
    end

    # Send Bulk events
    # 
    # @param event_list 
    # @param [Hash] opts the optional parameters
    # @return [Array<(Integer, Fixnum, Hash)>] Integer data, response status code and response headers
    def collect_event_bulk_events_with_http_info(event_list, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: EventApi#collect_event_bulk_events ..."
      end
      
      # verify the required parameter 'event_list' is set
      fail "Missing the required parameter 'event_list' when calling collect_event_bulk_events" if event_list.nil?
      
      # resource path
      path = "/event/bulk".sub('{format}','json')

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
      

      auth_names = ['master_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Integer')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EventApi#collect_event_bulk_events\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Commit Bulk events
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :collection 
    # @return [QueryResult]
    def collect_event_commit_bulk_events(opts = {})
      data, status_code, headers = collect_event_commit_bulk_events_with_http_info(opts)
      return data
    end

    # Commit Bulk events
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :collection 
    # @return [Array<(QueryResult, Fixnum, Hash)>] QueryResult data, response status code and response headers
    def collect_event_commit_bulk_events_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: EventApi#collect_event_commit_bulk_events ..."
      end
      
      # resource path
      path = "/event/bulk/commit".sub('{format}','json')

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

      # http body (model)
      post_body = nil
      

      auth_names = ['master_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'QueryResult')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EventApi#collect_event_commit_bulk_events\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Send Bulk events
    # 
    # @param event_list 
    # @param [Hash] opts the optional parameters
    # @return [Integer]
    def collect_event_bulk_events_remote(event_list, opts = {})
      data, status_code, headers = collect_event_bulk_events_remote_with_http_info(event_list, opts)
      return data
    end

    # Send Bulk events
    # 
    # @param event_list 
    # @param [Hash] opts the optional parameters
    # @return [Array<(Integer, Fixnum, Hash)>] Integer data, response status code and response headers
    def collect_event_bulk_events_remote_with_http_info(event_list, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: EventApi#collect_event_bulk_events_remote ..."
      end
      
      # verify the required parameter 'event_list' is set
      fail "Missing the required parameter 'event_list' when calling collect_event_bulk_events_remote" if event_list.nil?
      
      # resource path
      path = "/event/bulk/remote".sub('{format}','json')

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
      

      auth_names = ['master_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Integer')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EventApi#collect_event_bulk_events_remote\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Collect event
    # 
    # @param event 
    # @param [Hash] opts the optional parameters
    # @return [Integer]
    def collect_event_collect_event(event, opts = {})
      data, status_code, headers = collect_event_collect_event_with_http_info(event, opts)
      return data
    end

    # Collect event
    # 
    # @param event 
    # @param [Hash] opts the optional parameters
    # @return [Array<(Integer, Fixnum, Hash)>] Integer data, response status code and response headers
    def collect_event_collect_event_with_http_info(event, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: EventApi#collect_event_collect_event ..."
      end
      
      # verify the required parameter 'event' is set
      fail "Missing the required parameter 'event' when calling collect_event_collect_event" if event.nil?
      
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
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Integer')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EventApi#collect_event_collect_event\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Analyze events
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :query 
    # @option opts [Integer] :limit 
    # @return [QueryResult]
    def query_execute(opts = {})
      data, status_code, headers = query_execute_with_http_info(opts)
      return data
    end

    # Analyze events
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :query 
    # @option opts [Integer] :limit 
    # @return [Array<(QueryResult, Fixnum, Hash)>] QueryResult data, response status code and response headers
    def query_execute_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: EventApi#query_execute ..."
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
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'QueryResult')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EventApi#query_execute\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Explain query
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :query 
    # @return [inline_response_200]
    def query_explain(opts = {})
      data, status_code, headers = query_explain_with_http_info(opts)
      return data
    end

    # Explain query
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :query 
    # @return [Array<(inline_response_200, Fixnum, Hash)>] inline_response_200 data, response status code and response headers
    def query_explain_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: EventApi#query_explain ..."
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
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'inline_response_200')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EventApi#query_explain\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Test query
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :query 
    # @return [Array<SchemaField>]
    def query_metadata(opts = {})
      data, status_code, headers = query_metadata_with_http_info(opts)
      return data
    end

    # Test query
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :query 
    # @return [Array<(Array<SchemaField>, Fixnum, Hash)>] Array<SchemaField> data, response status code and response headers
    def query_metadata_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: EventApi#query_metadata ..."
      end
      
      # resource path
      path = "/query/metadata".sub('{format}','json')

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
        :return_type => 'Array<SchemaField>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EventApi#query_metadata\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end




