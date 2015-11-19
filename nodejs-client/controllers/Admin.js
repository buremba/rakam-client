'use strict';

var url = require('url');


var Admin = require('./AdminService');


module.exports.getModules = function getModules (req, res, next) {
  

  var result = Admin.getModules();

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.createProject = function createProject (req, res, next) {
  var name = req.swagger.params['name'].value;
  

  var result = Admin.createProject(name);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.getProjects = function getProjects (req, res, next) {
  

  var result = Admin.getProjects();

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};

module.exports.schema = function schema (req, res, next) {
  var project = req.swagger.params['project'].value;
  

  var result = Admin.schema(project);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};
