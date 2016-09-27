# Command

    <Measure_Get_Point_Mode />

## Description

Retrieves current point mode

***

## Parameters
- **None**

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - **data** — default wrapper for all secondary data API responses
    - 'measure_point_mode' — contains measure point mode information
        - "0" - Single Point
        - "1" - Continuous
        - "2" - Average Point
        - "3" - Timer

***

## Errors
- **None**

***

## Sample Response

```xml
<!-- RESPONSE 1 -->
<response>
    <success>
        <command_received>measure_get_point_mode</command_received>
        <acknowledgement />
        <request_id>1</request_id>
    </success>
</response>
<!-- RESPONSE 2 -->
<response>
	<success>
		<command_received>measure_get_point_mode</command_received>
		<data>2</data>
		<completed />
		<request_id>1</request_id>
	</success>
</response>
```
