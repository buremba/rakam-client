require "uri"

module RakamClient
  class ContinuousqueryApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
    end

    # Create stream
    # 
    # @param continuous_query 
    # @param [Hash] opts the optional parameters
    # @return [JsonResponse]
    def create(continuous_query, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: ContinuousqueryApi#create ..."
      end
      
      # verify the required parameter 'continuous_query' is set
      fail "Missing the required parameter 'continuous_query' when calling create" if continuous_query.nil?
      
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
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: ContinuousqueryApi#create. Result: #{result.inspect}"
      end
      return result
    end

    # Delete stream
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :name 
    # @return [JsonResponse]
    def delete(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: ContinuousqueryApi#delete ..."
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
      form_params["name"] = opts[:'name'] if opts[:'name']

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: ContinuousqueryApi#delete. Result: #{result.inspect}"
      end
      return result
    end

    # List queries
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<ContinuousQuery>]
    def list_queries(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: ContinuousqueryApi#list_queries ..."
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
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<ContinuousQuery>')
      if Configuration.debugging
        Configuration.logger.debug "API called: ContinuousqueryApi#list_queries. Result: #{result.inspect}"
      end
      return result
    end

    # Get query schema
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<Collection>]
    def schema(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: ContinuousqueryApi#schema ..."
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

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<Collection>')
      if Configuration.debugging
        Configuration.logger.debug "API called: ContinuousqueryApi#schema. Result: #{result.inspect}"
      end
      return result
    end

    # Test continuous query
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :query 
    # @return [Array<SchemaField>]
    def test(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: ContinuousqueryApi#test ..."
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
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<SchemaField>')
      if Configuration.debugging
        Configuration.logger.debug "API called: ContinuousqueryApi#test. Result: #{result.inspect}"
      end
      return result
    end
  end
end




