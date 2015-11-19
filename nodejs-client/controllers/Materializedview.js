'use strict';

var url = require('url');


var Materializedview = require('./MaterializedviewService');


module.exports.create = function create (req, res, next) {
  var materializedView = req.swagger.params['MaterializedView'].value;
  

  var result = Materializedview.create(materializedView);

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
  

  var result = Materializedview.delete(project, name);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.get = function get (req, res, next) {
  var project = req.swagger.params['project'].value;
  var name = req.swagger.params['name'].value;
  

  var result = Materializedview.get(project, name);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.listViews = function listViews (req, res, next) {
  var project = req.swagger.params['project'].value;
  

  var result = Materializedview.listViews(project);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.schema = function schema (req, res, next) {
  var project = req.swagger.params['project'].value;
  

  var result = Materializedview.schema(project);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.update = function update (req, res, next) {
  

  var result = Materializedview.update();

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};
