'use strict';

var url = require('url');


var Abtesting = require('./AbtestingService');


module.exports.abTestingCreate = function abTestingCreate (req, res, next) {
  Abtesting.abTestingCreate(req.swagger.params, res, next);
};

module.exports.abTestingDelete = function abTestingDelete (req, res, next) {
  Abtesting.abTestingDelete(req.swagger.params, res, next);
};

module.exports.abTestingGet = function abTestingGet (req, res, next) {
  Abtesting.abTestingGet(req.swagger.params, res, next);
};

module.exports.abTestingList = function abTestingList (req, res, next) {
  Abtesting.abTestingList(req.swagger.params, res, next);
};

module.exports.abTestingUpdate = function abTestingUpdate (req, res, next) {
  Abtesting.abTestingUpdate(req.swagger.params, res, next);
};
