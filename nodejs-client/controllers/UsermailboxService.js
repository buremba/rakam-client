'use strict';

exports.get = function(project, user, parent, limit, offset) {

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
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.getConnectedUsers = function(project) {

  var examples = {};
  
  examples['application/json'] = [ {
  "key" : "{}"
} ];
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.markAsRead = function(project, user, messageIds) {

  var examples = {};
  
  examples['application/json'] = {
  "success" : true,
  "message" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
exports.send = function(project, fromUser, toUser, parent, message, timestamp) {

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
