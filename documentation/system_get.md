# Command

    <System_Get name="" />

## Description

Returns specific variables used in the operation of Verisurf

***

## Parameters
- **name** _(required)_ — name of variable to be retrieved. Recognized values:
    - 'user' — Returns Verisurf user directory
    - 'shared' — Returns Verisurf shared directory
    - 'install' — Returns Verisurf install directory

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - 'system' — contains variable value

***

## Errors
- **406** — Missing parameter "name" in request
 
***

## Sample Response

```xml
<response>
	<success>
		<command_received>system_get</command_received>
		<data>C:\Users\verisurf\Documents\my mcam2017\</data>
		<request_id>1</request_id>
	</success>
</response>
```
