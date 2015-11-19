'use strict';

var url = require('url');


var Event = require('./EventService');


module.exports.batchEvents = function batchEvents (req, res, next) {
  var eventList = req.swagger.params['EventList'].value;
  

  var result = Event.batchEvents(eventList);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.collectEvent = function collectEvent (req, res, next) {
  var event = req.swagger.params['Event'].value;
  

  var result = Event.collectEvent(event);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.execute = function execute (req, res, next) {
  var project = req.swagger.params['project'].value;
  var query = req.swagger.params['query'].value;
  var limit = req.swagger.params['limit'].value;
  

  var result = Event.execute(project, query, limit);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};
