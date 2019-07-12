# Command

    <inspect_plan_set_header />

## Description

Sets Header values to specified plan ID.

***

## Parameters
- **planlist_Id** _(required)_ - Plan ID to be used.
- **use_datetime** - Include Date/Time in Report
- **use_headers** - Parameter to set Header information from API or Verisurf. 1 to use API Header, 0 to use Verisurf.
- **header_content_0** - _(0-32 Fields)_ - Sets Header content for Header Field 0, up to 32 Header Fields Available.


***

## Return format
A XML response with the following format:

- **response** - default wrapper for all API responses

***

## Errors
- **406** - Missing parameter "ID" in request
 
***

## Sample Response
```xml
<response>
	<success>
		<command_received>inspect_plan_set_header</command_received>
		<request_id>0</request_id>
	</success>
</response>
```
