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


class OLAPTable(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self):
        """
        OLAPTable - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'project': 'str',
            'collections': 'list[str]',
            'dimensions': 'list[str]',
            'aggregations': 'list[str]',
            'measures': 'list[str]',
            'table_name': 'str'
        }

        self.attribute_map = {
            'project': 'project',
            'collections': 'collections',
            'dimensions': 'dimensions',
            'aggregations': 'aggregations',
            'measures': 'measures',
            'table_name': 'tableName'
        }

        self._project = None
        self._collections = None
        self._dimensions = None
        self._aggregations = None
        self._measures = None
        self._table_name = None

    @property
    def project(self):
        """
        Gets the project of this OLAPTable.


        :return: The project of this OLAPTable.
        :rtype: str
        """
        return self._project

    @project.setter
    def project(self, project):
        """
        Sets the project of this OLAPTable.


        :param project: The project of this OLAPTable.
        :type: str
        """
        self._project = project

    @property
    def collections(self):
        """
        Gets the collections of this OLAPTable.


        :return: The collections of this OLAPTable.
        :rtype: list[str]
        """
        return self._collections

    @collections.setter
    def collections(self, collections):
        """
        Sets the collections of this OLAPTable.


        :param collections: The collections of this OLAPTable.
        :type: list[str]
        """
        self._collections = collections

    @property
    def dimensions(self):
        """
        Gets the dimensions of this OLAPTable.


        :return: The dimensions of this OLAPTable.
        :rtype: list[str]
        """
        return self._dimensions

    @dimensions.setter
    def dimensions(self, dimensions):
        """
        Sets the dimensions of this OLAPTable.


        :param dimensions: The dimensions of this OLAPTable.
        :type: list[str]
        """
        self._dimensions = dimensions

    @property
    def aggregations(self):
        """
        Gets the aggregations of this OLAPTable.


        :return: The aggregations of this OLAPTable.
        :rtype: list[str]
        """
        return self._aggregations

    @aggregations.setter
    def aggregations(self, aggregations):
        """
        Sets the aggregations of this OLAPTable.


        :param aggregations: The aggregations of this OLAPTable.
        :type: list[str]
        """
        self._aggregations = aggregations

    @property
    def measures(self):
        """
        Gets the measures of this OLAPTable.


        :return: The measures of this OLAPTable.
        :rtype: list[str]
        """
        return self._measures

    @measures.setter
    def measures(self, measures):
        """
        Sets the measures of this OLAPTable.


        :param measures: The measures of this OLAPTable.
        :type: list[str]
        """
        self._measures = measures

    @property
    def table_name(self):
        """
        Gets the table_name of this OLAPTable.


        :return: The table_name of this OLAPTable.
        :rtype: str
        """
        return self._table_name

    @table_name.setter
    def table_name(self, table_name):
        """
        Sets the table_name of this OLAPTable.


        :param table_name: The table_name of this OLAPTable.
        :type: str
        """
        self._table_name = table_name

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
