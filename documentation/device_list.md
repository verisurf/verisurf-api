# Command

    <Device_List />

## Description

Lists all active devices for current Verisurf instance

***

## Parameters
- **none**

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - 'command_received' — echos command sent to API
    - 'device_list' — contains list of devices
        - "device" — device information

***

## Errors
- **none**
 
***

## Sample Response

```xml
<response>
	<command_received>device_list</command_received>
	<device_list>
		<device id="0" name="Mouse"/>
		<device id="1" name="Faro Arm"/>
		<device id="2" name="Renishaw Equator"/>
	</device_list>
</response>
```
