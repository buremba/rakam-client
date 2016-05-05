'use strict';

var url = require('url');


var Materializedview = require('./MaterializedviewService');


module.exports.materializedViewCreate = function materializedViewCreate (req, res, next) {
  Materializedview.materializedViewCreate(req.swagger.params, res, next);
};

module.exports.materializedViewDelete = function materializedViewDelete (req, res, next) {
  Materializedview.materializedViewDelete(req.swagger.params, res, next);
};

module.exports.materializedViewGet = function materializedViewGet (req, res, next) {
  Materializedview.materializedViewGet(req.swagger.params, res, next);
};

module.exports.materializedViewListViews = function materializedViewListViews (req, res, next) {
  Materializedview.materializedViewListViews(req.swagger.params, res, next);
};

module.exports.materializedViewSchema = function materializedViewSchema (req, res, next) {
  Materializedview.materializedViewSchema(req.swagger.params, res, next);
};

module.exports.materializedViewUpdate = function materializedViewUpdate (req, res, next) {
  Materializedview.materializedViewUpdate(req.swagger.params, res, next);
};
