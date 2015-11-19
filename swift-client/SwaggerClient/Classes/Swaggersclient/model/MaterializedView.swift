//
// MaterializedView.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation


public class MaterializedView: JSONEncodable {

    public var project: String?
    public var name: String?
    public var table_name: String?
    public var query: String?
    public var update_interval: String?
    public var options: [String:String]?
    

    // MARK: JSONEncodable
    func encodeToJSON() -> AnyObject {
        var nillableDictionary = [String:AnyObject?]()
        nillableDictionary["project"] = self.project
        nillableDictionary["name"] = self.name
        nillableDictionary["table_name"] = self.table_name
        nillableDictionary["query"] = self.query
        nillableDictionary["update_interval"] = self.update_interval
        nillableDictionary["options"] = self.options?.encodeToJSON()
        let dictionary: [String:AnyObject] = APIHelper.rejectNil(nillableDictionary) ?? [:]
        return dictionary
    }
}