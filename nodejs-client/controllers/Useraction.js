'use strict';

var url = require('url');


var Useraction = require('./UseractionService');


module.exports.userEmailActionBatch = function userEmailActionBatch (req, res, next) {
  Useraction.userEmailActionBatch(req.swagger.params, res, next);
};

module.exports.userEmailActionSend = function userEmailActionSend (req, res, next) {
  Useraction.userEmailActionSend(req.swagger.params, res, next);
};

module.exports.userMailboxActionSend = function userMailboxActionSend (req, res, next) {
  Useraction.userMailboxActionSend(req.swagger.params, res, next);
};

module.exports.userMailboxActionBatchSendMessages = function userMailboxActionBatchSendMessages (req, res, next) {
  Useraction.userMailboxActionBatchSendMessages(req.swagger.params, res, next);
};
