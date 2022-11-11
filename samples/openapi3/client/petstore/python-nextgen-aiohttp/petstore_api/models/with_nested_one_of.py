# coding: utf-8

"""
    OpenAPI Petstore

    This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


from __future__ import annotations
from inspect import getfullargspec
import pprint
import re  # noqa: F401
import json


from typing import Optional
from pydantic import BaseModel, StrictInt
from petstore_api.models.pig import Pig
from pydantic import ValidationError

class WithNestedOneOf(BaseModel):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """
    size: Optional[StrictInt] = None
    nested_pig: Optional[Pig] = None

    class Config:
        allow_population_by_field_name = True
        validate_assignment = True

    def to_str(self) -> str:
        """Returns the string representation of the model using alias"""
        return pprint.pformat(self.to_dict())

    def to_json(self) -> str:
        """Returns the JSON representation of the model using alias"""
        return json.dumps(self.to_dict())

    @classmethod
    def from_json(cls, json_str: str) -> WithNestedOneOf:
        """Create an instance of WithNestedOneOf from a JSON string"""
        return cls.from_dict(json.loads(json_str))

    def to_dict(self):
        """Returns the dictionary representation of the model using alias"""
        _dict = self.dict(by_alias=True, exclude_none=True)
        # override the default output from pydantic by calling `to_dict()` of nested_pig
        if self.nested_pig:
            _dict['nested_pig'] = self.nested_pig.to_dict()

        return _dict

    @classmethod
    def from_dict(cls, obj: dict) -> WithNestedOneOf:
        """Create an instance of WithNestedOneOf from a dict"""
        if type(obj) is not dict:
            return WithNestedOneOf.parse_obj(obj)

        return WithNestedOneOf.parse_obj({
            "size": obj.get("size"),
            "nested_pig": Pig.from_dict(obj.get("nested_pig"))
        })


