# Command

    <Object_Set_Alignment id="" />

## Description

Assigns a specified alignment to a single or multiple objects given the object ids.

***

## Parameters
- **id(s)** _(required)_ — object id to be assigned an alignment
- **alignment id** _(required)_ — alignment to be used for assignment
***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - **data** — default wrapper for all secondary data API responses
    - 'object_set_alignment' — container for object information
	
***

## Errors
- **406** — Missing parameter "id(s)" in request
 
***

## Sample Call
```xml
<object_set_alignment id="4"  alignment_id="7" />

 - Assigns Circle{4} to the first Auto-Alignment{7}. ID's are found from <Object_list />
 
<object_set_alignment ids="4,5,6"  alignment_id="7" />

 - Assigns a series of Features{4,5,6} to the first Auto-Alignment{7}. ID's are found from <Object_list />
```

## Sample Response
```xml
<response>
    <success>
        <command_received>object_set_alignment</command_received>
        <acknowledgement />
        <request_id>1</request_id>
    </success>
</response>
```
