# Command

    <File_Open filename="" />

## Description

Opens and loads Verisurf .mcam file into Verisurf Software

***

## Parameters
- **filename** _(required)_ — filename to be loaded, requires full path

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - 'command_received' — echos command sent to API

***

## Errors
- **406** — Missing parameter "filename" in request
