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


class QueryError(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self):
        """
        QueryError - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'message': 'str',
            'sql_state': 'str',
            'error_code': 'int',
            'error_line': 'int',
            'char_position_in_line': 'int'
        }

        self.attribute_map = {
            'message': 'message',
            'sql_state': 'sqlState',
            'error_code': 'errorCode',
            'error_line': 'errorLine',
            'char_position_in_line': 'charPositionInLine'
        }

        self._message = None
        self._sql_state = None
        self._error_code = None
        self._error_line = None
        self._char_position_in_line = None

    @property
    def message(self):
        """
        Gets the message of this QueryError.


        :return: The message of this QueryError.
        :rtype: str
        """
        return self._message

    @message.setter
    def message(self, message):
        """
        Sets the message of this QueryError.


        :param message: The message of this QueryError.
        :type: str
        """
        self._message = message

    @property
    def sql_state(self):
        """
        Gets the sql_state of this QueryError.


        :return: The sql_state of this QueryError.
        :rtype: str
        """
        return self._sql_state

    @sql_state.setter
    def sql_state(self, sql_state):
        """
        Sets the sql_state of this QueryError.


        :param sql_state: The sql_state of this QueryError.
        :type: str
        """
        self._sql_state = sql_state

    @property
    def error_code(self):
        """
        Gets the error_code of this QueryError.


        :return: The error_code of this QueryError.
        :rtype: int
        """
        return self._error_code

    @error_code.setter
    def error_code(self, error_code):
        """
        Sets the error_code of this QueryError.


        :param error_code: The error_code of this QueryError.
        :type: int
        """
        self._error_code = error_code

    @property
    def error_line(self):
        """
        Gets the error_line of this QueryError.


        :return: The error_line of this QueryError.
        :rtype: int
        """
        return self._error_line

    @error_line.setter
    def error_line(self, error_line):
        """
        Sets the error_line of this QueryError.


        :param error_line: The error_line of this QueryError.
        :type: int
        """
        self._error_line = error_line

    @property
    def char_position_in_line(self):
        """
        Gets the char_position_in_line of this QueryError.


        :return: The char_position_in_line of this QueryError.
        :rtype: int
        """
        return self._char_position_in_line

    @char_position_in_line.setter
    def char_position_in_line(self, char_position_in_line):
        """
        Sets the char_position_in_line of this QueryError.


        :param char_position_in_line: The char_position_in_line of this QueryError.
        :type: int
        """
        self._char_position_in_line = char_position_in_line

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

