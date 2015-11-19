'use strict';

var url = require('url');


var Retention = require('./RetentionService');


module.exports.execute = function execute (req, res, next) {
  var retentionQuery = req.swagger.params['RetentionQuery'].value;
  

  var result = Retention.execute(retentionQuery);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};
