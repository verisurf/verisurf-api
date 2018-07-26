# Command

    <Object_Selection_Set ids="" />

## Description

Chooses selected items to be modified by other Verisurf API calls.

***

## Parameters
- **ids** _(required)_ — comma separated list of object ids (ex. 1,2,5)

***

## Return format
A XML response with the following format:

- **response** - default wrapper for all API responses

***

## Errors
- **None**
 
***

## Sample Response
```xml
<response>
	<success>
		<command_received>object_selection_set</command_received>
		<request_id>1</request_id>
	</success>
</response>
```
