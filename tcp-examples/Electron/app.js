var net = require('net');
const {dialog} = require('electron').remote;

var client;
var connection = false;
var client_message = '';
var server_message = '';

function Connect() {
    if (connection == false) {
        client = net.createConnection(33666, 'localhost');
        client.on('error', function(err) {
            client_message = 'Verisurf Connection Failed';
            UpdateTextarea();
            console.log(err);
        });
        client.on('connect', function () {
            client_message = 'Verisurf Connection Opened';
            connection = true;
        });
        client.on('data', function (data) {
            server_message = data;
            UpdateTextarea();
        });
        client.on('close', function () {
            connection = false;
        });
    }
    else {
        client_message = 'Verisurf Connection Already Established';
        UpdateTextarea();
    }
}

function PlanList() {
    SendCommand("<inspect_plan_list />");
}

function PlanLoad() {
    SendCommand("<inspect_plan_load id='0' />");
}

function PlanInfo() {
    SendCommand("<inspect_plan_info />");
}

function ObjectMeasure() {
    SendCommand("<inspect_object_measure id='0' />");
}

function ObjectInfo() {
    SendCommand("<inspect_object_info id='0' />");
}

function CustomCommand(){
    SendCommand($("#command").val());
}

function Disconnect() {
    if (client) {
        client_message = 'Verisurf Connection Closed';
        UpdateTextarea();

        client.destroy();
        client = undefined;
    }
}

function SendCommand(command) {
    if (client !== undefined && command !== undefined) {
        client.write(command + "\n");
        client_message = command;
    }
}

function CommandList() {
    SendCommand("<command_list />");
}

function FileOpen() {
    if (client !== undefined) {
        var filename = dialog.showOpenDialog({
            filters: [{name: 'Verisurf Files', extensions: ['mcam']}],
            properties: ['openFile']
        });
        if (filename.length)
            SendCommand("<file_open filename='" + filename + "' />");
    }
}

function FileSave() {
    if (client !== undefined) {
        var filename = dialog.showSaveDialog({
            filters: [{name: 'Verisurf Files', extensions: ['mcam']}]
        });
        if (filename.length)
            SendCommand("<file_save filename='" + filename + "' />");
    }
}

function UpdateTextarea()
{
    var update = '';
    if(client_message.length)
        update += "CLIENT: " + client_message + "\r\n\r\n";
    if(server_message.length)
        update += "SERVER: " + server_message;

    client_message = '';
    server_message = '';

    $("#results").val(update);
}