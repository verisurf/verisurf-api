# Command

    <Settings_Set selector="" value="" />

## Important Note
Be careful to only set viable values for Verisurf settings, setting values outside of normal allowable ranges can have undefined behavior up to and including the crashing of the software.  If you accidentally set a key which causes an error you may delete your settings file to revert the program to normal operation.

Additionally some values are unable to be changed in real time through the API and will require a restart before they take effect.

***

## Description

Sets a value in the Verisurf settings file

***

## Parameters
- **selector** _(required)_ — a string in selector format to retrieve the setting value - [**SELECTOR FORMAT DOCUMENTATION**](https://github.com/verisurf/verisurf-api/blob/master/documentation/selector_format.md)
- **value** _(required)_ — the value to be set for the selected setting

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses

***

## Errors
- **406** — Missing parameter "selector" or "value" in request
- **400** — Unable to parse settings file as XML
- **400** — Unable to find XML element via selector
- **400** — XML element has no attributes

***

## Sample Request
```xml
<settings_set selector="VerisurfX7:TwoVScene:MeasureSettings_CommonDisplay:bRandomClr" value="1" />
```
 
***

## Sample Response
```xml
<response>
	<success>
		<command_received>settings_set</command_received>
		<request_id>1</request_id>
	</success>
</response>
```
