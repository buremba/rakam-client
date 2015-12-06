//
// ContinuousqueryAPI.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Alamofire

extension SwaggerClientAPI {
    
    public class ContinuousqueryAPI: APIBase {
    
        /**
         
         Create stream
         
         - POST /continuous-query/create
         - 
         - API Key:
           - type: apiKey master_key 
           - name: master_key
         - examples: [{contentType=application/json, example={
  "success" : true,
  "message" : "aeiou"
}}]
         
         - parameter continuousQuery: (body) 

         - returns: RequestBuilder<JsonResponse> 
         */
        public class func create(continuousQuery continuousQuery: ContinuousQuery) -> RequestBuilder<JsonResponse> {
            let path = "/continuous-query/create"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = continuousQuery.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<JsonResponse>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
        /**
         
         Delete stream
         
         - POST /continuous-query/delete
         - 
         - API Key:
           - type: apiKey master_key 
           - name: master_key
         - examples: [{contentType=application/json, example={
  "success" : true,
  "message" : "aeiou"
}}]
         
         - parameter project: (form) 
         - parameter name: (form) 

         - returns: RequestBuilder<JsonResponse> 
         */
        public class func delete(project project: String?, name: String?) -> RequestBuilder<JsonResponse> {
            let path = "/continuous-query/delete"
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
         
         List queries
         
         - POST /continuous-query/list
         - 
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example=[ {
  "collections" : [ "aeiou" ],
  "name" : "aeiou",
  "options" : {
    "key" : "{}"
  },
  "project" : "aeiou",
  "partitionKeys" : [ "aeiou" ],
  "tableName" : "aeiou",
  "rawQuery" : "aeiou"
} ]}]
         
         - parameter project: (form) 

         - returns: RequestBuilder<[ContinuousQuery]> 
         */
        public class func listQueries(project project: String?) -> RequestBuilder<[ContinuousQuery]> {
            let path = "/continuous-query/list"
            let URLString = SwaggerClientAPI.basePath + path
            
            let nillableParameters: [String:AnyObject?] = [
                "project": project
            ]
            let parameters = APIHelper.rejectNil(nillableParameters)

            let requestBuilder: RequestBuilder<[ContinuousQuery]>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: false)
        }
    
        /**
         
         Get query schema
         
         - POST /continuous-query/schema
         - 
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example=[ {
  "name" : "aeiou",
  "fields" : [ {
    "nullable" : true,
    "descriptiveName" : "aeiou",
    "unique" : true,
    "name" : "aeiou",
    "description" : "aeiou",
    "type" : "aeiou",
    "category" : "aeiou"
  } ]
} ]}]
         
         - parameter project: (form) 

         - returns: RequestBuilder<[Collection]> 
         */
        public class func schema(project project: String?) -> RequestBuilder<[Collection]> {
            let path = "/continuous-query/schema"
            let URLString = SwaggerClientAPI.basePath + path
            
            let nillableParameters: [String:AnyObject?] = [
                "project": project
            ]
            let parameters = APIHelper.rejectNil(nillableParameters)

            let requestBuilder: RequestBuilder<[Collection]>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: false)
        }
    
        /**
         
         Test continuous query
         
         - POST /continuous-query/test
         - 
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example=[ {
  "nullable" : true,
  "descriptiveName" : "aeiou",
  "unique" : true,
  "name" : "aeiou",
  "description" : "aeiou",
  "type" : "aeiou",
  "category" : "aeiou"
} ]}]
         
         - parameter project: (form) 
         - parameter query: (form) 

         - returns: RequestBuilder<[SchemaField]> 
         */
        public class func test(project project: String?, query: String?) -> RequestBuilder<[SchemaField]> {
            let path = "/continuous-query/test"
            let URLString = SwaggerClientAPI.basePath + path
            
            let nillableParameters: [String:AnyObject?] = [
                "project": project,
                "query": query
            ]
            let parameters = APIHelper.rejectNil(nillableParameters)

            let requestBuilder: RequestBuilder<[SchemaField]>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: false)
        }
    
    }
}
