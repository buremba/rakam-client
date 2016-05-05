'use strict';

var url = require('url');


var Event = require('./EventService');


module.exports.collectEventBatchEvents = function collectEventBatchEvents (req, res, next) {
  Event.collectEventBatchEvents(req.swagger.params, res, next);
};

module.exports.collectEventBulkEvents = function collectEventBulkEvents (req, res, next) {
  Event.collectEventBulkEvents(req.swagger.params, res, next);
};

module.exports.collectEventCommitBulkEvents = function collectEventCommitBulkEvents (req, res, next) {
  Event.collectEventCommitBulkEvents(req.swagger.params, res, next);
};

module.exports.collectEventBulkEventsRemote = function collectEventBulkEventsRemote (req, res, next) {
  Event.collectEventBulkEventsRemote(req.swagger.params, res, next);
};

module.exports.collectEventCollectEvent = function collectEventCollectEvent (req, res, next) {
  Event.collectEventCollectEvent(req.swagger.params, res, next);
};

module.exports.queryExecute = function queryExecute (req, res, next) {
  Event.queryExecute(req.swagger.params, res, next);
};

module.exports.queryExplain = function queryExplain (req, res, next) {
  Event.queryExplain(req.swagger.params, res, next);
};

module.exports.queryMetadata = function queryMetadata (req, res, next) {
  Event.queryMetadata(req.swagger.params, res, next);
};
