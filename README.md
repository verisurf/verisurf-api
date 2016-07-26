# Verisurf API Introduction

The Verisurf API is provided to grant programmatic access to the functionality and data of the Verisurf desktop software.  This can be used to write automation routines or develop independent software that interfaces directly with Verisurf without using the Verisurf UI.

The interface for communication with Verisurf is handled through socket communication.  There is a TCP socket and WebSocket implementation available at this time.  This repository contains in depth sample code and documentation to cover the use of these interfaces.

Additionally we have hosted a number of sample applications on our website at http://sdk.verisurf.com

***

## Overview
* [Connection Basics](#connection)
* [API Reference](#reference)
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

## <a name="reference">API Reference</a>

## <a name="error">Error Codes</a>

## <a name="examples">Examples</a>

## <a name="version">Version Information</a>
Verisurf API 1.0 is included in Verisurf 2017.

## <a name="faq">FAQ</a>

## <a name="resources">Resources</a>
