'use strict';

var url = require('url');


var Recipe = require('./RecipeService');


module.exports.recipeExport = function recipeExport (req, res, next) {
  Recipe.recipeExport(req.swagger.params, res, next);
};

module.exports.recipeInstall = function recipeInstall (req, res, next) {
  Recipe.recipeInstall(req.swagger.params, res, next);
};
