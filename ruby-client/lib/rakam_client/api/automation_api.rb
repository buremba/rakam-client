require "uri"

module RakamClient
  class AutomationApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # Activate rule
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Integer] :id 
    # @return [JsonResponse]
    def automation_activate_rule(opts = {})
      data, status_code, headers = automation_activate_rule_with_http_info(opts)
      return data
    end

    # Activate rule
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Integer] :id 
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def automation_activate_rule_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AutomationApi#automation_activate_rule ..."
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
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AutomationApi#automation_activate_rule\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Add scenario
    # 
    # @param automation_rule 
    # @param [Hash] opts the optional parameters
    # @return [JsonResponse]
    def automation_add_rule(automation_rule, opts = {})
      data, status_code, headers = automation_add_rule_with_http_info(automation_rule, opts)
      return data
    end

    # Add scenario
    # 
    # @param automation_rule 
    # @param [Hash] opts the optional parameters
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def automation_add_rule_with_http_info(automation_rule, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AutomationApi#automation_add_rule ..."
      end
      
      # verify the required parameter 'automation_rule' is set
      fail "Missing the required parameter 'automation_rule' when calling automation_add_rule" if automation_rule.nil?
      
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
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AutomationApi#automation_add_rule\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Deactivate rule
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Integer] :id 
    # @return [JsonResponse]
    def automation_deactivate_rule(opts = {})
      data, status_code, headers = automation_deactivate_rule_with_http_info(opts)
      return data
    end

    # Deactivate rule
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Integer] :id 
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def automation_deactivate_rule_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AutomationApi#automation_deactivate_rule ..."
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
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AutomationApi#automation_deactivate_rule\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # List scenarios
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<AutomationRule>]
    def automation_list_rules(opts = {})
      data, status_code, headers = automation_list_rules_with_http_info(opts)
      return data
    end

    # List scenarios
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<(Array<AutomationRule>, Fixnum, Hash)>] Array<AutomationRule> data, response status code and response headers
    def automation_list_rules_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AutomationApi#automation_list_rules ..."
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
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<AutomationRule>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AutomationApi#automation_list_rules\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Remove rule
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Integer] :id 
    # @return [JsonResponse]
    def automation_remove_rule(opts = {})
      data, status_code, headers = automation_remove_rule_with_http_info(opts)
      return data
    end

    # Remove rule
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [Integer] :id 
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def automation_remove_rule_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: AutomationApi#automation_remove_rule ..."
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
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: AutomationApi#automation_remove_rule\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end




