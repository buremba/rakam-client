'use strict';

exports.userEmailActionBatch = function(args, res, next) {
  /**
   * parameters expected in the args:
   * userEmailActionBatch (UserEmailAction_Batch)
   **/

var examples = {};
  
  examples['application/json'] = 123456789;
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.userEmailActionSend = function(args, res, next) {
  /**
   * parameters expected in the args:
   * userEmailActionSend (UserEmailAction_Send)
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
exports.userMailboxActionSend = function(args, res, next) {
  /**
   * parameters expected in the args:
   * project (String)
   * fromUser (String)
   * toUser (String)
   * parent (Integer)
   * message (String)
   * timestamp (Long)
   **/

var examples = {};
  
  examples['application/json'] = {
  "to_user" : "{}",
  "project" : "aeiou",
  "id" : 123,
  "time" : 123456789,
  "content" : "aeiou",
  "parentId" : 123,
  "seen" : true,
  "from_user" : "{}"
};
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
exports.userMailboxActionBatchSendMessages = function(args, res, next) {
  /**
   * parameters expected in the args:
   * userMailboxActionBatchSendMessages (UserMailboxAction_BatchSendMessages)
   **/

var examples = {};
  
  examples['application/json'] = 123456789;
  

  
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
  
}
