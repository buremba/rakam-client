require "uri"

module RakamClient
  class AdminApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
    end

    # List installed modules
    # 
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def get_modules(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: AdminApi#get_modules ..."
      end
      
      # resource path
      path = "/admin/modules".sub('{format}','json')

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
      @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names)
      if Configuration.debugging
        Configuration.logger.debug "API called: AdminApi#get_modules"
      end
      return nil
    end

    # Create project
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :name 
    # @return [JsonResponse]
    def create_project(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: AdminApi#create_project ..."
      end
      
      # resource path
      path = "/project/create".sub('{format}','json')

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
      form_params["name"] = opts[:'name'] if opts[:'name']

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
        Configuration.logger.debug "API called: AdminApi#create_project. Result: #{result.inspect}"
      end
      return result
    end

    # List created projects
    # 
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def get_projects(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: AdminApi#get_projects ..."
      end
      
      # resource path
      path = "/project/list".sub('{format}','json')

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
      

      auth_names = ['read_key']
      @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names)
      if Configuration.debugging
        Configuration.logger.debug "API called: AdminApi#get_projects"
      end
      return nil
    end

    # Get collection schema
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<Collection>]
    def schema(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: AdminApi#schema ..."
      end
      
      # resource path
      path = "/project/schema".sub('{format}','json')

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
        :return_type => 'Array<Collection>')
      if Configuration.debugging
        Configuration.logger.debug "API called: AdminApi#schema. Result: #{result.inspect}"
      end
      return result
    end
  end
end




