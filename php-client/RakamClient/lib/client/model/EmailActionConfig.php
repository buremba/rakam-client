<?php
/**
 * EmailActionConfig
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
 * EmailActionConfig Class Doc Comment
 *
 * @category    Class
 * @description 
 * @package     Rakam
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class EmailActionConfig implements ArrayAccess
{
    /**
      * Array of property to type mappings. Used for (de)serialization 
      * @var string[]
      */
    static $swaggerTypes = array(
        'title' => 'string',
        'content' => 'string',
        'column_name' => 'string',
        'default_values' => 'map[string,string]',
        'rich_text' => 'bool'
    );
  
    /** 
      * Array of attributes where the key is the local name, and the value is the original name
      * @var string[] 
      */
    static $attributeMap = array(
        'title' => 'title',
        'content' => 'content',
        'column_name' => 'columnName',
        'default_values' => 'defaultValues',
        'rich_text' => 'richText'
    );
  
    /**
      * Array of attributes to setter functions (for deserialization of responses)
      * @var string[]
      */
    static $setters = array(
        'title' => 'setTitle',
        'content' => 'setContent',
        'column_name' => 'setColumnName',
        'default_values' => 'setDefaultValues',
        'rich_text' => 'setRichText'
    );
  
    /**
      * Array of attributes to getter functions (for serialization of requests)
      * @var string[]
      */
    static $getters = array(
        'title' => 'getTitle',
        'content' => 'getContent',
        'column_name' => 'getColumnName',
        'default_values' => 'getDefaultValues',
        'rich_text' => 'getRichText'
    );
  
    
    /**
      * $title 
      * @var string
      */
    protected $title;
    
    /**
      * $content 
      * @var string
      */
    protected $content;
    
    /**
      * $column_name 
      * @var string
      */
    protected $column_name;
    
    /**
      * $default_values 
      * @var map[string,string]
      */
    protected $default_values;
    
    /**
      * $rich_text 
      * @var bool
      */
    protected $rich_text;
    

    /**
     * Constructor
     * @param mixed[] $data Associated array of property value initalizing the model
     */
    public function __construct(array $data = null)
    {
        if ($data != null) {
            $this->title = $data["title"];
            $this->content = $data["content"];
            $this->column_name = $data["column_name"];
            $this->default_values = $data["default_values"];
            $this->rich_text = $data["rich_text"];
        }
    }
    
    /**
     * Gets title
     * @return string
     */
    public function getTitle()
    {
        return $this->title;
    }
  
    /**
     * Sets title
     * @param string $title 
     * @return $this
     */
    public function setTitle($title)
    {
        
        $this->title = $title;
        return $this;
    }
    
    /**
     * Gets content
     * @return string
     */
    public function getContent()
    {
        return $this->content;
    }
  
    /**
     * Sets content
     * @param string $content 
     * @return $this
     */
    public function setContent($content)
    {
        
        $this->content = $content;
        return $this;
    }
    
    /**
     * Gets column_name
     * @return string
     */
    public function getColumnName()
    {
        return $this->column_name;
    }
  
    /**
     * Sets column_name
     * @param string $column_name 
     * @return $this
     */
    public function setColumnName($column_name)
    {
        
        $this->column_name = $column_name;
        return $this;
    }
    
    /**
     * Gets default_values
     * @return map[string,string]
     */
    public function getDefaultValues()
    {
        return $this->default_values;
    }
  
    /**
     * Sets default_values
     * @param map[string,string] $default_values 
     * @return $this
     */
    public function setDefaultValues($default_values)
    {
        
        $this->default_values = $default_values;
        return $this;
    }
    
    /**
     * Gets rich_text
     * @return bool
     */
    public function getRichText()
    {
        return $this->rich_text;
    }
  
    /**
     * Sets rich_text
     * @param bool $rich_text 
     * @return $this
     */
    public function setRichText($rich_text)
    {
        
        $this->rich_text = $rich_text;
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