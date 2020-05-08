# Command

    <Object_Info id="" />

## Description

Returns current measurement information for object with specific id from the Verisurf Database

***

## Parameters
- **id** _(required)_ — object id to be retrieved

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - **data** — default wrapper for all secondary data API responses
    - 'object_info' — container for object information
	
***

## Errors
- **406** — Missing parameter "id" in request
 
***

## Sample Response
```xml
<!-- RESPONSE 1 -->
<response>
    <success>
        <command_received>object_info</command_received>
        <acknowledgement />
        <request_id>0</request_id>
    </success>
</response>
<response>
<!-- RESPONSE 2 -->
<response>
    <success>
        <command_received>object_info</command_received>
        <data>
            <object_info>
                <object name="Circle1" id="0">Circle: "Circle1" (4)  WCS: "Top"                                                                              
                Roundness: 0.0368                                                                                                       
                Diameter: 1.2285  Radius: 0.6142                                                                                        
                Center: X-0.9599 Y0.9182 Z0.0000                                                                                        
                Normal: I0.0000 J0.0000 K1.0000</object>
            </object_info>
        </data>
        <completed />
        <request_id>0</request_id>
    </success>
</response>
```
