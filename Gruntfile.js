module.exports = function(grunt) {
    var path = require('path');
    var RuthaGruntUI = require('rutha-dotnet-grunt-tasks')(grunt);

    require('time-grunt')(grunt);
    require('load-grunt-config')(grunt, {
        configPath: path.join(process.cwd(), 'node_modules/rutha-dotnet-grunt-tasks/grunt'), //path to task.js files, defaults to grunt dir
        init: true, //auto grunt.initConfig
        data: {
            deploySettings: {
              ruthaDeploy: '/home/rogelio/Code/provisioning/ruthanet_deploy',
              playbook: '~/Code/provisioning/ruthanet_deploy/provisioning/playbook.yml',
              hosts: {
                production: {
                  name: 'aws',
                  sshKey: 'fill_here',
                  remoteUser: 'ubuntu'
                },
                staging: {
                  name: 'staging',
                  sshKey: 'fill_here',
                  remoteUser: 'ubuntu'
                },
                vagrant: {
                  name: 'all',
                  remoteUser: 'vagrant'
                }
              }
            },
            bowerConcat: {
              exclude: ['angular', 'jquery', 'kendo-ui-core'],
              dependencies: null
            },
            nodemon: {
                environment: 'development',
                exec: ['k kestrel']
            },
            ngTemplates: {
                moduleNamespace: 'rutha.templates'
            },
            wiredepConfig: {
                src: ['Views/**/*.cshtml'],
                options: {
                    cwd: process.cwd()
                }
            },
            cwd: process.cwd(),
            pkg: grunt.file.readJSON('package.json')
        },
        jitGrunt: { 
          staticMappings: {
            protractor: 'grunt-protractor-runner',
            ngAnnotate: 'grunt-ng-annotate',
            ngtemplates: 'grunt-angular-templates',
            'validate-package': 'grunt-nsp-package'
          }
        }
    });

    //
    // Default tasks
    //
    RuthaGruntUI.registerTasks();
 
};