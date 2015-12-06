require "uri"

module RakamClient
  class AbtestingApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
    end

    # Create test
    # 
    # @param [Hash] opts the optional parameters
    # @return [JsonResponse]
    def create(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: AbtestingApi#create ..."
      end
      
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
      post_body = nil
      

      auth_names = ['master_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: AbtestingApi#create. Result: #{result.inspect}"
      end
      return result
    end

    # Delete report
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Integer] :id 
    # @return [JsonResponse]
    def delete(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: AbtestingApi#delete ..."
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
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: AbtestingApi#delete. Result: #{result.inspect}"
      end
      return result
    end

    # Get report
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Integer] :id 
    # @return [ABTestingReport]
    def get(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: AbtestingApi#get ..."
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
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'ABTestingReport')
      if Configuration.debugging
        Configuration.logger.debug "API called: AbtestingApi#get. Result: #{result.inspect}"
      end
      return result
    end

    # List reports
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<ABTestingReport>]
    def list(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: AbtestingApi#list ..."
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
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<ABTestingReport>')
      if Configuration.debugging
        Configuration.logger.debug "API called: AbtestingApi#list. Result: #{result.inspect}"
      end
      return result
    end

    # Update report
    # 
    # @param [Hash] opts the optional parameters
    # @return [ABTestingReport]
    def update(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: AbtestingApi#update ..."
      end
      
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
      post_body = nil
      

      auth_names = ['master_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'ABTestingReport')
      if Configuration.debugging
        Configuration.logger.debug "API called: AbtestingApi#update. Result: #{result.inspect}"
      end
      return result
    end
  end
end




