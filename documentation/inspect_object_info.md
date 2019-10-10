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
				<object id="0">Point1<property name="X" nominal="-6.502131725834623" tolmin="-0.01" tolmax="0.01" measured="-6.502131725834623" deviation="0"/>
					<property name="Y" nominal="3.0448689183020363" tolmin="-0.01" tolmax="0.01" measured="3.0448689183020363" deviation="0"/>
					<property name="Z" nominal="0.00071101086684584531" tolmin="-0.01" tolmax="0.01" measured="0.00071101086684584531" deviation="0"/>
					<property name="I" nominal="0" tolmin="-0.01" tolmax="0.01" measured="0" deviation="0"/>
					<property name="J" nominal="0" tolmin="-0.01" tolmax="0.01" measured="0" deviation="0"/>
					<property name="K" nominal="1" tolmin="-0.01" tolmax="0.01" measured="1" deviation="0"/>
					<property name="2D Radius" nominal="7.1797593072293822" tolmin="-0.01" tolmax="0.01" measured="7.1797593072293822" deviation="0"/>
					<property name="2D Angle" nominal="154.90688079322467" tolmin="-0.10000000000000001" tolmax="0.10000000000000001" measured="154.90688079322467" deviation="0"/>
					<property name="3D Radius" nominal="7.1797593424350508" tolmin="-0.01" tolmax="0.01" measured="7.1797593424350508" deviation="0"/>
					<property name="3D Angle" nominal="0.0056739954616604497" tolmin="-0.10000000000000001" tolmax="0.10000000000000001" measured="0.0056739954616604497" deviation="0"/>
					<property name="3D Position" nominal="0" tolmin="-0.01" tolmax="0.01" measured="0" deviation="0"/>
					<property name="Position" nominal="0" tolmax="0.01" measured="0" deviation="0"/>
					<property name="MMC" nominal="0" tolmax="0.01" measured="0" deviation="0"/>
					<property name="LMC" nominal="0" tolmax="0.01" measured="0" deviation="0"/>
				</object>
			</inspect_object_info>
		</data>
		<completed />
		<request_id>1</request_id>
	</success>
</response>
```
