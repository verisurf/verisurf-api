# Command

    <Inspect_Plan_Info id="" />

## Description

Returns object information for plan with specific id
plan id = index of Plan in Plan List.
run_state = If the plan is currently running.
measure_object_id = Current object in measurement. (only shown when run_state=1)

***

## Parameters
- **id** _(optional)_ — if included plan info of index, if omitted current plan is used

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - **data** — default wrapper for all secondary data API responses
    - 'inspect_plan_info' — data container for plan info

***

## Errors
- **406** — Missing parameter "id" in request
 
***

## Sample Response

```xml
<!-- RESPONSE 1 -->
<response>
    <success>
        <command_received>inspect_plan_info</command_received>
        <acknowledgement />
        <request_id>1</request_id>
    </success>
</response>
<!-- RESPONSE 2 -->
<response>
	<success>
		<command_received>inspect_plan_info</command_received>
		<data>
			<inspect_plan_info>
				<plan id="0" run_state="1" measure_object_id="0">Report1
				<plan_object object_id="0">Point1</plan_object>
				</plan>
			</inspect_plan_info>
		</data>
		<completed />
		<request_id>1</request_id>
	</success>
</response>
```
