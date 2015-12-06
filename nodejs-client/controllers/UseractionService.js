'use strict';

exports.batchSendEmails = function(batchSendEmails) {

  var examples = {};
  
  examples['application/json'] = 123456789;
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.send = function(send) {

  var examples = {};
  
  examples['application/json'] = true;
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.send_1 = function(project, fromUser, toUser, parent, message, timestamp) {

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
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.batchSendMessages = function(batchSendMessages) {

  var examples = {};
  
  examples['application/json'] = 123456789;
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
