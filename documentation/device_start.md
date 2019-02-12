# Command

    <Device_Start id="" />

## Description

Starts the specified device.

***

## Parameters
- **id** _(required)_ — device id to be retrieved. Recognized values:
    - '-1' — Starts Device ID "1" Device.

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
		<command_received>device_start</command_received>
		<request_id>1</request_id>
	</success>
</response>
```
