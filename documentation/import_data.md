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
- **data** - Send Base64 Encoded data. (A reference _filename_ still required as temporary placeholder for Verisurf. )

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


**Import Base64 encoded data**
The following snippet will import the above example XYZ data.
<!-- code -->
```xml
<Import_Data filename="testcloud" data="Ni4zOTMyNDYzCTEuMjQyOTYxODQJMS4yMzQKNi4wNDEyMDA4NwkwLjM5OTMwMzIyCTEuMjM0CjQuMjcxNzAzNDEJMC44OTIyOTMwNAkxLjIzNAozLjY3MDkzODEyCTIuNDY1OTU3OTIJMS4yMzQKNC4wNjg0Njg3MwkzLjUyNDU4NDQJMS4yMzQKNS4zMDQ0OTkxMQkzLjI4MzAyNjUyCTEuMjM0Ci0xLjExMjEyODE1CS0wLjIwODIzNzk5CTEuMjM0Ci0wLjk2MTA5ODQJMC42OTMzNjM4NAkxLjIzNAowLjg3NDE0MTg4CTAuNjE1NTYwNjQJMS4yMzQKMS42NzA0ODA1NQktMS45MDE2MDE4MwkxLjIzNAowLjQxMTg5OTMxCS0xLjk0NzM2ODQyCTEuMjM0" />"
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
