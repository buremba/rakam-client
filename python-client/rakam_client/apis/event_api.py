# coding: utf-8

"""
EventApi.py
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


class EventApi(object):
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

    def batch_events(self, event_list, **kwargs):
        """
        Collect multiple events
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.batch_events(event_list, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param EventList event_list:  (required)
        :return: int
                 If the method is called asynchronously,
                 returns the request thread.
        """
        # verify the required parameter 'event_list' is set
        if event_list is None:
            raise ValueError("Missing the required parameter `event_list` when calling `batch_events`")

        all_params = ['event_list']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method batch_events" % key
                )
            params[key] = val
        del params['kwargs']

        resource_path = '/event/batch'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}

        body_params = None
        if 'event_list' in params:
            body_params = params['event_list']

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = ['write_key']

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

    def collect_event(self, event, **kwargs):
        """
        Collect event
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.collect_event(event, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param Event event:  (required)
        :return: int
                 If the method is called asynchronously,
                 returns the request thread.
        """
        # verify the required parameter 'event' is set
        if event is None:
            raise ValueError("Missing the required parameter `event` when calling `collect_event`")

        all_params = ['event']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method collect_event" % key
                )
            params[key] = val
        del params['kwargs']

        resource_path = '/event/collect'.replace('{format}', 'json')
        method = 'POST'

        path_params = {}

        query_params = {}

        header_params = {}

        form_params = {}
        files = {}

        body_params = None
        if 'event' in params:
            body_params = params['event']

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = ['write_key']

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

    def execute(self, **kwargs):
        """
        Analyze events
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.execute(callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str project: 
        :param str query: 
        :param int limit: 
        :return: QueryResult
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['project', 'query', 'limit']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method execute" % key
                )
            params[key] = val
        del params['kwargs']

        resource_path = '/query/execute'.replace('{format}', 'json')
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
        if 'limit' in params:
            form_params['limit'] = params['limit']

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
                                            response_type='QueryResult',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response
