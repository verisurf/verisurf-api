# Command

    <Inspect_Object_Info id="" />

## Description

Returns measurement information for object with specific id

***

## Parameters
- **id** _(required)_ — object id to be retrieved

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - 'command_received' — echos command sent to API

- **data** — default wrapper for all secondary data API responses
    - 'inspect_planobjectinfo' — container for object information
	
***

## Errors
- **406** — Missing parameter "id" in request
