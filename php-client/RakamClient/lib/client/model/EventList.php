<?php
/**
 * EventList
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
 * EventList Class Doc Comment
 *
 * @category    Class
 * @description 
 * @package     Rakam
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class EventList implements ArrayAccess
{
    /**
      * Array of property to type mappings. Used for (de)serialization 
      * @var string[]
      */
    static $swaggerTypes = array(
        'api' => '\client.model\EventContext',
        'project' => 'string',
        'events' => '\client.model\Event[]'
    );
  
    /** 
      * Array of attributes where the key is the local name, and the value is the original name
      * @var string[] 
      */
    static $attributeMap = array(
        'api' => 'api',
        'project' => 'project',
        'events' => 'events'
    );
  
    /**
      * Array of attributes to setter functions (for deserialization of responses)
      * @var string[]
      */
    static $setters = array(
        'api' => 'setApi',
        'project' => 'setProject',
        'events' => 'setEvents'
    );
  
    /**
      * Array of attributes to getter functions (for serialization of requests)
      * @var string[]
      */
    static $getters = array(
        'api' => 'getApi',
        'project' => 'getProject',
        'events' => 'getEvents'
    );
  
    
    /**
      * $api 
      * @var \client.model\EventContext
      */
    protected $api;
    
    /**
      * $project 
      * @var string
      */
    protected $project;
    
    /**
      * $events 
      * @var \client.model\Event[]
      */
    protected $events;
    

    /**
     * Constructor
     * @param mixed[] $data Associated array of property value initalizing the model
     */
    public function __construct(array $data = null)
    {
        if ($data != null) {
            $this->api = $data["api"];
            $this->project = $data["project"];
            $this->events = $data["events"];
        }
    }
    
    /**
     * Gets api
     * @return \client.model\EventContext
     */
    public function getApi()
    {
        return $this->api;
    }
  
    /**
     * Sets api
     * @param \client.model\EventContext $api 
     * @return $this
     */
    public function setApi($api)
    {
        
        $this->api = $api;
        return $this;
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
     * Gets events
     * @return \client.model\Event[]
     */
    public function getEvents()
    {
        return $this->events;
    }
  
    /**
     * Sets events
     * @param \client.model\Event[] $events 
     * @return $this
     */
    public function setEvents($events)
    {
        
        $this->events = $events;
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
