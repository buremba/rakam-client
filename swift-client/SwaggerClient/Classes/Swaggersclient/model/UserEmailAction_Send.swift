//
// UserEmailAction_Send.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation


public class UserEmailAction_Send: JSONEncodable {

    public var project: String?
    public var user: String?
    public var config: EmailActionConfig?
    

    public init() {}

    // MARK: JSONEncodable
    func encodeToJSON() -> AnyObject {
        var nillableDictionary = [String:AnyObject?]()
        nillableDictionary["project"] = self.project
        nillableDictionary["user"] = self.user
        nillableDictionary["config"] = self.config?.encodeToJSON()
        let dictionary: [String:AnyObject] = APIHelper.rejectNil(nillableDictionary) ?? [:]
        return dictionary
    }
}
