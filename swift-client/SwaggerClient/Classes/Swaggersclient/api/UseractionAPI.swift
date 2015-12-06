//
// UseractionAPI.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Alamofire

extension SwaggerClientAPI {
    
    public class UseractionAPI: APIBase {
    
        /**
         
         Apply batch operation
         
         - POST /user/action/email/batch
         - 
         - examples: [{contentType=application/json, example=123456789}]
         
         - parameter batchSendEmails: (body) 

         - returns: RequestBuilder<Int> 
         */
        public class func batchSendEmails(batchSendEmails batchSendEmails: BatchSendEmails) -> RequestBuilder<Int> {
            let path = "/user/action/email/batch"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = batchSendEmails.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<Int>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
        /**
         
         Perform action for single user
         
         - POST /user/action/email/single
         - 
         - examples: [{contentType=application/json, example=true}]
         
         - parameter send: (body) 

         - returns: RequestBuilder<Bool> 
         */
        public class func send(send send: Send) -> RequestBuilder<Bool> {
            let path = "/user/action/email/single"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = send.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<Bool>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
        /**
         
         Send message to user
         
         - POST /user/action/mailbox/action/mailbox/single
         - Sends a mail to users mailbox
         - API Key:
           - type: apiKey write_key 
           - name: write_key
         - examples: [{contentType=application/json, example={
  "to_user" : "{}",
  "project" : "aeiou",
  "id" : 123,
  "time" : 123456789,
  "content" : "aeiou",
  "parentId" : 123,
  "seen" : true,
  "from_user" : "{}"
}}]
         
         - parameter project: (form) 
         - parameter fromUser: (form) 
         - parameter toUser: (form) 
         - parameter parent: (form) 
         - parameter message: (form) 
         - parameter timestamp: (form) 

         - returns: RequestBuilder<Message> 
         */
        public class func send(project project: String?, fromUser: String?, toUser: String?, parent: Int?, message: String?, timestamp: Int?) -> RequestBuilder<Message> {
            let path = "/user/action/mailbox/action/mailbox/single"
            let URLString = SwaggerClientAPI.basePath + path
            
            let nillableParameters: [String:AnyObject?] = [
                "project": project,
                "fromUser": fromUser,
                "toUser": toUser,
                "parent": parent,
                "message": message,
                "timestamp": timestamp
            ]
            let parameters = APIHelper.rejectNil(nillableParameters)

            let requestBuilder: RequestBuilder<Message>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: false)
        }
    
        /**
         
         Apply batch operation
         
         - POST /user/action/mailbox/batch
         - 
         - examples: [{contentType=application/json, example=123456789}]
         
         - parameter batchSendMessages: (body) 

         - returns: RequestBuilder<Int> 
         */
        public class func batchSendMessages(batchSendMessages batchSendMessages: BatchSendMessages) -> RequestBuilder<Int> {
            let path = "/user/action/mailbox/batch"
            let URLString = SwaggerClientAPI.basePath + path
            
            let parameters = batchSendMessages.encodeToJSON() as? [String:AnyObject]

            let requestBuilder: RequestBuilder<Int>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

            return requestBuilder.init(method: "POST", URLString: URLString, parameters: parameters, isBody: true)
        }
    
    }
}
