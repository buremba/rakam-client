<?php
/**
 * FunnelApi
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

namespace client.api;

use \Rakam\Configuration;
use \Rakam\ApiClient;
use \Rakam\ApiException;
use \Rakam\ObjectSerializer;

/**
 * FunnelApi Class Doc Comment
 *
 * @category Class
 * @package  Rakam
 * @author   http://github.com/swagger-api/swagger-codegen
 * @license  http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class FunnelApi
{

    /**
     * API Client
     * @var \Rakam\ApiClient instance of the ApiClient
     */
    protected $apiClient;
  
    /**
     * Constructor
     * @param \Rakam\ApiClient|null $apiClient The api client to use
     */
    function __construct($apiClient = null)
    {
        if ($apiClient == null) {
            $apiClient = new ApiClient();
            $apiClient->getConfig()->setHost('https://app.getrakam.com/');
        }
  
        $this->apiClient = $apiClient;
    }
  
    /**
     * Get API client
     * @return \Rakam\ApiClient get the API client
     */
    public function getApiClient()
    {
        return $this->apiClient;
    }
  
    /**
     * Set the API client
     * @param \Rakam\ApiClient $apiClient set the API client
     * @return FunnelApi
     */
    public function setApiClient(ApiClient $apiClient)
    {
        $this->apiClient = $apiClient;
        return $this;
    }
  
    
    /**
     * analyze
     *
     * Execute query
     *
     * @param \client.model\FunnelQuery $funnel_query  (required)
     * @return void
     * @throws \Rakam\ApiException on non-2xx response
     */
    public function analyze($funnel_query)
    {
        
        // verify the required parameter 'funnel_query' is set
        if ($funnel_query === null) {
            throw new \InvalidArgumentException('Missing the required parameter $funnel_query when calling analyze');
        }
  
        // parse inputs
        $resourcePath = "/funnel/analyze";
        $resourcePath = str_replace("{format}", "json", $resourcePath);
        $method = "GET";
        $httpBody = '';
        $queryParams = array();
        $headerParams = array();
        $formParams = array();
        $_header_accept = ApiClient::selectHeaderAccept(array('text/event-stream'));
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = ApiClient::selectHeaderContentType(array('text/event-stream'));
  
        
        
        
        
        // body params
        $_tempBody = null;
        if (isset($funnel_query)) {
            $_tempBody = $funnel_query;
        }
  
        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } else if (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        
        $apiKey = $this->apiClient->getApiKeyWithPrefix('read_key');
        if (isset($apiKey)) {
            $headerParams['read_key'] = $apiKey;
        }
        
        
        
        // make the API Call
        try
        {
            list($response, $httpHeader) = $this->apiClient->callApi(
                $resourcePath, $method,
                $queryParams, $httpBody,
                $headerParams
            );
            
        } catch (ApiException $e) {
            switch ($e->getCode()) { 
            }
  
            throw $e;
        }
        
    }
    
    /**
     * analyze_1
     *
     * Execute query
     *
     * @param \client.model\FunnelQuery $funnel_query  (required)
     * @return \client.model\QueryResult
     * @throws \Rakam\ApiException on non-2xx response
     */
    public function analyze_1($funnel_query)
    {
        
        // verify the required parameter 'funnel_query' is set
        if ($funnel_query === null) {
            throw new \InvalidArgumentException('Missing the required parameter $funnel_query when calling analyze_1');
        }
  
        // parse inputs
        $resourcePath = "/funnel/analyze";
        $resourcePath = str_replace("{format}", "json", $resourcePath);
        $method = "POST";
        $httpBody = '';
        $queryParams = array();
        $headerParams = array();
        $formParams = array();
        $_header_accept = ApiClient::selectHeaderAccept(array('application/json'));
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = ApiClient::selectHeaderContentType(array('application/json'));
  
        
        
        
        
        // body params
        $_tempBody = null;
        if (isset($funnel_query)) {
            $_tempBody = $funnel_query;
        }
  
        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } else if (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        
        $apiKey = $this->apiClient->getApiKeyWithPrefix('read_key');
        if (isset($apiKey)) {
            $headerParams['read_key'] = $apiKey;
        }
        
        
        
        // make the API Call
        try
        {
            list($response, $httpHeader) = $this->apiClient->callApi(
                $resourcePath, $method,
                $queryParams, $httpBody,
                $headerParams, '\client.model\QueryResult'
            );
            
            if (!$response) {
                return null;
            }

            return $this->apiClient->getSerializer()->deserialize($response, '\client.model\QueryResult', $httpHeader);
            
        } catch (ApiException $e) {
            switch ($e->getCode()) { 
            case 200:
                $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\client.model\QueryResult', $e->getResponseHeaders());
                $e->setResponseObject($data);
                break;
            }
  
            throw $e;
        }
        
        return null;
        
    }
    
}
