module.exports = function (grunt) {

    // Project configuration.
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),
        cssmin: {
            target: {
                files: [{
                    expand: true,
                    cwd: 'content/_src/css',
                    src: ['*.css', '**/*.css', '!*.min.css'],
                    dest: 'content/dist/css',
                    ext: '.css'
                }]
            }
        },
        uglify: {
            options: {
                banner: '/*! <%= pkg.name %> <%= grunt.template.today("yyyy-mm-dd") %> */\n',
                mangle: {
                    except: ['jQuery', 'Backbone']
                }
            },
            my_target: {
                files: [{
                    expand: true,
                    cwd: 'content/_src/js',
                    src: ['*.js','**/*.js', '!*.min.js'],
                    dest: 'content/dist/js',
                    ext: '.js'
                }]
            }
        },
        useminPrepare: {
            html: 'manager/index.aspx',
            options: {
                dest: '.'
            }
        },
        usemin: {
            html: ['manager/index.aspx']
        },
        copy: {
            html: {
                src: 'my/index.aspx', dest: 'manager/index.aspx'
            }
        },
        processhtml: {
            options: {
                data: {
                    message: 'Hello world!'
                }
            },
            dist: {
                files: [{
                    expand: true,
                    cwd: 'content/_src/demo',
                    src: ['*.html', '**/*.html'],
                    dest: 'content/dist/demo',
                    ext: '.html'
                }]
            }
        },
        imagemin: {                  
            dynamic: {                      
                files: [{
                    expand: true,             
                    cwd: 'content/_src/img',         
                    src: ['*.{png,jpg,gif}', '**/*.{png,jpg,gif}'],
                    dest: 'content/dist/img'             
                }]
            } 
        },
        watch: {
            css: {
                files: ['content/_src/css/*.css', 'content/_src/css/**/*.css'],
                tasks: ['newer:cssmin'],
            },
            js: {
                files: ['content/_src/js/*.js', 'content/_src/js/**/*.js'],
                tasks: ['newer:uglify'],
            },
            img: {
                files: ['content/_src/img/*.{png,jpg,gif}', 'content/_src/img/**/*.{png,jpg,gif}'],
                tasks: ['newer:imagemin'],
            },
            html: {
                files: ['content/_src/demo/*.html', 'content/_src/demo/**/*.html'],
                tasks: ['newer:processhtml'],
            },
        }
    });

    // Load the plugin that provides the "uglify" task.
    grunt.loadNpmTasks('grunt-usemin');
    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-cssmin');
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-imagemin');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-newer');
    grunt.loadNpmTasks('grunt-processhtml');
    grunt.loadNpmTasks('grunt-filerev');

    grunt.registerTask('build', ['copy:html', 'useminPrepare', 'concat:generated', 'cssmin:generated', 'uglify:generated', 'usemin']);

    // Default task(s).
    //grunt.registerTask('ok', ['processhtml']);
    grunt.registerTask('ok', ['newer:cssmin', 'newer:uglify', 'newer:imagemin', 'processhtml', 'build']);
    //grunt.registerTask('ok', ['cssmin', 'uglify', 'imagemin']);

   

};
 