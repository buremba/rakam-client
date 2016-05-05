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


class User(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self):
        """
        User - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'project': 'str',
            'id': 'str',
            'api': 'UserContext',
            'properties': 'dict(str, InlineResponse200)'
        }

        self.attribute_map = {
            'project': 'project',
            'id': 'id',
            'api': 'api',
            'properties': 'properties'
        }

        self._project = None
        self._id = None
        self._api = None
        self._properties = None

    @property
    def project(self):
        """
        Gets the project of this User.


        :return: The project of this User.
        :rtype: str
        """
        return self._project

    @project.setter
    def project(self, project):
        """
        Sets the project of this User.


        :param project: The project of this User.
        :type: str
        """
        self._project = project

    @property
    def id(self):
        """
        Gets the id of this User.


        :return: The id of this User.
        :rtype: str
        """
        return self._id

    @id.setter
    def id(self, id):
        """
        Sets the id of this User.


        :param id: The id of this User.
        :type: str
        """
        self._id = id

    @property
    def api(self):
        """
        Gets the api of this User.


        :return: The api of this User.
        :rtype: UserContext
        """
        return self._api

    @api.setter
    def api(self, api):
        """
        Sets the api of this User.


        :param api: The api of this User.
        :type: UserContext
        """
        self._api = api

    @property
    def properties(self):
        """
        Gets the properties of this User.


        :return: The properties of this User.
        :rtype: dict(str, InlineResponse200)
        """
        return self._properties

    @properties.setter
    def properties(self, properties):
        """
        Sets the properties of this User.


        :param properties: The properties of this User.
        :type: dict(str, InlineResponse200)
        """
        self._properties = properties

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

