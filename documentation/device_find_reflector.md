# Command

    <Device_Find_Reflector id="" />

## Description

Initiates the "Find Reflector" fuction for Laser Trackers with the given search radius.

***

## Parameters
- **id** _(required)_ — object id to be retrieved.
- **distance** — Radius of Reflector Search Distance.

***

## Example
- <device_find_reflector id="1" distance="3.0" />


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
        <command_received>device_find_reflector</command_received>
        <acknowledgement />
        <request_id>1</request_id>
    </success>
</response>

```
