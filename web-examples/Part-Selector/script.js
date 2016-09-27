var websocket;
var active = false;
var sharedDirectory;

$(function () {
    websocket = new WebSocket("ws://localhost:6734");

    websocket.onopen = function (event) {
        active = true;
        websocket.send("<system_get name='shared' />\n");
    };

    websocket.onmessage = function (event) {
        var domparser = new DOMParser();
        var xmlDoc = domparser.parseFromString(event.data, "text/xml");
        var info = xmlDoc.getElementsByTagName("data");
        if (info.length > 0) {
            sharedDirectory = info[0].firstChild.nodeValue;
        }
        console.log(event.data);
    };

    websocket.onclose = function (event) {
        active = false;
    };
});

function LoadPart(x) {
    if (active)
        websocket.send("<file_open filename=\"" + sharedDirectory + x + "\" />\n");
}
