<?php
/**
 * EventexplorerApi
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
 * EventexplorerApi Class Doc Comment
 *
 * @category Class
 * @package  Rakam
 * @author   http://github.com/swagger-api/swagger-codegen
 * @license  http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class EventexplorerApi
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
            $apiClient->getConfig()->setHost('https://api.rakam.io/');
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
     * @return EventexplorerApi
     */
    public function setApiClient(ApiClient $apiClient)
    {
        $this->apiClient = $apiClient;
        return $this;
    }
  
    
    /**
     * eventExplorerAnalyze
     *
     * Perform simple query on event data
     *
     * @param \client.model\AnalyzeRequest $analyze_request  (required)
     * @return \client.model\QueryResult
     * @throws \Rakam\ApiException on non-2xx response
     */
    public function eventExplorerAnalyze($analyze_request)
    {
        list($response, $statusCode, $httpHeader) = $this->eventExplorerAnalyzeWithHttpInfo ($analyze_request);
        return $response; 
    }


    /**
     * eventExplorerAnalyzeWithHttpInfo
     *
     * Perform simple query on event data
     *
     * @param \client.model\AnalyzeRequest $analyze_request  (required)
     * @return Array of \client.model\QueryResult, HTTP status code, HTTP response headers (array of strings)
     * @throws \Rakam\ApiException on non-2xx response
     */
    public function eventExplorerAnalyzeWithHttpInfo($analyze_request)
    {
        
        // verify the required parameter 'analyze_request' is set
        if ($analyze_request === null) {
            throw new \InvalidArgumentException('Missing the required parameter $analyze_request when calling eventExplorerAnalyze');
        }
  
        // parse inputs
        $resourcePath = "/event-explorer/analyze";
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
        if (isset($analyze_request)) {
            $_tempBody = $analyze_request;
        }
  
        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('read_key');
        if (strlen($apiKey) !== 0) {
            $headerParams['read_key'] = $apiKey;
        }
        
        
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath, $method,
                $queryParams, $httpBody,
                $headerParams, '\client.model\QueryResult'
            );
            
            if (!$response) {
                return array(null, $statusCode, $httpHeader);
            }

            return array($this->apiClient->getSerializer()->deserialize($response, '\client.model\QueryResult', $httpHeader), $statusCode, $httpHeader);
            
        } catch (ApiException $e) {
            switch ($e->getCode()) { 
            case 200:
                $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\client.model\QueryResult', $e->getResponseHeaders());
                $e->setResponseObject($data);
                break;
            }
  
            throw $e;
        }
    }
    
    /**
     * eventExplorerGetExtraDimensions
     *
     * Event statistics
     *
     * @param string $project  (optional)
     * @return map[string,string[]]
     * @throws \Rakam\ApiException on non-2xx response
     */
    public function eventExplorerGetExtraDimensions($project = null)
    {
        list($response, $statusCode, $httpHeader) = $this->eventExplorerGetExtraDimensionsWithHttpInfo ($project);
        return $response; 
    }


    /**
     * eventExplorerGetExtraDimensionsWithHttpInfo
     *
     * Event statistics
     *
     * @param string $project  (optional)
     * @return Array of map[string,string[]], HTTP status code, HTTP response headers (array of strings)
     * @throws \Rakam\ApiException on non-2xx response
     */
    public function eventExplorerGetExtraDimensionsWithHttpInfo($project = null)
    {
        
  
        // parse inputs
        $resourcePath = "/event-explorer/extra_dimensions";
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
  
        
        
        
        // form params
        if ($project !== null) {
            
            
            $formParams['project'] = $this->apiClient->getSerializer()->toFormValue($project);
            
        }
        
  
        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('read_key');
        if (strlen($apiKey) !== 0) {
            $headerParams['read_key'] = $apiKey;
        }
        
        
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath, $method,
                $queryParams, $httpBody,
                $headerParams, 'map[string,string[]]'
            );
            
            if (!$response) {
                return array(null, $statusCode, $httpHeader);
            }

            return array($this->apiClient->getSerializer()->deserialize($response, 'map[string,string[]]', $httpHeader), $statusCode, $httpHeader);
            
        } catch (ApiException $e) {
            switch ($e->getCode()) { 
            case 200:
                $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), 'map[string,string[]]', $e->getResponseHeaders());
                $e->setResponseObject($data);
                break;
            }
  
            throw $e;
        }
    }
    
    /**
     * eventExplorerCreatePreComputedTable
     *
     * Create Pre-computed table
     *
     * @param string $project  (optional)
     * @param string[] $collections  (optional)
     * @param string[] $dimensions  (optional)
     * @param string[] $aggregations  (optional)
     * @param string[] $measures  (optional)
     * @param string $table_name  (optional)
     * @return \client.model\PreCalculatedTable
     * @throws \Rakam\ApiException on non-2xx response
     */
    public function eventExplorerCreatePreComputedTable($project = null, $collections = null, $dimensions = null, $aggregations = null, $measures = null, $table_name = null)
    {
        list($response, $statusCode, $httpHeader) = $this->eventExplorerCreatePreComputedTableWithHttpInfo ($project, $collections, $dimensions, $aggregations, $measures, $table_name);
        return $response; 
    }


    /**
     * eventExplorerCreatePreComputedTableWithHttpInfo
     *
     * Create Pre-computed table
     *
     * @param string $project  (optional)
     * @param string[] $collections  (optional)
     * @param string[] $dimensions  (optional)
     * @param string[] $aggregations  (optional)
     * @param string[] $measures  (optional)
     * @param string $table_name  (optional)
     * @return Array of \client.model\PreCalculatedTable, HTTP status code, HTTP response headers (array of strings)
     * @throws \Rakam\ApiException on non-2xx response
     */
    public function eventExplorerCreatePreComputedTableWithHttpInfo($project = null, $collections = null, $dimensions = null, $aggregations = null, $measures = null, $table_name = null)
    {
        
  
        // parse inputs
        $resourcePath = "/event-explorer/pre_calculate";
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
  
        
        
        
        // form params
        if ($project !== null) {
            
            
            $formParams['project'] = $this->apiClient->getSerializer()->toFormValue($project);
            
        }// form params
        if ($collections !== null) {
            
            
            $formParams['collections'] = $this->apiClient->getSerializer()->toFormValue($collections);
            
        }// form params
        if ($dimensions !== null) {
            
            
            $formParams['dimensions'] = $this->apiClient->getSerializer()->toFormValue($dimensions);
            
        }// form params
        if ($aggregations !== null) {
            
            
            $formParams['aggregations'] = $this->apiClient->getSerializer()->toFormValue($aggregations);
            
        }// form params
        if ($measures !== null) {
            
            
            $formParams['measures'] = $this->apiClient->getSerializer()->toFormValue($measures);
            
        }// form params
        if ($table_name !== null) {
            
            
            $formParams['tableName'] = $this->apiClient->getSerializer()->toFormValue($table_name);
            
        }
        
  
        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('master_key');
        if (strlen($apiKey) !== 0) {
            $headerParams['master_key'] = $apiKey;
        }
        
        
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath, $method,
                $queryParams, $httpBody,
                $headerParams, '\client.model\PreCalculatedTable'
            );
            
            if (!$response) {
                return array(null, $statusCode, $httpHeader);
            }

            return array($this->apiClient->getSerializer()->deserialize($response, '\client.model\PreCalculatedTable', $httpHeader), $statusCode, $httpHeader);
            
        } catch (ApiException $e) {
            switch ($e->getCode()) { 
            case 200:
                $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\client.model\PreCalculatedTable', $e->getResponseHeaders());
                $e->setResponseObject($data);
                break;
            }
  
            throw $e;
        }
    }
    
    /**
     * eventExplorerGetEventStatistics
     *
     * Event statistics
     *
     * @param string $project  (optional)
     * @param string[] $collections  (optional)
     * @param string $dimension  (optional)
     * @param \DateTime $start_date  (optional)
     * @param \DateTime $end_date  (optional)
     * @return \client.model\QueryResult
     * @throws \Rakam\ApiException on non-2xx response
     */
    public function eventExplorerGetEventStatistics($project = null, $collections = null, $dimension = null, $start_date = null, $end_date = null)
    {
        list($response, $statusCode, $httpHeader) = $this->eventExplorerGetEventStatisticsWithHttpInfo ($project, $collections, $dimension, $start_date, $end_date);
        return $response; 
    }


    /**
     * eventExplorerGetEventStatisticsWithHttpInfo
     *
     * Event statistics
     *
     * @param string $project  (optional)
     * @param string[] $collections  (optional)
     * @param string $dimension  (optional)
     * @param \DateTime $start_date  (optional)
     * @param \DateTime $end_date  (optional)
     * @return Array of \client.model\QueryResult, HTTP status code, HTTP response headers (array of strings)
     * @throws \Rakam\ApiException on non-2xx response
     */
    public function eventExplorerGetEventStatisticsWithHttpInfo($project = null, $collections = null, $dimension = null, $start_date = null, $end_date = null)
    {
        
  
        // parse inputs
        $resourcePath = "/event-explorer/statistics";
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
  
        
        
        
        // form params
        if ($project !== null) {
            
            
            $formParams['project'] = $this->apiClient->getSerializer()->toFormValue($project);
            
        }// form params
        if ($collections !== null) {
            
            
            $formParams['collections'] = $this->apiClient->getSerializer()->toFormValue($collections);
            
        }// form params
        if ($dimension !== null) {
            
            
            $formParams['dimension'] = $this->apiClient->getSerializer()->toFormValue($dimension);
            
        }// form params
        if ($start_date !== null) {
            
            
            $formParams['startDate'] = $this->apiClient->getSerializer()->toFormValue($start_date);
            
        }// form params
        if ($end_date !== null) {
            
            
            $formParams['endDate'] = $this->apiClient->getSerializer()->toFormValue($end_date);
            
        }
        
  
        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('read_key');
        if (strlen($apiKey) !== 0) {
            $headerParams['read_key'] = $apiKey;
        }
        
        
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath, $method,
                $queryParams, $httpBody,
                $headerParams, '\client.model\QueryResult'
            );
            
            if (!$response) {
                return array(null, $statusCode, $httpHeader);
            }

            return array($this->apiClient->getSerializer()->deserialize($response, '\client.model\QueryResult', $httpHeader), $statusCode, $httpHeader);
            
        } catch (ApiException $e) {
            switch ($e->getCode()) { 
            case 200:
                $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\client.model\QueryResult', $e->getResponseHeaders());
                $e->setResponseObject($data);
                break;
            }
  
            throw $e;
        }
    }
    
}