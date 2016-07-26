# Command

    <File_Save filename="" />

## Description

Saves current file to absolute path given in filename attribute

***

## Parameters
- **filename** _(required)_ — filename to be saved, requires full path

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - 'command_received' — echos command sent to API

***

## Errors
- **406** — Missing parameter "filename" in request
