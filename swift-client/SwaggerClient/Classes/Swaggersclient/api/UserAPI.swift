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
         
         - parameter userBatchCreate: (body) 

         - returns: RequestBuilder<[String]> 
         */
        public class func userBatchCreate(userBatchCreate userBatchCreate: User_BatchCreate) -> RequestBuilder<[String]> {
            let path = "/user/batch/create"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = userBatchCreate.encodeToJSON() as? [String:AnyObject]

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
        public class func userCreate(user user: User) -> RequestBuilder<String> {
            let path = "/user/create"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = user.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<String>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
        /**
         
         Get events of the user
         
         - POST /user/create_segment
         - 
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example={
  "success" : true,
  "message" : "aeiou"
}}]
         
         - parameter userCreateSegment: (body) 

         - returns: RequestBuilder<JsonResponse> 
         */
        public class func userCreateSegment(userCreateSegment userCreateSegment: User_CreateSegment) -> RequestBuilder<JsonResponse> {
            let path = "/user/create_segment"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = userCreateSegment.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<JsonResponse>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
        /**
         
         Get user
         
         - POST /user/get
         - 
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example={
  "project" : "aeiou",
  "id" : "aeiou",
  "api" : {
    "writeKey" : "aeiou",
    "apiVersion" : "aeiou"
  },
  "properties" : {
    "key" : { }
  }
}}]
         
         - parameter project: (form) 
         - parameter user: (form) 

         - returns: RequestBuilder<User> 
         */
        public class func userGetUser(project project: String?, user: String?) -> RequestBuilder<User> {
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
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example=[ {
  "collection" : "aeiou",
  "properties" : {
    "key" : { }
  }
} ]}]
         
         - parameter project: (form) 
         - parameter user: (form) 
         - parameter limit: (form) 
         - parameter offset: (form) 

         - returns: RequestBuilder<[CollectionEvent]> 
         */
        public class func userGetEvents(project project: String?, user: String?, limit: Int?, offset: NSDate?) -> RequestBuilder<[CollectionEvent]> {
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
         
         - POST /user/increment_property
         - 
         - examples: [{contentType=application/json, example={
  "success" : true,
  "message" : "aeiou"
}}]
         
         - parameter userIncrementProperty: (body) 

         - returns: RequestBuilder<JsonResponse> 
         */
        public class func userIncrementProperty(userIncrementProperty userIncrementProperty: User_IncrementProperty) -> RequestBuilder<JsonResponse> {
            let path = "/user/increment_property"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = userIncrementProperty.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<JsonResponse>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
        /**
         
         Merge user with anonymous id
         
         - POST /user/merge
         - 
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example=true}]
         
         - parameter userMergeUser: (body) 

         - returns: RequestBuilder<Bool> 
         */
        public class func userMergeUser(userMergeUser userMergeUser: User_MergeUser) -> RequestBuilder<Bool> {
            let path = "/user/merge"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = userMergeUser.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<Bool>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
        /**
         
         Get user storage metadata
         
         - POST /user/metadata
         - 
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example={
  "columns" : [ {
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
        public class func userGetMetadata(project project: String?) -> RequestBuilder<MetadataResponse> {
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
         - API Key:
           - type: apiKey read_key 
           - name: read_key
         - examples: [{contentType=application/json, example={
  "result" : [ [ "{}" ] ],
  "metadata" : [ {
    "descriptiveName" : "aeiou",
    "unique" : true,
    "name" : "aeiou",
    "description" : "aeiou",
    "type" : "aeiou",
    "category" : "aeiou"
  } ],
  "failed" : true,
  "error" : {
    "charPositionInLine" : 123,
    "sqlState" : "aeiou",
    "errorCode" : 123,
    "message" : "aeiou",
    "errorLine" : 123
  },
  "properties" : {
    "key" : { }
  }
}}]
         
         - parameter userSearchUsers: (body) 

         - returns: RequestBuilder<QueryResult> 
         */
        public class func userSearchUsers(userSearchUsers userSearchUsers: User_SearchUsers) -> RequestBuilder<QueryResult> {
            let path = "/user/search"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = userSearchUsers.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<QueryResult>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
        /**
         
         Set user properties
         
         - POST /user/set_properties
         - 
         - examples: [{contentType=application/json, example=123}]
         
         - parameter setUserProperties: (body) 

         - returns: RequestBuilder<Int> 
         */
        public class func userSetProperties(setUserProperties setUserProperties: SetUserProperties) -> RequestBuilder<Int> {
            let path = "/user/set_properties"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = setUserProperties.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<Int>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
        /**
         
         Set user properties once
         
         - POST /user/set_properties_once
         - 
         
         - parameter setUserProperties: (body) 

         - returns: RequestBuilder<Void> 
         */
        public class func userSetPropertiesOnce(setUserProperties setUserProperties: SetUserProperties) -> RequestBuilder<Void> {
            let path = "/user/set_properties_once"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = setUserProperties.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<Void>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
        /**
         
         Unset user property
         
         - POST /user/unset_properties
         - 
         - examples: [{contentType=application/json, example={
  "success" : true,
  "message" : "aeiou"
}}]
         
         - parameter userUnsetProperty: (body) 

         - returns: RequestBuilder<JsonResponse> 
         */
        public class func userUnsetProperty(userUnsetProperty userUnsetProperty: User_UnsetProperty) -> RequestBuilder<JsonResponse> {
            let path = "/user/unset_properties"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = userUnsetProperty.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<JsonResponse>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
    }
}
