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
* [Resources](#resources)

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
- **[<code>General</code> Command_List](#)** - List all available API commands
- **[<code>General</code> File_Open](#)** - Open Verisurf file
- **[<code>General</code> File_Save](#)** - Save Verisurf file
- **[<code>View</code> CADView_FitScreen](#)** - Modifies the CAD view to fit current surfaces and solids to the screen
- **[<code>View</code> CADView_Wireframe](#)** - Modifies the CAD view to enter wireframe mode
- **[<code>View</code> CADView_Shaded](#)** - Modifies the CAD view to enter shaded mode
- **[<code>View</code> CADView_Top](#)** - Modifies the CAD view to top
- **[<code>View</code> CADView_Front](#)** - Modifies the CAD view to front
- **[<code>View</code> CADView_Right](#)**Modifies the CAD view to right
- **[<code>View</code> CADView_ISO](#)** - Modifies the CAD view to ISO
- **[<code>View</code> CADView_Left](#)** - Modifies the CAD view to left
- **[<code>View</code> CADView_Back](#)** - Modifies the CAD view to back
- **[<code>View</code> CADView_Bottom](#)** - Modifies the CAD view to bottom
- **[<code>View</code> CADView_ZoomIn](#)** - Modifies the CAD view to zoom in
- **[<code>View</code> CADView_ZoomOut](#)** - Modifies the CAD view to zoom out
- **[<code>View</code> CADView_ZoomProbe](#)** - Modifies the CAD view to zoom probe
- **[<code>View</code> CADView_PanLeft](#)** - Modifies the CAD view to pan left
- **[<code>View</code> CADView_PanRight](#)** - Modifies the CAD view to pan right
- **[<code>View</code> CADView_PanUp](#)** - Modifies the CAD view to pan up
- **[<code>View</code> CADView_PanDown](#)** - Modifies the CAD view to pan down
- **[<code>View</code> CADView_RotateLeft](#)** - Modifies the CAD view to rotate left
- **[<code>View</code> CADView_RotateRight](#)** - Modifies the CAD view to rotate right
- **[<code>View</code> CADView_RotateUp](#)** - Modifies the CAD view to rotate up
- **[<code>View</code> CADView_RotateDown](#)** - Modifies the CAD view to rotate down
- **[<code>Measure</code> Measure_Point](#)** - Initializes measurement of Point
- **[<code>Measure</code> Measure_Line](#)** - Initializes measurement of Line
- **[<code>Measure</code> Measure_Circle](#)** - Initializes measurement of Circle
- **[<code>Measure</code> Measure_Spline](#)** - Initializes measurement of Spline
- **[<code>Measure</code> Measure_Ellipse](#)** - Initializes measurement of Ellipse
- **[<code>Measure</code> Measure_Slot](#)** - Initializes measurement of Slot
- **[<code>Measure</code> Measure_Plane](#)** - Initializes measurement of Plane
- **[<code>Measure</code> Measure_Sphere](#)** - Initializes measurement of Sphere
- **[<code>Measure</code> Measure_Cylinder](#)** - Initializes measurement of Cylinder
- **[<code>Measure</code> Measure_Cone](#)** - Initializes measurement of Cone
- **[<code>Measure</code> Measure_Set_Average](#)** - Set measurement mode to Average
- **[<code>Measure</code> Measure_Set_Single](#)** - Sets measurement mode to Single
- **[<code>Measure</code> Measure_Set_Cloud](#)** - Sets measurement mode to Cloud
- **[<code>Measure</code> Measure_Get_Point_Mode](#)** - **<code>Data</code>** Retrieves current point mode
- **[<code>Measure</code> Measure_Cancel](#)** - Exits measurement mode and discards unfinished measurements
- **[<code>Inspect</code> Inspect_Plan_List](#)** - **<code>Data</code>** Lists inspection plans for current file
- **[<code>Inspect</code> Inspect_Plan_Load](#)** - Loads inspection plan
- **[<code>Inspect</code> Inspect_Plan_Info](#)** - **<code>Data</code>** Retrieves plan object information
- **[<code>Inspect</code> Inspect_Plan_Start](#)** - Starts plan inspections process
- **[<code>Inspect</code> Inspect_Plan_Stop](#)** - Halts plan inspection process
- **[<code>Inspect</code> Inspect_Plan_Clear_All](#)** - Clears all measurement information from plan
- **[<code>Inspect</code> Inspect_Object_Measure](#)** - Initializes measurement mode for plan object
- **[<code>Inspect</code> Inspect_Object_Info](#)** - **<code>Data</code>** Retrieves measurement information for plan object
- **[<code>Inspect</code> Inspect_Object_Clear](#)** - Resets measurement information for plan object
- **[<code>Device</code> Device_Info](#)** - Returns device information

## <a name="error">Error Codes</a>

## <a name="examples">Examples</a>
###TCP Examples
* [<code>C#</code> C# Winforms](https://github.com/verisurf/verisurf-api/tree/master/tcp-examples/CSharp)
* [<code>Javascript</code> Electron Bootstrap](https://github.com/verisurf/verisurf-api/tree/master/tcp-examples/Electron)
* [<code>Javascript</code> NodeJS Command Line](https://github.com/verisurf/verisurf-api/tree/master/tcp-examples/NodeJS)
* [<code>Python</code> Python Command Line](https://github.com/verisurf/verisurf-api/tree/master/tcp-examples/Python)
* [<code>VB</code> Visual Basic Winforms](https://github.com/verisurf/verisurf-api/tree/master/tcp-examples/VisualBasic)

###WEB Examples
* [<code>Javascript</code> Live-Report](https://github.com/verisurf/verisurf-api/tree/master/web-examples/Live-Report)
* [<code>Javascript</code> Probes (Phaser)](https://github.com/verisurf/verisurf-api/tree/master/web-examples/Probes)

## <a name="version">Version Information</a>
Verisurf API 1.0 is included in Verisurf 2017.

## <a name="faq">FAQ</a>

## <a name="resources">Resources</a>
