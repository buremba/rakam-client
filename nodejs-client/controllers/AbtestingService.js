'use strict';

exports.create = function() {

  var examples = {};
  
  examples['application/json'] = {
  "success" : true,
  "message" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.delete = function(project, id) {

  var examples = {};
  
  examples['application/json'] = {
  "success" : true,
  "message" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.get = function(project, id) {

  var examples = {};
  
  examples['application/json'] = {
  "connectorField" : "aeiou",
  "goal" : {
    "filter" : "aeiou",
    "collection" : "aeiou"
  },
  "name" : "aeiou",
  "options" : "{}",
  "project" : "aeiou",
  "variants" : [ {
    "data" : "{}",
    "name" : "aeiou",
    "weight" : 123
  } ],
  "id" : 123,
  "collectionName" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.list = function(project) {

  var examples = {};
  
  examples['application/json'] = [ {
  "connectorField" : "aeiou",
  "goal" : {
    "filter" : "aeiou",
    "collection" : "aeiou"
  },
  "name" : "aeiou",
  "options" : "{}",
  "project" : "aeiou",
  "variants" : [ {
    "data" : "{}",
    "name" : "aeiou",
    "weight" : 123
  } ],
  "id" : 123,
  "collectionName" : "aeiou"
} ];
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.update = function() {

  var examples = {};
  
  examples['application/json'] = {
  "connectorField" : "aeiou",
  "goal" : {
    "filter" : "aeiou",
    "collection" : "aeiou"
  },
  "name" : "aeiou",
  "options" : "{}",
  "project" : "aeiou",
  "variants" : [ {
    "data" : "{}",
    "name" : "aeiou",
    "weight" : 123
  } ],
  "id" : 123,
  "collectionName" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
