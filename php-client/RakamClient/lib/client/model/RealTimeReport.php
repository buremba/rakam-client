<?php
/**
 * RealTimeReport
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
 * RealTimeReport Class Doc Comment
 *
 * @category    Class
 * @description 
 * @package     Rakam
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class RealTimeReport implements ArrayAccess
{
    /**
      * Array of property to type mappings. Used for (de)serialization 
      * @var string[]
      */
    static $swaggerTypes = array(
        'project' => 'string',
        'name' => 'string',
        'aggregation' => 'string',
        'table_name' => 'string',
        'collections' => 'string[]',
        'filter' => 'string',
        'measure' => 'string',
        'dimensions' => 'string[]'
    );
  
    /** 
      * Array of attributes where the key is the local name, and the value is the original name
      * @var string[] 
      */
    static $attributeMap = array(
        'project' => 'project',
        'name' => 'name',
        'aggregation' => 'aggregation',
        'table_name' => 'table_name',
        'collections' => 'collections',
        'filter' => 'filter',
        'measure' => 'measure',
        'dimensions' => 'dimensions'
    );
  
    /**
      * Array of attributes to setter functions (for deserialization of responses)
      * @var string[]
      */
    static $setters = array(
        'project' => 'setProject',
        'name' => 'setName',
        'aggregation' => 'setAggregation',
        'table_name' => 'setTableName',
        'collections' => 'setCollections',
        'filter' => 'setFilter',
        'measure' => 'setMeasure',
        'dimensions' => 'setDimensions'
    );
  
    /**
      * Array of attributes to getter functions (for serialization of requests)
      * @var string[]
      */
    static $getters = array(
        'project' => 'getProject',
        'name' => 'getName',
        'aggregation' => 'getAggregation',
        'table_name' => 'getTableName',
        'collections' => 'getCollections',
        'filter' => 'getFilter',
        'measure' => 'getMeasure',
        'dimensions' => 'getDimensions'
    );
  
    
    /**
      * $project 
      * @var string
      */
    protected $project;
    
    /**
      * $name 
      * @var string
      */
    protected $name;
    
    /**
      * $aggregation 
      * @var string
      */
    protected $aggregation;
    
    /**
      * $table_name 
      * @var string
      */
    protected $table_name;
    
    /**
      * $collections 
      * @var string[]
      */
    protected $collections;
    
    /**
      * $filter 
      * @var string
      */
    protected $filter;
    
    /**
      * $measure 
      * @var string
      */
    protected $measure;
    
    /**
      * $dimensions 
      * @var string[]
      */
    protected $dimensions;
    

    /**
     * Constructor
     * @param mixed[] $data Associated array of property value initalizing the model
     */
    public function __construct(array $data = null)
    {
        if ($data != null) {
            $this->project = $data["project"];
            $this->name = $data["name"];
            $this->aggregation = $data["aggregation"];
            $this->table_name = $data["table_name"];
            $this->collections = $data["collections"];
            $this->filter = $data["filter"];
            $this->measure = $data["measure"];
            $this->dimensions = $data["dimensions"];
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
     * Gets aggregation
     * @return string
     */
    public function getAggregation()
    {
        return $this->aggregation;
    }
  
    /**
     * Sets aggregation
     * @param string $aggregation 
     * @return $this
     */
    public function setAggregation($aggregation)
    {
        $allowed_values = array("COUNT", "COUNT_UNIQUE", "SUM", "MINIMUM", "MAXIMUM", "APPROXIMATE_UNIQUE", "VARIANCE", "POPULATION_VARIANCE", "STANDARD_DEVIATION", "AVERAGE");
        if (!in_array($aggregation, $allowed_values)) {
            throw new \InvalidArgumentException("Invalid value for 'aggregation', must be one of 'COUNT', 'COUNT_UNIQUE', 'SUM', 'MINIMUM', 'MAXIMUM', 'APPROXIMATE_UNIQUE', 'VARIANCE', 'POPULATION_VARIANCE', 'STANDARD_DEVIATION', 'AVERAGE'");
        }
        $this->aggregation = $aggregation;
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
     * Gets collections
     * @return string[]
     */
    public function getCollections()
    {
        return $this->collections;
    }
  
    /**
     * Sets collections
     * @param string[] $collections 
     * @return $this
     */
    public function setCollections($collections)
    {
        
        $this->collections = $collections;
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
     * @return string
     */
    public function getMeasure()
    {
        return $this->measure;
    }
  
    /**
     * Sets measure
     * @param string $measure 
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
