'use strict';

exports.adminGetConfigurations = function(args, res, next) {
  /**
   * parameters expected in the args:
   **/

var examples = {};
  

  
  res.end();
}
exports.adminModules = function(args, res, next) {
  /**
   * parameters expected in the args:
   **/

var examples = {};
  

  
  res.end();
}
exports.adminGetTypes = function(args, res, next) {
  /**
   * parameters expected in the args:
   **/

var examples = {};
  

  
  res.end();
}
exports.projectCollections = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   **/

var examples = {};
  
  examples['application/json'] = [ "aeiou" ];
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.projectCreateProject = function(args, res, next) {
  /**
   * parameters expected in the args:
   * name (String)
   **/

var examples = {};
  
  examples['application/json'] = {
  "success" : true,
  "message" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.projectDeleteProject = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   **/

var examples = {};
  
  examples['application/json'] = {
  "success" : true,
  "message" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.projectGetProjects = function(args, res, next) {
  /**
   * parameters expected in the args:
   **/

var examples = {};
  

  
  res.end();
}
exports.projectSchema = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * names (List)
   **/

var examples = {};
  
  examples['application/json'] = [ {
  "name" : "aeiou",
  "fields" : [ {
    "descriptiveName" : "aeiou",
    "unique" : true,
    "name" : "aeiou",
    "description" : "aeiou",
    "type" : "aeiou",
    "category" : "aeiou"
  } ]
} ];
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.projectAddFieldsToSchema = function(args, res, next) {
  /**
   * parameters expected in the args:
   * projectAddFieldsToSchema (Project_AddFieldsToSchema)
   **/

var examples = {};
  
  examples['application/json'] = [ {
  "descriptiveName" : "aeiou",
  "unique" : true,
  "name" : "aeiou",
  "description" : "aeiou",
  "type" : "aeiou",
  "category" : "aeiou"
} ];
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.projectAddCustomFieldsToSchema = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * collection (String)
   * schemaType (String)
   * schema (String)
   **/

var examples = {};
  
  examples['application/json'] = [ {
  "descriptiveName" : "aeiou",
  "unique" : true,
  "name" : "aeiou",
  "description" : "aeiou",
  "type" : "aeiou",
  "category" : "aeiou"
} ];
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
