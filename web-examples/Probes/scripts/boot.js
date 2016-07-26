Verisurf.Boot = function (game) {
};
Verisurf.Boot.prototype = {
    preload: function () {
        //set event listener for change to full-screen
        this.scale.onFullScreenChange.add(this.onChangeFullScreen, this);
        //static images
        this.load.image('background', 'images/background.png');
        this.load.image('background-game', 'images/background-game.jpg');
        this.load.image('probe1', 'images/probe1.png');
        this.load.image('probe2', 'images/probe2.png');
        this.load.image('probe3', 'images/probe3.png');
        this.load.image('border-horizontal', 'images/border-horizontal.png');
        this.load.image('border-vertical', 'images/border-vertical.png');
        this.load.image('button-keyboard', 'images/button-keyboard.png');
        this.load.image('button-mouse', 'images/button-mouse.png');
        this.load.image('button-device', 'images/button-device.png');
        this.load.image('verisurf', 'images/verisurf.png');
        //sprite sheets
        this.load.spritesheet('button-start', 'images/button-start.png', 182, 34);
        this.load.spritesheet('button-exit', 'images/button-exit.png', 182, 34);
        this.load.spritesheet('button-clear', 'images/button-clear.png', 110, 34);
        //audio
        this.load.audio('audio-bounce', ['audio/bounce.ogg', 'audio/bounce.mp3', 'audio/bounce.m4a']);
    },
    create: function () {
        //after done loading resources
        this.game.state.start('main');
    },
    onChangeFullScreen: function () {
        //event to change the game size when it's full-screen
        if (this.game.scale.isFullScreen) {
            this.scale.setGameSize(1920, 1080);
        }
        else {
            this.scale.setGameSize(800, 450);
            this.game.state.start('main');
        }
    }
};