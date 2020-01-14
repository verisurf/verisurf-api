# Command

    <Inspect_Object_Info id="" />

## Description

Returns current measurement information for object with specific id

***

## Parameters
- **id** _(required)_ — object id to be retrieved
- **fullData** — return all property data regardless of settings

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - **data** — default wrapper for all secondary data API responses
    - 'inspect_object_info' — container for object information
	
***

## Errors
- **406** — Missing parameter "id" in request
 
***

## Sample Response
```xml
<!-- RESPONSE 1 -->
<response>
    <success>
        <command_received>inspect_object_info</command_received>
        <acknowledgement />
        <request_id>1</request_id>
    </success>
</response>
<!-- RESPONSE 2 -->
<response>
    <success>
        <command_received>inspect_object_info</command_received>
        <data>
            <inspect_object_info>
                <object id="0">Circle1
			<property name="X" nominal="-0.65005677877700985" tolmin="-0.01" tolmax="0.01" measured="-0.65005677877700985" deviation="0" />
			<property name="Y" nominal="-0.23476512888355075" tolmin="-0.01" tolmax="0.01" measured="-0.23476512888355075" deviation="0" />
			<property name="Z" nominal="0" tolmin="-0.01" tolmax="0.01" measured="0" deviation="0" />
			<property name="Diameter" nominal="1.8470422215408304" tolmin="-0.01" tolmax="0.01" measured="1.8470422215408304" deviation="0" />
			<property name="Position" nominal="0" tolmax="0.01" measured="0" deviation="0" />
			<property name="Alignments" value="Auto-Align1" />
			<property name="Transformation" value="Translation: X:-0.1818 Y:0.0039 Z:0.0150 / Rotation: A:0.0000 B:-0.0000 C:0.8451" /></object>
            </inspect_object_info>
        </data>
        <completed />
        <request_id>2</request_id>
    </success>
</response>
```
