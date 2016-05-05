'use strict';

var url = require('url');


var User = require('./UserService');


module.exports.userBatchCreate = function userBatchCreate (req, res, next) {
  User.userBatchCreate(req.swagger.params, res, next);
};

module.exports.userCreate = function userCreate (req, res, next) {
  User.userCreate(req.swagger.params, res, next);
};

module.exports.userCreateSegment = function userCreateSegment (req, res, next) {
  User.userCreateSegment(req.swagger.params, res, next);
};

module.exports.userGetUser = function userGetUser (req, res, next) {
  User.userGetUser(req.swagger.params, res, next);
};

module.exports.userGetEvents = function userGetEvents (req, res, next) {
  User.userGetEvents(req.swagger.params, res, next);
};

module.exports.userIncrementProperty = function userIncrementProperty (req, res, next) {
  User.userIncrementProperty(req.swagger.params, res, next);
};

module.exports.userMergeUser = function userMergeUser (req, res, next) {
  User.userMergeUser(req.swagger.params, res, next);
};

module.exports.userGetMetadata = function userGetMetadata (req, res, next) {
  User.userGetMetadata(req.swagger.params, res, next);
};

module.exports.userSearchUsers = function userSearchUsers (req, res, next) {
  User.userSearchUsers(req.swagger.params, res, next);
};

module.exports.userSetProperties = function userSetProperties (req, res, next) {
  User.userSetProperties(req.swagger.params, res, next);
};

module.exports.userSetPropertiesOnce = function userSetPropertiesOnce (req, res, next) {
  User.userSetPropertiesOnce(req.swagger.params, res, next);
};

module.exports.userUnsetProperty = function userUnsetProperty (req, res, next) {
  User.userUnsetProperty(req.swagger.params, res, next);
};
