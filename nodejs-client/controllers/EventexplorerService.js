'use strict';

exports.execute = function(execute) {

  var examples = {};
  
  examples['application/json'] = {
  "result" : [ [ "{}" ] ],
  "metadata" : [ {
    "nullable" : true,
    "descriptiveName" : "aeiou",
    "unique" : true,
    "name" : "aeiou",
    "description" : "aeiou",
    "type" : "aeiou",
    "category" : "aeiou"
  } ],
  "failed" : true,
  "error" : {
    "query" : "aeiou",
    "sqlState" : "aeiou",
    "errorCode" : 123,
    "message" : "aeiou"
  },
  "properties" : {
    "key" : "{}"
  }
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.getEventDimensions = function(project) {

  var examples = {};
  
  examples['application/json'] = [ "aeiou" ];
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.getExtraDimensions = function(project) {

  var examples = {};
  
  examples['application/json'] = [ "aeiou" ];
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.getEventStatistics = function(project, collections, dimension, startDate, endDate) {

  var examples = {};
  
  examples['application/json'] = {
  "result" : [ [ "{}" ] ],
  "metadata" : [ {
    "nullable" : true,
    "descriptiveName" : "aeiou",
    "unique" : true,
    "name" : "aeiou",
    "description" : "aeiou",
    "type" : "aeiou",
    "category" : "aeiou"
  } ],
  "failed" : true,
  "error" : {
    "query" : "aeiou",
    "sqlState" : "aeiou",
    "errorCode" : 123,
    "message" : "aeiou"
  },
  "properties" : {
    "key" : "{}"
  }
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
