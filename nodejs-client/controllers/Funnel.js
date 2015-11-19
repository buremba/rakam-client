'use strict';

var url = require('url');


var Funnel = require('./FunnelService');


module.exports.analyze = function analyze (req, res, next) {
  var funnelQuery = req.swagger.params['FunnelQuery'].value;
  

  var result = Funnel.analyze(funnelQuery);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.analyze_1 = function analyze_1 (req, res, next) {
  var funnelQuery = req.swagger.params['FunnelQuery'].value;
  

  var result = Funnel.analyze_1(funnelQuery);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};
