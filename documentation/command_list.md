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
	<command_received>command_list</command_received>
	<commands>
		<build />
		<cadview_back />
		<cadview_bottom />
		...
		<measure_sphere />
		<measure_spline />
	</commands>
</response>
```
