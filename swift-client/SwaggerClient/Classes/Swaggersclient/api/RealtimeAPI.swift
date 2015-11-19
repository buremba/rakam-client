//
// RealtimeAPI.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Alamofire

extension SwaggerClientAPI {
    
    public class RealtimeAPI: APIBase {
    
        /**
         
         Create report
         
         - POST /realtime/create
         - 
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example={
  "success" : true,
  "message" : "aeiou"
}}]
         
         - parameter project: (form) 
         - parameter name: (form) 
         - parameter aggregation: (form) 
         - parameter tableName: (form) 
         - parameter collections: (form) 
         - parameter filter: (form) 
         - parameter measure: (form) 
         - parameter dimensions: (form) 

         - returns: RequestBuilder<JsonResponse> 
         */
        public class func create(project project: String?, name: String?, aggregation: String?, tableName: String?, collections: [String]?, filter: String?, measure: String?, dimensions: [String]?) -> RequestBuilder<JsonResponse> {
            let path = "/realtime/create"
            let URLString = SwaggerClientAPI.basePath + path
            
            let nillableParameters: [String:AnyObject?] = [
                "project": project,
                "name": name,
                "aggregation": aggregation,
                "tableName": tableName,
                "collections": collections,
                "filter": filter,
                "measure": measure,
                "dimensions": dimensions
            ]
            let parameters = APIHelper.rejectNil(nillableParameters)

            let requestBuilder: RequestBuilder<JsonResponse>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: false)
        }
    
        /**
         
         Delete report
         
         - POST /realtime/delete
         - 
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example={
  "success" : true,
  "message" : "aeiou"
}}]
         
         - parameter project: (form) 
         - parameter name: (form) 

         - returns: RequestBuilder<JsonResponse> 
         */
        public class func delete(project project: String?, name: String?) -> RequestBuilder<JsonResponse> {
            let path = "/realtime/delete"
            let URLString = SwaggerClientAPI.basePath + path
            
            let nillableParameters: [String:AnyObject?] = [
                "project": project,
                "name": name
            ]
            let parameters = APIHelper.rejectNil(nillableParameters)

            let requestBuilder: RequestBuilder<JsonResponse>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: false)
        }
    
        /**
         
         Get report
         
         - POST /realtime/get
         - 
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example="{}"}]
         
         - parameter project: (form) 
         - parameter tableName: (form) 
         - parameter filter: (form) 
         - parameter aggregation: (form) 
         - parameter measure: (form) 
         - parameter dimensions: (form) 
         - parameter aggregate: (form) 
         - parameter dateStart: (form) 
         - parameter dateEnd: (form) 

         - returns: RequestBuilder<String> 
         */
        public class func get(project project: String?, tableName: String?, filter: String?, aggregation: String?, measure: String?, dimensions: [String]?, aggregate: Bool?, dateStart: NSDate?, dateEnd: NSDate?) -> RequestBuilder<String> {
            let path = "/realtime/get"
            let URLString = SwaggerClientAPI.basePath + path
            
            let nillableParameters: [String:AnyObject?] = [
                "project": project,
                "tableName": tableName,
                "filter": filter,
                "aggregation": aggregation,
                "measure": measure,
                "dimensions": dimensions,
                "aggregate": aggregate,
                "dateStart": dateStart,
                "dateEnd": dateEnd
            ]
            let parameters = APIHelper.rejectNil(nillableParameters)

            let requestBuilder: RequestBuilder<String>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: false)
        }
    
        /**
         
         List reports
         
         - POST /realtime/list
         - 
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example=[ {
  "filter" : "aeiou",
  "measure" : "aeiou",
  "collections" : [ "aeiou" ],
  "name" : "aeiou",
  "project" : "aeiou",
  "aggregation" : "aeiou",
  "table_name" : "aeiou",
  "dimensions" : [ "aeiou" ]
} ]}]
         
         - parameter project: (form) 

         - returns: RequestBuilder<[RealTimeReport]> 
         */
        public class func listReports(project project: String?) -> RequestBuilder<[RealTimeReport]> {
            let path = "/realtime/list"
            let URLString = SwaggerClientAPI.basePath + path
            
            let nillableParameters: [String:AnyObject?] = [
                "project": project
            ]
            let parameters = APIHelper.rejectNil(nillableParameters)

            let requestBuilder: RequestBuilder<[RealTimeReport]>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: false)
        }
    
    }
}
