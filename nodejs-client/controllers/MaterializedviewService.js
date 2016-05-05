'use strict';

exports.materializedViewCreate = function(args, res, next) {
  /**
   * parameters expected in the args:
   * materializedView (MaterializedView)
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
exports.materializedViewDelete = function(args, res, next) {
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
exports.materializedViewGet = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * tableName (String)
   **/

var examples = {};
  
  examples['application/json'] = {
  "updateInterval" : "aeiou",
  "query" : "aeiou",
  "lastUpdate" : "2016-05-05T23:48:08.793+0000",
  "name" : "aeiou",
  "options" : {
    "key" : { }
  },
  "project" : "aeiou",
  "incremental" : true,
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
exports.materializedViewListViews = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   **/

var examples = {};
  
  examples['application/json'] = [ {
  "updateInterval" : "aeiou",
  "query" : "aeiou",
  "lastUpdate" : "2016-05-05T23:48:08.797+0000",
  "name" : "aeiou",
  "options" : {
    "key" : { }
  },
  "project" : "aeiou",
  "incremental" : true,
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
exports.materializedViewSchema = function(args, res, next) {
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
exports.materializedViewUpdate = function(args, res, next) {
  /**
   * parameters expected in the args:
   **/

var examples = {};
  

  
  res.end();
}
