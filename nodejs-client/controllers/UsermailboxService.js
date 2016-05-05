'use strict';

exports.userMailboxGet = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * user (String)
   * parent (Integer)
   * limit (Integer)
   * offset (Long)
   **/

var examples = {};
  
  examples['application/json'] = [ [ {
  "to_user" : "{}",
  "project" : "aeiou",
  "id" : 123,
  "time" : 123456789,
  "content" : "aeiou",
  "parentId" : 123,
  "seen" : true,
  "from_user" : "{}"
} ] ];
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.userMailboxGetConnectedUsers = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   **/

var examples = {};
  
  examples['application/json'] = [ {
  "key" : "{}"
} ];
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.userMailboxMarkAsRead = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * user (String)
   * messageIds (List)
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
