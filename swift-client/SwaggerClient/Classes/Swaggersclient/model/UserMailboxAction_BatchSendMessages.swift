//
// UserMailboxAction_BatchSendMessages.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation


public class UserMailboxAction_BatchSendMessages: JSONEncodable {

    public var project: String?
    public var filter: String?
    public var event_filters: [EventFilter]?
    public var config: MailAction?
    

    public init() {}

    // MARK: JSONEncodable
    func encodeToJSON() -> AnyObject {
        var nillableDictionary = [String:AnyObject?]()
        nillableDictionary["project"] = self.project
        nillableDictionary["filter"] = self.filter
        nillableDictionary["event_filters"] = self.event_filters?.encodeToJSON()
        nillableDictionary["config"] = self.config?.encodeToJSON()
        let dictionary: [String:AnyObject] = APIHelper.rejectNil(nillableDictionary) ?? [:]
        return dictionary
    }
}
