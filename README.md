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
If telnet is enable on your machine you may easily test the TCP interface by opening a command prompt and typing "telnet localhost 33666", on success you should see the Verisurf API welcome message.

####WEB
You may test the WEB interface by clicking the following link and clicking the "Start Test" button [Verisurf WebSocket Test](http://sdk.verisurf.com/connection-test)

## <a name="requests">Sending Requests</a>
The following rules apply to all API requests
* All requests must be in XML format - ex. &lt;Command_List /&gt;
* All requests are case insensitive - File_Open == FILE_OPEN == file_open

The following rule applies to all TCP API requests
* All requests must be terminated with a newline character - &lt;Inspect_Plan_List /&gt;\n

## List of Commands
**[Complete Function Reference](https://github.com/verisurf/verisurf-api/blob/master/documentation/README.md)**

## <a name="error">Error Codes</a>
| Code | Issue | Cause |
|------|-------|------------|
| 400 | Bad Request | Request not in XML format |
| 404 | Command Unknown | Command not in Command List |
| 406 | Missing Parameter | Required parameter missing from request |

## <a name="examples">Examples</a>
###TCP Examples
* [<code>C++</code> C++ Juce](https://github.com/verisurf/verisurf-api/tree/master/tcp-examples/C++)
* [<code>C#</code> C# Winforms](https://github.com/verisurf/verisurf-api/tree/master/tcp-examples/CSharp)
* [<code>Javascript</code> Electron Bootstrap](https://github.com/verisurf/verisurf-api/tree/master/tcp-examples/Electron)
* [<code>Javascript</code> NodeJS Command Line](https://github.com/verisurf/verisurf-api/tree/master/tcp-examples/NodeJS)
* [<code>Python</code> Python Command Line](https://github.com/verisurf/verisurf-api/tree/master/tcp-examples/Python)
* [<code>VB</code> Visual Basic Winforms](https://github.com/verisurf/verisurf-api/tree/master/tcp-examples/VisualBasic)

###WEB Examples
* [<code>Javascript</code> Live-Report](https://github.com/verisurf/verisurf-api/tree/master/web-examples/Live-Report)
* [<code>Javascript</code> Probes](https://github.com/verisurf/verisurf-api/tree/master/web-examples/Probes)
* [<code>Javascript</code> Part-Selector](https://github.com/verisurf/verisurf-api/tree/master/web-examples/Part-Selector)
* [<code>Javascript</code> Detector](https://github.com/verisurf/verisurf-api/tree/master/web-examples/Detector)

## <a name="version">Version Information</a>
Verisurf API 1.0 is included in Verisurf 2017.

## <a name="faq">FAQ</a>
##### What are the pre-requisites to getting started?
* A licensed copy of Verisurf 2017
* Some programming experience
* Basic understanding of socket communication

