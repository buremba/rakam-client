# coding: utf-8

"""
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

    Ref: https://github.com/swagger-api/swagger-codegen
"""

from pprint import pformat
from six import iteritems


class UserMailboxActionBatchSendMessages(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self):
        """
        UserMailboxActionBatchSendMessages - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'project': 'str',
            'filter': 'str',
            'event_filters': 'list[EventFilter]',
            'config': 'MailAction'
        }

        self.attribute_map = {
            'project': 'project',
            'filter': 'filter',
            'event_filters': 'event_filters',
            'config': 'config'
        }

        self._project = None
        self._filter = None
        self._event_filters = None
        self._config = None

    @property
    def project(self):
        """
        Gets the project of this UserMailboxActionBatchSendMessages.


        :return: The project of this UserMailboxActionBatchSendMessages.
        :rtype: str
        """
        return self._project

    @project.setter
    def project(self, project):
        """
        Sets the project of this UserMailboxActionBatchSendMessages.


        :param project: The project of this UserMailboxActionBatchSendMessages.
        :type: str
        """
        self._project = project

    @property
    def filter(self):
        """
        Gets the filter of this UserMailboxActionBatchSendMessages.


        :return: The filter of this UserMailboxActionBatchSendMessages.
        :rtype: str
        """
        return self._filter

    @filter.setter
    def filter(self, filter):
        """
        Sets the filter of this UserMailboxActionBatchSendMessages.


        :param filter: The filter of this UserMailboxActionBatchSendMessages.
        :type: str
        """
        self._filter = filter

    @property
    def event_filters(self):
        """
        Gets the event_filters of this UserMailboxActionBatchSendMessages.


        :return: The event_filters of this UserMailboxActionBatchSendMessages.
        :rtype: list[EventFilter]
        """
        return self._event_filters

    @event_filters.setter
    def event_filters(self, event_filters):
        """
        Sets the event_filters of this UserMailboxActionBatchSendMessages.


        :param event_filters: The event_filters of this UserMailboxActionBatchSendMessages.
        :type: list[EventFilter]
        """
        self._event_filters = event_filters

    @property
    def config(self):
        """
        Gets the config of this UserMailboxActionBatchSendMessages.


        :return: The config of this UserMailboxActionBatchSendMessages.
        :rtype: MailAction
        """
        return self._config

    @config.setter
    def config(self, config):
        """
        Sets the config of this UserMailboxActionBatchSendMessages.


        :param config: The config of this UserMailboxActionBatchSendMessages.
        :type: MailAction
        """
        self._config = config

    def to_dict(self):
        """
        Returns the model properties as a dict
        """
        result = {}

        for attr, _ in iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            else:
                result[attr] = value

        return result

    def to_str(self):
        """
        Returns the string representation of the model
        """
        return pformat(self.to_dict())

    def __repr__(self):
        """
        For `print` and `pprint`
        """
        return self.to_str()

    def __eq__(self, other): 
        """
        Returns true if both objects are equal
        """
        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """ 
        Returns true if both objects are not equal
        """
        return not self == other
