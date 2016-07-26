# Command

    <Device_Info id="" />

## Description

Returns measurement device information for specific device or global points

***

## Parameters
- **id** _(required)_ — device id to be retrieved. Recognized values:
    - '-1' — Returns global device information
    - '0' — Returns mouse device information
	- 'x' — Where X is any number > 0.  Returns device information for Xth device in VDI device list

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - 'command_received' — echos command sent to API
    - 'deviceinfo' — contains attributes with measurement information

***

## Errors
- **406** — Missing parameter "id" in request
