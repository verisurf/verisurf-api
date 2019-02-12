# Command

    <Device_Home id="" />

## Description

Homes the specified Device. 

***

## Parameters
- **id** _(required)_ — device id to be retrieved. Recognized values:
    - '-1' — Homes Device ID "1" Device.

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses

***

## Errors
- **406** — Missing parameter "id" in request
 
***

## Sample Response
```xml
<response>
	<success>
		<command_received>device_home</command_received>
		<request_id>1</request_id>
	</success>
</response>
```
