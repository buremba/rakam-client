'use strict';

var url = require('url');


var Funnel = require('./FunnelService');


module.exports.funnelAnalyzerAnalyze = function funnelAnalyzerAnalyze (req, res, next) {
  Funnel.funnelAnalyzerAnalyze(req.swagger.params, res, next);
};
