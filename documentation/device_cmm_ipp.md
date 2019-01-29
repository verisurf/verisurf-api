# Command

  <device_cmm_ipp id='1' cmd="ClearAllErrors()"/>
  
## Description

Sends I++ command to current I++ Device

***

## Parameters
 - **id** _(required)_ — device id to be used for I++ command

***

## Errors
- **406** — Missing parameter "id" in request
 
***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses

***

## Errors
- **None**
 
***

## Sample Response
```xml
<response>
	<success>
		<command_received>device_cmm_ipp</command_received
		<request_id>1</request_id>
	</success>
</response>
```
