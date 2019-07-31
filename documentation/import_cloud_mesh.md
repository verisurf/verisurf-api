# Command

    <Import_Cloud_Mesh filename="" />

## Description

Imports external Mesh or Cloud data into Verisurf.  Supports specific formats of the following filetypes: eASCII_CLOUD = 1, eSTL_CLOUD, eSTL_MESH, eASCII_POINTS, eASCII_XYZDATA, eASCII_XYZRGBDATA, eCollada_DAE, eWavefront_OBJ, eStanford_PLY, eRandomAssimpFile, Wavefront_OBJ

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

***

## Errors
- **406** - Missing parameter "filename" in request
 
***

## Sample Response
```xml
<response>
	<success>
		<command_received>import_cloud_mesh</command_received>
		<request_id>1</request_id>
	</success>
</response>
```
