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
 
***

## Sample Response
```xml
<response>
	<command_received>inspect_object_info</command_received>
</response>

<data>
	<inspect_object_info>
		<object id="0">Point1<property name="X" measured="-0.32183760807056133" nominal="-0.32183760807056133" deviation="0"/>
			<property name="Y" measured="0.3481161192270939" nominal="0.3481161192270939" deviation="0"/>
			<property name="Z" measured="0.94474000000000002" nominal="0.94474000000000002" deviation="0"/>
			<property name="I" measured="0.42770732281531232" nominal="0.42770732281531232" deviation="0"/>
			<property name="J" measured="0.18225313202975177" nominal="0.18225313202975177" deviation="0"/>
			<property name="K" measured="0.88535317352766296" nominal="0.88535317352766296" deviation="0"/>
			<property name="3D Position" measured="0" nominal="0" deviation="0"/>
			<property name="Position" measured="0" nominal="0" deviation="0"/>
		</object>
	</inspect_object_info>
</data>
```
