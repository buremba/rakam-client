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


class Threshold(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self):
        """
        Threshold - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'aggregation': 'str',
            'field_name': 'str',
            'value': 'int'
        }

        self.attribute_map = {
            'aggregation': 'aggregation',
            'field_name': 'fieldName',
            'value': 'value'
        }

        self._aggregation = None
        self._field_name = None
        self._value = None

    @property
    def aggregation(self):
        """
        Gets the aggregation of this Threshold.


        :return: The aggregation of this Threshold.
        :rtype: str
        """
        return self._aggregation

    @aggregation.setter
    def aggregation(self, aggregation):
        """
        Sets the aggregation of this Threshold.


        :param aggregation: The aggregation of this Threshold.
        :type: str
        """
        allowed_values = ["count", "sum"]
        if aggregation not in allowed_values:
            raise ValueError(
                "Invalid value for `aggregation`, must be one of {0}"
                .format(allowed_values)
            )
        self._aggregation = aggregation

    @property
    def field_name(self):
        """
        Gets the field_name of this Threshold.


        :return: The field_name of this Threshold.
        :rtype: str
        """
        return self._field_name

    @field_name.setter
    def field_name(self, field_name):
        """
        Sets the field_name of this Threshold.


        :param field_name: The field_name of this Threshold.
        :type: str
        """
        self._field_name = field_name

    @property
    def value(self):
        """
        Gets the value of this Threshold.


        :return: The value of this Threshold.
        :rtype: int
        """
        return self._value

    @value.setter
    def value(self, value):
        """
        Sets the value of this Threshold.


        :param value: The value of this Threshold.
        :type: int
        """
        self._value = value

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