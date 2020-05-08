# Command

    <device_aim id="" />

## Description

Aims the Laser Tracker Device to the supplied coordinates.

***

## Parameters
- **id** _(required)_ — Device ID to Aim.
- **pos_x** — x Value for Device Aiming.
- **pos_y** — y Value for Device Aiming.
- **pos_z** — z Value for Device Aiming.

***

## Example
- <device_aim id='1' pos_x="5.0" pos_y="6.0" pos_z="7.0"/>

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
	
***

## Errors
- **406** — Missing parameter "id" in request
 
***

## Sample Response
```xml
<!-- RESPONSE 1 -->
<response>
    <success>
        <command_received>device_aim</command_received>
        <acknowledgement />
        <request_id>1</request_id>
    </success>
</response>
```
