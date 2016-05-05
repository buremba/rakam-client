'use strict';

var url = require('url');


var Admin = require('./AdminService');


module.exports.adminGetConfigurations = function adminGetConfigurations (req, res, next) {
  Admin.adminGetConfigurations(req.swagger.params, res, next);
};

module.exports.adminModules = function adminModules (req, res, next) {
  Admin.adminModules(req.swagger.params, res, next);
};

module.exports.adminGetTypes = function adminGetTypes (req, res, next) {
  Admin.adminGetTypes(req.swagger.params, res, next);
};

module.exports.projectCollections = function projectCollections (req, res, next) {
  Admin.projectCollections(req.swagger.params, res, next);
};

module.exports.projectCreateProject = function projectCreateProject (req, res, next) {
  Admin.projectCreateProject(req.swagger.params, res, next);
};

module.exports.projectDeleteProject = function projectDeleteProject (req, res, next) {
  Admin.projectDeleteProject(req.swagger.params, res, next);
};

module.exports.projectGetProjects = function projectGetProjects (req, res, next) {
  Admin.projectGetProjects(req.swagger.params, res, next);
};

module.exports.projectSchema = function projectSchema (req, res, next) {
  Admin.projectSchema(req.swagger.params, res, next);
};

module.exports.projectAddFieldsToSchema = function projectAddFieldsToSchema (req, res, next) {
  Admin.projectAddFieldsToSchema(req.swagger.params, res, next);
};

module.exports.projectAddCustomFieldsToSchema = function projectAddCustomFieldsToSchema (req, res, next) {
  Admin.projectAddCustomFieldsToSchema(req.swagger.params, res, next);
};
