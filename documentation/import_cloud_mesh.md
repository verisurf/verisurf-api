# Command

    <Import_Cloud_Mesh filename="" filetype="" />

## Description

Imports external Mesh or Cloud data into Verisurf.  Supports specific formats of the following filetypes: 

- **ASCII_CLOUD** = 1
- **STL_CLOUD** = 2
- **STL_MESH** = 3
- **ASCII_POINTS** = 4
- **ASCII_XYZDATA** = 5
- **ASCII_XYZRGBDAT** = 6
- **Collada_DAE** = 7
- **Wavefront_OBJ** = 8
- **Stanford_PLY** = 9
- **RandomAssimpFile** = 11

***

## Parameters
- **filename** _(required)_ - filename to be loaded, requires full path
- **filetype** _(required)_ - filetype of file to be loaded, int
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
		<command_received>import_cloud_mesh filetype= "8" filename= "C:\users\github\meshes\mesh.obj"</command_received>
		<request_id>1</request_id>
	</success>
</response>
```
