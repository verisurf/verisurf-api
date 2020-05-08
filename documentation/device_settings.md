# Command

    <device_settings id="" />

## Description

Gets or Sets Device Information for the _Leica T-Scan Interface_.

***

## Parameters
- **id** _(required)_ — Device ID used.
- **read** — _(Optional)_ Parameter to return the last Device Settings _Set_ made.
- **contour_filter_mode**  — Set the Contour Filter Mode.
- **exposure_time**  — Set the Scanner Exposure Time.
- **line_to_line_distance**  — Set the Line Distance.
- **max_angle_of_incidence**  — Set the Max Angle of Incidence.
- **point_to_point_distance**  — Set the Scanner Point to Point Distance.
- **raster_width**  — Set the Raster Width.
- **reflection_filter_type**  — Set the Reflection/Material Type Filter.
- **scan_line_width**  — Set the Scan Line Width.
- **scanner_line_frequency**  — Set the Scan Line Frequency

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses
    - **data** — default wrapper for all secondary data API responses
	
***

## Errors
- **406** — Missing parameter "id" in request
 
***

## Example (Setting multiple values and reading)
```xml
<device_settings id="1" read="1">
    <settings scanner_line_frequency="0.5" scan_line_width="2" point_to_point_distance=".02" />
</device_settings>
```
***

## Sample Response
```xml
<!-- RESPONSE 1 -->
<response>
    <success>
        <command_received>device_settings</command_received>
        <acknowledgement />
        <request_id>1</request_id>
    </success>
</response>
<!-- RESPONSE 2 -->
<response>
    <success>
        <command_received>device_settings</command_received>
        <data>
            <settings scanner_line_frequency="0.5" 
            point_to_point_distance=".02" 
            scan_line_width="2" 
        </data>
        <completed />
        <request_id>0</request_id>
    </success>
</response>
```
