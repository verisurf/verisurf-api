# Command

    <Screenshot />

## Description

Returns the path to a screenshot of the current CAD window

***

## Parameters
- **None**

***

## Return format
A XML response with the following format:

- **response** - default wrapper for all API responses
    - 'command_received' - echos command sent to API
- **data** — default wrapper for all secondary data API responses

***

## Errors
- **None**

## Sample Response
```xml
<response>
	<command_received>screenshot</command_received>
</response>

<data command="screenshot">C:\Users\matth\AppData\Local\Temp\Mastercam 2017\DXLLOS1BQ1\T.png</data>
```
