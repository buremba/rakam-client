require "uri"

module RakamClient
  class RetentionApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
    end

    # Execute query
    # 
    # @param retention_query 
    # @param [Hash] opts the optional parameters
    # @return [QueryResult]
    def execute(retention_query, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: RetentionApi#execute ..."
      end
      
      # verify the required parameter 'retention_query' is set
      fail "Missing the required parameter 'retention_query' when calling execute" if retention_query.nil?
      
      # resource path
      path = "/retention/analyze".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(retention_query)
      

      auth_names = ['read_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'QueryResult')
      if Configuration.debugging
        Configuration.logger.debug "API called: RetentionApi#execute. Result: #{result.inspect}"
      end
      return result
    end
  end
end




