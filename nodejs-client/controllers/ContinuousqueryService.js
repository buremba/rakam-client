'use strict';

exports.create = function(continuousQuery) {

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
exports.listQueries = function(project) {

  var examples = {};
  
  examples['application/json'] = [ {
  "collections" : [ "aeiou" ],
  "name" : "aeiou",
  "options" : {
    "key" : "{}"
  },
  "project" : "aeiou",
  "partitionKeys" : [ "aeiou" ],
  "tableName" : "aeiou",
  "rawQuery" : "aeiou"
} ];
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.schema = function(project) {

  var examples = {};
  
  examples['application/json'] = [ {
  "name" : "aeiou",
  "fields" : [ {
    "nullable" : true,
    "descriptiveName" : "aeiou",
    "unique" : true,
    "name" : "aeiou",
    "description" : "aeiou",
    "type" : "aeiou",
    "category" : "aeiou"
  } ]
} ];
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.test = function(project, query) {

  var examples = {};
  
  examples['application/json'] = [ {
  "nullable" : true,
  "descriptiveName" : "aeiou",
  "unique" : true,
  "name" : "aeiou",
  "description" : "aeiou",
  "type" : "aeiou",
  "category" : "aeiou"
} ];
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
