//
// QueryError.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation


public class QueryError: JSONEncodable {

    public var message: String?
    public var sqlState: String?
    public var errorCode: Int?
    public var query: String?
    

    // MARK: JSONEncodable
    func encodeToJSON() -> AnyObject {
        var nillableDictionary = [String:AnyObject?]()
        nillableDictionary["message"] = self.message
        nillableDictionary["sqlState"] = self.sqlState
        nillableDictionary["errorCode"] = self.errorCode
        nillableDictionary["query"] = self.query
        let dictionary: [String:AnyObject] = APIHelper.rejectNil(nillableDictionary) ?? [:]
        return dictionary
    }
}
