require "uri"

module RakamClient
  class AutomationApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
    end

    # Activate rule
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Integer] :id 
    # @return [JsonResponse]
    def activate_rule(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: AutomationApi#activate_rule ..."
      end
      
      # resource path
      path = "/automation/activate".sub('{format}','json')

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
        Configuration.logger.debug "API called: AutomationApi#activate_rule. Result: #{result.inspect}"
      end
      return result
    end

    # Add scenario
    # 
    # @param automation_rule 
    # @param [Hash] opts the optional parameters
    # @return [JsonResponse]
    def add_rule(automation_rule, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: AutomationApi#add_rule ..."
      end
      
      # verify the required parameter 'automation_rule' is set
      fail "Missing the required parameter 'automation_rule' when calling add_rule" if automation_rule.nil?
      
      # resource path
      path = "/automation/add".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(automation_rule)
      

      auth_names = ['master_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: AutomationApi#add_rule. Result: #{result.inspect}"
      end
      return result
    end

    # Deactivate rule
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Integer] :id 
    # @return [JsonResponse]
    def deactivate_rule(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: AutomationApi#deactivate_rule ..."
      end
      
      # resource path
      path = "/automation/deactivate".sub('{format}','json')

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
        Configuration.logger.debug "API called: AutomationApi#deactivate_rule. Result: #{result.inspect}"
      end
      return result
    end

    # List scenarios
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<AutomationRule>]
    def list_rules(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: AutomationApi#list_rules ..."
      end
      
      # resource path
      path = "/automation/list".sub('{format}','json')

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
        :return_type => 'Array<AutomationRule>')
      if Configuration.debugging
        Configuration.logger.debug "API called: AutomationApi#list_rules. Result: #{result.inspect}"
      end
      return result
    end

    # Remove rule
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Integer] :id 
    # @return [JsonResponse]
    def remove_rule(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: AutomationApi#remove_rule ..."
      end
      
      # resource path
      path = "/automation/remove".sub('{format}','json')

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
        Configuration.logger.debug "API called: AutomationApi#remove_rule. Result: #{result.inspect}"
      end
      return result
    end
  end
end




