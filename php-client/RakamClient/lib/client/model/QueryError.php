<?php
/**
 * QueryError
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
 * QueryError Class Doc Comment
 *
 * @category    Class
 * @description 
 * @package     Rakam
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class QueryError implements ArrayAccess
{
    /**
      * Array of property to type mappings. Used for (de)serialization 
      * @var string[]
      */
    static $swaggerTypes = array(
        'message' => 'string',
        'sql_state' => 'string',
        'error_code' => 'int',
        'query' => 'string'
    );
  
    /** 
      * Array of attributes where the key is the local name, and the value is the original name
      * @var string[] 
      */
    static $attributeMap = array(
        'message' => 'message',
        'sql_state' => 'sqlState',
        'error_code' => 'errorCode',
        'query' => 'query'
    );
  
    /**
      * Array of attributes to setter functions (for deserialization of responses)
      * @var string[]
      */
    static $setters = array(
        'message' => 'setMessage',
        'sql_state' => 'setSqlState',
        'error_code' => 'setErrorCode',
        'query' => 'setQuery'
    );
  
    /**
      * Array of attributes to getter functions (for serialization of requests)
      * @var string[]
      */
    static $getters = array(
        'message' => 'getMessage',
        'sql_state' => 'getSqlState',
        'error_code' => 'getErrorCode',
        'query' => 'getQuery'
    );
  
    
    /**
      * $message 
      * @var string
      */
    protected $message;
    
    /**
      * $sql_state 
      * @var string
      */
    protected $sql_state;
    
    /**
      * $error_code 
      * @var int
      */
    protected $error_code;
    
    /**
      * $query 
      * @var string
      */
    protected $query;
    

    /**
     * Constructor
     * @param mixed[] $data Associated array of property value initalizing the model
     */
    public function __construct(array $data = null)
    {
        if ($data != null) {
            $this->message = $data["message"];
            $this->sql_state = $data["sql_state"];
            $this->error_code = $data["error_code"];
            $this->query = $data["query"];
        }
    }
    
    /**
     * Gets message
     * @return string
     */
    public function getMessage()
    {
        return $this->message;
    }
  
    /**
     * Sets message
     * @param string $message 
     * @return $this
     */
    public function setMessage($message)
    {
        
        $this->message = $message;
        return $this;
    }
    
    /**
     * Gets sql_state
     * @return string
     */
    public function getSqlState()
    {
        return $this->sql_state;
    }
  
    /**
     * Sets sql_state
     * @param string $sql_state 
     * @return $this
     */
    public function setSqlState($sql_state)
    {
        
        $this->sql_state = $sql_state;
        return $this;
    }
    
    /**
     * Gets error_code
     * @return int
     */
    public function getErrorCode()
    {
        return $this->error_code;
    }
  
    /**
     * Sets error_code
     * @param int $error_code 
     * @return $this
     */
    public function setErrorCode($error_code)
    {
        
        $this->error_code = $error_code;
        return $this;
    }
    
    /**
     * Gets query
     * @return string
     */
    public function getQuery()
    {
        return $this->query;
    }
  
    /**
     * Sets query
     * @param string $query 
     * @return $this
     */
    public function setQuery($query)
    {
        
        $this->query = $query;
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