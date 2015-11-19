'use strict';

var url = require('url');


var User = require('./UserService');


module.exports.batchCreate = function batchCreate (req, res, next) {
  var batchCreate = req.swagger.params['batchCreate'].value;
  

  var result = User.batchCreate(batchCreate);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.create = function create (req, res, next) {
  var user = req.swagger.params['User'].value;
  

  var result = User.create(user);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.getUser = function getUser (req, res, next) {
  var project = req.swagger.params['project'].value;
  var user = req.swagger.params['user'].value;
  

  var result = User.getUser(project, user);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.getEvents = function getEvents (req, res, next) {
  var project = req.swagger.params['project'].value;
  var user = req.swagger.params['user'].value;
  var limit = req.swagger.params['limit'].value;
  var offset = req.swagger.params['offset'].value;
  

  var result = User.getEvents(project, user, limit, offset);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.incrementUserProperty = function incrementUserProperty (req, res, next) {
  var project = req.swagger.params['project'].value;
  var user = req.swagger.params['user'].value;
  

  var result = User.incrementUserProperty(project, user);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.getMetadata = function getMetadata (req, res, next) {
  var project = req.swagger.params['project'].value;
  

  var result = User.getMetadata(project);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.searchUsers = function searchUsers (req, res, next) {
  var searchUsers = req.swagger.params['searchUsers'].value;
  

  var result = User.searchUsers(searchUsers);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.setUserPropertyOnce = function setUserPropertyOnce (req, res, next) {
  var setUserPropertyOnce = req.swagger.params['setUserPropertyOnce'].value;
  

  var result = User.setUserPropertyOnce(setUserPropertyOnce);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.setUserProperties = function setUserProperties (req, res, next) {
  var setUserProperties = req.swagger.params['setUserProperties'].value;
  

  var result = User.setUserProperties(setUserProperties);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};
