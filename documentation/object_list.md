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
    - **data** — default wrapper for all secondary data API responses
    - 'object_info' — container for object information
	
***

## Errors
- **None**
 
***

## Sample Response
```xml
<!-- RESPONSE 1 -->
<response>
    <success>
        <command_received>object_list</command_received>
        <acknowledgement />
        <request_id>1</request_id>
    </success>
</response>
<!-- RESPONSE 2 -->
<response>
	<success>
		<command_received>object_list</command_received>
		<data>
			<object_info>
				<object id="0" type="Point">Point1</object>
			</object_info>
		</data>
		<completed />
		<request_id>1</request_id>
	</success>
</response>
```
