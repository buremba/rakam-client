'use strict';

var url = require('url');


var Realtime = require('./RealtimeService');


module.exports.create = function create (req, res, next) {
  var project = req.swagger.params['project'].value;
  var name = req.swagger.params['name'].value;
  var aggregation = req.swagger.params['aggregation'].value;
  var tableName = req.swagger.params['table_name'].value;
  var collections = req.swagger.params['collections'].value;
  var filter = req.swagger.params['filter'].value;
  var measure = req.swagger.params['measure'].value;
  var dimensions = req.swagger.params['dimensions'].value;
  

  var result = Realtime.create(project, name, aggregation, tableName, collections, filter, measure, dimensions);

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
  

  var result = Realtime.delete(project, name);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.get = function get (req, res, next) {
  var project = req.swagger.params['project'].value;
  var tableName = req.swagger.params['table_name'].value;
  var filter = req.swagger.params['filter'].value;
  var aggregation = req.swagger.params['aggregation'].value;
  var measure = req.swagger.params['measure'].value;
  var dimensions = req.swagger.params['dimensions'].value;
  var aggregate = req.swagger.params['aggregate'].value;
  var dateStart = req.swagger.params['date_start'].value;
  var dateEnd = req.swagger.params['date_end'].value;
  

  var result = Realtime.get(project, tableName, filter, aggregation, measure, dimensions, aggregate, dateStart, dateEnd);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.listReports = function listReports (req, res, next) {
  var project = req.swagger.params['project'].value;
  

  var result = Realtime.listReports(project);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};
