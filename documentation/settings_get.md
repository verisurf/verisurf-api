# Command

    <Settings_Get selector="" />

## Description

Reads the value from the Verisurf settings file

***

## Parameters
- **selector** _(required)_ — a string in selector format to retrieve the setting value - [**SELECTOR FORMAT DOCUMENTATION**](https://github.com/verisurf/verisurf-api/blob/master/documentation/selector_format.md)

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - 'setting_value' — value of the selected setting

***

## Errors
- **406** — Missing parameter "selector" in request
- **400** — Unable to parse settings file as XML
- **400** — Unable to find XML element via selector
- **400** — XML element has no attributes

***

## Sample Request
```xml
<settings_get selector="VerisurfX7:TwoVScene:MeasureSettings_CommonDisplay:bRandomClr" />
```

## Sample Response
```xml
<response>
	<success>
		<command_received>settings_get</command_received>
		<data>0</data>
		<request_id>1</request_id>
	</success>
</response>
```
