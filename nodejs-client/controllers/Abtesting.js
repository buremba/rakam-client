'use strict';

var url = require('url');


var Abtesting = require('./AbtestingService');


module.exports.create = function create (req, res, next) {
  

  var result = Abtesting.create();

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.delete = function delete (req, res, next) {
  var project = req.swagger.params['project'].value;
  var id = req.swagger.params['id'].value;
  

  var result = Abtesting.delete(project, id);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.get = function get (req, res, next) {
  var project = req.swagger.params['project'].value;
  var id = req.swagger.params['id'].value;
  

  var result = Abtesting.get(project, id);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.list = function list (req, res, next) {
  var project = req.swagger.params['project'].value;
  

  var result = Abtesting.list(project);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.update = function update (req, res, next) {
  

  var result = Abtesting.update();

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};
