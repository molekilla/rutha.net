# rutha.net - ASP.NET 5 with Angular#

Pure pragmatic ASP.NET 5 front end workflow stack

For updates, read [changelog](changelog.md)

### Last update: 0.3.1

## Features ##

* Uses Mono 3.12.0 and up with [ruthanet_deploy](https://github.com/molekilla/ruthanet_deploy) ansible / vagrant machine
* ASP.NET 5 / ASP.NET MVC 6
* `rutha-dotnet-grunt-tasks` frontend tasks

## Installing ##
1. Create folder e.g. my_disrupting_dotcom
2. Clone to `my_app_name` dir
3. Clone [ruthanet_deploy](https://github.com/molekilla/ruthanet_deploy) to `my_app_env` dir
4. Configure Vagrantfile in `my_app_env`
```ruby
  # Share an additional folder to the guest VM. The first argument is
  # the path on the host to the actual folder. The second argument is
  # the path on the guest to mount the folder. And the optional third
  # argument is a set of non-required options.
  config.vm.synced_folder "~/Code/rutha.net", "/home/vagrant/repos/rutha.net"
```

5. Configure Gruntfile in `my_app_name` dir

```javascript
        data: {
            deploySettings: {
              ruthaDeploy: '/home/rutha_user/rutha_deploy',
              playbook: '/home/rutha_user/provisioning/playbook.yml',
              hosts: {
                production: {
                  name: 'aws',
                  sshKey: '/home/rutha_user/site.pem',
                  remoteUser: 'app'
                },
                staging: {
                  name: 'azure',
                  sshKey: '/home/rutha_user/staging.pem',
                  remoteUser: 'app'
                },
                vagrant: {
                  name: 'all',
                  remoteUser: 'vagrant'
                }
              }
            },
        }
```

6. Run `vagrant up` in `my_app_env` dir or preferably `grunt stagelocal` in `my_app_name` dir
1. Run `vagrant ssh` into [ruthanet_deploy](https://github.com/molekilla/ruthanet_deploy)

## KVM
1. Either run `./setup_kvm.sh` or commands below
  * Run `curl -sSL https://raw.githubusercontent.com/aspnet/Home/dev/kvminstall.sh | sh && source ~/.kre/kvm/kvm.sh`
  * Install latest kpm with `kvm upgrade`
  * Why kvm dev edition ? Read http://www.robzhu.com/blog/2014/12/7/to-run-aspnet-vnext-on-docker

## Command Help ##

* `grunt serve`: serves k kestrel and watches for changes
* `npm start`: Runs k kestrel without watching CSS and JS changes
* `kpm restore`: Restore packages


## To start developing ASP.NET 5
1. Install dependencies with `npm install` (which runs `kpm restore` as a postinstall script)
2. Run apps with `grunt serve`
3. Go to http://192.168.88.88:3002/

## Issues with kvm ?

Try 
`export KRE_FEED="https://www.nuget.org/api/v2"`
`rm -rf ~/.k/runtimes/`
`kvm install 1.0.0-beta2`

### Maintainers, notes ###
Maintain by Rogelio Morrell C.

### Disclaimer ###
Feel free to fork.
