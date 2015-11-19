//
// Measure.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation


public class Measure: JSONEncodable {

    public enum Aggregation: String { 
        case COUNT = "COUNT"
        case COUNT_UNIQUE = "COUNT_UNIQUE"
        case SUM = "SUM"
        case MINIMUM = "MINIMUM"
        case MAXIMUM = "MAXIMUM"
        case APPROXIMATE_UNIQUE = "APPROXIMATE_UNIQUE"
        case VARIANCE = "VARIANCE"
        case POPULATION_VARIANCE = "POPULATION_VARIANCE"
        case STANDARD_DEVIATION = "STANDARD_DEVIATION"
        case AVERAGE = "AVERAGE"
    }
    
    public var column: String?
    public var aggregation: Aggregation?
    

    // MARK: JSONEncodable
    func encodeToJSON() -> AnyObject {
        var nillableDictionary = [String:AnyObject?]()
        nillableDictionary["column"] = self.column
        nillableDictionary["aggregation"] = self.aggregation?.rawValue
        let dictionary: [String:AnyObject] = APIHelper.rejectNil(nillableDictionary) ?? [:]
        return dictionary
    }
}
