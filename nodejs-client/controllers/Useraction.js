'use strict';

var url = require('url');


var Useraction = require('./UseractionService');


module.exports.batchSendEmails = function batchSendEmails (req, res, next) {
  var batchSendEmails = req.swagger.params['BatchSendEmails'].value;
  

  var result = Useraction.batchSendEmails(batchSendEmails);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.send = function send (req, res, next) {
  var send = req.swagger.params['Send'].value;
  

  var result = Useraction.send(send);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.send_1 = function send_1 (req, res, next) {
  var project = req.swagger.params['project'].value;
  var fromUser = req.swagger.params['from_user'].value;
  var toUser = req.swagger.params['to_user'].value;
  var parent = req.swagger.params['parent'].value;
  var message = req.swagger.params['message'].value;
  var timestamp = req.swagger.params['timestamp'].value;
  

  var result = Useraction.send_1(project, fromUser, toUser, parent, message, timestamp);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.batchSendMessages = function batchSendMessages (req, res, next) {
  var batchSendMessages = req.swagger.params['BatchSendMessages'].value;
  

  var result = Useraction.batchSendMessages(batchSendMessages);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};
