# rutha.net - ASP.NET 5 with Angular#

Pure pragmatic ASP.NET 5 front end workflow stack

For updates, read [changelog](changelog.md)

### Last update: 0.2.1

## Features ##

* Uses Mono 3.12.0 and up with [ruthanet_deploy](https://github.com/molekilla/ruthanet_deploy) ansible / vagrant machine
* ASP.NET 5 / ASP.NET MVC 6

## Installing ##
1. Clone repo
2. Rename text containing `rutha.net` to `your_app_name`
3. Be sure to have node 0.10.32 or greater (e.g. nvm use 0.10.32)


## Grunt Help (Service) ##

* `grunt migrate:create [--name]`: Creates a migration task. Args: --name: migration name (optional)
* `grunt migrate:up [--revision]`: Migrates up. Args: --revision: revision name (optional)
* `grunt migrate:down [--revision]`: Migrates down. Args: --revision: revision name (optional)

## To start developing ASP.NET 5
1. Run `vagrant ssh` into [ruthanet_deploy](https://github.com/molekilla/ruthanet_deploy)
2. Run `curl -sSL https://raw.githubusercontent.com/aspnet/Home/master/kvminstall.sh | sh && source ~/.kre/kvm/kvm.sh`
3. Install latest kpm with `kvm upgrade`
4. Install dependencies with `npm install` (which runs `kpm restore` as a postinstall script)
5. Run apps with `npm start`

### Maintainers, notes ###
Maintain by Rogelio Morrell C.

### Disclaimer ###
Feel free to fork.
