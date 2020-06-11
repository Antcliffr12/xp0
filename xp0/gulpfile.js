// JavaScript source code
var concat = require('gulp-concat');
var cleanCss = require('gulp-clean-css');
var del = require('del');
var gulp = require('gulp');
var plugins = require('gulp-load-plugins')();
var less = require('gulp-less');

//var ProjectPath = 'src/Project/*/code/*/Assets/Styles/'

var dirs = {
    ProjectAssets: 'src/Project/*/code/*/Assets',
    FeatureAssets: 'src/Feature/*/code/*/',
    bundledAssets: 'src/Project/Website/code/xp0.Project.Website/Assets/bundles/'
};

function clean() {
    return del([dirs.bundledAssets]);
}

function FoundationCss() {
    return gulp
        .src([
            dirs.ProjectAssets + '/Styles/bootstrap.min.css',
            dirs.ProjectAssets + '/Styles/rivet.min.css',
        ])
        .pipe(plugins.concat('foundation.css'))
        .pipe(gulp.dest(dirs.bundledAssets));
}

function FoundationJS() {
    return gulp
        .src([
            dirs.ProjectAssets + '/Scripts/jQuery.min.js',
            dirs.ProjectAssets + '/Scripts/bootstrap.min.js',

        ])
        .pipe(plugins.concat('foundation.js'))
        .pipe(gulp.dest(dirs.bundledAssets));
}

/*
function js() {
    return gulp
        .src([
            dirs.FeatureAssets + '/Views/'
        ])
        .pipe(plugins.concat('scripts.js'))
        .pipe(gulp.dest(dirs.bundledAssets));
}
*/

function css() {
    return gulp
        .src([
            dirs.ProjectAssets + '/Styles/*.less',
            dirs.FeatureAssets + '/Views/*/*.less'
        ])
        .pipe(plugins.concat('styles.less'))
        .pipe(plugins.less())
        .pipe(gulp.dest(dirs.bundledAssets));
}

const build = gulp.series(clean, gulp.parallel(FoundationCss, FoundationJS, css));
exports.FoundationCss = FoundationCss;
exports.FoundationJS = FoundationJS;
//exports.js = js;
exports.css = css;

exports.clean = clean;

exports.build = build;
exports.default = build;