# coding: utf-8

"""
ContinuousqueryApi.py
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


class ContinuousqueryApi(object):
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

    def create(self, continuous_query, **kwargs):
        """
        Create stream
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.create(continuous_query, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param ContinuousQuery continuous_query:  (required)
        :return: JsonResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """
        # verify the required parameter 'continuous_query' is set
        if continuous_query is None:
            raise ValueError("Missing the required parameter `continuous_query` when calling `create`")

        all_params = ['continuous_query']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method create" % key
                )
            params[key] = val
        del params['kwargs']

        resource_path = '/continuous-query/create'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}

        body_params = None
        if 'continuous_query' in params:
            body_params = params['continuous_query']

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

    def delete(self, **kwargs):
        """
        Delete stream
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.delete(callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str project: 
        :param str name: 
        :return: JsonResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['project', 'name']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method delete" % key
                )
            params[key] = val
        del params['kwargs']

        resource_path = '/continuous-query/delete'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}
        if 'project' in params:
            form_params['project'] = params['project']
        if 'name' in params:
            form_params['name'] = params['name']

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

    def list_queries(self, **kwargs):
        """
        List queries
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.list_queries(callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str project: 
        :return: list[ContinuousQuery]
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
                    " to method list_queries" % key
                )
            params[key] = val
        del params['kwargs']

        resource_path = '/continuous-query/list'.replace('{format}', 'json')
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
        auth_settings = []

        response = self.api_client.call_api(resource_path, method,
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=files,
                                            response_type='list[ContinuousQuery]',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response

    def schema(self, **kwargs):
        """
        Get query schema
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.schema(callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str project: 
        :return: list[Collection]
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
                    " to method schema" % key
                )
            params[key] = val
        del params['kwargs']

        resource_path = '/continuous-query/schema'.replace('{format}', 'json')
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
        auth_settings = []

        response = self.api_client.call_api(resource_path, method,
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=files,
                                            response_type='list[Collection]',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response

    def test(self, **kwargs):
        """
        Test continuous query
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.test(callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str project: 
        :param str query: 
        :return: list[SchemaField]
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['project', 'query']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method test" % key
                )
            params[key] = val
        del params['kwargs']

        resource_path = '/continuous-query/test'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}
        if 'project' in params:
            form_params['project'] = params['project']
        if 'query' in params:
            form_params['query'] = params['query']

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
        auth_settings = []

        response = self.api_client.call_api(resource_path, method,
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=files,
                                            response_type='list[SchemaField]',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response