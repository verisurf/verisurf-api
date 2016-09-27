# Command

    <Inspect_Object_Measure id="" />

## Description

Specifies which plan object should be measured and initiates measure mode

***

## Parameters
- **id** _(required)_ — object id to be retrieved

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
		<command_received>inspect_object_measure</command_received>
		<request_id>1</request_id>
	</success>
</response>
```
