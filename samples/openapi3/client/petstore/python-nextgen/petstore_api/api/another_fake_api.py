# coding: utf-8

"""
    OpenAPI Petstore

    This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import re  # noqa: F401

from pydantic import validate_arguments, ValidationError
from typing_extensions import Annotated
from petstore_api import models

from pydantic import Field

from petstore_api import models

from petstore_api.api_client import ApiClient
from petstore_api.exceptions import (  # noqa: F401
    ApiTypeError,
    ApiValueError
)


class AnotherFakeApi(object):
    """NOTE: This class is auto generated by OpenAPI Generator
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client

    #@validate_arguments
    def call_123_test_special_tags(self, client : Annotated[models.Client, Field(..., description="client model")], **kwargs):  # noqa: E501
        """To test special tags  # noqa: E501

        To test special tags and operation ID starting with number  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.call_123_test_special_tags(client, async_req=True)
        >>> result = thread.get()

        :param client: client model (required)
        :type client: Client
        :param async_req: Whether to execute the request asynchronously.
        :type async_req: bool, optional
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :type _preload_content: bool, optional
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: Returns the result object.
                 If the method is called asynchronously,
                 returns the request thread.
        :rtype: Client
        """
        kwargs['_return_http_data_only'] = True
        return self.call_123_test_special_tags_with_http_info(client, **kwargs)  # noqa: E501

    #@validate_arguments
    def call_123_test_special_tags_with_http_info(self, client : Annotated[models.Client, Field(..., description="client model")], **kwargs):  # noqa: E501
        """To test special tags  # noqa: E501

        To test special tags and operation ID starting with number  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.call_123_test_special_tags_with_http_info(client, async_req=True)
        >>> result = thread.get()

        :param client: client model (required)
        :type client: Client
        :param async_req: Whether to execute the request asynchronously.
        :type async_req: bool, optional
        :param _return_http_data_only: response data without head status code
                                       and headers
        :type _return_http_data_only: bool, optional
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :type _preload_content: bool, optional
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :param _request_auth: set to override the auth_settings for an a single
                              request; this effectively ignores the authentication
                              in the spec for a single request.
        :type _request_auth: dict, optional
        :type _content_type: string, optional: force content-type for the request
        :return: Returns the result object.
                 If the method is called asynchronously,
                 returns the request thread.
        :rtype: tuple(Client, status_code(int), headers(HTTPHeaderDict))
        """

        local_var_params = locals()

        all_params = [
            'client'
        ]
        all_params.extend(
            [
                'async_req',
                '_return_http_data_only',
                '_preload_content',
                '_request_timeout',
                '_request_auth',
                '_content_type',
                '_headers'
            ]
        )

        for key, val in local_var_params['kwargs'].items():
            if key not in all_params:
                raise ApiTypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method call_123_test_special_tags" % key
                )
            local_var_params[key] = val
        del local_var_params['kwargs']
        # verify the required parameter 'client' is set
        if self.api_client.client_side_validation and local_var_params.get('client') is None:  # noqa: E501
            raise ApiValueError("Missing the required parameter `client` when calling `call_123_test_special_tags`")  # noqa: E501
        collection_formats = {}

        path_params = {}

        query_params = []

        header_params = dict(local_var_params.get('_headers', {}))

        form_params = []
        local_var_files = {}

        body_params = None
        if 'client' in local_var_params:
            body_params = local_var_params['client']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # HTTP header `Content-Type`
        content_types_list = local_var_params.get('_content_type',
            self.api_client.select_header_content_type(
                ['application/json'],
                'PATCH', body_params))  # noqa: E501
        if content_types_list:
                header_params['Content-Type'] = content_types_list

        # Authentication setting
        auth_settings = []  # noqa: E501

        response_types_map = {
            200: "Client",
        }

        return self.api_client.call_api(
            '/another-fake/dummy', 'PATCH',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_types_map=response_types_map,
            auth_settings=auth_settings,
            async_req=local_var_params.get('async_req'),
            _return_http_data_only=local_var_params.get('_return_http_data_only'),  # noqa: E501
            _preload_content=local_var_params.get('_preload_content', True),
            _request_timeout=local_var_params.get('_request_timeout'),
            collection_formats=collection_formats,
            _request_auth=local_var_params.get('_request_auth'))
