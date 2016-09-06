# Command

    <Import_Data filename="" />

## Description

Imports external measurement data into Verisurf.  Supports specific formats of the following filetypes .csv, .txt, .xyz, .dat, .ref, .des, .raz

***

## Parameters
- **filename** _(required)_ - filename to be loaded, requires full path
- **group** - group name to use for imported objects
- **scale** - scale to use for imported measurements
- **poly** - if present import will be done as poly
- **type** - integer for import type, 1 (point), 2 (cad), 3 (cloud, default), 4 (target)
- **skip** - integer for number of rows to skip on import
- **useWCS** - use active WCS when importing data

***

## Return format
A XML response with the following format:

- **response** - default wrapper for all API responses
    - 'command_received' - echos command sent to API

***

## Errors
- **406** - Missing parameter "filename" in request
