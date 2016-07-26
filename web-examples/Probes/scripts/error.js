Verisurf.Error = function (game) {
};
Verisurf.Error.prototype = {
    create: function () {
        //tiled background
        this.add.tileSprite(0, 0, 1920, 1080, 'background');
        //start (re-try connection)
        this.startButton = this.add.button(this.game.width * 0.5, 600, 'button-start', this.start, this, 2, 0, 1);
        this.startButton.anchor.set(0.5, 0);
        this.startButton.input.useHandCursor = true;
        //exit full-screen mode
        this.exitButton = this.add.button(this.game.width * 0.5, 700, 'button-exit', this.exit, this, 2, 0, 1);
        this.exitButton.anchor.set(0.5, 0);
        this.exitButton.input.useHandCursor = true;
        //failed connection text
        var font = {font: "bold 32px Arial", fill: "#000", boundsAlignH: "center", boundsAlignV: "middle"};
        var text = game.add.text(0, 0, "     Verisurf connection failed\nplease ensure Verisurf is running\n     and API (Web) is enabled.", font);
        text.setTextBounds(0, 0, this.game.width, 600);
    },
    start: function () {
        //re-attempt to connect to verisurf web-socket
        socketConnect();
    },
    exit: function () {
        //the full-screen toggle listener will take care of getting us back to the main menu
        this.scale.stopFullScreen();
    }
};