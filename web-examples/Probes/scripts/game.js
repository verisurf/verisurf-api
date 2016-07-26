Verisurf.Game = function (game) {
};
Verisurf.Game.prototype = {
    create: function () {
        //
        this.add.sprite(0, 0, 'background-game');
        //
        this.add.sprite(Verisurf._WIDTH * 0.5 - 175, Verisurf._HEIGHT - 60, 'button-device');
        this.add.sprite(Verisurf._WIDTH * 0.5 - 55, Verisurf._HEIGHT - 60, 'button-keyboard');
        this.add.sprite(Verisurf._WIDTH * 0.5 + 65, Verisurf._HEIGHT - 60, 'button-mouse');
        this.add.sprite(Verisurf._WIDTH - 200, Verisurf._HEIGHT - 100, 'verisurf');
        //
        this.clearButton = this.add.button(Verisurf._WIDTH - 80, 20, 'button-clear', this.clearTrails, this, 2, 0, 1);
        this.clearButton.anchor.set(0.5, 0);
        this.clearButton.input.useHandCursor = true;
        //
        this.physics.startSystem(Phaser.Physics.ARCADE);
        //
        this.movementForce = 10;
        this.ballStartPos = {x: Verisurf._WIDTH * 0.5, y: 1000};
        this.countdown = 0;
        //
        this.ball_1_trail = this.add.bitmapData(Verisurf._WIDTH, Verisurf._HEIGHT);
        this.ball_1_trail.context.fillStyle = "#d9534f";
        this.add.sprite(0,0,this.ball_1_trail);
        this.ball_2_trail = this.add.bitmapData(Verisurf._WIDTH, Verisurf._HEIGHT);
        this.ball_2_trail.context.fillStyle = "#337ab7";
        this.add.sprite(0,0,this.ball_2_trail);
        this.ball_3_trail = this.add.bitmapData(Verisurf._WIDTH, Verisurf._HEIGHT);
        this.ball_3_trail.context.fillStyle = "#5cb85c";
        this.add.sprite(0,0,this.ball_3_trail);
        //
        this.ball1 = this.add.sprite(this.ballStartPos.x - 100, this.ballStartPos.y, 'probe1');
        this.ball1.anchor.set(0.5);
        this.physics.enable(this.ball1, Phaser.Physics.ARCADE);
        this.ball1.body.bounce.set(0.7, 0.7);
        //
        this.ball2 = this.add.sprite(this.ballStartPos.x, this.ballStartPos.y, 'probe2');
        this.ball2.anchor.set(0.5);
        this.physics.enable(this.ball2, Phaser.Physics.ARCADE);
        this.ball2.body.bounce.set(0.7, 0.7);
        //
        this.ball3 = this.add.sprite(this.ballStartPos.x + 100, this.ballStartPos.y, 'probe3');
        this.ball3.anchor.set(0.5);
        this.physics.enable(this.ball3, Phaser.Physics.ARCADE);
        this.ball3.body.bounce.set(0.7, 0.7);
        //
        this.keys = this.game.input.keyboard.createCursorKeys();
        //
        this.borderGroup = this.add.group();
        this.borderGroup.enableBody = true;
        this.borderGroup.physicsBodyType = Phaser.Physics.ARCADE;
        this.borderGroup.create(0, 0, 'border-horizontal');
        this.borderGroup.create(0, Verisurf._HEIGHT - 2, 'border-horizontal');
        this.borderGroup.create(0, 0, 'border-vertical');
        this.borderGroup.create(Verisurf._WIDTH - 2, 0, 'border-vertical');
        this.borderGroup.setAll('body.immovable', true);
        //
        this.bounceSound = this.game.add.audio('audio-bounce');
        //debugging text
        var font_style = {font: "bold 24px Courier New", fill: "#000", boundsAlignH: "left", boundsAlignV: "top"};
        this.dro = game.add.text(20, 20, "", font_style);
        this.dro.setTextBounds(20, 20, Verisurf._WIDTH, Verisurf._HEIGHT);
    },
    update: function () {
        //
        this.updateDRO();
        //verisurf device movement
        this.ball1.body.velocity.x += limitValue(verisurf_i * 2, -1, 1) * this.movementForce;
        this.ball1.body.velocity.y -= limitValue(verisurf_j * 2, -1, 1) * this.movementForce;
        //keyboard movement
        if (this.keys.left.isDown) {
            this.ball2.body.velocity.x -= this.movementForce;
        }
        else if (this.keys.right.isDown) {
            this.ball2.body.velocity.x += this.movementForce;
        }
        if (this.keys.up.isDown) {
            this.ball2.body.velocity.y -= this.movementForce;
        }
        else if (this.keys.down.isDown) {
            this.ball2.body.velocity.y += this.movementForce;
        }
        //mouse movement
        if (game.input.mousePointer.isDown) {
            if (Phaser.Rectangle.contains(this.ball3.body, this.input.x, this.input.y) == false) {
                this.physics.arcade.moveToPointer(this.ball3, this.movementForce * 25);
            }
        }
        //ball to border collisions
        this.physics.arcade.collide(this.ball1, this.borderGroup, this.wallCollision, null, this);
        this.physics.arcade.collide(this.ball2, this.borderGroup, this.wallCollision, null, this);
        this.physics.arcade.collide(this.ball3, this.borderGroup, this.wallCollision, null, this);
        //ball to ball collisions
        this.physics.arcade.collide(this.ball1, this.ball2, this.wallCollision, null, this);
        this.physics.arcade.collide(this.ball1, this.ball3, this.wallCollision, null, this);
        this.physics.arcade.collide(this.ball2, this.ball3, this.wallCollision, null, this);
        //
        alternate = !alternate;
        if(alternate)
        {
            this.ball_1_trail.context.fillRect(this.ball1.x, this.ball1.y, 2, 2);
            this.ball_2_trail.context.fillRect(this.ball2.x, this.ball2.y, 2, 2);
            this.ball_3_trail.context.fillRect(this.ball3.x, this.ball3.y, 2, 2);
        }
    },
    render: function () {
    },
    wallCollision: function () {
        this.bounceSound.play();
    },
    updateDRO: function () {
        var text = "";
        text += "X: ";
        text += formatDRONumber(verisurf_x);
        text += "\n";
        text += "Y: ";
        text += formatDRONumber(verisurf_y);
        text += "\n";
        text += "Z: ";
        text += formatDRONumber(verisurf_z);
        text += "\n";
        text += "I: ";
        text += formatDRONumber(verisurf_i);
        text += "\n";
        text += "J: ";
        text += formatDRONumber(verisurf_j);
        text += "\n";
        text += "K: ";
        text += formatDRONumber(verisurf_k);
        text += "\n";
        this.dro.setText(text);
    },
    clearTrails: function () {
        this.ball1.body.velocity.x = 0;
        this.ball1.body.velocity.y = 0;
        this.ball2.body.velocity.x = 0;
        this.ball2.body.velocity.y = 0;
        this.ball3.body.velocity.x = 0;
        this.ball3.body.velocity.y = 0;
        //
        this.ball_1_trail.clear();
        this.ball_2_trail.clear();
        this.ball_3_trail.clear();
    }
};