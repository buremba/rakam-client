<?php
/**
 * AutomationRule
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
 * AutomationRule Class Doc Comment
 *
 * @category    Class
 * @description 
 * @package     Rakam
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class AutomationRule implements ArrayAccess
{
    /**
      * Array of property to type mappings. Used for (de)serialization 
      * @var string[]
      */
    static $swaggerTypes = array(
        'project' => 'string',
        'is_active' => 'bool',
        'scenarios' => '\client.model\ScenarioStep[]',
        'actions' => '\client.model\SerializableAction[]',
        'custom_data' => 'string',
        'id' => 'int'
    );
  
    /** 
      * Array of attributes where the key is the local name, and the value is the original name
      * @var string[] 
      */
    static $attributeMap = array(
        'project' => 'project',
        'is_active' => 'is_active',
        'scenarios' => 'scenarios',
        'actions' => 'actions',
        'custom_data' => 'custom_data',
        'id' => 'id'
    );
  
    /**
      * Array of attributes to setter functions (for deserialization of responses)
      * @var string[]
      */
    static $setters = array(
        'project' => 'setProject',
        'is_active' => 'setIsActive',
        'scenarios' => 'setScenarios',
        'actions' => 'setActions',
        'custom_data' => 'setCustomData',
        'id' => 'setId'
    );
  
    /**
      * Array of attributes to getter functions (for serialization of requests)
      * @var string[]
      */
    static $getters = array(
        'project' => 'getProject',
        'is_active' => 'getIsActive',
        'scenarios' => 'getScenarios',
        'actions' => 'getActions',
        'custom_data' => 'getCustomData',
        'id' => 'getId'
    );
  
    
    /**
      * $project 
      * @var string
      */
    protected $project;
    
    /**
      * $is_active 
      * @var bool
      */
    protected $is_active = false;
    
    /**
      * $scenarios 
      * @var \client.model\ScenarioStep[]
      */
    protected $scenarios;
    
    /**
      * $actions 
      * @var \client.model\SerializableAction[]
      */
    protected $actions;
    
    /**
      * $custom_data 
      * @var string
      */
    protected $custom_data;
    
    /**
      * $id 
      * @var int
      */
    protected $id;
    

    /**
     * Constructor
     * @param mixed[] $data Associated array of property value initalizing the model
     */
    public function __construct(array $data = null)
    {
        if ($data != null) {
            $this->project = $data["project"];
            $this->is_active = $data["is_active"];
            $this->scenarios = $data["scenarios"];
            $this->actions = $data["actions"];
            $this->custom_data = $data["custom_data"];
            $this->id = $data["id"];
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
     * Gets is_active
     * @return bool
     */
    public function getIsActive()
    {
        return $this->is_active;
    }
  
    /**
     * Sets is_active
     * @param bool $is_active 
     * @return $this
     */
    public function setIsActive($is_active)
    {
        
        $this->is_active = $is_active;
        return $this;
    }
    
    /**
     * Gets scenarios
     * @return \client.model\ScenarioStep[]
     */
    public function getScenarios()
    {
        return $this->scenarios;
    }
  
    /**
     * Sets scenarios
     * @param \client.model\ScenarioStep[] $scenarios 
     * @return $this
     */
    public function setScenarios($scenarios)
    {
        
        $this->scenarios = $scenarios;
        return $this;
    }
    
    /**
     * Gets actions
     * @return \client.model\SerializableAction[]
     */
    public function getActions()
    {
        return $this->actions;
    }
  
    /**
     * Sets actions
     * @param \client.model\SerializableAction[] $actions 
     * @return $this
     */
    public function setActions($actions)
    {
        
        $this->actions = $actions;
        return $this;
    }
    
    /**
     * Gets custom_data
     * @return string
     */
    public function getCustomData()
    {
        return $this->custom_data;
    }
  
    /**
     * Sets custom_data
     * @param string $custom_data 
     * @return $this
     */
    public function setCustomData($custom_data)
    {
        
        $this->custom_data = $custom_data;
        return $this;
    }
    
    /**
     * Gets id
     * @return int
     */
    public function getId()
    {
        return $this->id;
    }
  
    /**
     * Sets id
     * @param int $id 
     * @return $this
     */
    public function setId($id)
    {
        
        $this->id = $id;
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
