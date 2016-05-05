'use strict';

var url = require('url');


var Realtime = require('./RealtimeService');


module.exports.realtimeCreate = function realtimeCreate (req, res, next) {
  Realtime.realtimeCreate(req.swagger.params, res, next);
};

module.exports.realtimeDelete = function realtimeDelete (req, res, next) {
  Realtime.realtimeDelete(req.swagger.params, res, next);
};

module.exports.realtimeGet = function realtimeGet (req, res, next) {
  Realtime.realtimeGet(req.swagger.params, res, next);
};

module.exports.realtimeList = function realtimeList (req, res, next) {
  Realtime.realtimeList(req.swagger.params, res, next);
};
