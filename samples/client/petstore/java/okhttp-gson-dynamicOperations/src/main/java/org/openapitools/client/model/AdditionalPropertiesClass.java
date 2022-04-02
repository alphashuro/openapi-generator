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
import java.math.BigDecimal;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonArray;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;

import java.lang.reflect.Type;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;
import java.util.Map.Entry;
import java.util.Set;

import org.openapitools.client.JSON;

/**
 * AdditionalPropertiesClass
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen")
public class AdditionalPropertiesClass {
  public static final String SERIALIZED_NAME_MAP_STRING = "map_string";
  @SerializedName(SERIALIZED_NAME_MAP_STRING)
  private Map<String, String> mapString = null;

  public static final String SERIALIZED_NAME_MAP_NUMBER = "map_number";
  @SerializedName(SERIALIZED_NAME_MAP_NUMBER)
  private Map<String, BigDecimal> mapNumber = null;

  public static final String SERIALIZED_NAME_MAP_INTEGER = "map_integer";
  @SerializedName(SERIALIZED_NAME_MAP_INTEGER)
  private Map<String, Integer> mapInteger = null;

  public static final String SERIALIZED_NAME_MAP_BOOLEAN = "map_boolean";
  @SerializedName(SERIALIZED_NAME_MAP_BOOLEAN)
  private Map<String, Boolean> mapBoolean = null;

  public static final String SERIALIZED_NAME_MAP_ARRAY_INTEGER = "map_array_integer";
  @SerializedName(SERIALIZED_NAME_MAP_ARRAY_INTEGER)
  private Map<String, List<Integer>> mapArrayInteger = null;

  public static final String SERIALIZED_NAME_MAP_ARRAY_ANYTYPE = "map_array_anytype";
  @SerializedName(SERIALIZED_NAME_MAP_ARRAY_ANYTYPE)
  private Map<String, List<Object>> mapArrayAnytype = null;

  public static final String SERIALIZED_NAME_MAP_MAP_STRING = "map_map_string";
  @SerializedName(SERIALIZED_NAME_MAP_MAP_STRING)
  private Map<String, Map<String, String>> mapMapString = null;

  public static final String SERIALIZED_NAME_MAP_MAP_ANYTYPE = "map_map_anytype";
  @SerializedName(SERIALIZED_NAME_MAP_MAP_ANYTYPE)
  private Map<String, Map<String, Object>> mapMapAnytype = null;

  public static final String SERIALIZED_NAME_ANYTYPE1 = "anytype_1";
  @SerializedName(SERIALIZED_NAME_ANYTYPE1)
  private Object anytype1;

  public static final String SERIALIZED_NAME_ANYTYPE2 = "anytype_2";
  @SerializedName(SERIALIZED_NAME_ANYTYPE2)
  private Object anytype2;

  public static final String SERIALIZED_NAME_ANYTYPE3 = "anytype_3";
  @SerializedName(SERIALIZED_NAME_ANYTYPE3)
  private Object anytype3;

  public AdditionalPropertiesClass() { 
  }

  public AdditionalPropertiesClass mapString(Map<String, String> mapString) {
    
    this.mapString = mapString;
    return this;
  }

  public AdditionalPropertiesClass putMapStringItem(String key, String mapStringItem) {
    if (this.mapString == null) {
      this.mapString = new HashMap<>();
    }
    this.mapString.put(key, mapStringItem);
    return this;
  }

   /**
   * Get mapString
   * @return mapString
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Map<String, String> getMapString() {
    return mapString;
  }


  public void setMapString(Map<String, String> mapString) {
    this.mapString = mapString;
  }


  public AdditionalPropertiesClass mapNumber(Map<String, BigDecimal> mapNumber) {
    
    this.mapNumber = mapNumber;
    return this;
  }

  public AdditionalPropertiesClass putMapNumberItem(String key, BigDecimal mapNumberItem) {
    if (this.mapNumber == null) {
      this.mapNumber = new HashMap<>();
    }
    this.mapNumber.put(key, mapNumberItem);
    return this;
  }

   /**
   * Get mapNumber
   * @return mapNumber
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Map<String, BigDecimal> getMapNumber() {
    return mapNumber;
  }


  public void setMapNumber(Map<String, BigDecimal> mapNumber) {
    this.mapNumber = mapNumber;
  }


  public AdditionalPropertiesClass mapInteger(Map<String, Integer> mapInteger) {
    
    this.mapInteger = mapInteger;
    return this;
  }

  public AdditionalPropertiesClass putMapIntegerItem(String key, Integer mapIntegerItem) {
    if (this.mapInteger == null) {
      this.mapInteger = new HashMap<>();
    }
    this.mapInteger.put(key, mapIntegerItem);
    return this;
  }

   /**
   * Get mapInteger
   * @return mapInteger
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Map<String, Integer> getMapInteger() {
    return mapInteger;
  }


  public void setMapInteger(Map<String, Integer> mapInteger) {
    this.mapInteger = mapInteger;
  }


  public AdditionalPropertiesClass mapBoolean(Map<String, Boolean> mapBoolean) {
    
    this.mapBoolean = mapBoolean;
    return this;
  }

  public AdditionalPropertiesClass putMapBooleanItem(String key, Boolean mapBooleanItem) {
    if (this.mapBoolean == null) {
      this.mapBoolean = new HashMap<>();
    }
    this.mapBoolean.put(key, mapBooleanItem);
    return this;
  }

   /**
   * Get mapBoolean
   * @return mapBoolean
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Map<String, Boolean> getMapBoolean() {
    return mapBoolean;
  }


  public void setMapBoolean(Map<String, Boolean> mapBoolean) {
    this.mapBoolean = mapBoolean;
  }


  public AdditionalPropertiesClass mapArrayInteger(Map<String, List<Integer>> mapArrayInteger) {
    
    this.mapArrayInteger = mapArrayInteger;
    return this;
  }

  public AdditionalPropertiesClass putMapArrayIntegerItem(String key, List<Integer> mapArrayIntegerItem) {
    if (this.mapArrayInteger == null) {
      this.mapArrayInteger = new HashMap<>();
    }
    this.mapArrayInteger.put(key, mapArrayIntegerItem);
    return this;
  }

   /**
   * Get mapArrayInteger
   * @return mapArrayInteger
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Map<String, List<Integer>> getMapArrayInteger() {
    return mapArrayInteger;
  }


  public void setMapArrayInteger(Map<String, List<Integer>> mapArrayInteger) {
    this.mapArrayInteger = mapArrayInteger;
  }


  public AdditionalPropertiesClass mapArrayAnytype(Map<String, List<Object>> mapArrayAnytype) {
    
    this.mapArrayAnytype = mapArrayAnytype;
    return this;
  }

  public AdditionalPropertiesClass putMapArrayAnytypeItem(String key, List<Object> mapArrayAnytypeItem) {
    if (this.mapArrayAnytype == null) {
      this.mapArrayAnytype = new HashMap<>();
    }
    this.mapArrayAnytype.put(key, mapArrayAnytypeItem);
    return this;
  }

   /**
   * Get mapArrayAnytype
   * @return mapArrayAnytype
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Map<String, List<Object>> getMapArrayAnytype() {
    return mapArrayAnytype;
  }


  public void setMapArrayAnytype(Map<String, List<Object>> mapArrayAnytype) {
    this.mapArrayAnytype = mapArrayAnytype;
  }


  public AdditionalPropertiesClass mapMapString(Map<String, Map<String, String>> mapMapString) {
    
    this.mapMapString = mapMapString;
    return this;
  }

  public AdditionalPropertiesClass putMapMapStringItem(String key, Map<String, String> mapMapStringItem) {
    if (this.mapMapString == null) {
      this.mapMapString = new HashMap<>();
    }
    this.mapMapString.put(key, mapMapStringItem);
    return this;
  }

   /**
   * Get mapMapString
   * @return mapMapString
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Map<String, Map<String, String>> getMapMapString() {
    return mapMapString;
  }


  public void setMapMapString(Map<String, Map<String, String>> mapMapString) {
    this.mapMapString = mapMapString;
  }


  public AdditionalPropertiesClass mapMapAnytype(Map<String, Map<String, Object>> mapMapAnytype) {
    
    this.mapMapAnytype = mapMapAnytype;
    return this;
  }

  public AdditionalPropertiesClass putMapMapAnytypeItem(String key, Map<String, Object> mapMapAnytypeItem) {
    if (this.mapMapAnytype == null) {
      this.mapMapAnytype = new HashMap<>();
    }
    this.mapMapAnytype.put(key, mapMapAnytypeItem);
    return this;
  }

   /**
   * Get mapMapAnytype
   * @return mapMapAnytype
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Map<String, Map<String, Object>> getMapMapAnytype() {
    return mapMapAnytype;
  }


  public void setMapMapAnytype(Map<String, Map<String, Object>> mapMapAnytype) {
    this.mapMapAnytype = mapMapAnytype;
  }


  public AdditionalPropertiesClass anytype1(Object anytype1) {
    
    this.anytype1 = anytype1;
    return this;
  }

   /**
   * Get anytype1
   * @return anytype1
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Object getAnytype1() {
    return anytype1;
  }


  public void setAnytype1(Object anytype1) {
    this.anytype1 = anytype1;
  }


  public AdditionalPropertiesClass anytype2(Object anytype2) {
    
    this.anytype2 = anytype2;
    return this;
  }

   /**
   * Get anytype2
   * @return anytype2
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Object getAnytype2() {
    return anytype2;
  }


  public void setAnytype2(Object anytype2) {
    this.anytype2 = anytype2;
  }


  public AdditionalPropertiesClass anytype3(Object anytype3) {
    
    this.anytype3 = anytype3;
    return this;
  }

   /**
   * Get anytype3
   * @return anytype3
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Object getAnytype3() {
    return anytype3;
  }


  public void setAnytype3(Object anytype3) {
    this.anytype3 = anytype3;
  }



  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AdditionalPropertiesClass additionalPropertiesClass = (AdditionalPropertiesClass) o;
    return Objects.equals(this.mapString, additionalPropertiesClass.mapString) &&
        Objects.equals(this.mapNumber, additionalPropertiesClass.mapNumber) &&
        Objects.equals(this.mapInteger, additionalPropertiesClass.mapInteger) &&
        Objects.equals(this.mapBoolean, additionalPropertiesClass.mapBoolean) &&
        Objects.equals(this.mapArrayInteger, additionalPropertiesClass.mapArrayInteger) &&
        Objects.equals(this.mapArrayAnytype, additionalPropertiesClass.mapArrayAnytype) &&
        Objects.equals(this.mapMapString, additionalPropertiesClass.mapMapString) &&
        Objects.equals(this.mapMapAnytype, additionalPropertiesClass.mapMapAnytype) &&
        Objects.equals(this.anytype1, additionalPropertiesClass.anytype1) &&
        Objects.equals(this.anytype2, additionalPropertiesClass.anytype2) &&
        Objects.equals(this.anytype3, additionalPropertiesClass.anytype3);
  }

  @Override
  public int hashCode() {
    return Objects.hash(mapString, mapNumber, mapInteger, mapBoolean, mapArrayInteger, mapArrayAnytype, mapMapString, mapMapAnytype, anytype1, anytype2, anytype3);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AdditionalPropertiesClass {\n");
    sb.append("    mapString: ").append(toIndentedString(mapString)).append("\n");
    sb.append("    mapNumber: ").append(toIndentedString(mapNumber)).append("\n");
    sb.append("    mapInteger: ").append(toIndentedString(mapInteger)).append("\n");
    sb.append("    mapBoolean: ").append(toIndentedString(mapBoolean)).append("\n");
    sb.append("    mapArrayInteger: ").append(toIndentedString(mapArrayInteger)).append("\n");
    sb.append("    mapArrayAnytype: ").append(toIndentedString(mapArrayAnytype)).append("\n");
    sb.append("    mapMapString: ").append(toIndentedString(mapMapString)).append("\n");
    sb.append("    mapMapAnytype: ").append(toIndentedString(mapMapAnytype)).append("\n");
    sb.append("    anytype1: ").append(toIndentedString(anytype1)).append("\n");
    sb.append("    anytype2: ").append(toIndentedString(anytype2)).append("\n");
    sb.append("    anytype3: ").append(toIndentedString(anytype3)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }


  public static HashSet<String> openapiFields;
  public static HashSet<String> openapiRequiredFields;

  static {
    // a set of all properties/fields (JSON key names)
    openapiFields = new HashSet<String>();
    openapiFields.add("map_string");
    openapiFields.add("map_number");
    openapiFields.add("map_integer");
    openapiFields.add("map_boolean");
    openapiFields.add("map_array_integer");
    openapiFields.add("map_array_anytype");
    openapiFields.add("map_map_string");
    openapiFields.add("map_map_anytype");
    openapiFields.add("anytype_1");
    openapiFields.add("anytype_2");
    openapiFields.add("anytype_3");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to AdditionalPropertiesClass
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (AdditionalPropertiesClass.openapiRequiredFields.isEmpty()) {
          return;
        } else { // has required fields
          throw new IllegalArgumentException(String.format("The required field(s) %s in AdditionalPropertiesClass is not found in the empty JSON string", AdditionalPropertiesClass.openapiRequiredFields.toString()));
        }
      }

      Set<Entry<String, JsonElement>> entries = jsonObj.entrySet();
      // check to see if the JSON string contains additional fields
      for (Entry<String, JsonElement> entry : entries) {
        if (!AdditionalPropertiesClass.openapiFields.contains(entry.getKey())) {
          throw new IllegalArgumentException(String.format("The field `%s` in the JSON string is not defined in the `AdditionalPropertiesClass` properties. JSON: %s", entry.getKey(), jsonObj.toString()));
        }
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!AdditionalPropertiesClass.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'AdditionalPropertiesClass' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<AdditionalPropertiesClass> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(AdditionalPropertiesClass.class));

       return (TypeAdapter<T>) new TypeAdapter<AdditionalPropertiesClass>() {
           @Override
           public void write(JsonWriter out, AdditionalPropertiesClass value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             elementAdapter.write(out, obj);
           }

           @Override
           public AdditionalPropertiesClass read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             return thisAdapter.fromJsonTree(jsonObj);
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of AdditionalPropertiesClass given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of AdditionalPropertiesClass
  * @throws IOException if the JSON string is invalid with respect to AdditionalPropertiesClass
  */
  public static AdditionalPropertiesClass fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, AdditionalPropertiesClass.class);
  }

 /**
  * Convert an instance of AdditionalPropertiesClass to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

