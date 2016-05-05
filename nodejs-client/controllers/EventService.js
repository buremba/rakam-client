'use strict';

exports.collectEventBatchEvents = function(args, res, next) {
  /**
   * parameters expected in the args:
   * eventList (EventList)
   **/

var examples = {};
  
  examples['application/json'] = 123;
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.collectEventBulkEvents = function(args, res, next) {
  /**
   * parameters expected in the args:
   * eventList (EventList)
   **/

var examples = {};
  
  examples['application/json'] = 123;
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.collectEventCommitBulkEvents = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * collection (String)
   **/

var examples = {};
  
  examples['application/json'] = {
  "result" : [ [ "{}" ] ],
  "metadata" : [ {
    "descriptiveName" : "aeiou",
    "unique" : true,
    "name" : "aeiou",
    "description" : "aeiou",
    "type" : "aeiou",
    "category" : "aeiou"
  } ],
  "failed" : true,
  "error" : {
    "charPositionInLine" : 123,
    "sqlState" : "aeiou",
    "errorCode" : 123,
    "message" : "aeiou",
    "errorLine" : 123
  },
  "properties" : {
    "key" : { }
  }
};
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.collectEventBulkEventsRemote = function(args, res, next) {
  /**
   * parameters expected in the args:
   * eventList (EventList)
   **/

var examples = {};
  
  examples['application/json'] = 123;
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.collectEventCollectEvent = function(args, res, next) {
  /**
   * parameters expected in the args:
   * event (Event)
   **/

var examples = {};
  
  examples['application/json'] = 123;
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.queryExecute = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * query (String)
   * limit (Integer)
   **/

var examples = {};
  
  examples['application/json'] = {
  "result" : [ [ "{}" ] ],
  "metadata" : [ {
    "descriptiveName" : "aeiou",
    "unique" : true,
    "name" : "aeiou",
    "description" : "aeiou",
    "type" : "aeiou",
    "category" : "aeiou"
  } ],
  "failed" : true,
  "error" : {
    "charPositionInLine" : 123,
    "sqlState" : "aeiou",
    "errorCode" : 123,
    "message" : "aeiou",
    "errorLine" : 123
  },
  "properties" : {
    "key" : { }
  }
};
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.queryExplain = function(args, res, next) {
  /**
   * parameters expected in the args:
   * query (String)
   **/

var examples = {};
  
  examples['application/json'] = { };
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.queryMetadata = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * query (String)
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
