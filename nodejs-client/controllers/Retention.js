'use strict';

var url = require('url');


var Retention = require('./RetentionService');


module.exports.retentionAnalyzerExecute = function retentionAnalyzerExecute (req, res, next) {
  Retention.retentionAnalyzerExecute(req.swagger.params, res, next);
};
