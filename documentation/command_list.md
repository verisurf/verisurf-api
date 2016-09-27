# Command

    <Command_List />

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
    - 'commands' — contains elements describing all possible API commands

***

## Errors
- **None**
 
***

## Sample Response
```xml
<response>
	<success>
		<command_received>command_list</command_received>
		<data>
			<analyze />
			<build />
			...
			<version />
		</data>
		<request_id>1</request_id>
	</success>
</response>
```
