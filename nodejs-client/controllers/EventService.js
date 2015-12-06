'use strict';

exports.batchEvents = function(eventList) {

  var examples = {};
  
  examples['application/json'] = 123;
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.collectEvent = function(event) {

  var examples = {};
  
  examples['application/json'] = 123;
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.execute = function(project, query, limit) {

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
exports.explain = function(query) {

  var examples = {};
  
  examples['application/json'] = "{}";
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
