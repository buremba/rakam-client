'use strict';

exports.getModules = function() {

  var examples = {};
  

  
}
exports.createProject = function(name) {

  var examples = {};
  
  examples['application/json'] = {
  "success" : true,
  "message" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.getProjects = function() {

  var examples = {};
  

  
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
