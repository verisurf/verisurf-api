# Command

    <Object_List />

## Description

Returns list of all database objects in current file

***

## Parameters
- **None**

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - 'command_received' — echos command sent to API

- **data** — default wrapper for all secondary data API responses
    - 'object_info' — container for object information
	
***

## Errors
- **None**
 
***

## Sample Response
```xml
<response>
	<command_received>object_list</command_received>
</response>

<data>
	<object_info>
		<object id="0" type="Point">Point1</object>
		<object id="1" type="Line" group="Feature">Line1</object>
		<object id="2" type="Cloud">Cloud1</object>
	</object_info>
</data>
```
