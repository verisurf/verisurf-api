# Command

    <Version />

## Description

Returns API version

***

## Parameters
- **none**

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - 'version' — contains running API version

***

## Errors
- **none**
 
***

## Sample Response

```xml
<response>
	<success>
		<command_received>version</command_received>
		<data>1.0.3</data>
		<request_id>1</request_id>
	</success>
</response>
```
