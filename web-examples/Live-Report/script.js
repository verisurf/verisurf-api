var websocket;
var timer;

var verisurf_x = $("#x_measured");
var verisurf_y = $("#y_measured");
var verisurf_z = $("#z_measured");
var verisurf_dx = $("#x_deviation");
var verisurf_dy = $("#y_deviation");
var verisurf_dz = $("#z_deviation");
var verisurf_d3 = $("#d3_measured");
var verisurf_px = $("#x_nominal");
var verisurf_py = $("#y_nominal");
var verisurf_pz = $("#z_nominal");

function socketTimerCallback() {
    websocket.send("<device_info id='1' />\n");
}

function ifNullZero(value) {
    if (value == null)
        return 0;
    else
        return parseFloat(value).toFixed(4);
}

$(function () {
    websocket = new WebSocket("ws://localhost:6734");

    websocket.onopen = function (event) {
        websocket.send("<build />\n");
        timer = setInterval(function () {
            socketTimerCallback();
        }, 100);
    };

    websocket.onmessage = function (event) {
        var domparser = new DOMParser();
        var xmlDoc = domparser.parseFromString(event.data, "text/xml");
        var info = xmlDoc.getElementsByTagName("device_info");
        if (info.length > 0) {
            verisurf_x.text(ifNullZero(info[0].getAttribute("X")));
            verisurf_px.text(ifNullZero(info[0].getAttribute("PX")));
            verisurf_dx.text(ifNullZero(info[0].getAttribute("DX")));

            verisurf_y.text(ifNullZero(info[0].getAttribute("Y")));
            verisurf_py.text(ifNullZero(info[0].getAttribute("PY")));
            verisurf_dy.text(ifNullZero(info[0].getAttribute("DY")));

            verisurf_z.text(ifNullZero(info[0].getAttribute("Z")));
            verisurf_pz.text(ifNullZero(info[0].getAttribute("PZ")));
            verisurf_dz.text(ifNullZero(info[0].getAttribute("DZ")));

            verisurf_d3.text(ifNullZero(info[0].getAttribute("D3")));
        }
        console.log(event.data);
    };

    websocket.onclose = function (event) {
        clearTimeout(timer);
    };
});

