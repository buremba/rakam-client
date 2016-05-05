'use strict';

exports.retentionAnalyzerExecute = function(args, res, next) {
  /**
   * parameters expected in the args:
   * retentionQuery (RetentionQuery)
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
