require "uri"

module RakamClient
  class UserApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
    end

    # Create new user
    # 
    # @param batch_create 
    # @param [Hash] opts the optional parameters
    # @return [Array<String>]
    def batch_create(batch_create, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UserApi#batch_create ..."
      end
      
      # verify the required parameter 'batch_create' is set
      fail "Missing the required parameter 'batch_create' when calling batch_create" if batch_create.nil?
      
      # resource path
      path = "/user/batch/create".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(batch_create)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<String>')
      if Configuration.debugging
        Configuration.logger.debug "API called: UserApi#batch_create. Result: #{result.inspect}"
      end
      return result
    end

    # Create new user
    # 
    # @param user 
    # @param [Hash] opts the optional parameters
    # @return [String]
    def create(user, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UserApi#create ..."
      end
      
      # verify the required parameter 'user' is set
      fail "Missing the required parameter 'user' when calling create" if user.nil?
      
      # resource path
      path = "/user/create".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(user)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'String')
      if Configuration.debugging
        Configuration.logger.debug "API called: UserApi#create. Result: #{result.inspect}"
      end
      return result
    end

    # Get user
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :user 
    # @return [User]
    def get_user(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UserApi#get_user ..."
      end
      
      # resource path
      path = "/user/get".sub('{format}','json')

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

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'User')
      if Configuration.debugging
        Configuration.logger.debug "API called: UserApi#get_user. Result: #{result.inspect}"
      end
      return result
    end

    # Get events of the user
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :user 
    # @option opts [Integer] :limit 
    # @option opts [Integer] :offset 
    # @return [Array<CollectionEvent>]
    def get_events(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UserApi#get_events ..."
      end
      
      # resource path
      path = "/user/get_events".sub('{format}','json')

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
      form_params["limit"] = opts[:'limit'] if opts[:'limit']
      form_params["offset"] = opts[:'offset'] if opts[:'offset']

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<CollectionEvent>')
      if Configuration.debugging
        Configuration.logger.debug "API called: UserApi#get_events. Result: #{result.inspect}"
      end
      return result
    end

    # Set user property
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :user 
    # @return [JsonResponse]
    def increment_user_property(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UserApi#increment_user_property ..."
      end
      
      # resource path
      path = "/user/increment".sub('{format}','json')

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

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: UserApi#increment_user_property. Result: #{result.inspect}"
      end
      return result
    end

    # Get user storage metadata
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [MetadataResponse]
    def get_metadata(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UserApi#get_metadata ..."
      end
      
      # resource path
      path = "/user/metadata".sub('{format}','json')

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
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'MetadataResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: UserApi#get_metadata. Result: #{result.inspect}"
      end
      return result
    end

    # Search users
    # 
    # @param search_users 
    # @param [Hash] opts the optional parameters
    # @return [QueryResult]
    def search_users(search_users, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UserApi#search_users ..."
      end
      
      # verify the required parameter 'search_users' is set
      fail "Missing the required parameter 'search_users' when calling search_users" if search_users.nil?
      
      # resource path
      path = "/user/search".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(search_users)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'QueryResult')
      if Configuration.debugging
        Configuration.logger.debug "API called: UserApi#search_users. Result: #{result.inspect}"
      end
      return result
    end

    # Set user property
    # 
    # @param set_user_property_once 
    # @param [Hash] opts the optional parameters
    # @return [JsonResponse]
    def set_user_property_once(set_user_property_once, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UserApi#set_user_property_once ..."
      end
      
      # verify the required parameter 'set_user_property_once' is set
      fail "Missing the required parameter 'set_user_property_once' when calling set_user_property_once" if set_user_property_once.nil?
      
      # resource path
      path = "/user/set_once".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(set_user_property_once)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: UserApi#set_user_property_once. Result: #{result.inspect}"
      end
      return result
    end

    # Set user property
    # 
    # @param set_user_properties 
    # @param [Hash] opts the optional parameters
    # @return [JsonResponse]
    def set_user_properties(set_user_properties, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: UserApi#set_user_properties ..."
      end
      
      # verify the required parameter 'set_user_properties' is set
      fail "Missing the required parameter 'set_user_properties' when calling set_user_properties" if set_user_properties.nil?
      
      # resource path
      path = "/user/set_property".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(set_user_properties)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: UserApi#set_user_properties. Result: #{result.inspect}"
      end
      return result
    end
  end
end




