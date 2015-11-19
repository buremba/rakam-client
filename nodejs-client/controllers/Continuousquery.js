'use strict';

var url = require('url');


var Continuousquery = require('./ContinuousqueryService');


module.exports.create = function create (req, res, next) {
  var continuousQuery = req.swagger.params['ContinuousQuery'].value;
  

  var result = Continuousquery.create(continuousQuery);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.delete = function delete (req, res, next) {
  var project = req.swagger.params['project'].value;
  var name = req.swagger.params['name'].value;
  

  var result = Continuousquery.delete(project, name);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.listQueries = function listQueries (req, res, next) {
  var project = req.swagger.params['project'].value;
  

  var result = Continuousquery.listQueries(project);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.schema = function schema (req, res, next) {
  var project = req.swagger.params['project'].value;
  

  var result = Continuousquery.schema(project);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.test = function test (req, res, next) {
  var project = req.swagger.params['project'].value;
  var query = req.swagger.params['query'].value;
  

  var result = Continuousquery.test(project, query);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};
