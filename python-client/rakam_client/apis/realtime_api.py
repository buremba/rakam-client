# coding: utf-8

"""
RealtimeApi.py
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


class RealtimeApi(object):
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

    def create(self, **kwargs):
        """
        Create report
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.create(callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str project: 
        :param str name: 
        :param str aggregation: 
        :param str table_name: 
        :param list[str] collections: 
        :param str filter: 
        :param str measure: 
        :param list[str] dimensions: 
        :return: JsonResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['project', 'name', 'aggregation', 'table_name', 'collections', 'filter', 'measure', 'dimensions']
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

        resource_path = '/realtime/create'.replace('{format}', 'json')
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
        if 'aggregation' in params:
            form_params['aggregation'] = params['aggregation']
        if 'table_name' in params:
            form_params['table_name'] = params['table_name']
        if 'collections' in params:
            form_params['collections'] = params['collections']
        if 'filter' in params:
            form_params['filter'] = params['filter']
        if 'measure' in params:
            form_params['measure'] = params['measure']
        if 'dimensions' in params:
            form_params['dimensions'] = params['dimensions']

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
                                            response_type='JsonResponse',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response

    def delete(self, **kwargs):
        """
        Delete report
        

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

        resource_path = '/realtime/delete'.replace('{format}', 'json')
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

    def get(self, **kwargs):
        """
        Get report
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get(callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str project: 
        :param str table_name: 
        :param str filter: 
        :param str aggregation: 
        :param str measure: 
        :param list[str] dimensions: 
        :param bool aggregate: 
        :param datetime date_start: 
        :param datetime date_end: 
        :return: object
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['project', 'table_name', 'filter', 'aggregation', 'measure', 'dimensions', 'aggregate', 'date_start', 'date_end']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get" % key
                )
            params[key] = val
        del params['kwargs']

        resource_path = '/realtime/get'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}
        if 'project' in params:
            form_params['project'] = params['project']
        if 'table_name' in params:
            form_params['table_name'] = params['table_name']
        if 'filter' in params:
            form_params['filter'] = params['filter']
        if 'aggregation' in params:
            form_params['aggregation'] = params['aggregation']
        if 'measure' in params:
            form_params['measure'] = params['measure']
        if 'dimensions' in params:
            form_params['dimensions'] = params['dimensions']
        if 'aggregate' in params:
            form_params['aggregate'] = params['aggregate']
        if 'date_start' in params:
            form_params['date_start'] = params['date_start']
        if 'date_end' in params:
            form_params['date_end'] = params['date_end']

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
                                            response_type='object',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response

    def list_reports(self, **kwargs):
        """
        List reports
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.list_reports(callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str project: 
        :return: list[RealTimeReport]
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
                    " to method list_reports" % key
                )
            params[key] = val
        del params['kwargs']

        resource_path = '/realtime/list'.replace('{format}', 'json')
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
                                            response_type='list[RealTimeReport]',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response