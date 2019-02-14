# Command

    <Object_delete id="" />

## Description

Deletes Object from Verisurf Database with specified ID.

***

## Parameters
- **id** _(required)_ — ID to be used for deletion.

***

## Return format
A XML response with the following format:

- **response** - default wrapper for all API responses

***

## Errors
- **406** - Missing parameter ID in request
 
***

## Sample Response
```xml
<response>
	<success>
		<command_received>object_delete</command_received>
		<request_id>1</request_id>
	</success>
</response>
```
