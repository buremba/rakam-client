//
// UserAPI.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Alamofire

extension SwaggerClientAPI {
    
    public class UserAPI: APIBase {
    
        /**
         
         Create new user
         
         - POST /user/batch/create
         - 
         - examples: [{contentType=application/json, example=[ "aeiou" ]}]
         
         - parameter batchCreate: (body) 

         - returns: RequestBuilder<[String]> 
         */
        public class func batchCreate(batchCreate batchCreate: BatchCreate) -> RequestBuilder<[String]> {
            let path = "/user/batch/create"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = batchCreate.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<[String]>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
        /**
         
         Create new user
         
         - POST /user/create
         - 
         - examples: [{contentType=application/json, example="aeiou"}]
         
         - parameter user: (body) 

         - returns: RequestBuilder<String> 
         */
        public class func create(user user: User) -> RequestBuilder<String> {
            let path = "/user/create"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = user.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<String>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
        /**
         
         Get user
         
         - POST /user/get
         - 
         - examples: [{contentType=application/json, example={
  "project" : "aeiou",
  "id" : "aeiou",
  "properties" : {
    "key" : "{}"
  }
}}]
         
         - parameter project: (form) 
         - parameter user: (form) 

         - returns: RequestBuilder<User> 
         */
        public class func getUser(project project: String?, user: String?) -> RequestBuilder<User> {
            let path = "/user/get"
            let URLString = SwaggerClientAPI.basePath + path
            
            let nillableParameters: [String:AnyObject?] = [
                "project": project,
                "user": user
            ]
            let parameters = APIHelper.rejectNil(nillableParameters)

            let requestBuilder: RequestBuilder<User>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: false)
        }
    
        /**
         
         Get events of the user
         
         - POST /user/get_events
         - 
         - examples: [{contentType=application/json, example=[ {
  "collection" : "aeiou",
  "properties" : {
    "key" : "{}"
  }
} ]}]
         
         - parameter project: (form) 
         - parameter user: (form) 
         - parameter limit: (form) 
         - parameter offset: (form) 

         - returns: RequestBuilder<[CollectionEvent]> 
         */
        public class func getEvents(project project: String?, user: String?, limit: Int?, offset: Int?) -> RequestBuilder<[CollectionEvent]> {
            let path = "/user/get_events"
            let URLString = SwaggerClientAPI.basePath + path
            
            let nillableParameters: [String:AnyObject?] = [
                "project": project,
                "user": user,
                "limit": limit,
                "offset": offset
            ]
            let parameters = APIHelper.rejectNil(nillableParameters)

            let requestBuilder: RequestBuilder<[CollectionEvent]>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: false)
        }
    
        /**
         
         Set user property
         
         - POST /user/increment
         - 
         - examples: [{contentType=application/json, example={
  "success" : true,
  "message" : "aeiou"
}}]
         
         - parameter project: (form) 
         - parameter user: (form) 

         - returns: RequestBuilder<JsonResponse> 
         */
        public class func incrementUserProperty(project project: String?, user: String?) -> RequestBuilder<JsonResponse> {
            let path = "/user/increment"
            let URLString = SwaggerClientAPI.basePath + path
            
            let nillableParameters: [String:AnyObject?] = [
                "project": project,
                "user": user
            ]
            let parameters = APIHelper.rejectNil(nillableParameters)

            let requestBuilder: RequestBuilder<JsonResponse>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: false)
        }
    
        /**
         
         Get user storage metadata
         
         - POST /user/metadata
         - 
         - examples: [{contentType=application/json, example={
  "columns" : [ {
    "nullable" : true,
    "descriptiveName" : "aeiou",
    "unique" : true,
    "name" : "aeiou",
    "description" : "aeiou",
    "type" : "aeiou",
    "category" : "aeiou"
  } ],
  "identifierColumn" : "aeiou"
}}]
         
         - parameter project: (form) 

         - returns: RequestBuilder<MetadataResponse> 
         */
        public class func getMetadata(project project: String?) -> RequestBuilder<MetadataResponse> {
            let path = "/user/metadata"
            let URLString = SwaggerClientAPI.basePath + path
            
            let nillableParameters: [String:AnyObject?] = [
                "project": project
            ]
            let parameters = APIHelper.rejectNil(nillableParameters)

            let requestBuilder: RequestBuilder<MetadataResponse>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: false)
        }
    
        /**
         
         Search users
         
         - POST /user/search
         - 
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
         
         - parameter searchUsers: (body) 

         - returns: RequestBuilder<QueryResult> 
         */
        public class func searchUsers(searchUsers searchUsers: SearchUsers) -> RequestBuilder<QueryResult> {
            let path = "/user/search"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = searchUsers.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<QueryResult>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
        /**
         
         Set user properties once
         
         - POST /user/set_once
         - 
         
         - parameter setUserProperties: (body) 

         - returns: RequestBuilder<Void> 
         */
        public class func setUserPropertiesOnce(setUserProperties setUserProperties: SetUserProperties) -> RequestBuilder<Void> {
            let path = "/user/set_once"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = setUserProperties.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<Void>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
        /**
         
         Set user properties
         
         - POST /user/set_property
         - 
         - examples: [{contentType=application/json, example=123}]
         
         - parameter setUserProperties: (body) 

         - returns: RequestBuilder<Int> 
         */
        public class func setUserProperties(setUserProperties setUserProperties: SetUserProperties) -> RequestBuilder<Int> {
            let path = "/user/set_property"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = setUserProperties.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<Int>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
    }
}
