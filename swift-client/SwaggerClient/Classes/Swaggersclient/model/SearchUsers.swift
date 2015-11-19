//
// SearchUsers.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation


public class SearchUsers: JSONEncodable {

    public var project: String?
    public var filter: String?
    public var event_filters: [EventFilter]?
    public var sorting: Sorting?
    public var offset: Int?
    public var limit: Int?
    

    // MARK: JSONEncodable
    func encodeToJSON() -> AnyObject {
        var nillableDictionary = [String:AnyObject?]()
        nillableDictionary["project"] = self.project
        nillableDictionary["filter"] = self.filter
        nillableDictionary["event_filters"] = self.event_filters?.encodeToJSON()
        nillableDictionary["sorting"] = self.sorting?.encodeToJSON()
        nillableDictionary["offset"] = self.offset
        nillableDictionary["limit"] = self.limit
        let dictionary: [String:AnyObject] = APIHelper.rejectNil(nillableDictionary) ?? [:]
        return dictionary
    }
}
