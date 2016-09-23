Verisurf.Game = function (game) {
};
Verisurf.Game.prototype = {
    create: function () {
        this.timerInitial = 10;
        this.timerAmount = 5;
        //tiled background
        this.add.tileSprite(0, 0, 1920, 1080, 'background');
        //
        this.add.sprite(Verisurf._WIDTH * 0.5 - 50, Verisurf._HEIGHT - 100, 'cube');
        //
        this.beep = game.add.audio('beep');
        this.ding = game.add.audio('ding');
        //
        this.points = [];
        this.bounds = [];
        //debugging text
        var font_style = {font: "bold 24px Courier New", fill: "#000", boundsAlignH: "center", boundsAlignV: "top"};
        this.instructions = game.add.text(0, 50, "", font_style);
        this.instructions.setTextBounds(0, 50, Verisurf._WIDTH, Verisurf._HEIGHT);
        //
        font_style = {font: "bold 16px Courier New", fill: "#000", boundsAlignH: "center", boundsAlignV: "top"};
        this.instructions2 = game.add.text(0, 150, "", font_style);
        this.instructions2.setTextBounds(0, 50, Verisurf._WIDTH, Verisurf._HEIGHT);
        //
        this.playing = false;
        this.setupStart();
        //
        this.audioFrequency = 0;
        this.audioCounter = 0;
        this.normalFrequency = 200;
    },
    update: function () {
    },
    render: function () {
        if (this.timer !== null) {
            game.debug.text(this.formatTime(Math.round((this.timerEvent.delay - this.timer.ms) / 1000)), 370, 320, "#000");
        }
        if (this.playing == true) {
            if(this.points.length == 0)
            {
                this.instructions.setText("Verisurf Audio Point Detection\nPhase 3: Winning");
                this.instructions2.setText("You are the very best, you win!\nWe never doubted you.");
            }
            else
            {
                var result = this.scoutPoints();
                if(result.frequency == 0)
                {
                    this.ding.play('', 0, 0.5);
                    this.points.splice(result.index,1);
                    this.audioFrequency = this.normalFrequency;
                    console.log("POINT FOUND: POINT "+result.index);
                }
                else
                {
                    if(result.frequency == 1)
                        this.audioFrequency = 10;
                    else if(result.frequency == 2)
                        this.audioFrequency = 25;
                    else if(result.frequency == 3)
                        this.audioFrequency = 50;
                    else if(result.frequency == 4)
                        this.audioFrequency = 100;
                    else if(result.frequency == 5)
                        this.audioFrequency = this.normalFrequency;

                    if (this.audioCounter >= this.audioFrequency) {
                        this.beep.play('', 0, 0.5);
                        this.audioCounter = 0;
                    }
                    else
                        this.audioCounter++;
                }
                game.debug.text("Points Remaining: " + this.points.length, 300, 300, "#000");
            }
        }
    },
    scoutPoints: function () {
        global_x = parseFloat(verisurf_x);
        global_y = parseFloat(verisurf_y);
        var closest = {index:-1,distance:1000};
        for(var i =0;i<this.points.length;i++)
        {
            var dx = global_x - this.points[i].x;
            var dy = global_y - this.points[i].y;
            var distance = Math.sqrt(dx*dx + dy*dy);

            if(distance < closest.distance)
                closest = {index:i,distance:distance};
        }

        if(closest.distance < 0.5)
            return {index:closest.index,frequency:0};
        else if(closest.distance < 1.0)
            return {index:closest.index,frequency:1};
        else if(closest.distance < 1.5)
            return {index:closest.index,frequency:2};
        else if(closest.distance < 2.0)
            return {index:closest.index,frequency:3};
        else if(closest.distance < 2.5)
            return {index:closest.index,frequency:4};
        else
            return {index:closest.index,frequency:5};
    },
    setupStart: function () {
        this.instructions.setText("Verisurf Audio Point Detection\nPhase 1: Settings Bounds");
        this.instructions2.setText("First we have to set the playing field to do so\nyou'll need to move your device as instructed.\n\n       Move your device to the LEFT now (-X)");
        this.timer = game.time.create();
        this.timerEvent = this.timer.add(Phaser.Timer.SECOND * this.timerInitial, this.setupStep2, this);
        this.timer.start();
    },
    setupStep2: function () {
        this.ding.play('', 0, 0.5);
        this.bounds.push(parseFloat(verisurf_x));
        this.timer = game.time.create();
        this.instructions2.setText("First we have to set the playing field to do so\nyou'll need to move your device as instructed.\n\n      Move your device to the RIGHT now (+X)");
        this.timerEvent = this.timer.add(Phaser.Timer.SECOND * this.timerAmount, this.setupStep3, this);
        this.timer.start();
    },
    setupStep3: function () {
        this.ding.play('', 0, 0.5);
        this.bounds.push(parseFloat(verisurf_x));
        this.timer = game.time.create();
        this.instructions2.setText("First we have to set the playing field to do so\nyou'll need to move your device as instructed.\n\n    Move your device TOWARDS yourself now (-Y)");
        this.timerEvent = this.timer.add(Phaser.Timer.SECOND * this.timerAmount, this.setupStep4, this);
        this.timer.start();
    },
    setupStep4: function () {
        this.ding.play('', 0, 0.5);
        this.bounds.push(parseFloat(verisurf_y));
        this.timer = game.time.create();
        this.instructions2.setText("First we have to set the playing field to do so\nyou'll need to move your device as instructed.\n\n   Move your device AWAY from yourself now (+Y)");
        this.timerEvent = this.timer.add(Phaser.Timer.SECOND * this.timerAmount, this.setupComplete, this);
        this.timer.start();
    },
    setupComplete: function () {
        this.ding.play('', 0, 0.5);
        this.bounds.push(parseFloat(verisurf_y));
        if (this.bounds[0] < this.bounds[1] && this.bounds[2] < this.bounds[3]) {
            this.startGame();
            this.timer = null;
            this.instructions.setText("Verisurf Audio Point Detection\nPhase 2: Point Detection");
            this.instructions2.setText("The points have now been randomly placed in the area\nuse audio cues to find the points within the bounds");
        }
        else {
            this.bounds = [];
            this.timer = game.time.create();
            this.instructions2.setText("    The device bounds were invalid.\n\nSetup will restart once the timer expires");
            this.timerEvent = this.timer.add(Phaser.Timer.SECOND * this.timerInitial, this.setupStart, this);
            this.timer.start();
        }
    },
    startGame: function () {
        this.createPoints();
        this.playing = true;
        this.audioFrequency = this.normalFrequency;

        console.log(this.points);
    },
    createPoints: function () {
        for (var i = 0; i < 5; i++)
            this.points.push({
                x: this.rangeRandom(this.bounds[0], this.bounds[1]),
                y: this.rangeRandom(this.bounds[2], this.bounds[3])
            });
    },
    formatTime: function (s) {
        // Convert seconds (s) to a nicely formatted and padded time string
        var minutes = "0" + Math.floor(s / 60);
        var seconds = "0" + (s - minutes * 60);
        return minutes.substr(-2) + ":" + seconds.substr(-2);
    },
    rangeRandom: function (min, max) {
        var range = max-min;
        var rangeValue = Math.random() * range;
        return min + rangeValue;
    }
};