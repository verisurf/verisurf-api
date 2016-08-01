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
    - 'command_received' — echos command sent to API
    - 'version' — contains running API version

***

## Errors
- **none**
 
***

## Sample Response

```xml
<response>
	<command_received>version</command_received>
	<version>1</version>
</response>
```
