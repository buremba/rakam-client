require "uri"

module RakamClient
  class UsermailboxApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
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
    def get(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UsermailboxApi#get ..."
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
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<Array<Message>>')
      if Configuration.debugging
        Configuration.logger.debug "API called: UsermailboxApi#get. Result: #{result.inspect}"
      end
      return result
    end

    # Get connected users
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<Hash<String, Object>>]
    def get_connected_users(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UsermailboxApi#get_connected_users ..."
      end
      
      # resource path
      path = "/user/mailbox/getOnlineUsers".sub('{format}','json')

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
        :return_type => 'Array<Hash<String, Object>>')
      if Configuration.debugging
        Configuration.logger.debug "API called: UsermailboxApi#get_connected_users. Result: #{result.inspect}"
      end
      return result
    end

    # Mark mail as read
    # Marks the specified mails as read.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :user 
    # @option opts [Array<String>] :message_ids 
    # @return [JsonResponse]
    def mark_as_read(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UsermailboxApi#mark_as_read ..."
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
      form_params["message_ids"] = opts[:'message_ids'] if opts[:'message_ids']

      # http body (model)
      post_body = nil
      

      auth_names = ['write_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: UsermailboxApi#mark_as_read. Result: #{result.inspect}"
      end
      return result
    end

    # Send mail to user
    # Sends a mail to users mailbox
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :from_user 
    # @option opts [String] :to_user 
    # @option opts [Integer] :parent 
    # @option opts [String] :message 
    # @option opts [Integer] :timestamp 
    # @return [Message]
    def send(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UsermailboxApi#send ..."
      end
      
      # resource path
      path = "/user/mailbox/send".sub('{format}','json')

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
      form_params["from_user"] = opts[:'from_user'] if opts[:'from_user']
      form_params["to_user"] = opts[:'to_user'] if opts[:'to_user']
      form_params["parent"] = opts[:'parent'] if opts[:'parent']
      form_params["message"] = opts[:'message'] if opts[:'message']
      form_params["timestamp"] = opts[:'timestamp'] if opts[:'timestamp']

      # http body (model)
      post_body = nil
      

      auth_names = ['write_key']
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Message')
      if Configuration.debugging
        Configuration.logger.debug "API called: UsermailboxApi#send. Result: #{result.inspect}"
      end
      return result
    end
  end
end




