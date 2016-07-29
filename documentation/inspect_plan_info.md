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
- **data** — default wrapper for all secondary data API responses
    - 'inspect_planinfo' — data container for plan info

***

## Errors
- **406** — Missing parameter "id" in request
 
***

## Sample Response

```xml
<response>
    <command_received>inspect_plan_info</command_received>
</response>

<data>
	<inspect_planinfo>
		<plan id="0" run_state="0">Report1
			<plan_object object_id="0">Point1</plan_object>
			<plan_object object_id="1">Point2</plan_object>
			<plan_object object_id="2">Point3</plan_object>
			<plan_object object_id="3">Point4</plan_object>
			<plan_object object_id="4">Plane1</plan_object>
			<plan_object object_id="5">ScreenShot</plan_object>
		</plan>
	</inspect_planinfo>
</data>
```
