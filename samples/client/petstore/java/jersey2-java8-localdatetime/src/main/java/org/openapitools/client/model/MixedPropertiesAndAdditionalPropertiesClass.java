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
import java.util.Map;
import java.util.HashMap;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.time.LocalDateTime;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.UUID;
import org.openapitools.client.model.Animal;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;
import org.openapitools.client.JSON;


/**
 * MixedPropertiesAndAdditionalPropertiesClass
 */
@JsonPropertyOrder({
  MixedPropertiesAndAdditionalPropertiesClass.JSON_PROPERTY_UUID,
  MixedPropertiesAndAdditionalPropertiesClass.JSON_PROPERTY_DATE_TIME,
  MixedPropertiesAndAdditionalPropertiesClass.JSON_PROPERTY_MAP
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen")
public class MixedPropertiesAndAdditionalPropertiesClass {
  public static final String JSON_PROPERTY_UUID = "uuid";
  private UUID uuid;

  public static final String JSON_PROPERTY_DATE_TIME = "dateTime";
  private LocalDateTime dateTime;

  public static final String JSON_PROPERTY_MAP = "map";
  private Map<String, Animal> map = null;

  public MixedPropertiesAndAdditionalPropertiesClass() { 
  }

  public MixedPropertiesAndAdditionalPropertiesClass uuid(UUID uuid) {
    this.uuid = uuid;
    return this;
  }

   /**
   * Get uuid
   * @return uuid
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")
  @JsonProperty(JSON_PROPERTY_UUID)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public UUID getUuid() {
    return uuid;
  }


  @JsonProperty(JSON_PROPERTY_UUID)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setUuid(UUID uuid) {
    this.uuid = uuid;
  }


  public MixedPropertiesAndAdditionalPropertiesClass dateTime(LocalDateTime dateTime) {
    this.dateTime = dateTime;
    return this;
  }

   /**
   * Get dateTime
   * @return dateTime
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")
  @JsonProperty(JSON_PROPERTY_DATE_TIME)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public LocalDateTime getDateTime() {
    return dateTime;
  }


  @JsonProperty(JSON_PROPERTY_DATE_TIME)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setDateTime(LocalDateTime dateTime) {
    this.dateTime = dateTime;
  }


  public MixedPropertiesAndAdditionalPropertiesClass map(Map<String, Animal> map) {
    this.map = map;
    return this;
  }

  public MixedPropertiesAndAdditionalPropertiesClass putMapItem(String key, Animal mapItem) {
    if (this.map == null) {
      this.map = new HashMap<>();
    }
    this.map.put(key, mapItem);
    return this;
  }

   /**
   * Get map
   * @return map
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")
  @JsonProperty(JSON_PROPERTY_MAP)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public Map<String, Animal> getMap() {
    return map;
  }


  @JsonProperty(JSON_PROPERTY_MAP)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setMap(Map<String, Animal> map) {
    this.map = map;
  }


  /**
   * Return true if this MixedPropertiesAndAdditionalPropertiesClass object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MixedPropertiesAndAdditionalPropertiesClass mixedPropertiesAndAdditionalPropertiesClass = (MixedPropertiesAndAdditionalPropertiesClass) o;
    return Objects.equals(this.uuid, mixedPropertiesAndAdditionalPropertiesClass.uuid) &&
        Objects.equals(this.dateTime, mixedPropertiesAndAdditionalPropertiesClass.dateTime) &&
        Objects.equals(this.map, mixedPropertiesAndAdditionalPropertiesClass.map);
  }

  @Override
  public int hashCode() {
    return Objects.hash(uuid, dateTime, map);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MixedPropertiesAndAdditionalPropertiesClass {\n");
    sb.append("    uuid: ").append(toIndentedString(uuid)).append("\n");
    sb.append("    dateTime: ").append(toIndentedString(dateTime)).append("\n");
    sb.append("    map: ").append(toIndentedString(map)).append("\n");
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

}

