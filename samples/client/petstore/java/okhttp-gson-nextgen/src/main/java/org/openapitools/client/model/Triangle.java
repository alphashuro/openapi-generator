/*
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import org.openapitools.client.model.EquilateralTriangle;
import org.openapitools.client.model.IsoscelesTriangle;
import org.openapitools.client.model.ScaleneTriangle;

import javax.ws.rs.core.GenericType;

import java.io.IOException;
import java.lang.reflect.Type;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.ArrayList;
import java.util.Collections;
import java.util.HashSet;
import java.util.HashMap;
import java.util.Map;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapter;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;
import com.google.gson.JsonPrimitive;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonSerializationContext;
import com.google.gson.JsonSerializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;

import org.openapitools.client.JSON;

@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen")
public class Triangle extends AbstractOpenApiSchema {
    private static final Logger log = Logger.getLogger(Triangle.class.getName());

    public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
        @SuppressWarnings("unchecked")
        @Override
        public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
            if (!Triangle.class.isAssignableFrom(type.getRawType())) {
                return null; // this class only serializes 'Triangle' and its subtypes
            }
            final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
            final TypeAdapter<EquilateralTriangle> adapterEquilateralTriangle = gson.getDelegateAdapter(this, TypeToken.get(EquilateralTriangle.class));
            final TypeAdapter<IsoscelesTriangle> adapterIsoscelesTriangle = gson.getDelegateAdapter(this, TypeToken.get(IsoscelesTriangle.class));
            final TypeAdapter<ScaleneTriangle> adapterScaleneTriangle = gson.getDelegateAdapter(this, TypeToken.get(ScaleneTriangle.class));

            return (TypeAdapter<T>) new TypeAdapter<Triangle>() {
                @Override
                public void write(JsonWriter out, Triangle value) throws IOException {
                    if (value == null || value.getActualInstance() == null) {
                        elementAdapter.write(out, null);
                        return;
                    }

                    // check if the actual instance is of the type `EquilateralTriangle`
                    if (value.getActualInstance() instanceof EquilateralTriangle) {
                        JsonObject obj = adapterEquilateralTriangle.toJsonTree((EquilateralTriangle)value.getActualInstance()).getAsJsonObject();
                        elementAdapter.write(out, obj);
                        return;
                    }

                    // check if the actual instance is of the type `IsoscelesTriangle`
                    if (value.getActualInstance() instanceof IsoscelesTriangle) {
                        JsonObject obj = adapterIsoscelesTriangle.toJsonTree((IsoscelesTriangle)value.getActualInstance()).getAsJsonObject();
                        elementAdapter.write(out, obj);
                        return;
                    }

                    // check if the actual instance is of the type `ScaleneTriangle`
                    if (value.getActualInstance() instanceof ScaleneTriangle) {
                        JsonObject obj = adapterScaleneTriangle.toJsonTree((ScaleneTriangle)value.getActualInstance()).getAsJsonObject();
                        elementAdapter.write(out, obj);
                        return;
                    }

                    throw new IOException("Failed to serialize as the type doesn't match oneOf schemas: EquilateralTriangle, IsoscelesTriangle, ScaleneTriangle");
                }

                @Override
                public Triangle read(JsonReader in) throws IOException {
                    Object deserialized = null;
                    JsonObject jsonObject = elementAdapter.read(in).getAsJsonObject();

                    int match = 0;
                    TypeAdapter actualAdapter = elementAdapter;

                    // deserialize EquilateralTriangle
                    try {
                        // validate the JSON object to see if any excpetion is thrown
                        EquilateralTriangle.validateJsonObject(jsonObject);
                        actualAdapter = adapterEquilateralTriangle;
                        match++;
                        log.log(Level.FINER, "Input data matches schema 'EquilateralTriangle'");
                    } catch (Exception e) {
                        // deserialization failed, continue
                        log.log(Level.FINER, "Input data does not match schema 'EquilateralTriangle'", e);
                    }

                    // deserialize IsoscelesTriangle
                    try {
                        // validate the JSON object to see if any excpetion is thrown
                        IsoscelesTriangle.validateJsonObject(jsonObject);
                        actualAdapter = adapterIsoscelesTriangle;
                        match++;
                        log.log(Level.FINER, "Input data matches schema 'IsoscelesTriangle'");
                    } catch (Exception e) {
                        // deserialization failed, continue
                        log.log(Level.FINER, "Input data does not match schema 'IsoscelesTriangle'", e);
                    }

                    // deserialize ScaleneTriangle
                    try {
                        // validate the JSON object to see if any excpetion is thrown
                        ScaleneTriangle.validateJsonObject(jsonObject);
                        actualAdapter = adapterScaleneTriangle;
                        match++;
                        log.log(Level.FINER, "Input data matches schema 'ScaleneTriangle'");
                    } catch (Exception e) {
                        // deserialization failed, continue
                        log.log(Level.FINER, "Input data does not match schema 'ScaleneTriangle'", e);
                    }

                    if (match == 1) {
                        Triangle ret = new Triangle();
                        ret.setActualInstance(actualAdapter.fromJsonTree(jsonObject));
                        return ret;
                    }

                    throw new IOException(String.format("Failed deserialization for Triangle: %d classes match result, expected 1. JSON: %s", match, jsonObject.toString()));
                }
            }.nullSafe();
        }
    }

    // store a list of schema names defined in oneOf
    public static final Map<String, GenericType> schemas = new HashMap<String, GenericType>();

    public Triangle() {
        super("oneOf", Boolean.FALSE);
    }

    public Triangle(EquilateralTriangle o) {
        super("oneOf", Boolean.FALSE);
        setActualInstance(o);
    }

    public Triangle(IsoscelesTriangle o) {
        super("oneOf", Boolean.FALSE);
        setActualInstance(o);
    }

    public Triangle(ScaleneTriangle o) {
        super("oneOf", Boolean.FALSE);
        setActualInstance(o);
    }

    static {
        schemas.put("EquilateralTriangle", new GenericType<EquilateralTriangle>() {
        });
        schemas.put("IsoscelesTriangle", new GenericType<IsoscelesTriangle>() {
        });
        schemas.put("ScaleneTriangle", new GenericType<ScaleneTriangle>() {
        });
    }

    @Override
    public Map<String, GenericType> getSchemas() {
        return Triangle.schemas;
    }

    /**
     * Set the instance that matches the oneOf child schema, check
     * the instance parameter is valid against the oneOf child schemas:
     * EquilateralTriangle, IsoscelesTriangle, ScaleneTriangle
     *
     * It could be an instance of the 'oneOf' schemas.
     * The oneOf child schemas may themselves be a composed schema (allOf, anyOf, oneOf).
     */
    @Override
    public void setActualInstance(Object instance) {
        if (instance instanceof EquilateralTriangle) {
            super.setActualInstance(instance);
            return;
        }

        if (instance instanceof IsoscelesTriangle) {
            super.setActualInstance(instance);
            return;
        }

        if (instance instanceof ScaleneTriangle) {
            super.setActualInstance(instance);
            return;
        }

        throw new RuntimeException("Invalid instance type. Must be EquilateralTriangle, IsoscelesTriangle, ScaleneTriangle");
    }

    /**
     * Get the actual instance, which can be the following:
     * EquilateralTriangle, IsoscelesTriangle, ScaleneTriangle
     *
     * @return The actual instance (EquilateralTriangle, IsoscelesTriangle, ScaleneTriangle)
     */
    @Override
    public Object getActualInstance() {
        return super.getActualInstance();
    }

    /**
     * Get the actual instance of `EquilateralTriangle`. If the actual instance is not `EquilateralTriangle`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `EquilateralTriangle`
     * @throws ClassCastException if the instance is not `EquilateralTriangle`
     */
    public EquilateralTriangle getEquilateralTriangle() throws ClassCastException {
        return (EquilateralTriangle)super.getActualInstance();
    }

    /**
     * Get the actual instance of `IsoscelesTriangle`. If the actual instance is not `IsoscelesTriangle`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `IsoscelesTriangle`
     * @throws ClassCastException if the instance is not `IsoscelesTriangle`
     */
    public IsoscelesTriangle getIsoscelesTriangle() throws ClassCastException {
        return (IsoscelesTriangle)super.getActualInstance();
    }

    /**
     * Get the actual instance of `ScaleneTriangle`. If the actual instance is not `ScaleneTriangle`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `ScaleneTriangle`
     * @throws ClassCastException if the instance is not `ScaleneTriangle`
     */
    public ScaleneTriangle getScaleneTriangle() throws ClassCastException {
        return (ScaleneTriangle)super.getActualInstance();
    }


 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to Triangle
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
    // validate oneOf schemas one by one
    int validCount = 0;
    // validate the json string with EquilateralTriangle
    try {
      EquilateralTriangle.validateJsonObject(jsonObj);
      validCount++;
    } catch (Exception e) {
      // continue to the next one
    }
    // validate the json string with IsoscelesTriangle
    try {
      IsoscelesTriangle.validateJsonObject(jsonObj);
      validCount++;
    } catch (Exception e) {
      // continue to the next one
    }
    // validate the json string with ScaleneTriangle
    try {
      ScaleneTriangle.validateJsonObject(jsonObj);
      validCount++;
    } catch (Exception e) {
      // continue to the next one
    }
    if (validCount != 1) {
      throw new IOException(String.format("The JSON string is invalid for Triangle with oneOf schemas: EquilateralTriangle, IsoscelesTriangle, ScaleneTriangle. %d class(es) match the result, expected 1. JSON: %s", validCount, jsonObj.toString()));
    }
  }

 /**
  * Create an instance of Triangle given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of Triangle
  * @throws IOException if the JSON string is invalid with respect to Triangle
  */
  public static Triangle fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, Triangle.class);
  }

 /**
  * Convert an instance of Triangle to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

