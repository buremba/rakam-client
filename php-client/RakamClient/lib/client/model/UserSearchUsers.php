<?php
/**
 * UserSearchUsers
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
 * UserSearchUsers Class Doc Comment
 *
 * @category    Class
 * @description 
 * @package     Rakam
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class UserSearchUsers implements ArrayAccess
{
    /**
      * Array of property to type mappings. Used for (de)serialization 
      * @var string[]
      */
    static $swaggerTypes = array(
        'project' => 'string',
        'columns' => 'string[]',
        'filter' => 'string',
        'event_filters' => '\client.model\EventFilter[]',
        'sorting' => '\client.model\Sorting',
        'offset' => 'string',
        'limit' => 'int'
    );
  
    /** 
      * Array of attributes where the key is the local name, and the value is the original name
      * @var string[] 
      */
    static $attributeMap = array(
        'project' => 'project',
        'columns' => 'columns',
        'filter' => 'filter',
        'event_filters' => 'event_filters',
        'sorting' => 'sorting',
        'offset' => 'offset',
        'limit' => 'limit'
    );
  
    /**
      * Array of attributes to setter functions (for deserialization of responses)
      * @var string[]
      */
    static $setters = array(
        'project' => 'setProject',
        'columns' => 'setColumns',
        'filter' => 'setFilter',
        'event_filters' => 'setEventFilters',
        'sorting' => 'setSorting',
        'offset' => 'setOffset',
        'limit' => 'setLimit'
    );
  
    /**
      * Array of attributes to getter functions (for serialization of requests)
      * @var string[]
      */
    static $getters = array(
        'project' => 'getProject',
        'columns' => 'getColumns',
        'filter' => 'getFilter',
        'event_filters' => 'getEventFilters',
        'sorting' => 'getSorting',
        'offset' => 'getOffset',
        'limit' => 'getLimit'
    );
  
    
    /**
      * $project 
      * @var string
      */
    protected $project;
    
    /**
      * $columns 
      * @var string[]
      */
    protected $columns;
    
    /**
      * $filter 
      * @var string
      */
    protected $filter;
    
    /**
      * $event_filters 
      * @var \client.model\EventFilter[]
      */
    protected $event_filters;
    
    /**
      * $sorting 
      * @var \client.model\Sorting
      */
    protected $sorting;
    
    /**
      * $offset 
      * @var string
      */
    protected $offset;
    
    /**
      * $limit 
      * @var int
      */
    protected $limit;
    

    /**
     * Constructor
     * @param mixed[] $data Associated array of property value initalizing the model
     */
    public function __construct(array $data = null)
    {
        if ($data != null) {
            $this->project = $data["project"];
            $this->columns = $data["columns"];
            $this->filter = $data["filter"];
            $this->event_filters = $data["event_filters"];
            $this->sorting = $data["sorting"];
            $this->offset = $data["offset"];
            $this->limit = $data["limit"];
        }
    }
    
    /**
     * Gets project
     * @return string
     */
    public function getProject()
    {
        return $this->project;
    }
  
    /**
     * Sets project
     * @param string $project 
     * @return $this
     */
    public function setProject($project)
    {
        
        $this->project = $project;
        return $this;
    }
    
    /**
     * Gets columns
     * @return string[]
     */
    public function getColumns()
    {
        return $this->columns;
    }
  
    /**
     * Sets columns
     * @param string[] $columns 
     * @return $this
     */
    public function setColumns($columns)
    {
        
        $this->columns = $columns;
        return $this;
    }
    
    /**
     * Gets filter
     * @return string
     */
    public function getFilter()
    {
        return $this->filter;
    }
  
    /**
     * Sets filter
     * @param string $filter 
     * @return $this
     */
    public function setFilter($filter)
    {
        
        $this->filter = $filter;
        return $this;
    }
    
    /**
     * Gets event_filters
     * @return \client.model\EventFilter[]
     */
    public function getEventFilters()
    {
        return $this->event_filters;
    }
  
    /**
     * Sets event_filters
     * @param \client.model\EventFilter[] $event_filters 
     * @return $this
     */
    public function setEventFilters($event_filters)
    {
        
        $this->event_filters = $event_filters;
        return $this;
    }
    
    /**
     * Gets sorting
     * @return \client.model\Sorting
     */
    public function getSorting()
    {
        return $this->sorting;
    }
  
    /**
     * Sets sorting
     * @param \client.model\Sorting $sorting 
     * @return $this
     */
    public function setSorting($sorting)
    {
        
        $this->sorting = $sorting;
        return $this;
    }
    
    /**
     * Gets offset
     * @return string
     */
    public function getOffset()
    {
        return $this->offset;
    }
  
    /**
     * Sets offset
     * @param string $offset 
     * @return $this
     */
    public function setOffset($offset)
    {
        
        $this->offset = $offset;
        return $this;
    }
    
    /**
     * Gets limit
     * @return int
     */
    public function getLimit()
    {
        return $this->limit;
    }
  
    /**
     * Sets limit
     * @param int $limit 
     * @return $this
     */
    public function setLimit($limit)
    {
        
        $this->limit = $limit;
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
