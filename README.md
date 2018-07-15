# Windows Service template project #

## Features ##

1. Easy installation and deinstallation
2. Easy service name change without rebuild (through app.config)
3. Built-in debug mode. You no longer need a separate console application to debug your service


## Install ##

1. Clone or download project to you project folder.
2. Rename WinSvc.csproj
3. Connect the project to your solution
4. Change the project assembly name and namespace
5. If you using VisualStudio or Rider with installed VisualStudio 2017 - `install.bat` and `delete.bat` will be regenerated on build. 
	Otherwise you need to update their with new assembly name yourself.
6. Configure `ServiceName` in app.config
7. Implement `OnStart` and `OnStop` behavior in MyService.cs

## Using ##

### Installation ###

To install your service as Windows Service 

1. Build project
2. Start install.bat from output dir (with admin)
3. You can see your service in Windows Services list

### Uninstallation ###

To uninstall your Windows Service run delete.bat with admin. That's stop your service and removes it from the Windows Services list.

### Debug ###

To debug your service configure your IDE to start service project with `/d` key. Now just hit 'F5' without any service installation.

## Roadmap ##

* ~~Autogenerate install.bat and delete.bat on build~~
* Autogeneration without VisualStudio installed
* Create Rider project template
