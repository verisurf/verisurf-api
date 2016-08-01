## Live Report Sample Application

The following example utilizes the Verisurf API to create a real time version of a familiar Verisurf report.  This is intended to be a basic example to showcase the functionality of the Verisurf API using WebSockets.

This example is also hosted on http://sdk.verisurf.com/

### Specifications

This exhibits the following functionality:
- Set up jquery selectors for table cells
- Make WebSocket connection and establish callback function to Verisurf polling 4 times a second
- Parse callback response and update table cells with returned data

### Implementation

Simply host the 4 included files on the web server of your choice (apache/nginx/nodejs) and the example will be active