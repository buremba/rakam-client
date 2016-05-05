'use strict';

var url = require('url');


var Eventexplorer = require('./EventexplorerService');


module.exports.eventExplorerAnalyze = function eventExplorerAnalyze (req, res, next) {
  Eventexplorer.eventExplorerAnalyze(req.swagger.params, res, next);
};

module.exports.eventExplorerGetExtraDimensions = function eventExplorerGetExtraDimensions (req, res, next) {
  Eventexplorer.eventExplorerGetExtraDimensions(req.swagger.params, res, next);
};

module.exports.eventExplorerCreatePreComputedTable = function eventExplorerCreatePreComputedTable (req, res, next) {
  Eventexplorer.eventExplorerCreatePreComputedTable(req.swagger.params, res, next);
};

module.exports.eventExplorerGetEventStatistics = function eventExplorerGetEventStatistics (req, res, next) {
  Eventexplorer.eventExplorerGetEventStatistics(req.swagger.params, res, next);
};
