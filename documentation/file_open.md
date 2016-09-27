# Command

    <File_Open filename="" />

## Description

Opens and loads Verisurf .mcam file into Verisurf Software

***

## Parameters
- **filename** _(required)_ — filename to be loaded, requires full path

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses

***

## Errors
- **406** — Missing parameter "filename" in request

***

## Sample Response
```xml
<response>
	<success>
		<command_received>file_open</command_received>
		<request_id>1</request_id>
	</success>
</response>
```
