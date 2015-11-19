require "uri"

module RakamClient
  class RealtimeApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
    end

    # Create report
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :name 
    # @option opts [String] :aggregation 
    # @option opts [String] :table_name 
    # @option opts [Array<String>] :collections 
    # @option opts [String] :filter 
    # @option opts [String] :measure 
    # @option opts [Array<String>] :dimensions 
    # @return [JsonResponse]
    def create(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: RealtimeApi#create ..."
      end
      
      # resource path
      path = "/realtime/create".sub('{format}','json')

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
      form_params["aggregation"] = opts[:'aggregation'] if opts[:'aggregation']
      form_params["table_name"] = opts[:'table_name'] if opts[:'table_name']
      form_params["collections"] = opts[:'collections'] if opts[:'collections']
      form_params["filter"] = opts[:'filter'] if opts[:'filter']
      form_params["measure"] = opts[:'measure'] if opts[:'measure']
      form_params["dimensions"] = opts[:'dimensions'] if opts[:'dimensions']

      # http body (model)
      post_body = nil
      

      auth_names = ['read_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: RealtimeApi#create. Result: #{result.inspect}"
      end
      return result
    end

    # Delete report
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :name 
    # @return [JsonResponse]
    def delete(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: RealtimeApi#delete ..."
      end
      
      # resource path
      path = "/realtime/delete".sub('{format}','json')

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
      

      auth_names = ['read_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: RealtimeApi#delete. Result: #{result.inspect}"
      end
      return result
    end

    # Get report
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :table_name 
    # @option opts [String] :filter 
    # @option opts [String] :aggregation 
    # @option opts [String] :measure 
    # @option opts [Array<String>] :dimensions 
    # @option opts [BOOLEAN] :aggregate 
    # @option opts [DateTime] :date_start 
    # @option opts [DateTime] :date_end 
    # @return [Object]
    def get(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: RealtimeApi#get ..."
      end
      
      # resource path
      path = "/realtime/get".sub('{format}','json')

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
      form_params["table_name"] = opts[:'table_name'] if opts[:'table_name']
      form_params["filter"] = opts[:'filter'] if opts[:'filter']
      form_params["aggregation"] = opts[:'aggregation'] if opts[:'aggregation']
      form_params["measure"] = opts[:'measure'] if opts[:'measure']
      form_params["dimensions"] = opts[:'dimensions'] if opts[:'dimensions']
      form_params["aggregate"] = opts[:'aggregate'] if opts[:'aggregate']
      form_params["date_start"] = opts[:'date_start'] if opts[:'date_start']
      form_params["date_end"] = opts[:'date_end'] if opts[:'date_end']

      # http body (model)
      post_body = nil
      

      auth_names = ['read_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Object')
      if Configuration.debugging
        Configuration.logger.debug "API called: RealtimeApi#get. Result: #{result.inspect}"
      end
      return result
    end

    # List reports
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<RealTimeReport>]
    def list_reports(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: RealtimeApi#list_reports ..."
      end
      
      # resource path
      path = "/realtime/list".sub('{format}','json')

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
        :return_type => 'Array<RealTimeReport>')
      if Configuration.debugging
        Configuration.logger.debug "API called: RealtimeApi#list_reports. Result: #{result.inspect}"
      end
      return result
    end
  end
end




