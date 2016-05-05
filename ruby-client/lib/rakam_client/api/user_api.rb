require "uri"

module RakamClient
  class UserApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # Create new user
    # 
    # @param user_batch_create 
    # @param [Hash] opts the optional parameters
    # @return [Array<String>]
    def user_batch_create(user_batch_create, opts = {})
      data, status_code, headers = user_batch_create_with_http_info(user_batch_create, opts)
      return data
    end

    # Create new user
    # 
    # @param user_batch_create 
    # @param [Hash] opts the optional parameters
    # @return [Array<(Array<String>, Fixnum, Hash)>] Array<String> data, response status code and response headers
    def user_batch_create_with_http_info(user_batch_create, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UserApi#user_batch_create ..."
      end
      
      # verify the required parameter 'user_batch_create' is set
      fail "Missing the required parameter 'user_batch_create' when calling user_batch_create" if user_batch_create.nil?
      
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
      post_body = @api_client.object_to_http_body(user_batch_create)
      

      auth_names = []
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<String>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserApi#user_batch_create\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Create new user
    # 
    # @param user 
    # @param [Hash] opts the optional parameters
    # @return [String]
    def user_create(user, opts = {})
      data, status_code, headers = user_create_with_http_info(user, opts)
      return data
    end

    # Create new user
    # 
    # @param user 
    # @param [Hash] opts the optional parameters
    # @return [Array<(String, Fixnum, Hash)>] String data, response status code and response headers
    def user_create_with_http_info(user, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UserApi#user_create ..."
      end
      
      # verify the required parameter 'user' is set
      fail "Missing the required parameter 'user' when calling user_create" if user.nil?
      
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
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'String')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserApi#user_create\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get events of the user
    # 
    # @param user_create_segment 
    # @param [Hash] opts the optional parameters
    # @return [JsonResponse]
    def user_create_segment(user_create_segment, opts = {})
      data, status_code, headers = user_create_segment_with_http_info(user_create_segment, opts)
      return data
    end

    # Get events of the user
    # 
    # @param user_create_segment 
    # @param [Hash] opts the optional parameters
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def user_create_segment_with_http_info(user_create_segment, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UserApi#user_create_segment ..."
      end
      
      # verify the required parameter 'user_create_segment' is set
      fail "Missing the required parameter 'user_create_segment' when calling user_create_segment" if user_create_segment.nil?
      
      # resource path
      path = "/user/create_segment".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(user_create_segment)
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserApi#user_create_segment\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get user
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :user 
    # @return [User]
    def user_get_user(opts = {})
      data, status_code, headers = user_get_user_with_http_info(opts)
      return data
    end

    # Get user
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :user 
    # @return [Array<(User, Fixnum, Hash)>] User data, response status code and response headers
    def user_get_user_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UserApi#user_get_user ..."
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
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'User')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserApi#user_get_user\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get events of the user
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :user 
    # @option opts [Integer] :limit 
    # @option opts [DateTime] :offset 
    # @return [Array<CollectionEvent>]
    def user_get_events(opts = {})
      data, status_code, headers = user_get_events_with_http_info(opts)
      return data
    end

    # Get events of the user
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @option opts [String] :user 
    # @option opts [Integer] :limit 
    # @option opts [DateTime] :offset 
    # @return [Array<(Array<CollectionEvent>, Fixnum, Hash)>] Array<CollectionEvent> data, response status code and response headers
    def user_get_events_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UserApi#user_get_events ..."
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
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<CollectionEvent>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserApi#user_get_events\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Set user property
    # 
    # @param user_increment_property 
    # @param [Hash] opts the optional parameters
    # @return [JsonResponse]
    def user_increment_property(user_increment_property, opts = {})
      data, status_code, headers = user_increment_property_with_http_info(user_increment_property, opts)
      return data
    end

    # Set user property
    # 
    # @param user_increment_property 
    # @param [Hash] opts the optional parameters
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def user_increment_property_with_http_info(user_increment_property, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UserApi#user_increment_property ..."
      end
      
      # verify the required parameter 'user_increment_property' is set
      fail "Missing the required parameter 'user_increment_property' when calling user_increment_property" if user_increment_property.nil?
      
      # resource path
      path = "/user/increment_property".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(user_increment_property)
      

      auth_names = []
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserApi#user_increment_property\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Merge user with anonymous id
    # 
    # @param user_merge_user 
    # @param [Hash] opts the optional parameters
    # @return [BOOLEAN]
    def user_merge_user(user_merge_user, opts = {})
      data, status_code, headers = user_merge_user_with_http_info(user_merge_user, opts)
      return data
    end

    # Merge user with anonymous id
    # 
    # @param user_merge_user 
    # @param [Hash] opts the optional parameters
    # @return [Array<(BOOLEAN, Fixnum, Hash)>] BOOLEAN data, response status code and response headers
    def user_merge_user_with_http_info(user_merge_user, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UserApi#user_merge_user ..."
      end
      
      # verify the required parameter 'user_merge_user' is set
      fail "Missing the required parameter 'user_merge_user' when calling user_merge_user" if user_merge_user.nil?
      
      # resource path
      path = "/user/merge".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(user_merge_user)
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BOOLEAN')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserApi#user_merge_user\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get user storage metadata
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [MetadataResponse]
    def user_get_metadata(opts = {})
      data, status_code, headers = user_get_metadata_with_http_info(opts)
      return data
    end

    # Get user storage metadata
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :project 
    # @return [Array<(MetadataResponse, Fixnum, Hash)>] MetadataResponse data, response status code and response headers
    def user_get_metadata_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UserApi#user_get_metadata ..."
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
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'MetadataResponse')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserApi#user_get_metadata\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Search users
    # 
    # @param user_search_users 
    # @param [Hash] opts the optional parameters
    # @return [QueryResult]
    def user_search_users(user_search_users, opts = {})
      data, status_code, headers = user_search_users_with_http_info(user_search_users, opts)
      return data
    end

    # Search users
    # 
    # @param user_search_users 
    # @param [Hash] opts the optional parameters
    # @return [Array<(QueryResult, Fixnum, Hash)>] QueryResult data, response status code and response headers
    def user_search_users_with_http_info(user_search_users, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UserApi#user_search_users ..."
      end
      
      # verify the required parameter 'user_search_users' is set
      fail "Missing the required parameter 'user_search_users' when calling user_search_users" if user_search_users.nil?
      
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
      post_body = @api_client.object_to_http_body(user_search_users)
      

      auth_names = ['read_key']
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'QueryResult')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserApi#user_search_users\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Set user properties
    # 
    # @param set_user_properties 
    # @param [Hash] opts the optional parameters
    # @return [Integer]
    def user_set_properties(set_user_properties, opts = {})
      data, status_code, headers = user_set_properties_with_http_info(set_user_properties, opts)
      return data
    end

    # Set user properties
    # 
    # @param set_user_properties 
    # @param [Hash] opts the optional parameters
    # @return [Array<(Integer, Fixnum, Hash)>] Integer data, response status code and response headers
    def user_set_properties_with_http_info(set_user_properties, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UserApi#user_set_properties ..."
      end
      
      # verify the required parameter 'set_user_properties' is set
      fail "Missing the required parameter 'set_user_properties' when calling user_set_properties" if set_user_properties.nil?
      
      # resource path
      path = "/user/set_properties".sub('{format}','json')

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
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Integer')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserApi#user_set_properties\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Set user properties once
    # 
    # @param set_user_properties 
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def user_set_properties_once(set_user_properties, opts = {})
      user_set_properties_once_with_http_info(set_user_properties, opts)
      return nil
    end

    # Set user properties once
    # 
    # @param set_user_properties 
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Fixnum, Hash)>] nil, response status code and response headers
    def user_set_properties_once_with_http_info(set_user_properties, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UserApi#user_set_properties_once ..."
      end
      
      # verify the required parameter 'set_user_properties' is set
      fail "Missing the required parameter 'set_user_properties' when calling user_set_properties_once" if set_user_properties.nil?
      
      # resource path
      path = "/user/set_properties_once".sub('{format}','json')

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
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserApi#user_set_properties_once\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Unset user property
    # 
    # @param user_unset_property 
    # @param [Hash] opts the optional parameters
    # @return [JsonResponse]
    def user_unset_property(user_unset_property, opts = {})
      data, status_code, headers = user_unset_property_with_http_info(user_unset_property, opts)
      return data
    end

    # Unset user property
    # 
    # @param user_unset_property 
    # @param [Hash] opts the optional parameters
    # @return [Array<(JsonResponse, Fixnum, Hash)>] JsonResponse data, response status code and response headers
    def user_unset_property_with_http_info(user_unset_property, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UserApi#user_unset_property ..."
      end
      
      # verify the required parameter 'user_unset_property' is set
      fail "Missing the required parameter 'user_unset_property' when calling user_unset_property" if user_unset_property.nil?
      
      # resource path
      path = "/user/unset_properties".sub('{format}','json')

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
      post_body = @api_client.object_to_http_body(user_unset_property)
      

      auth_names = []
      data, status_code, headers = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'JsonResponse')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserApi#user_unset_property\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end




