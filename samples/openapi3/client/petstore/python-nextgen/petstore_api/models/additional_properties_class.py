# coding: utf-8

"""
    OpenAPI Petstore

    This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


try:
    from inspect import getfullargspec
except ImportError:
    from inspect import getargspec as getfullargspec
import pprint
import re  # noqa: F401
import six

from petstore_api.configuration import Configuration


class AdditionalPropertiesClass(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'map_property': 'dict(str, str)',
        'map_of_map_property': 'dict(str, dict(str, str))'
    }

    attribute_map = {
        'map_property': 'map_property',
        'map_of_map_property': 'map_of_map_property'
    }

    def __init__(self, map_property=None, map_of_map_property=None):  # noqa: E501
        """AdditionalPropertiesClass - a model defined in OpenAPI"""  # noqa: E501

        self._map_property = None
        self._map_of_map_property = None
        self.discriminator = None

        if map_property is not None:
            self.map_property = map_property
        if map_of_map_property is not None:
            self.map_of_map_property = map_of_map_property

    @property
    def map_property(self):
        """Gets the map_property of this AdditionalPropertiesClass.  # noqa: E501


        :return: The map_property of this AdditionalPropertiesClass.  # noqa: E501
        :rtype: dict(str, str)
        """
        return self._map_property

    @map_property.setter
    def map_property(self, map_property):
        """Sets the map_property of this AdditionalPropertiesClass.


        :param map_property: The map_property of this AdditionalPropertiesClass.  # noqa: E501
        :type map_property: dict(str, str)
        """

        self._map_property = map_property

    @property
    def map_of_map_property(self):
        """Gets the map_of_map_property of this AdditionalPropertiesClass.  # noqa: E501


        :return: The map_of_map_property of this AdditionalPropertiesClass.  # noqa: E501
        :rtype: dict(str, dict(str, str))
        """
        return self._map_of_map_property

    @map_of_map_property.setter
    def map_of_map_property(self, map_of_map_property):
        """Sets the map_of_map_property of this AdditionalPropertiesClass.


        :param map_of_map_property: The map_of_map_property of this AdditionalPropertiesClass.  # noqa: E501
        :type map_of_map_property: dict(str, dict(str, str))
        """

        self._map_of_map_property = map_of_map_property

    def to_dict(self, serialize=False):
        """Returns the model properties as a dict"""
        result = {}

        def convert(x):
            if hasattr(x, "to_dict"):
                args = getfullargspec(x.to_dict).args
                if len(args) == 1:
                    return x.to_dict()
                else:
                    return x.to_dict(serialize)
            else:
                return x

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            attr = self.attribute_map.get(attr, attr) if serialize else attr
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: convert(x),
                    value
                ))
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], convert(item[1])),
                    value.items()
                ))
            else:
                result[attr] = convert(value)

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, AdditionalPropertiesClass):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, AdditionalPropertiesClass):
            return True

        return self.to_dict() != other.to_dict()
