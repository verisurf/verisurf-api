Verisurf.Boot = function (game) {
};
Verisurf.Boot.prototype = {
    preload: function () {
        //static images
        this.load.image('cube', 'images/cube.png');
        this.load.image('background', 'images/background.png');
        //sprite sheets
        this.load.spritesheet('button-start', 'images/button-start.png', 182, 34);
        this.load.spritesheet('button-exit', 'images/button-exit.png', 182, 34);
        //audio
        this.load.audio('beep', 'audio/beep.mp3');
        this.load.audio('ding', 'audio/ding.wav');
    },
    create: function () {
        //after done loading resources
        this.game.state.start('main');
    }
};