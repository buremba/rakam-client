require "uri"

module RakamClient
  class UseractionApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
    end

    # Apply batch operation
    # 
    # @param batch_send_emails 
    # @param [Hash] opts the optional parameters
    # @return [Integer]
    def batch_send_emails(batch_send_emails, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UseractionApi#batch_send_emails ..."
      end
      
      # verify the required parameter 'batch_send_emails' is set
      fail "Missing the required parameter 'batch_send_emails' when calling batch_send_emails" if batch_send_emails.nil?
      
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
      post_body = @api_client.object_to_http_body(batch_send_emails)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Integer')
      if Configuration.debugging
        Configuration.logger.debug "API called: UseractionApi#batch_send_emails. Result: #{result.inspect}"
      end
      return result
    end

    # Perform action for single user
    # 
    # @param send 
    # @param [Hash] opts the optional parameters
    # @return [BOOLEAN]
    def send(send, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UseractionApi#send ..."
      end
      
      # verify the required parameter 'send' is set
      fail "Missing the required parameter 'send' when calling send" if send.nil?
      
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
      post_body = @api_client.object_to_http_body(send)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BOOLEAN')
      if Configuration.debugging
        Configuration.logger.debug "API called: UseractionApi#send. Result: #{result.inspect}"
      end
      return result
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
    def send_1(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UseractionApi#send_1 ..."
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
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Message')
      if Configuration.debugging
        Configuration.logger.debug "API called: UseractionApi#send_1. Result: #{result.inspect}"
      end
      return result
    end

    # Apply batch operation
    # 
    # @param batch_send_messages 
    # @param [Hash] opts the optional parameters
    # @return [Integer]
    def batch_send_messages(batch_send_messages, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UseractionApi#batch_send_messages ..."
      end
      
      # verify the required parameter 'batch_send_messages' is set
      fail "Missing the required parameter 'batch_send_messages' when calling batch_send_messages" if batch_send_messages.nil?
      
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
      post_body = @api_client.object_to_http_body(batch_send_messages)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Integer')
      if Configuration.debugging
        Configuration.logger.debug "API called: UseractionApi#batch_send_messages. Result: #{result.inspect}"
      end
      return result
    end
  end
end




