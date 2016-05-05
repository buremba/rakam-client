//
// AnalyzeRequest.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation


public class AnalyzeRequest: JSONEncodable {

    public var project: String?
    public var measure: Measure?
    public var grouping: Reference?
    public var segment: Reference?
    public var filterExpression: String?
    public var startDate: NSDate?
    public var endDate: NSDate?
    public var collections: [String]?
    

    public init() {}

    // MARK: JSONEncodable
    func encodeToJSON() -> AnyObject {
        var nillableDictionary = [String:AnyObject?]()
        nillableDictionary["project"] = self.project
        nillableDictionary["measure"] = self.measure?.encodeToJSON()
        nillableDictionary["grouping"] = self.grouping?.encodeToJSON()
        nillableDictionary["segment"] = self.segment?.encodeToJSON()
        nillableDictionary["filterExpression"] = self.filterExpression
        nillableDictionary["startDate"] = self.startDate?.encodeToJSON()
        nillableDictionary["endDate"] = self.endDate?.encodeToJSON()
        nillableDictionary["collections"] = self.collections?.encodeToJSON()
        let dictionary: [String:AnyObject] = APIHelper.rejectNil(nillableDictionary) ?? [:]
        return dictionary
    }
}
