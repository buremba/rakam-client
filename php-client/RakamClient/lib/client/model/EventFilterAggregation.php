<?php
/**
 * EventFilterAggregation
 *
 * PHP version 5
 *
 * @category Class
 * @package  Rakam
 * @author   http://github.com/swagger-api/swagger-codegen
 * @license  http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link     https://github.com/swagger-api/swagger-codegen
 */
/**
 *  Copyright 2015 SmartBear Software
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace client.model;

use \ArrayAccess;
/**
 * EventFilterAggregation Class Doc Comment
 *
 * @category    Class
 * @description 
 * @package     Rakam
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class EventFilterAggregation implements ArrayAccess
{
    /**
      * Array of property to type mappings. Used for (de)serialization 
      * @var string[]
      */
    static $swaggerTypes = array(
        'field' => 'string',
        'minimum' => 'int',
        'maximum' => 'int',
        'type' => 'string'
    );
  
    /** 
      * Array of attributes where the key is the local name, and the value is the original name
      * @var string[] 
      */
    static $attributeMap = array(
        'field' => 'field',
        'minimum' => 'minimum',
        'maximum' => 'maximum',
        'type' => 'type'
    );
  
    /**
      * Array of attributes to setter functions (for deserialization of responses)
      * @var string[]
      */
    static $setters = array(
        'field' => 'setField',
        'minimum' => 'setMinimum',
        'maximum' => 'setMaximum',
        'type' => 'setType'
    );
  
    /**
      * Array of attributes to getter functions (for serialization of requests)
      * @var string[]
      */
    static $getters = array(
        'field' => 'getField',
        'minimum' => 'getMinimum',
        'maximum' => 'getMaximum',
        'type' => 'getType'
    );
  
    
    /**
      * $field 
      * @var string
      */
    protected $field;
    
    /**
      * $minimum 
      * @var int
      */
    protected $minimum;
    
    /**
      * $maximum 
      * @var int
      */
    protected $maximum;
    
    /**
      * $type 
      * @var string
      */
    protected $type;
    

    /**
     * Constructor
     * @param mixed[] $data Associated array of property value initalizing the model
     */
    public function __construct(array $data = null)
    {
        if ($data != null) {
            $this->field = $data["field"];
            $this->minimum = $data["minimum"];
            $this->maximum = $data["maximum"];
            $this->type = $data["type"];
        }
    }
    
    /**
     * Gets field
     * @return string
     */
    public function getField()
    {
        return $this->field;
    }
  
    /**
     * Sets field
     * @param string $field 
     * @return $this
     */
    public function setField($field)
    {
        
        $this->field = $field;
        return $this;
    }
    
    /**
     * Gets minimum
     * @return int
     */
    public function getMinimum()
    {
        return $this->minimum;
    }
  
    /**
     * Sets minimum
     * @param int $minimum 
     * @return $this
     */
    public function setMinimum($minimum)
    {
        
        $this->minimum = $minimum;
        return $this;
    }
    
    /**
     * Gets maximum
     * @return int
     */
    public function getMaximum()
    {
        return $this->maximum;
    }
  
    /**
     * Sets maximum
     * @param int $maximum 
     * @return $this
     */
    public function setMaximum($maximum)
    {
        
        $this->maximum = $maximum;
        return $this;
    }
    
    /**
     * Gets type
     * @return string
     */
    public function getType()
    {
        return $this->type;
    }
  
    /**
     * Sets type
     * @param string $type 
     * @return $this
     */
    public function setType($type)
    {
        $allowed_values = array("COUNT", "COUNT_UNIQUE", "SUM", "MINIMUM", "MAXIMUM", "AVERAGE", "APPROXIMATE_UNIQUE");
        if (!in_array($type, $allowed_values)) {
            throw new \InvalidArgumentException("Invalid value for 'type', must be one of 'COUNT', 'COUNT_UNIQUE', 'SUM', 'MINIMUM', 'MAXIMUM', 'AVERAGE', 'APPROXIMATE_UNIQUE'");
        }
        $this->type = $type;
        return $this;
    }
    
    /**
     * Returns true if offset exists. False otherwise.
     * @param  integer $offset Offset 
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->$offset);
    }
  
    /**
     * Gets offset.
     * @param  integer $offset Offset 
     * @return mixed 
     */
    public function offsetGet($offset)
    {
        return $this->$offset;
    }
  
    /**
     * Sets value based on offset.
     * @param  integer $offset Offset 
     * @param  mixed   $value  Value to be set
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        $this->$offset = $value;
    }
  
    /**
     * Unsets offset.
     * @param  integer $offset Offset 
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->$offset);
    }
  
    /**
     * Gets the string presentation of the object
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) {
            return json_encode(get_object_vars($this), JSON_PRETTY_PRINT);
        } else {
            return json_encode(get_object_vars($this));
        }
    }
}
