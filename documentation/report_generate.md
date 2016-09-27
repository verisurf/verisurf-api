# Command

    <Report_Generate />

## Description

Generates the output from the currently selected report object, contrary to normal Verisurf operation the report will not open and will just be saved to its proper location

***

## Parameters
- **openOnSave** _(optional)_ - will open the file after generation

***

## Return format
A XML response with the following format:

- **response** - default wrapper for all API responses

***

## Errors
- **None**
 
***

## Sample Response
```xml
<!-- RESPONSE 1 -->
<response>
    <success>
        <command_received>report_generate</command_received>
        <acknowledgement />
        <request_id>1</request_id>
    </success>
</response>
<!-- RESPONSE 2 -->
<response>
	<success>
		<command_received>report_generate</command_received>
		<data>C:\Users\verisurf\Documents\my mcam2017\data\Reports\test.html</data>
		<completed />
		<request_id>1</request_id>
	</success>
</response>
```
