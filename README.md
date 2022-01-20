# RoverCore BreadCrumbs

This small library provides a service that makes it easy to add and customize breadcrumbs.

## Usage

### Install

Install the package using NuGet  
`Install-Package RoverCore.BreadCrumbs`

### Initialize

After you have setup your breadcrumbs you must add the breadcrumbs service:  
```cs
services.AddScoped<IBreadCrumbService, BreadCrumbService>();
```


