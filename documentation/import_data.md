# Command

<!-- code -->
```xml
<Import_Data filename="" />
```
## Description

Imports external measurement data into Verisurf.  Supports specific formats of the following filetypes .csv, .txt, .xyz, .dat, .ref, .des, .raz

***

## Parameters
- **filename** _(required)_ - filename to be loaded, requires full path
- **group** - group name to use for imported objects
- **scale** - scale to use for imported measurements
- **poly** - if present import will be done as poly
- **type** - integer for import type, 1 (point(s)), 2 (Targets), 3 (Cloud (default)), 4 (CAD)
- **skip** - integer for number of rows to skip on import
- **useWCS** - use active WCS when importing data

***

## Working with Parameters
Source CSV:
| Point        | Xval        | Yval        | Zval  |
|--------------|-------------|-------------|-------|
| Point_ex-_1  | 6.3932463   | 1.24296184  | 1.234 |
| Point_ex-_2  | 6.04120087  | 0.39930322  | 1.234 |
| Point_ex-_3  | 4.27170341  | 0.89229304  | 1.234 |
| Point_ex-_4  | 3.67093812  | 2.46595792  | 1.234 |
| Point_ex-_5  | 4.06846873  | 3.5245844   | 1.234 |
| Point_ex-_6  | 5.30449911  | 3.28302652  | 1.234 |
| Point_ex-_7  | -1.11212815 | -0.20823799 | 1.234 |
| Point_ex-_8  | -0.9610984  | 0.69336384  | 1.234 |
| Point_ex-_9  | 0.87414188  | 0.61556064  | 1.234 |
| Point_ex-_10 | 1.81693364  | -0.78032037 | 1.234 |
| Point_ex-_11 | 1.67048055  | -1.90160183 | 1.234 |
| Point_ex-_12 | 0.41189931  | -1.94736842 | 1.234 |

**Import Data as Targets**

<!-- code -->
```xml
<Import_Data type="2" filename="E:\Verisurf\Dev\vs-data-file.csv" />
```

**Import Data as Targets with Group**

*If no group exists with specified name, one will be created*

<!-- code -->
```xml
<Import_Data type="2" group="init alignment" filename="E:\Verisurf\Dev\vs-data-file.csv" />
```


**Import Data as Pointcloud**

<!-- code -->
```xml
<Import_Data filename="E:\Verisurf\Dev\vs-data-file.csv" />
```


**Import Data as Pointcloud using Active WCS**

<!-- code -->
```xml
<Import_Data useWCS="true" filename="E:\Verisurf\Dev\vs-data-file.csv" />
```


**Import Data as CAD Skipping every 1th Row**

<!-- code -->
```xml
<Import_Data type="4" skip="1" filename="E:\Verisurf\Dev\vs-data-file.csv" />
```


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
		<command_received>import_data</command_received>
		<request_id>1</request_id>
	</success>
</response>
```
