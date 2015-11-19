require "uri"

module RakamClient
  class RecipeApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
    end

    # Export recipe
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Recipe]
    def export(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: RecipeApi#export ..."
      end
      
      # resource path
      path = "/recipe/export".sub('{format}','json')

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
      

      auth_names = ['master_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Recipe')
      if Configuration.debugging
        Configuration.logger.debug "API called: RecipeApi#export. Result: #{result.inspect}"
      end
      return result
    end

    # Install recipe
    # 
    # @param recipe 
    # @param [Hash] opts the optional parameters
    # @return [JsonResponse]
    def install(recipe, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: RecipeApi#install ..."
      end
      
      # verify the required parameter 'recipe' is set
      fail "Missing the required parameter 'recipe' when calling install" if recipe.nil?
      
      # resource path
      path = "/recipe/install".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(recipe)
      

      auth_names = ['master_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: RecipeApi#install. Result: #{result.inspect}"
      end
      return result
    end
  end
end




