<?php
/**
 * SchemaField
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
 * SchemaField Class Doc Comment
 *
 * @category    Class
 * @description 
 * @package     Rakam
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class SchemaField implements ArrayAccess
{
    /**
      * Array of property to type mappings. Used for (de)serialization 
      * @var string[]
      */
    static $swaggerTypes = array(
        'name' => 'string',
        'type' => 'string',
        'unique' => 'bool',
        'descriptive_name' => 'string',
        'description' => 'string',
        'category' => 'string'
    );
  
    /** 
      * Array of attributes where the key is the local name, and the value is the original name
      * @var string[] 
      */
    static $attributeMap = array(
        'name' => 'name',
        'type' => 'type',
        'unique' => 'unique',
        'descriptive_name' => 'descriptiveName',
        'description' => 'description',
        'category' => 'category'
    );
  
    /**
      * Array of attributes to setter functions (for deserialization of responses)
      * @var string[]
      */
    static $setters = array(
        'name' => 'setName',
        'type' => 'setType',
        'unique' => 'setUnique',
        'descriptive_name' => 'setDescriptiveName',
        'description' => 'setDescription',
        'category' => 'setCategory'
    );
  
    /**
      * Array of attributes to getter functions (for serialization of requests)
      * @var string[]
      */
    static $getters = array(
        'name' => 'getName',
        'type' => 'getType',
        'unique' => 'getUnique',
        'descriptive_name' => 'getDescriptiveName',
        'description' => 'getDescription',
        'category' => 'getCategory'
    );
  
    
    /**
      * $name 
      * @var string
      */
    protected $name;
    
    /**
      * $type 
      * @var string
      */
    protected $type;
    
    /**
      * $unique 
      * @var bool
      */
    protected $unique = false;
    
    /**
      * $descriptive_name 
      * @var string
      */
    protected $descriptive_name;
    
    /**
      * $description 
      * @var string
      */
    protected $description;
    
    /**
      * $category 
      * @var string
      */
    protected $category;
    

    /**
     * Constructor
     * @param mixed[] $data Associated array of property value initalizing the model
     */
    public function __construct(array $data = null)
    {
        if ($data != null) {
            $this->name = $data["name"];
            $this->type = $data["type"];
            $this->unique = $data["unique"];
            $this->descriptive_name = $data["descriptive_name"];
            $this->description = $data["description"];
            $this->category = $data["category"];
        }
    }
    
    /**
     * Gets name
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }
  
    /**
     * Sets name
     * @param string $name 
     * @return $this
     */
    public function setName($name)
    {
        
        $this->name = $name;
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
        $allowed_values = array("STRING", "INTEGER", "DECIMAL", "DOUBLE", "LONG", "BOOLEAN", "DATE", "TIME", "TIMESTAMP", "BINARY", "ARRAY_STRING", "ARRAY_INTEGER", "ARRAY_DECIMAL", "ARRAY_DOUBLE", "ARRAY_LONG", "ARRAY_BOOLEAN", "ARRAY_DATE", "ARRAY_TIME", "ARRAY_TIMESTAMP", "ARRAY_BINARY", "MAP_STRING", "MAP_INTEGER", "MAP_DECIMAL", "MAP_DOUBLE", "MAP_LONG", "MAP_BOOLEAN", "MAP_DATE", "MAP_TIME", "MAP_TIMESTAMP", "MAP_BINARY");
        if (!in_array($type, $allowed_values)) {
            throw new \InvalidArgumentException("Invalid value for 'type', must be one of 'STRING', 'INTEGER', 'DECIMAL', 'DOUBLE', 'LONG', 'BOOLEAN', 'DATE', 'TIME', 'TIMESTAMP', 'BINARY', 'ARRAY_STRING', 'ARRAY_INTEGER', 'ARRAY_DECIMAL', 'ARRAY_DOUBLE', 'ARRAY_LONG', 'ARRAY_BOOLEAN', 'ARRAY_DATE', 'ARRAY_TIME', 'ARRAY_TIMESTAMP', 'ARRAY_BINARY', 'MAP_STRING', 'MAP_INTEGER', 'MAP_DECIMAL', 'MAP_DOUBLE', 'MAP_LONG', 'MAP_BOOLEAN', 'MAP_DATE', 'MAP_TIME', 'MAP_TIMESTAMP', 'MAP_BINARY'");
        }
        $this->type = $type;
        return $this;
    }
    
    /**
     * Gets unique
     * @return bool
     */
    public function getUnique()
    {
        return $this->unique;
    }
  
    /**
     * Sets unique
     * @param bool $unique 
     * @return $this
     */
    public function setUnique($unique)
    {
        
        $this->unique = $unique;
        return $this;
    }
    
    /**
     * Gets descriptive_name
     * @return string
     */
    public function getDescriptiveName()
    {
        return $this->descriptive_name;
    }
  
    /**
     * Sets descriptive_name
     * @param string $descriptive_name 
     * @return $this
     */
    public function setDescriptiveName($descriptive_name)
    {
        
        $this->descriptive_name = $descriptive_name;
        return $this;
    }
    
    /**
     * Gets description
     * @return string
     */
    public function getDescription()
    {
        return $this->description;
    }
  
    /**
     * Sets description
     * @param string $description 
     * @return $this
     */
    public function setDescription($description)
    {
        
        $this->description = $description;
        return $this;
    }
    
    /**
     * Gets category
     * @return string
     */
    public function getCategory()
    {
        return $this->category;
    }
  
    /**
     * Sets category
     * @param string $category 
     * @return $this
     */
    public function setCategory($category)
    {
        
        $this->category = $category;
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
