# Verisurf API Introduction

The Verisurf API is provided to grant programmatic access to the functionality and data of the Verisurf desktop software.  This can be used to write automation routines or develop independent software that interfaces directly with Verisurf without using the Verisurf UI.

The interface for communication with Verisurf is handled through socket communication.  There are TCP socket and WebSocket implementations available at this time.  This repository contains in depth sample code and documentation to cover the use of these interfaces.

***

## Overview
* [Connection Basics](#connection)
* [Sending Requests](#requests)
* [Error Codes](#error)
* [Examples](#examples)
* [Version Information](#version)
* [FAQ](#faq)

***

## <a name="connection">Connection Basics</a>
####Enabling the API
To first get started you'll need to enable the socket connection interface, this can be done by opening Verisurf preferences and enabling the API method you intend to use.  If you change the port number during this step be sure to modify all examples with the modified port number.

![Verisurf API Preferences](https://github.com/verisurf/verisurf-api/blob/master/documentation/images/api-enabled.png)

####TCP Test
You may test the TCP socket by opening a command prompt window on your local machine and typing "telnet localhost 33666", after doing so you should see the Verisurf API welcome message.

####WEB
You may test the WEB socket by clicking the following link and clicking the "Start Test" button [Verisurf WebSocket Test](http://sdk.verisurf.com/connection-test)

## <a name="requests">Sending Requests</a>
The following rules apply to all API requests
* All requests must be in XML format - ex. &lt;Command_List /&gt;
* All requests are case insensitive - File_Open == FILE_OPEN == file_open

The following rule applies to all TCP API requests
* All requests must be terminated with a newline character - &lt;Inspect_Plan_List /&gt;\n

###API Reference
- **[<code>General</code> Command_List](https://github.com/verisurf/verisurf-api/blob/master/documentation/command_list.md)**
- **[<code>General</code> File_Open](https://github.com/verisurf/verisurf-api/blob/master/documentation/file_open.md)**
- **[<code>General</code> File_Save](https://github.com/verisurf/verisurf-api/blob/master/documentation/file_save.md)**
- **[<code>General</code> Version](https://github.com/verisurf/verisurf-api/blob/master/documentation/version.md)**
- **[<code>General</code> Settings_Get](https://github.com/verisurf/verisurf-api/blob/master/documentation/settings_get.md)**
- **[<code>General</code> Settings_Set](https://github.com/verisurf/verisurf-api/blob/master/documentation/settings_set.md)**
- **[<code>View</code> CADView_FitScreen](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_fitscreen.md)**
- **[<code>View</code> CADView_Wireframe](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_wireframe.md)**
- **[<code>View</code> CADView_Shaded](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_shaded.md)**
- **[<code>View</code> CADView_Top](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_top.md)**
- **[<code>View</code> CADView_Front](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_front.md)**
- **[<code>View</code> CADView_Right](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_right.md)**
- **[<code>View</code> CADView_ISO](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_iso.md)**
- **[<code>View</code> CADView_Left](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_left.md)**
- **[<code>View</code> CADView_Back](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_back.md)**
- **[<code>View</code> CADView_Bottom](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_bottom.md)**
- **[<code>View</code> CADView_ZoomIn](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_zoomin.md)**
- **[<code>View</code> CADView_ZoomOut](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_zoomout.md)**
- **[<code>View</code> CADView_ZoomProbe](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_zoomprobe.md)**
- **[<code>View</code> CADView_PanLeft](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_panleft.md)**
- **[<code>View</code> CADView_PanRight](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_panright.md)**
- **[<code>View</code> CADView_PanUp](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_panup.md)**
- **[<code>View</code> CADView_PanDown](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_pandown.md)**
- **[<code>View</code> CADView_RotateLeft](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_rotateleft.md)**
- **[<code>View</code> CADView_RotateRight](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_rotateright.md)**
- **[<code>View</code> CADView_RotateUp](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_rotateup.md)**
- **[<code>View</code> CADView_RotateDown](https://github.com/verisurf/verisurf-api/blob/master/documentation/cadview_rotatedown.md)**
- **[<code>Measure</code> Build](https://github.com/verisurf/verisurf-api/blob/master/documentation/build.md)**
- **[<code>Measure</code> Measure_Point](https://github.com/verisurf/verisurf-api/blob/master/documentation/measure_point.md)**
- **[<code>Measure</code> Measure_Line](https://github.com/verisurf/verisurf-api/blob/master/documentation/measure_line.md)**
- **[<code>Measure</code> Measure_Circle](https://github.com/verisurf/verisurf-api/blob/master/documentation/measure_circle.md)**
- **[<code>Measure</code> Measure_Spline](https://github.com/verisurf/verisurf-api/blob/master/documentation/measure_spline.md)**
- **[<code>Measure</code> Measure_Ellipse](https://github.com/verisurf/verisurf-api/blob/master/documentation/measure_ellipse.md)**
- **[<code>Measure</code> Measure_Slot](https://github.com/verisurf/verisurf-api/blob/master/documentation/measure_slot.md)**
- **[<code>Measure</code> Measure_Plane](https://github.com/verisurf/verisurf-api/blob/master/documentation/measure_plane.md)**
- **[<code>Measure</code> Measure_Sphere](https://github.com/verisurf/verisurf-api/blob/master/documentation/measure_sphere.md)**
- **[<code>Measure</code> Measure_Cylinder](https://github.com/verisurf/verisurf-api/blob/master/documentation/measure_cylinder.md)**
- **[<code>Measure</code> Measure_Cone](https://github.com/verisurf/verisurf-api/blob/master/documentation/measure_cone.md)**
- **[<code>Measure</code> Measure_Set_Average](https://github.com/verisurf/verisurf-api/blob/master/documentation/measure_set_average.md)**
- **[<code>Measure</code> Measure_Set_Single](https://github.com/verisurf/verisurf-api/blob/master/documentation/measure_set_single.md)**
- **[<code>Measure</code> Measure_Set_Cloud](https://github.com/verisurf/verisurf-api/blob/master/documentation/measure_set_cloud.md)**
- **[<code>Measure</code> Measure_Get_Point_Mode](https://github.com/verisurf/verisurf-api/blob/master/documentation/measure_get_point_mode.md)**
- **[<code>Measure</code> Measure_Cancel](https://github.com/verisurf/verisurf-api/blob/master/documentation/measure_cancel.md)**
- **[<code>Inspect</code> Inspect_Plan_List](https://github.com/verisurf/verisurf-api/blob/master/documentation/inspect_plan_list.md)**
- **[<code>Inspect</code> Inspect_Plan_Load](https://github.com/verisurf/verisurf-api/blob/master/documentation/inspect_plan_load.md)**
- **[<code>Inspect</code> Inspect_Plan_Info](https://github.com/verisurf/verisurf-api/blob/master/documentation/inspect_plan_info.md)**
- **[<code>Inspect</code> Inspect_Plan_Start](https://github.com/verisurf/verisurf-api/blob/master/documentation/inspect_plan_start.md)**
- **[<code>Inspect</code> Inspect_Plan_Stop](https://github.com/verisurf/verisurf-api/blob/master/documentation/inspect_plan_stop.md)**
- **[<code>Inspect</code> Inspect_Plan_Clear_All](https://github.com/verisurf/verisurf-api/blob/master/documentation/inspect_plan_clear_all.md)**
- **[<code>Inspect</code> Inspect_Object_Measure](https://github.com/verisurf/verisurf-api/blob/master/documentation/inspect_object_measure.md)**
- **[<code>Inspect</code> Inspect_Object_Info](https://github.com/verisurf/verisurf-api/blob/master/documentation/inspect_object_info.md)**
- **[<code>Inspect</code> Inspect_Object_Clear](https://github.com/verisurf/verisurf-api/blob/master/documentation/inspect_object_clear.md)**
- **[<code>Device</code> Device_List](https://github.com/verisurf/verisurf-api/blob/master/documentation/device_list.md)**
- **[<code>Device</code> Device_Info](https://github.com/verisurf/verisurf-api/blob/master/documentation/device_info.md)**

## <a name="error">Error Codes</a>
| Code | Issue | Cause |
|------|-------|------------|
| 400 | Bad Request | Request not in XML format |
| 404 | Command Unknown | Command not in Command List |
| 406 | Missing Parameter | Required parameter missing from request |

## <a name="examples">Examples</a>
###TCP Examples
* [<code>C#</code> C# Winforms](https://github.com/verisurf/verisurf-api/tree/master/tcp-examples/CSharp)
* [<code>Javascript</code> Electron Bootstrap](https://github.com/verisurf/verisurf-api/tree/master/tcp-examples/Electron)
* [<code>Javascript</code> NodeJS Command Line](https://github.com/verisurf/verisurf-api/tree/master/tcp-examples/NodeJS)
* [<code>Python</code> Python Command Line](https://github.com/verisurf/verisurf-api/tree/master/tcp-examples/Python)
* [<code>VB</code> Visual Basic Winforms](https://github.com/verisurf/verisurf-api/tree/master/tcp-examples/VisualBasic)

###WEB Examples
* [<code>Javascript</code> Live-Report](https://github.com/verisurf/verisurf-api/tree/master/web-examples/Live-Report)
* [<code>Javascript</code> Probes](https://github.com/verisurf/verisurf-api/tree/master/web-examples/Probes)

## <a name="version">Version Information</a>
Verisurf API 1.0 is included in Verisurf 2017.

## <a name="faq">FAQ</a>
##### What are the pre-requisites to getting started?
* A licensed copy of Verisurf 2017
* Some programming experience
* Basic understanding of socket communication

