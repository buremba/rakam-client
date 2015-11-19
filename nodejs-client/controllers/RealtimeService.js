'use strict';

exports.create = function(project, name, aggregation, tableName, collections, filter, measure, dimensions) {

  var examples = {};
  
  examples['application/json'] = {
  "success" : true,
  "message" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.delete = function(project, name) {

  var examples = {};
  
  examples['application/json'] = {
  "success" : true,
  "message" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.get = function(project, tableName, filter, aggregation, measure, dimensions, aggregate, dateStart, dateEnd) {

  var examples = {};
  
  examples['application/json'] = "{}";
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.listReports = function(project) {

  var examples = {};
  
  examples['application/json'] = [ {
  "filter" : "aeiou",
  "measure" : "aeiou",
  "collections" : [ "aeiou" ],
  "name" : "aeiou",
  "project" : "aeiou",
  "aggregation" : "aeiou",
  "table_name" : "aeiou",
  "dimensions" : [ "aeiou" ]
} ];
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
