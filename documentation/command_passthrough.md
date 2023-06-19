
# Command
	<command_passthrough />
##  Description
The `command_passthrough` API call allows you to access and call any built-in Mastercam function included in the "Mastercam.Ft" file. This provides a highly flexible means to interact with Mastercam's functionalities directly from within Verisurf.

## Parameters
To call a Mastercam function via the `command_passthrough` API, you will need to provide the `category` and `command` properties. The `category` will typically be "Mastercam", while the `command` will correspond to the Mastercam function you want to access.

Here is the general structure for using the `command_passthrough` API call:

```xml
<command_passthrough category="Mastercam" command="YourMastercamFunctionHere" />
```

## Example Usage
Here's a practical example where we call the QuickMaskSurfacesOnly function from Mastercam:

```xml
<command_passthrough category="Mastercam" command="QuickMaskSurfacesOnly" />
```
This line of code sends a command to Mastercam to only quick mask the surfaces.

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
## Conclusion
The command_passthrough API call is a powerful tool that allows you to access the broad functionality of Mastercam directly from within Verisurf. This enables you to build highly customized solutions tailored to your unique needs.

Be sure to replace "YourMastercamFunctionHere" with the actual function you wish to call.

Please refer to the Mastercam.Ft file for the list of all available Mastercam functions.
