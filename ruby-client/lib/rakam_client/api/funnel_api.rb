require "uri"

module RakamClient
  class FunnelApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
    end

    # Execute query
    # 
    # @param funnel_query 
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def analyze(funnel_query, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: FunnelApi#analyze ..."
      end
      
      # verify the required parameter 'funnel_query' is set
      fail "Missing the required parameter 'funnel_query' when calling analyze" if funnel_query.nil?
      
      # resource path
      path = "/funnel/analyze".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['text/event-stream']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['text/event-stream']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(funnel_query)
      

      auth_names = ['read_key']
      @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names)
      if Configuration.debugging
        Configuration.logger.debug "API called: FunnelApi#analyze"
      end
      return nil
    end

    # Execute query
    # 
    # @param funnel_query 
    # @param [Hash] opts the optional parameters
    # @return [QueryResult]
    def analyze_1(funnel_query, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: FunnelApi#analyze_1 ..."
      end
      
      # verify the required parameter 'funnel_query' is set
      fail "Missing the required parameter 'funnel_query' when calling analyze_1" if funnel_query.nil?
      
      # resource path
      path = "/funnel/analyze".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(funnel_query)
      

      auth_names = ['read_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'QueryResult')
      if Configuration.debugging
        Configuration.logger.debug "API called: FunnelApi#analyze_1. Result: #{result.inspect}"
      end
      return result
    end
  end
end




