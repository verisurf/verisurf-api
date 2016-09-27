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
    - 'device_info' — contains attributes with measurement information

***

## Errors
- **406** — Missing parameter "id" in request
 
***

## Sample Response

```xml
<response>
	<success>
		<command_received>device_info</command_received>
		<data>
			<device_info 
			id="0" 
			X="11.502328647260969" 
			Y="0.00093040743343797395" 
			Z="2.2474214800824512" 
			I="0" 
			J="0" 
			K="1" 
			ProbeRadius="0.25">
			Mouse
			</device_info>
		</data>
		<request_id>1</request_id>
	</success>
</response>
```
