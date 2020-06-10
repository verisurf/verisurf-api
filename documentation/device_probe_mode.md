# Command

    <device_probe_mode id="" mode="" />

## Description

**Leica Only**
Sets the Device Probing Mode

***

## Parameters
- **id** _(required)_ Device ID used.
- **mode**  _(required)_  **0** = Scanner, **1** = SMR

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
	
***

## Errors
- **406** — Missing parameter "id" in request
 
***

## Example (Setting Device 1 to SMR Probe Mode)
```xml
<device_probe_mode id="1" mode="1" />

```
***

## Sample Response
```xml
<response>
    <success>
        <command_received>device_probe_mode</command_received>
        <acknowledgement />
        <request_id>1</request_id>
    </success>
</response>
```
