# Command

    <Inspect_Plan_List />

## Description

Returns all currently supported commands accepted by the API

***

## Parameters
- **None**

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - **data** — default wrapper for all secondary data API responses
    - 'plans' — contains all plan information

***

## Errors
- **None**

***

## Sample Response

```xml
<!-- RESPONSE 1 -->
<response>
    <success>
        <command_received>inspect_plan_list</command_received>
        <acknowledgement />
        <request_id>1</request_id>
    </success>
</response>
<!-- RESPONSE 2 -->
<response>
    <success>
        <command_received>inspect_plan_list</command_received>
        <data>
            <plans>
                <plan id="0">Bolt Hole Inspection</plan>
                <plan id="1">Fitting Test Inspection</plan>
            </plans>
        </data>
        <completed />
        <request_id>1</request_id>
    </success>
</response>
```
