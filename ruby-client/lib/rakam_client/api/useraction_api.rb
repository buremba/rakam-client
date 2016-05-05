require "uri"

module RakamClient
  class UseractionApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # Apply batch operation
    # 
    # @param user_email_action_batch 
    # @param [Hash] opts the optional parameters
    # @return [Integer]
    def user_email_action_batch(user_email_action_batch, opts = {})
      data, status_code, headers = user_email_action_batch_with_http_info(user_email_action_batch, opts)
      return data
    end

    # Apply batch operation
    # 
    # @param user_email_action_batch 
    # @param [Hash] opts the optional parameters
    # @return [Array<(Integer, Fixnum, Hash)>] Integer data, response status code and response headers
    def user_email_action_batch_with_http_info(user_email_action_batch, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UseractionApi#user_email_action_batch ..."
      end
      
      # verify the required parameter 'user_email_action_batch' is set
      fail "Missing the required parameter 'user_email_action_batch' when calling user_email_action_batch" if user_email_action_batch.nil?
      
      # resource path
      path = "/user/action/email/batch".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(user_email_action_batch)
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Integer')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UseractionApi#user_email_action_batch\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Perform action for single user
    # 
    # @param user_email_action_send 
    # @param [Hash] opts the optional parameters
    # @return [BOOLEAN]
    def user_email_action_send(user_email_action_send, opts = {})
      data, status_code, headers = user_email_action_send_with_http_info(user_email_action_send, opts)
      return data
    end

    # Perform action for single user
    # 
    # @param user_email_action_send 
    # @param [Hash] opts the optional parameters
    # @return [Array<(BOOLEAN, Fixnum, Hash)>] BOOLEAN data, response status code and response headers
    def user_email_action_send_with_http_info(user_email_action_send, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UseractionApi#user_email_action_send ..."
      end
      
      # verify the required parameter 'user_email_action_send' is set
      fail "Missing the required parameter 'user_email_action_send' when calling user_email_action_send" if user_email_action_send.nil?
      
      # resource path
      path = "/user/action/email/single".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(user_email_action_send)
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BOOLEAN')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UseractionApi#user_email_action_send\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Send message to user
    # Sends a mail to users mailbox
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :from_user 
    # @option opts [String] :to_user 
    # @option opts [Integer] :parent 
    # @option opts [String] :message 
    # @option opts [Integer] :timestamp 
    # @return [Message]
    def user_mailbox_action_send(opts = {})
      data, status_code, headers = user_mailbox_action_send_with_http_info(opts)
      return data
    end

    # Send message to user
    # Sends a mail to users mailbox
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :from_user 
    # @option opts [String] :to_user 
    # @option opts [Integer] :parent 
    # @option opts [String] :message 
    # @option opts [Integer] :timestamp 
    # @return [Array<(Message, Fixnum, Hash)>] Message data, response status code and response headers
    def user_mailbox_action_send_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UseractionApi#user_mailbox_action_send ..."
      end
      
      # resource path
      path = "/user/action/mailbox/action/mailbox/single".sub('{format}','json')

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
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Message')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UseractionApi#user_mailbox_action_send\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Apply batch operation
    # 
    # @param user_mailbox_action_batch_send_messages 
    # @param [Hash] opts the optional parameters
    # @return [Integer]
    def user_mailbox_action_batch_send_messages(user_mailbox_action_batch_send_messages, opts = {})
      data, status_code, headers = user_mailbox_action_batch_send_messages_with_http_info(user_mailbox_action_batch_send_messages, opts)
      return data
    end

    # Apply batch operation
    # 
    # @param user_mailbox_action_batch_send_messages 
    # @param [Hash] opts the optional parameters
    # @return [Array<(Integer, Fixnum, Hash)>] Integer data, response status code and response headers
    def user_mailbox_action_batch_send_messages_with_http_info(user_mailbox_action_batch_send_messages, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UseractionApi#user_mailbox_action_batch_send_messages ..."
      end
      
      # verify the required parameter 'user_mailbox_action_batch_send_messages' is set
      fail "Missing the required parameter 'user_mailbox_action_batch_send_messages' when calling user_mailbox_action_batch_send_messages" if user_mailbox_action_batch_send_messages.nil?
      
      # resource path
      path = "/user/action/mailbox/batch".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(user_mailbox_action_batch_send_messages)
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Integer')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UseractionApi#user_mailbox_action_batch_send_messages\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end




