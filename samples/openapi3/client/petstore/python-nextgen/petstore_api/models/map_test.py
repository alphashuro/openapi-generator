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


class MapTest(object):
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
        'map_map_of_string': 'dict(str, dict(str, str))',
        'map_of_enum_string': 'dict(str, str)',
        'direct_map': 'dict(str, bool)',
        'indirect_map': 'dict(str, bool)'
    }

    attribute_map = {
        'map_map_of_string': 'map_map_of_string',
        'map_of_enum_string': 'map_of_enum_string',
        'direct_map': 'direct_map',
        'indirect_map': 'indirect_map'
    }

    def __init__(self, map_map_of_string=None, map_of_enum_string=None, direct_map=None, indirect_map=None):  # noqa: E501
        """MapTest - a model defined in OpenAPI"""  # noqa: E501

        self._map_map_of_string = None
        self._map_of_enum_string = None
        self._direct_map = None
        self._indirect_map = None
        self.discriminator = None

        if map_map_of_string is not None:
            self.map_map_of_string = map_map_of_string
        if map_of_enum_string is not None:
            self.map_of_enum_string = map_of_enum_string
        if direct_map is not None:
            self.direct_map = direct_map
        if indirect_map is not None:
            self.indirect_map = indirect_map

    @property
    def map_map_of_string(self):
        """Gets the map_map_of_string of this MapTest.  # noqa: E501


        :return: The map_map_of_string of this MapTest.  # noqa: E501
        :rtype: dict(str, dict(str, str))
        """
        return self._map_map_of_string

    @map_map_of_string.setter
    def map_map_of_string(self, map_map_of_string):
        """Sets the map_map_of_string of this MapTest.


        :param map_map_of_string: The map_map_of_string of this MapTest.  # noqa: E501
        :type map_map_of_string: dict(str, dict(str, str))
        """

        self._map_map_of_string = map_map_of_string

    @property
    def map_of_enum_string(self):
        """Gets the map_of_enum_string of this MapTest.  # noqa: E501


        :return: The map_of_enum_string of this MapTest.  # noqa: E501
        :rtype: dict(str, str)
        """
        return self._map_of_enum_string

    @map_of_enum_string.setter
    def map_of_enum_string(self, map_of_enum_string):
        """Sets the map_of_enum_string of this MapTest.


        :param map_of_enum_string: The map_of_enum_string of this MapTest.  # noqa: E501
        :type map_of_enum_string: dict(str, str)
        """
        allowed_values = ["UPPER", "lower"]  # noqa: E501
        if not set(map_of_enum_string.keys()).issubset(set(allowed_values)):  # noqa: E501
            raise ValueError(
                "Invalid keys in `map_of_enum_string` [{0}], must be a subset of [{1}]"  # noqa: E501
                .format(", ".join(map(str, set(map_of_enum_string.keys()) - set(allowed_values))),  # noqa: E501
                        ", ".join(map(str, allowed_values)))
            )

        self._map_of_enum_string = map_of_enum_string

    @property
    def direct_map(self):
        """Gets the direct_map of this MapTest.  # noqa: E501


        :return: The direct_map of this MapTest.  # noqa: E501
        :rtype: dict(str, bool)
        """
        return self._direct_map

    @direct_map.setter
    def direct_map(self, direct_map):
        """Sets the direct_map of this MapTest.


        :param direct_map: The direct_map of this MapTest.  # noqa: E501
        :type direct_map: dict(str, bool)
        """

        self._direct_map = direct_map

    @property
    def indirect_map(self):
        """Gets the indirect_map of this MapTest.  # noqa: E501


        :return: The indirect_map of this MapTest.  # noqa: E501
        :rtype: dict(str, bool)
        """
        return self._indirect_map

    @indirect_map.setter
    def indirect_map(self, indirect_map):
        """Sets the indirect_map of this MapTest.


        :param indirect_map: The indirect_map of this MapTest.  # noqa: E501
        :type indirect_map: dict(str, bool)
        """

        self._indirect_map = indirect_map

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
        if not isinstance(other, MapTest):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, MapTest):
            return True

        return self.to_dict() != other.to_dict()
