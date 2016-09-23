//
var device_id = 1;
//
var verisurf_x = 0;
var verisurf_y = 0;
var global_x = 0;
var global_y = 0;
//
var Verisurf = {
    _WIDTH: 800,
    _HEIGHT: 450
};
//
var game;
var timer;
var websocket;
var alternate = false;
//
function limitValue(v, min, max) {
    return (Math.min(max, Math.max(min, v)));
}
//
function formatDRONumber(number)
{
    if(number >= 0)
        number = " "+parseFloat(number).toFixed(4);
    else
        number = parseFloat(number).toFixed(4);
    return number;
}