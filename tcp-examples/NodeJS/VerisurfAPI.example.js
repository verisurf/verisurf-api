//  VERISURF NODEJS API EXAMPLE
var net = require('net');

var client = net.createConnection(33666, 'localhost');
var commands = ["<command_list />", "<inspect_plan_list />", "<device_info id='1' />"];
var i = 0;
client.on('connect', function () {
	console.log('Verisurf Connection Established');
	client.on('fire', function () {
		console.log("SENT: " + commands[i]);
		client.write(commands[i] + "\n");
		i++;

		var now = new Date().getTime();
		while(new Date().getTime() < now + 1000){ /* do nothing */ }
	});
	client.on('data', function (data) {
		console.log("GOT: " + data);

		if(i < commands.length)
		{
			client.emit('fire');
		}
		else
			client.destroy();
	});
});
client.on('close', function () {
	console.log('Verisurf Connection Closed');
});