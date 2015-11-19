'use strict';

var url = require('url');


var Usermailbox = require('./UsermailboxService');


module.exports.get = function get (req, res, next) {
  var project = req.swagger.params['project'].value;
  var user = req.swagger.params['user'].value;
  var parent = req.swagger.params['parent'].value;
  var limit = req.swagger.params['limit'].value;
  var offset = req.swagger.params['offset'].value;
  

  var result = Usermailbox.get(project, user, parent, limit, offset);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.getConnectedUsers = function getConnectedUsers (req, res, next) {
  var project = req.swagger.params['project'].value;
  

  var result = Usermailbox.getConnectedUsers(project);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.markAsRead = function markAsRead (req, res, next) {
  var project = req.swagger.params['project'].value;
  var user = req.swagger.params['user'].value;
  var messageIds = req.swagger.params['message_ids'].value;
  

  var result = Usermailbox.markAsRead(project, user, messageIds);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.send = function send (req, res, next) {
  var project = req.swagger.params['project'].value;
  var fromUser = req.swagger.params['from_user'].value;
  var toUser = req.swagger.params['to_user'].value;
  var parent = req.swagger.params['parent'].value;
  var message = req.swagger.params['message'].value;
  var timestamp = req.swagger.params['timestamp'].value;
  

  var result = Usermailbox.send(project, fromUser, toUser, parent, message, timestamp);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};
