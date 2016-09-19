# Command

    <Inspect_Plan_List />

## Description

Returns all currently supported commands accepted by the API

***

## Parameters
- **None**

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - 'command_received' — echos command sent to API
- **data** — default wrapper for all secondary data API responses
    - 'plans' — contains all plan information

***

## Errors
- **None**

***

## Sample Response

```xml
<response>
    <command_received>inspect_plan_list</command_received>
</response>

<data command="inspect_plan_list">
	<plans>
		<plan id="0">Bolt Hole Inspection</plan>
		<plan id="1">Fitting Test Inspection</plan>
	</plans>
</data>
```
