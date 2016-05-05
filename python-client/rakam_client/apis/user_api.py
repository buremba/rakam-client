# coding: utf-8

"""
UserApi.py
Copyright 2015 SmartBear Software

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
"""

from __future__ import absolute_import

import sys
import os

# python 2 and python 3 compatibility library
from six import iteritems

from ..configuration import Configuration
from ..api_client import ApiClient


class UserApi(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    Ref: https://github.com/swagger-api/swagger-codegen
    """

    def __init__(self, api_client=None):
        config = Configuration()
        if api_client:
            self.api_client = api_client
        else:
            if not config.api_client:
                config.api_client = ApiClient()
            self.api_client = config.api_client

    def user_batch_create(self, **kwargs):
        """
        Create new user
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.user_batch_create(user_batch_create=user_batch_create_value, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param UserBatchCreate user_batch_create:  (required)
        :return: list[str]
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_batch_create']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method user_batch_create" % key
                )
            params[key] = val
        del params['kwargs']

        # verify the required parameter 'user_batch_create' is set
        if ('user_batch_create' not in params) or (params['user_batch_create'] is None):
            raise ValueError("Missing the required parameter `user_batch_create` when calling `user_batch_create`")

        resource_path = '/user/batch/create'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}

        body_params = None
        if 'user_batch_create' in params:
            body_params = params['user_batch_create']

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = []

        response = self.api_client.call_api(resource_path, method,
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=files,
                                            response_type='list[str]',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response

    def user_create(self, **kwargs):
        """
        Create new user
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.user_create(user=user_value, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param User user:  (required)
        :return: str
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method user_create" % key
                )
            params[key] = val
        del params['kwargs']

        # verify the required parameter 'user' is set
        if ('user' not in params) or (params['user'] is None):
            raise ValueError("Missing the required parameter `user` when calling `user_create`")

        resource_path = '/user/create'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}

        body_params = None
        if 'user' in params:
            body_params = params['user']

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = []

        response = self.api_client.call_api(resource_path, method,
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=files,
                                            response_type='str',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response

    def user_create_segment(self, **kwargs):
        """
        Get events of the user
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.user_create_segment(user_create_segment=user_create_segment_value, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param UserCreateSegment user_create_segment:  (required)
        :return: JsonResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_create_segment']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method user_create_segment" % key
                )
            params[key] = val
        del params['kwargs']

        # verify the required parameter 'user_create_segment' is set
        if ('user_create_segment' not in params) or (params['user_create_segment'] is None):
            raise ValueError("Missing the required parameter `user_create_segment` when calling `user_create_segment`")

        resource_path = '/user/create_segment'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}

        body_params = None
        if 'user_create_segment' in params:
            body_params = params['user_create_segment']

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = ['read_key']

        response = self.api_client.call_api(resource_path, method,
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=files,
                                            response_type='JsonResponse',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response

    def user_get_user(self, **kwargs):
        """
        Get user
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.user_get_user(callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str project: 
        :param str user: 
        :return: User
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['project', 'user']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method user_get_user" % key
                )
            params[key] = val
        del params['kwargs']


        resource_path = '/user/get'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}
        if 'project' in params:
            form_params['project'] = params['project']
        if 'user' in params:
            form_params['user'] = params['user']

        body_params = None

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = ['read_key']

        response = self.api_client.call_api(resource_path, method,
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=files,
                                            response_type='User',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response

    def user_get_events(self, **kwargs):
        """
        Get events of the user
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.user_get_events(callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str project: 
        :param str user: 
        :param int limit: 
        :param datetime offset: 
        :return: list[CollectionEvent]
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['project', 'user', 'limit', 'offset']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method user_get_events" % key
                )
            params[key] = val
        del params['kwargs']


        resource_path = '/user/get_events'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}
        if 'project' in params:
            form_params['project'] = params['project']
        if 'user' in params:
            form_params['user'] = params['user']
        if 'limit' in params:
            form_params['limit'] = params['limit']
        if 'offset' in params:
            form_params['offset'] = params['offset']

        body_params = None

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = ['read_key']

        response = self.api_client.call_api(resource_path, method,
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=files,
                                            response_type='list[CollectionEvent]',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response

    def user_increment_property(self, **kwargs):
        """
        Set user property
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.user_increment_property(user_increment_property=user_increment_property_value, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param UserIncrementProperty user_increment_property:  (required)
        :return: JsonResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_increment_property']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method user_increment_property" % key
                )
            params[key] = val
        del params['kwargs']

        # verify the required parameter 'user_increment_property' is set
        if ('user_increment_property' not in params) or (params['user_increment_property'] is None):
            raise ValueError("Missing the required parameter `user_increment_property` when calling `user_increment_property`")

        resource_path = '/user/increment_property'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}

        body_params = None
        if 'user_increment_property' in params:
            body_params = params['user_increment_property']

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = []

        response = self.api_client.call_api(resource_path, method,
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=files,
                                            response_type='JsonResponse',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response

    def user_merge_user(self, **kwargs):
        """
        Merge user with anonymous id
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.user_merge_user(user_merge_user=user_merge_user_value, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param UserMergeUser user_merge_user:  (required)
        :return: bool
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_merge_user']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method user_merge_user" % key
                )
            params[key] = val
        del params['kwargs']

        # verify the required parameter 'user_merge_user' is set
        if ('user_merge_user' not in params) or (params['user_merge_user'] is None):
            raise ValueError("Missing the required parameter `user_merge_user` when calling `user_merge_user`")

        resource_path = '/user/merge'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}

        body_params = None
        if 'user_merge_user' in params:
            body_params = params['user_merge_user']

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = ['read_key']

        response = self.api_client.call_api(resource_path, method,
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=files,
                                            response_type='bool',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response

    def user_get_metadata(self, **kwargs):
        """
        Get user storage metadata
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.user_get_metadata(callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str project: 
        :return: MetadataResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['project']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method user_get_metadata" % key
                )
            params[key] = val
        del params['kwargs']


        resource_path = '/user/metadata'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}
        if 'project' in params:
            form_params['project'] = params['project']

        body_params = None

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = ['read_key']

        response = self.api_client.call_api(resource_path, method,
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=files,
                                            response_type='MetadataResponse',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response

    def user_search_users(self, **kwargs):
        """
        Search users
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.user_search_users(user_search_users=user_search_users_value, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param UserSearchUsers user_search_users:  (required)
        :return: QueryResult
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_search_users']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method user_search_users" % key
                )
            params[key] = val
        del params['kwargs']

        # verify the required parameter 'user_search_users' is set
        if ('user_search_users' not in params) or (params['user_search_users'] is None):
            raise ValueError("Missing the required parameter `user_search_users` when calling `user_search_users`")

        resource_path = '/user/search'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}

        body_params = None
        if 'user_search_users' in params:
            body_params = params['user_search_users']

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = ['read_key']

        response = self.api_client.call_api(resource_path, method,
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=files,
                                            response_type='QueryResult',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response

    def user_set_properties(self, **kwargs):
        """
        Set user properties
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.user_set_properties(set_user_properties=set_user_properties_value, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param SetUserProperties set_user_properties:  (required)
        :return: int
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['set_user_properties']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method user_set_properties" % key
                )
            params[key] = val
        del params['kwargs']

        # verify the required parameter 'set_user_properties' is set
        if ('set_user_properties' not in params) or (params['set_user_properties'] is None):
            raise ValueError("Missing the required parameter `set_user_properties` when calling `user_set_properties`")

        resource_path = '/user/set_properties'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}

        body_params = None
        if 'set_user_properties' in params:
            body_params = params['set_user_properties']

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = []

        response = self.api_client.call_api(resource_path, method,
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=files,
                                            response_type='int',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response

    def user_set_properties_once(self, **kwargs):
        """
        Set user properties once
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.user_set_properties_once(set_user_properties=set_user_properties_value, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param SetUserProperties set_user_properties:  (required)
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['set_user_properties']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method user_set_properties_once" % key
                )
            params[key] = val
        del params['kwargs']

        # verify the required parameter 'set_user_properties' is set
        if ('set_user_properties' not in params) or (params['set_user_properties'] is None):
            raise ValueError("Missing the required parameter `set_user_properties` when calling `user_set_properties_once`")

        resource_path = '/user/set_properties_once'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}

        body_params = None
        if 'set_user_properties' in params:
            body_params = params['set_user_properties']

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = []

        response = self.api_client.call_api(resource_path, method,
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=files,
                                            response_type=None,
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response

    def user_unset_property(self, **kwargs):
        """
        Unset user property
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.user_unset_property(user_unset_property=user_unset_property_value, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param UserUnsetProperty user_unset_property:  (required)
        :return: JsonResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_unset_property']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method user_unset_property" % key
                )
            params[key] = val
        del params['kwargs']

        # verify the required parameter 'user_unset_property' is set
        if ('user_unset_property' not in params) or (params['user_unset_property'] is None):
            raise ValueError("Missing the required parameter `user_unset_property` when calling `user_unset_property`")

        resource_path = '/user/unset_properties'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}

        body_params = None
        if 'user_unset_property' in params:
            body_params = params['user_unset_property']

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = []

        response = self.api_client.call_api(resource_path, method,
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=files,
                                            response_type='JsonResponse',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response
