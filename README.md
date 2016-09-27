# Verisurf API Introduction

The Verisurf API is provided to grant programmatic access to the functionality and data of the Verisurf desktop software.  This can be used to write automation routines or develop independent software that interfaces directly with Verisurf without using the Verisurf UI.

The interface for communication with Verisurf is handled through socket communication.  There are TCP socket and WebSocket implementations available at this time.  This repository contains in depth sample code and documentation to cover the use of these interfaces.

***

## Overview
* [Basics](#basics)
* [Requests](#requests)
* [Responses](#responses)
* [Commands](#commands)
* [Errors](#errors)
* [Examples](#examples)
* [Version](#version)
* [FAQ](#faq)

***

## <a name="basics">Basics</a>
####Enabling the API
To first get started you'll need to enable the socket connection interface, this can be done by opening Verisurf preferences and enabling the API method you intend to use.  If you change the port number during this step be sure to modify all examples with the modified port number.

![Verisurf API Preferences](https://github.com/verisurf/verisurf-api/blob/master/documentation/images/api-enabled.png)

####TCP Test
If telnet is enable on your machine you may easily test the TCP interface by opening a command prompt and typing "telnet localhost 33666", on success you should see the Verisurf API welcome message.

####WEB
You may test the WEB interface by clicking the following link and clicking the "Start Test" button [Verisurf WebSocket Test](http://sdk.verisurf.com/connection-test)

## <a name="requests">Requests</a>
All requests sent to the Verisurf API are done in simple XML. Following the format of:

&lt;command_name /&gt; or &lt;command_name&gt;&lt;/command_name&gt;

* All requests must be valid XML. 
* All command and argument names are case insensitive; however, the data of arguments is case sensitive.
* When using the TCP API all commands must be terminated by a newline character &lt;command_name /&gt;\n
* All requests may include a custom request id attribute to overwrite the default incremental session counter. &lt;command_name request_id='Alphanumeric' /&gt;

## <a name="responses">Responses</a>
Responses from the API follow a consistent response format where the top level element is always &lt;response&gt; with the first child being either &lt;success&gt; or &lt;error&gt;

Below is a sample response from the device_info command.  Commands that can be run in real time follow this format returning the command requested, the request id and optionally data.

```xml
<!-- REQUEST -->
<device_info id='0' />
<!-- RESPONSE -->
<response>
	<success>
		<command_received>device_info</command_received>
		<data>
			<device_info id="0" X="-7.8234033634455082">CMM</device_info>
		</data>
		<request_id>TEST-01</request_id>
	</success>
</response>
```

If the command requires additional time to execute such as the inspect_plan_list command it will first send an acknoledgement that the command was recieved then follow with the data response.  Commands that follow this format will be documented as such, below is an example response.

```xml
<!-- REQUEST -->
<inspect_plan_list />
<!-- RESPONSE 1 -->
<response>
	<success>
		<command_received>inspect_plan_list</command_received>
		<acknowledgement />
		<request_id>TEST-02</request_id>
	</success>
</response>
<!-- RESPONSE 2 -->
<response>
	<success>
		<command_received>inspect_plan_list</command_received>
		<data>
			<plans>
				<plan id="0">Standard Inspection</plan>
				<plan id="1">Alternate Inspection</plan>
			</plans>
		</data>
		<completed />
		<request_id>TEST-02</request_id>
	</success>
</response>
```

If the response is in error it will include a code and description element to assist you in resolving the error.  Below is a sample error response.

```xml
<!-- REQUEST -->
<file_open />
<!-- RESPONSE -->
<response>
	<error>
		<command_received>file_open</command_received>
		<code>406</code>
		<description>Missing Required Parameter : FILENAME</description>
		<request_id>TEST-03</request_id>
	</error>
</response>
```

## <a name="commands">Commands</a>
**[Function Reference](https://github.com/verisurf/verisurf-api/blob/master/documentation/README.md)**

## <a name="errors">Errors</a>
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

## <a name="version">Version</a>
Verisurf API 1.0 is included in Verisurf 2017.

## <a name="faq">FAQ</a>
##### What are the pre-requisites to getting started?
* A licensed copy of Verisurf 2017
* Some programming experience
* Basic understanding of socket communication

