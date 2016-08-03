# Command

    <Settings_Get selector="" />

## Description

Reads the value from the Verisurf settings file

***

## Parameters
- **selector** _(required)_ — a string in selector format to retrieve the setting value

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - 'command_received' — echos command sent to API
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
	<command_received>settings_get</command_received>
	<setting_value>1</setting_value>
</response>
```
