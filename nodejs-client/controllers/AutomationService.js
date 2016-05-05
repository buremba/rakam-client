'use strict';

exports.automationActivateRule = function(args, res, next) {
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
exports.automationAddRule = function(args, res, next) {
  /**
   * parameters expected in the args:
   * automationRule (AutomationRule)
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
exports.automationDeactivateRule = function(args, res, next) {
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
exports.automationListRules = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   **/

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
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.automationRemoveRule = function(args, res, next) {
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
