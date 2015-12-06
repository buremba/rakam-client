'use strict';

exports.activateRule = function(project, id) {

  var examples = {};
  
  examples['application/json'] = {
  "success" : true,
  "message" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.addRule = function(automationRule) {

  var examples = {};
  
  examples['application/json'] = {
  "success" : true,
  "message" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.deactivateRule = function(project, id) {

  var examples = {};
  
  examples['application/json'] = {
  "success" : true,
  "message" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.listRules = function(project) {

  var examples = {};
  
  examples['application/json'] = [ {
  "is_active" : true,
  "project" : "aeiou",
  "scenarios" : [ {
    "filter" : "aeiou",
    "threshold" : {
      "fieldName" : "aeiou",
      "aggregation" : "aeiou",
      "value" : 123456789
    },
    "collection" : "aeiou"
  } ],
  "id" : 123,
  "actions" : [ {
    "type" : "aeiou",
    "value" : "{}"
  } ],
  "custom_data" : "aeiou"
} ];
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.removeRule = function(project, id) {

  var examples = {};
  
  examples['application/json'] = {
  "success" : true,
  "message" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
