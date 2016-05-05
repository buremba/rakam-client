'use strict';

exports.userBatchCreate = function(args, res, next) {
  /**
   * parameters expected in the args:
   * userBatchCreate (User_BatchCreate)
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
exports.userCreate = function(args, res, next) {
  /**
   * parameters expected in the args:
   * user (User)
   **/

var examples = {};
  
  examples['application/json'] = "aeiou";
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.userCreateSegment = function(args, res, next) {
  /**
   * parameters expected in the args:
   * userCreateSegment (User_CreateSegment)
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
exports.userGetUser = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * user (String)
   **/

var examples = {};
  
  examples['application/json'] = {
  "project" : "aeiou",
  "id" : "aeiou",
  "api" : {
    "writeKey" : "aeiou",
    "apiVersion" : "aeiou"
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
exports.userGetEvents = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * user (String)
   * limit (Integer)
   * offset (Date)
   **/

var examples = {};
  
  examples['application/json'] = [ {
  "collection" : "aeiou",
  "properties" : {
    "key" : { }
  }
} ];
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.userIncrementProperty = function(args, res, next) {
  /**
   * parameters expected in the args:
   * userIncrementProperty (User_IncrementProperty)
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
exports.userMergeUser = function(args, res, next) {
  /**
   * parameters expected in the args:
   * userMergeUser (User_MergeUser)
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
exports.userGetMetadata = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   **/

var examples = {};
  
  examples['application/json'] = {
  "columns" : [ {
    "descriptiveName" : "aeiou",
    "unique" : true,
    "name" : "aeiou",
    "description" : "aeiou",
    "type" : "aeiou",
    "category" : "aeiou"
  } ],
  "identifierColumn" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.userSearchUsers = function(args, res, next) {
  /**
   * parameters expected in the args:
   * userSearchUsers (User_SearchUsers)
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
exports.userSetProperties = function(args, res, next) {
  /**
   * parameters expected in the args:
   * setUserProperties (SetUserProperties)
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
exports.userSetPropertiesOnce = function(args, res, next) {
  /**
   * parameters expected in the args:
   * setUserProperties (SetUserProperties)
   **/

var examples = {};
  

  
  res.end();
}
exports.userUnsetProperty = function(args, res, next) {
  /**
   * parameters expected in the args:
   * userUnsetProperty (User_UnsetProperty)
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
