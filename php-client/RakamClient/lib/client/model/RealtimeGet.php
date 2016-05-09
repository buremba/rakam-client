<?php
/**
 * RealtimeGet
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
 * RealtimeGet Class Doc Comment
 *
 * @category    Class
 * @description 
 * @package     Rakam
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class RealtimeGet implements ArrayAccess
{
    /**
      * Array of property to type mappings. Used for (de)serialization 
      * @var string[]
      */
    static $swaggerTypes = array(
        'project' => 'string',
        'table_name' => 'string',
        'filter' => 'string',
        'measure' => '\client.model\Measure',
        'dimensions' => 'string[]',
        'aggregate' => 'bool',
        'date_start' => '\DateTime',
        'date_end' => '\DateTime'
    );
  
    /** 
      * Array of attributes where the key is the local name, and the value is the original name
      * @var string[] 
      */
    static $attributeMap = array(
        'project' => 'project',
        'table_name' => 'table_name',
        'filter' => 'filter',
        'measure' => 'measure',
        'dimensions' => 'dimensions',
        'aggregate' => 'aggregate',
        'date_start' => 'date_start',
        'date_end' => 'date_end'
    );
  
    /**
      * Array of attributes to setter functions (for deserialization of responses)
      * @var string[]
      */
    static $setters = array(
        'project' => 'setProject',
        'table_name' => 'setTableName',
        'filter' => 'setFilter',
        'measure' => 'setMeasure',
        'dimensions' => 'setDimensions',
        'aggregate' => 'setAggregate',
        'date_start' => 'setDateStart',
        'date_end' => 'setDateEnd'
    );
  
    /**
      * Array of attributes to getter functions (for serialization of requests)
      * @var string[]
      */
    static $getters = array(
        'project' => 'getProject',
        'table_name' => 'getTableName',
        'filter' => 'getFilter',
        'measure' => 'getMeasure',
        'dimensions' => 'getDimensions',
        'aggregate' => 'getAggregate',
        'date_start' => 'getDateStart',
        'date_end' => 'getDateEnd'
    );
  
    
    /**
      * $project 
      * @var string
      */
    protected $project;
    
    /**
      * $table_name 
      * @var string
      */
    protected $table_name;
    
    /**
      * $filter 
      * @var string
      */
    protected $filter;
    
    /**
      * $measure 
      * @var \client.model\Measure
      */
    protected $measure;
    
    /**
      * $dimensions 
      * @var string[]
      */
    protected $dimensions;
    
    /**
      * $aggregate 
      * @var bool
      */
    protected $aggregate;
    
    /**
      * $date_start 
      * @var \DateTime
      */
    protected $date_start;
    
    /**
      * $date_end 
      * @var \DateTime
      */
    protected $date_end;
    

    /**
     * Constructor
     * @param mixed[] $data Associated array of property value initalizing the model
     */
    public function __construct(array $data = null)
    {
        if ($data != null) {
            $this->project = $data["project"];
            $this->table_name = $data["table_name"];
            $this->filter = $data["filter"];
            $this->measure = $data["measure"];
            $this->dimensions = $data["dimensions"];
            $this->aggregate = $data["aggregate"];
            $this->date_start = $data["date_start"];
            $this->date_end = $data["date_end"];
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
     * Gets table_name
     * @return string
     */
    public function getTableName()
    {
        return $this->table_name;
    }
  
    /**
     * Sets table_name
     * @param string $table_name 
     * @return $this
     */
    public function setTableName($table_name)
    {
        
        $this->table_name = $table_name;
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
     * Gets measure
     * @return \client.model\Measure
     */
    public function getMeasure()
    {
        return $this->measure;
    }
  
    /**
     * Sets measure
     * @param \client.model\Measure $measure 
     * @return $this
     */
    public function setMeasure($measure)
    {
        
        $this->measure = $measure;
        return $this;
    }
    
    /**
     * Gets dimensions
     * @return string[]
     */
    public function getDimensions()
    {
        return $this->dimensions;
    }
  
    /**
     * Sets dimensions
     * @param string[] $dimensions 
     * @return $this
     */
    public function setDimensions($dimensions)
    {
        
        $this->dimensions = $dimensions;
        return $this;
    }
    
    /**
     * Gets aggregate
     * @return bool
     */
    public function getAggregate()
    {
        return $this->aggregate;
    }
  
    /**
     * Sets aggregate
     * @param bool $aggregate 
     * @return $this
     */
    public function setAggregate($aggregate)
    {
        
        $this->aggregate = $aggregate;
        return $this;
    }
    
    /**
     * Gets date_start
     * @return \DateTime
     */
    public function getDateStart()
    {
        return $this->date_start;
    }
  
    /**
     * Sets date_start
     * @param \DateTime $date_start 
     * @return $this
     */
    public function setDateStart($date_start)
    {
        
        $this->date_start = $date_start;
        return $this;
    }
    
    /**
     * Gets date_end
     * @return \DateTime
     */
    public function getDateEnd()
    {
        return $this->date_end;
    }
  
    /**
     * Sets date_end
     * @param \DateTime $date_end 
     * @return $this
     */
    public function setDateEnd($date_end)
    {
        
        $this->date_end = $date_end;
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