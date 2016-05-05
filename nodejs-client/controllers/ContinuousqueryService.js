'use strict';

exports.continuousQueryCreate = function(args, res, next) {
  /**
   * parameters expected in the args:
   * continuousQuery (ContinuousQuery)
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
exports.continuousQueryDelete = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * tableName (String)
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
exports.continuousQueryGet = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * tableName (String)
   **/

var examples = {};
  
  examples['application/json'] = {
  "query" : "aeiou",
  "name" : "aeiou",
  "options" : {
    "key" : { }
  },
  "project" : "aeiou",
  "partitionKeys" : [ "aeiou" ],
  "tableName" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.continuousQueryListQueries = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   **/

var examples = {};
  
  examples['application/json'] = [ {
  "query" : "aeiou",
  "name" : "aeiou",
  "options" : {
    "key" : { }
  },
  "project" : "aeiou",
  "partitionKeys" : [ "aeiou" ],
  "tableName" : "aeiou"
} ];
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.continuousQuerySchema = function(args, res, next) {
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
exports.continuousQueryTest = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * query (String)
   **/

var examples = {};
  
  examples['application/json'] = true;
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
