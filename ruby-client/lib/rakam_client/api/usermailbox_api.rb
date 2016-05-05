require "uri"

module RakamClient
  class UsermailboxApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # Get user mailbox
    # Returns the last mails sent to the user
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :user 
    # @option opts [Integer] :parent 
    # @option opts [Integer] :limit 
    # @option opts [Integer] :offset 
    # @return [Array<Array<Message>>]
    def user_mailbox_get(opts = {})
      data, status_code, headers = user_mailbox_get_with_http_info(opts)
      return data
    end

    # Get user mailbox
    # Returns the last mails sent to the user
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :user 
    # @option opts [Integer] :parent 
    # @option opts [Integer] :limit 
    # @option opts [Integer] :offset 
    # @return [Array<(Array<Array<Message>>, Fixnum, Hash)>] Array<Array<Message>> data, response status code and response headers
    def user_mailbox_get_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UsermailboxApi#user_mailbox_get ..."
      end
      
      # resource path
      path = "/user/mailbox/get".sub('{format}','json')

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
      form_params["user"] = opts[:'user'] if opts[:'user']
      form_params["parent"] = opts[:'parent'] if opts[:'parent']
      form_params["limit"] = opts[:'limit'] if opts[:'limit']
      form_params["offset"] = opts[:'offset'] if opts[:'offset']

      # http body (model)
      post_body = nil
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<Array<Message>>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UsermailboxApi#user_mailbox_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get connected users
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<Hash<String, Object>>]
    def user_mailbox_get_connected_users(opts = {})
      data, status_code, headers = user_mailbox_get_connected_users_with_http_info(opts)
      return data
    end

    # Get connected users
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<(Array<Hash<String, Object>>, Fixnum, Hash)>] Array<Hash<String, Object>> data, response status code and response headers
    def user_mailbox_get_connected_users_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UsermailboxApi#user_mailbox_get_connected_users ..."
      end
      
      # resource path
      path = "/user/mailbox/get_online_users".sub('{format}','json')

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
        :return_type => 'Array<Hash<String, Object>>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UsermailboxApi#user_mailbox_get_connected_users\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Mark mail as read
    # Marks the specified mails as read.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :user 
    # @option opts [Array<Integer>] :message_ids 
    # @return [JsonResponse]
    def user_mailbox_mark_as_read(opts = {})
      data, status_code, headers = user_mailbox_mark_as_read_with_http_info(opts)
      return data
    end

    # Mark mail as read
    # Marks the specified mails as read.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :user 
    # @option opts [Array<Integer>] :message_ids 
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def user_mailbox_mark_as_read_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UsermailboxApi#user_mailbox_mark_as_read ..."
      end
      
      # resource path
      path = "/user/mailbox/mark_as_read".sub('{format}','json')

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
      form_params["user"] = opts[:'user'] if opts[:'user']
      form_params["message_ids"] = @api_client.build_collection_param(opts[:'message_ids'], :multi) if opts[:'message_ids']

      # http body (model)
      post_body = nil
      

      auth_names = ['write_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UsermailboxApi#user_mailbox_mark_as_read\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end




