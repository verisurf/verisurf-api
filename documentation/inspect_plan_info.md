# Command

    <Inspect_Plan_Info id="" />

## Description

Returns object information for plan with specific id

***

## Parameters
- **id** _(required)_ — object id to be retrieved

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - 'command_received' — echos command sent to API

***

## Errors
- **406** — Missing parameter "id" in request
