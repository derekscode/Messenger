/*
This file in the main entry point for defining grunt tasks and using grunt plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkID=513275&clcid=0x409
*/
module.exports = function (grunt) {

    var babelConfig = {
        files: {
            src: ["scripts/es6/**/*js"],
            dest:"scripts/es5/scripts.js"
        }
    };

    var concatConfig = {
        files: {
            src: ["scripts/es5/*.js"],
            dest: "wwwroot/scripts/script.js"
        }
    }

    var uglifyConfig = {
        files: {
            src: "wwwroot/scripts/script.js",
            dest: "wwwroot/scripts/script.min.js"
        }
    }

    grunt.initConfig({
        babel: babelConfig,
        concat: concatConfig,
        uglify: uglifyConfig
    });

    grunt.registerTask("build", ["babel", "concat", "uglify"]);


    grunt.loadNpmTasks("grunt-babel");
    grunt.loadNpmTasks("grunt-contrib-concat");
    grunt.loadNpmTasks("grunt-contrib-uglify");
};