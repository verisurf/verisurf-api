# Command

    <File_Save filename="" />

## Description

Saves current file to absolute path given in filename attribute

***

## Parameters
- **filename** _(required)_ — filename to be saved, requires full path

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
		<command_received>file_save</command_received>
		<request_id>1</request_id>
	</success>
</response>
```
