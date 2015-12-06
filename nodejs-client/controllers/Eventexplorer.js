'use strict';

var url = require('url');


var Eventexplorer = require('./EventexplorerService');


module.exports.execute = function execute (req, res, next) {
  var execute = req.swagger.params['Execute'].value;
  

  var result = Eventexplorer.execute(execute);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.getEventDimensions = function getEventDimensions (req, res, next) {
  var project = req.swagger.params['project'].value;
  

  var result = Eventexplorer.getEventDimensions(project);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.getExtraDimensions = function getExtraDimensions (req, res, next) {
  var project = req.swagger.params['project'].value;
  

  var result = Eventexplorer.getExtraDimensions(project);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.getEventStatistics = function getEventStatistics (req, res, next) {
  var project = req.swagger.params['project'].value;
  var collections = req.swagger.params['collections'].value;
  var dimension = req.swagger.params['dimension'].value;
  var startDate = req.swagger.params['startDate'].value;
  var endDate = req.swagger.params['endDate'].value;
  

  var result = Eventexplorer.getEventStatistics(project, collections, dimension, startDate, endDate);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};
