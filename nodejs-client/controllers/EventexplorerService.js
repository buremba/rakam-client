'use strict';

exports.eventExplorerAnalyze = function(args, res, next) {
  /**
   * parameters expected in the args:
   * analyzeRequest (AnalyzeRequest)
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
exports.eventExplorerGetExtraDimensions = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   **/

var examples = {};
  
  examples['application/json'] = {
  "key" : [ "aeiou" ]
};
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.eventExplorerCreatePreComputedTable = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * collections (List)
   * dimensions (List)
   * aggregations (List)
   * measures (List)
   * tableName (String)
   **/

var examples = {};
  
  examples['application/json'] = {
  "name" : "aeiou",
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
exports.eventExplorerGetEventStatistics = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * collections (List)
   * dimension (String)
   * startDate (date)
   * endDate (date)
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
