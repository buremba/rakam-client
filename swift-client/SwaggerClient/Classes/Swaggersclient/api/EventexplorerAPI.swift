//
// EventexplorerAPI.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Alamofire

extension SwaggerClientAPI {
    
    public class EventexplorerAPI: APIBase {
    
        /**
         
         Perform simple query on event data
         
         - POST /event-explorer/analyze
         - 
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example={
  "result" : [ [ "{}" ] ],
  "metadata" : [ {
    "nullable" : true,
    "descriptiveName" : "aeiou",
    "unique" : true,
    "name" : "aeiou",
    "description" : "aeiou",
    "type" : "aeiou",
    "category" : "aeiou"
  } ],
  "failed" : true,
  "error" : {
    "query" : "aeiou",
    "sqlState" : "aeiou",
    "errorCode" : 123,
    "message" : "aeiou"
  },
  "properties" : {
    "key" : "{}"
  }
}}]
         
         - parameter execute: (body) 

         - returns: RequestBuilder<QueryResult> 
         */
        public class func execute(execute execute: Execute) -> RequestBuilder<QueryResult> {
            let path = "/event-explorer/analyze"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = execute.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<QueryResult>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
        /**
         
         Event statistics
         
         - POST /event-explorer/event_dimensions
         - 
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example=[ "aeiou" ]}]
         
         - parameter project: (form) 

         - returns: RequestBuilder<[String]> 
         */
        public class func getEventDimensions(project project: String?) -> RequestBuilder<[String]> {
            let path = "/event-explorer/event_dimensions"
            let URLString = SwaggerClientAPI.basePath + path
            
            let nillableParameters: [String:AnyObject?] = [
                "project": project
            ]
            let parameters = APIHelper.rejectNil(nillableParameters)

            let requestBuilder: RequestBuilder<[String]>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: false)
        }
    
        /**
         
         Event statistics
         
         - POST /event-explorer/extra_dimensions
         - 
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example=[ "aeiou" ]}]
         
         - parameter project: (form) 

         - returns: RequestBuilder<[String]> 
         */
        public class func getExtraDimensions(project project: String?) -> RequestBuilder<[String]> {
            let path = "/event-explorer/extra_dimensions"
            let URLString = SwaggerClientAPI.basePath + path
            
            let nillableParameters: [String:AnyObject?] = [
                "project": project
            ]
            let parameters = APIHelper.rejectNil(nillableParameters)

            let requestBuilder: RequestBuilder<[String]>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: false)
        }
    
        /**
         
         Event statistics
         
         - POST /event-explorer/statistics
         - 
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example={
  "result" : [ [ "{}" ] ],
  "metadata" : [ {
    "nullable" : true,
    "descriptiveName" : "aeiou",
    "unique" : true,
    "name" : "aeiou",
    "description" : "aeiou",
    "type" : "aeiou",
    "category" : "aeiou"
  } ],
  "failed" : true,
  "error" : {
    "query" : "aeiou",
    "sqlState" : "aeiou",
    "errorCode" : 123,
    "message" : "aeiou"
  },
  "properties" : {
    "key" : "{}"
  }
}}]
         
         - parameter project: (form) 
         - parameter collections: (form) 
         - parameter dimension: (form) 
         - parameter startDate: (form) 
         - parameter endDate: (form) 

         - returns: RequestBuilder<QueryResult> 
         */
        public class func getEventStatistics(project project: String?, collections: [String]?, dimension: String?, startDate: NSDate?, endDate: NSDate?) -> RequestBuilder<QueryResult> {
            let path = "/event-explorer/statistics"
            let URLString = SwaggerClientAPI.basePath + path
            
            let nillableParameters: [String:AnyObject?] = [
                "project": project,
                "collections": collections,
                "dimension": dimension,
                "startDate": startDate,
                "endDate": endDate
            ]
            let parameters = APIHelper.rejectNil(nillableParameters)

            let requestBuilder: RequestBuilder<QueryResult>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: false)
        }
    
    }
}
