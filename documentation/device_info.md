# Command

    <Device_Info id="" />

## Description

Returns measurement device information for specific device or global points

***

## Parameters
- **id** _(required)_ — device id to be retrieved. Recognized values:
    - '-1' — Returns global device information
    - '0' — Returns mouse device information
	- 'x' — Where X is any number > 0.  Returns device information for Xth device in VDI device list

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - 'command_received' — echos command sent to API
    - 'device_info' — contains attributes with measurement information

***

## Errors
- **406** — Missing parameter "id" in request
 
***

## Sample Response

```xml
<response>
	<command_received>device_info</command_received>
	<device_info 
	id="0" 
	X="-3.5044802425831776" 
	Y="1.7999521558749731" 
	Z="-0.024870884228536172" 
	DX="-2.8928114847412703" 
	DY="1.2165142637796156" 
	DZ="-0.024870884228536172" 
	D3="3.1382931349879608" 
	P0="6.2765862699759216" 
	I="0" 
	J="0" 
	K="1" 
	PX="-0.61166875784190711" 
	PY="0.58343789209535757" 
	PZ="0" 
	ProbeRadius="0.25">
	Mouse
	</device_info>
</response>
```
