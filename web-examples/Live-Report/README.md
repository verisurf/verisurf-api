## Live Report Sample Application

The following example utilizes the Verisurf API to create a real time version of a familiar Verisurf report.  This is intended to be a basic example to showcase the functionality of the Verisurf API using WebSockets.

This example is also hosted on http://sdk.verisurf.com/

### Functionality

- Set up jquery selectors for table cells
- Make WebSocket connection and establish callback function to Verisurf polling 4 times a second
- Parse callback response and update table cells with returned data

### Utilization

- Enable WEB socket connection within Verisurf
- Clone or download repository source code
- Install and configure web server (apache, nginx, etc)
- Host source files on server and navigate to page via web browser
