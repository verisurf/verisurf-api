# Command

    <Inspect_Plan_Load id="" />

## Description

Returns all currently supported commands accepted by the API

***

## Parameters
- **id** _(required)_ — id of the plan to be loaded

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
		<command_received>inspect_plan_load</command_received>
		<request_id>1</request_id>
	</success>
</response>
```
