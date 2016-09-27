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
    - **data** — default wrapper for all secondary data API responses

***

## Errors
- **None**

## Sample Response
```xml
<!-- RESPONSE 1 -->
<response>
    <success>
        <command_received>screenshot</command_received>
        <acknowledgement />
        <request_id>1</request_id>
    </success>
</response>
<!-- RESPONSE 2 -->
<response>
	<success>
		<command_received>screenshot</command_received>
		<data>C:\Users\verisurf\AppData\Local\Temp\Mastercam 2017\test.png</data>
		<completed />
		<request_id>1</request_id>
	</success>
</response>
```
