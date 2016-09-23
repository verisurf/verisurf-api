//this function will be called 30 times a second once the socket connection is made
function socketTimerCallback() {
    websocket.send("<device_info id='" + device_id + "' />\n");
}
//
function ifNullZero(value)
{
    if(value == null)
        return 0;
    else
        return value;
}
//function used to attempt connection to verisurf
function socketConnect() {
    //default api (web) socket for verisurf
    websocket = new WebSocket("ws://localhost:6734");

    //callback for success of socket connection
    websocket.onopen = function (event) {
        //change game state to begin game
        game.state.start('game');
        //start build mode to take measurements
        websocket.send("<build />\n");
        //set timer callback to get i/j/k from verisurf
        timer = setInterval(function () {
            socketTimerCallback();
        }, 1000);
    };
    //
    websocket.onmessage = function (event) {
        //parse response data from verisurf server
        var domparser = new DOMParser();
        var xmlDoc = domparser.parseFromString(event.data, "text/xml");
        var info = xmlDoc.getElementsByTagName("device_info");
        if (info.length > 0) {
            verisurf_x = ifNullZero(info[0].getAttribute("X"));
            verisurf_y = ifNullZero(info[0].getAttribute("Y"));
        }
    };
    //
    websocket.onclose = function (event) {
        //once the connection closes because of errors or
        // closing verisurf stop timer and exit game
        clearTimeout(timer);
        game.state.start('error');
    };
}