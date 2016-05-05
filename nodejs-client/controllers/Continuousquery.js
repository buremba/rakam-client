'use strict';

var url = require('url');


var Continuousquery = require('./ContinuousqueryService');


module.exports.continuousQueryCreate = function continuousQueryCreate (req, res, next) {
  Continuousquery.continuousQueryCreate(req.swagger.params, res, next);
};

module.exports.continuousQueryDelete = function continuousQueryDelete (req, res, next) {
  Continuousquery.continuousQueryDelete(req.swagger.params, res, next);
};

module.exports.continuousQueryGet = function continuousQueryGet (req, res, next) {
  Continuousquery.continuousQueryGet(req.swagger.params, res, next);
};

module.exports.continuousQueryListQueries = function continuousQueryListQueries (req, res, next) {
  Continuousquery.continuousQueryListQueries(req.swagger.params, res, next);
};

module.exports.continuousQuerySchema = function continuousQuerySchema (req, res, next) {
  Continuousquery.continuousQuerySchema(req.swagger.params, res, next);
};

module.exports.continuousQueryTest = function continuousQueryTest (req, res, next) {
  Continuousquery.continuousQueryTest(req.swagger.params, res, next);
};
