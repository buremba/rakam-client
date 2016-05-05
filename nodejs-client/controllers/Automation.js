'use strict';

var url = require('url');


var Automation = require('./AutomationService');


module.exports.automationActivateRule = function automationActivateRule (req, res, next) {
  Automation.automationActivateRule(req.swagger.params, res, next);
};

module.exports.automationAddRule = function automationAddRule (req, res, next) {
  Automation.automationAddRule(req.swagger.params, res, next);
};

module.exports.automationDeactivateRule = function automationDeactivateRule (req, res, next) {
  Automation.automationDeactivateRule(req.swagger.params, res, next);
};

module.exports.automationListRules = function automationListRules (req, res, next) {
  Automation.automationListRules(req.swagger.params, res, next);
};

module.exports.automationRemoveRule = function automationRemoveRule (req, res, next) {
  Automation.automationRemoveRule(req.swagger.params, res, next);
};
