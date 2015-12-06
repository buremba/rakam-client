'use strict';

exports.export = function(project) {

  var examples = {};
  
  examples['application/json'] = {
  "reports" : [ {
    "query" : "aeiou",
    "name" : "aeiou",
    "options" : {
      "key" : "{}"
    },
    "slug" : "aeiou"
  } ],
  "materializedViews" : [ {
    "updateInterval" : "aeiou",
    "query" : "aeiou",
    "name" : "aeiou",
    "options" : {
      "key" : "{}"
    },
    "table_name" : "aeiou"
  } ],
  "materializedViewBuilders" : [ "" ],
  "collections" : {
    "key" : {
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
    }
  },
  "continuousQueryBuilders" : [ "" ],
  "project" : "aeiou",
  "strategy" : "aeiou",
  "continuousQueries" : [ {
    "collections" : [ "aeiou" ],
    "query" : "aeiou",
    "name" : "aeiou",
    "options" : {
      "key" : "{}"
    },
    "partitionKeys" : [ "aeiou" ],
    "tableName" : "aeiou"
  } ]
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.install = function() {

  var examples = {};
  
  examples['application/json'] = {
  "success" : true,
  "message" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
