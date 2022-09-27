# coding: utf-8

"""
    openapi 3.0.3 sample spec

    sample spec for testing openapi functionality, built from json schema tests for draft6  # noqa: E501

    The version of the OpenAPI document: 0.0.1
    Generated by: https://openapi-generator.tech
"""

from datetime import date, datetime  # noqa: F401
import decimal  # noqa: F401
import functools  # noqa: F401
import io  # noqa: F401
import re  # noqa: F401
import typing  # noqa: F401
import typing_extensions  # noqa: F401
import uuid  # noqa: F401

import frozendict  # noqa: F401

from unit_test_api import schemas  # noqa: F401


class NestedItems(
    schemas.ListSchema
):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """


    class MetaOapg:
        
        
        class items(
            schemas.ListSchema
        ):
        
        
            class MetaOapg:
                
                
                class items(
                    schemas.ListSchema
                ):
                
                
                    class MetaOapg:
                        
                        
                        class items(
                            schemas.ListSchema
                        ):
                        
                        
                            class MetaOapg:
                                items = schemas.NumberSchema
                        
                            def __new__(
                                cls,
                                arg: typing.Union[typing.Tuple[typing.Union[MetaOapg.items, decimal.Decimal, int, float, ]], typing.List[typing.Union[MetaOapg.items, decimal.Decimal, int, float, ]]],
                                _configuration: typing.Optional[schemas.Configuration] = None,
                            ) -> 'items':
                                return super().__new__(
                                    cls,
                                    arg,
                                    _configuration=_configuration,
                                )
                        
                            def __getitem__(self, i: int) -> MetaOapg.items:
                                return super().__getitem__(i)
                
                    def __new__(
                        cls,
                        arg: typing.Union[typing.Tuple[typing.Union[MetaOapg.items, list, tuple, ]], typing.List[typing.Union[MetaOapg.items, list, tuple, ]]],
                        _configuration: typing.Optional[schemas.Configuration] = None,
                    ) -> 'items':
                        return super().__new__(
                            cls,
                            arg,
                            _configuration=_configuration,
                        )
                
                    def __getitem__(self, i: int) -> MetaOapg.items:
                        return super().__getitem__(i)
        
            def __new__(
                cls,
                arg: typing.Union[typing.Tuple[typing.Union[MetaOapg.items, list, tuple, ]], typing.List[typing.Union[MetaOapg.items, list, tuple, ]]],
                _configuration: typing.Optional[schemas.Configuration] = None,
            ) -> 'items':
                return super().__new__(
                    cls,
                    arg,
                    _configuration=_configuration,
                )
        
            def __getitem__(self, i: int) -> MetaOapg.items:
                return super().__getitem__(i)

    def __new__(
        cls,
        arg: typing.Union[typing.Tuple[typing.Union[MetaOapg.items, list, tuple, ]], typing.List[typing.Union[MetaOapg.items, list, tuple, ]]],
        _configuration: typing.Optional[schemas.Configuration] = None,
    ) -> 'NestedItems':
        return super().__new__(
            cls,
            arg,
            _configuration=_configuration,
        )

    def __getitem__(self, i: int) -> MetaOapg.items:
        return super().__getitem__(i)
