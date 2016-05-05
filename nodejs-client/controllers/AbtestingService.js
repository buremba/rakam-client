'use strict';

exports.abTestingCreate = function(args, res, next) {
  /**
   * parameters expected in the args:
   * aBTestingReport (ABTestingReport)
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
exports.abTestingDelete = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * id (Integer)
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
exports.abTestingGet = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * id (Integer)
   **/

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
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.abTestingList = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   **/

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
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.abTestingUpdate = function(args, res, next) {
  /**
   * parameters expected in the args:
   * aBTestingReport (ABTestingReport)
   **/

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
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
