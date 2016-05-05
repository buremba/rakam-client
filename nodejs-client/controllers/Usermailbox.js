'use strict';

var url = require('url');


var Usermailbox = require('./UsermailboxService');


module.exports.userMailboxGet = function userMailboxGet (req, res, next) {
  Usermailbox.userMailboxGet(req.swagger.params, res, next);
};

module.exports.userMailboxGetConnectedUsers = function userMailboxGetConnectedUsers (req, res, next) {
  Usermailbox.userMailboxGetConnectedUsers(req.swagger.params, res, next);
};

module.exports.userMailboxMarkAsRead = function userMailboxMarkAsRead (req, res, next) {
  Usermailbox.userMailboxMarkAsRead(req.swagger.params, res, next);
};
