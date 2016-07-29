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
    - 'command_received' — echos command sent to API
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
<response>
    <command_received>measure_get_point_mode</command_received>
</response>

<data>
	<measure_point_mode>0</measure_pointmode>
</data>
```
