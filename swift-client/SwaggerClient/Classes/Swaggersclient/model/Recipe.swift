//
// Recipe.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation


public class Recipe: JSONEncodable {

    public enum Strategy: String { 
        case DEFAULT = "DEFAULT"
        case SPECIFIC = "SPECIFIC"
    }
    
    public var strategy: Strategy!
    public var project: String?
    public var collections: [String:Collection]!
    public var reports: [ReportBuilder]!
    public var materializedViews: [MaterializedViewBuilder]?
    public var continuousQueries: [ContinuousQueryBuilder]?
    public var continuousQueryBuilders: [ContinuousQueryBuilder]?
    public var materializedViewBuilders: [MaterializedViewBuilder]?
    

    // MARK: JSONEncodable
    func encodeToJSON() -> AnyObject {
        var nillableDictionary = [String:AnyObject?]()
        nillableDictionary["strategy"] = self.strategy.rawValue
        nillableDictionary["project"] = self.project
        nillableDictionary["collections"] = self.collections.encodeToJSON()
        nillableDictionary["reports"] = self.reports.encodeToJSON()
        nillableDictionary["materializedViews"] = self.materializedViews?.encodeToJSON()
        nillableDictionary["continuousQueries"] = self.continuousQueries?.encodeToJSON()
        nillableDictionary["continuousQueryBuilders"] = self.continuousQueryBuilders?.encodeToJSON()
        nillableDictionary["materializedViewBuilders"] = self.materializedViewBuilders?.encodeToJSON()
        let dictionary: [String:AnyObject] = APIHelper.rejectNil(nillableDictionary) ?? [:]
        return dictionary
    }
}
