require "uri"

module RakamClient
  class FunnelApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # Execute query
    # 
    # @param funnel_query 
    # @param [Hash] opts the optional parameters
    # @return [QueryResult]
    def funnel_analyzer_analyze(funnel_query, opts = {})
      data, status_code, headers = funnel_analyzer_analyze_with_http_info(funnel_query, opts)
      return data
    end

    # Execute query
    # 
    # @param funnel_query 
    # @param [Hash] opts the optional parameters
    # @return [Array<(QueryResult, Fixnum, Hash)>] QueryResult data, response status code and response headers
    def funnel_analyzer_analyze_with_http_info(funnel_query, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: FunnelApi#funnel_analyzer_analyze ..."
      end
      
      # verify the required parameter 'funnel_query' is set
      fail "Missing the required parameter 'funnel_query' when calling funnel_analyzer_analyze" if funnel_query.nil?
      
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
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'QueryResult')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: FunnelApi#funnel_analyzer_analyze\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end




