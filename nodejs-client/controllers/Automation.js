'use strict';

var url = require('url');


var Automation = require('./AutomationService');


module.exports.activateRule = function activateRule (req, res, next) {
  var project = req.swagger.params['project'].value;
  var id = req.swagger.params['id'].value;
  

  var result = Automation.activateRule(project, id);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.addRule = function addRule (req, res, next) {
  

  var result = Automation.addRule();

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.deactivateRule = function deactivateRule (req, res, next) {
  var project = req.swagger.params['project'].value;
  var id = req.swagger.params['id'].value;
  

  var result = Automation.deactivateRule(project, id);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.listRules = function listRules (req, res, next) {
  var project = req.swagger.params['project'].value;
  

  var result = Automation.listRules(project);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.removeRule = function removeRule (req, res, next) {
  var project = req.swagger.params['project'].value;
  var id = req.swagger.params['id'].value;
  

  var result = Automation.removeRule(project, id);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};
