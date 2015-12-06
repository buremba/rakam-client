'use strict';

var url = require('url');


var Recipe = require('./RecipeService');


module.exports.export = function export (req, res, next) {
  var project = req.swagger.params['project'].value;
  

  var result = Recipe.export(project);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.install = function install (req, res, next) {
  

  var result = Recipe.install();

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};
