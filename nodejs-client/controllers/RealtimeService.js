'use strict';

exports.realtimeCreate = function(args, res, next) {
  /**
   * parameters expected in the args:
   * realTimeReport (RealTimeReport)
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
exports.realtimeDelete = function(args, res, next) {
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
exports.realtimeGet = function(args, res, next) {
  /**
   * parameters expected in the args:
   * realtimeGet (Realtime_Get)
   **/

var examples = {};
  
  examples['application/json'] = {
  "result" : "{}",
  "start" : 123456789,
  "end" : 123456789
};
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.realtimeList = function(args, res, next) {
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
