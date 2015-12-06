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


class Variant(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self):
        """
        Variant - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'name': 'str',
            'weight': 'int',
            'data': 'object'
        }

        self.attribute_map = {
            'name': 'name',
            'weight': 'weight',
            'data': 'data'
        }

        self._name = None
        self._weight = None
        self._data = None

    @property
    def name(self):
        """
        Gets the name of this Variant.


        :return: The name of this Variant.
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """
        Sets the name of this Variant.


        :param name: The name of this Variant.
        :type: str
        """
        self._name = name

    @property
    def weight(self):
        """
        Gets the weight of this Variant.


        :return: The weight of this Variant.
        :rtype: int
        """
        return self._weight

    @weight.setter
    def weight(self, weight):
        """
        Sets the weight of this Variant.


        :param weight: The weight of this Variant.
        :type: int
        """
        self._weight = weight

    @property
    def data(self):
        """
        Gets the data of this Variant.


        :return: The data of this Variant.
        :rtype: object
        """
        return self._data

    @data.setter
    def data(self, data):
        """
        Sets the data of this Variant.


        :param data: The data of this Variant.
        :type: object
        """
        self._data = data

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
