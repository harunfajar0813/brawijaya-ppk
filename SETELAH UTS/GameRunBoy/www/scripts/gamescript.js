(function () {
    var knight,
        knightImage,
        zombie = [],
        numZombie = 3,
        numBush = 4,
        numTree = 2,
        velocity = 1,
        score = 0,
        jumping = false,
        jumpHeight = 210,
        level = 1,
        gameOver = "",
        btnRestart,
        btnRestartImage,
        btnPause,
        btnPauseImage,
        btnResume,
        btnResumeImage,
        life = 3,
        bgm,
        bgmGameOver,
        animation = "",
        isShowBtnRestart = false,
        bush = [],
        bushImage,
        tree = [],
        treeImage,
        heart = [],
        heartImage,
        canvas;

    function gameLoop() {
        animation = requestAnimationFrame(gameLoop);

        canvas.getContext("2d").clearRect(0, 0, canvas.width, canvas.height);

        var i;
        for (i = 0; i < tree.length; i++) {
            tree[i].update();
            tree[i].x -= velocity / 2;
            tree[i].render();
        }

        knight.update();
        knight.x -= level * velocity;
        if (knight.x < -128) {
            knight.x = canvas.width + Math.round(Math.random() * canvas.width);
        }
        knight.render();

        for (i = 0; i < life; i++) {
            heart[i].update();
            heart[i].render();
        }

        for (i = 0; i < zombie.length; i++) {
            zombie[i].update();
            zombie[i].x -= level * velocity;
            zombie[i].render();

            if (zombie[i].x < -128) {
                destroyZombie(zombie[i]);
                setTimeout(spawnZombie, 1000);
                life--;
            }

            if (score > level * 5) {
                level++;
            }
        }

        for (i = 0; i < bush.length; i++) {
            bush[i].update();
            bush[i].x += velocity / 2;
            bush[i].render();

            if (bush[i].x > canvas.width + 65) {
                bush[i].x = -80 - Math.floor(Math.random() * 3 + 1);
            }
        }

        if (life < 1) {
            life = 0;
            knightImage.src = "images/character/knight_dead.png";
            knight.w = 2640;
            gameOver = "Game Over";
            bgm.pause();
            bgm.currentTime = 0;
            isShowBtnRestart = true;

            bgmGameOver.play();
            btnRestart.update();
            btnRestart.render();

            setTimeout(stopAnimation, 600);
        }

        isShowBtnPause = true;
        btnPause.update();
        btnPause.render();

        isShowBtnResume = true;
        btnResume.update();
        btnResume.render();

        drawHud();
    }

    function stopAnimation() {
        cancelAnimationFrame(animation);
    }


    function drawHud() {
        var context = canvas.getContext("2d");

        context.font = "bold 20px Consolas";
        context.textAlign = "start";
        context.fillStyle = "white";
        context.fillText("Score: " + score, canvas.width - 275, 40);

        context.font = "bold 20px Consolas";
        context.textAlign = "start";
        context.fillStyle = "white";
        context.fillText("Level: " + level, canvas.width - 125, 40);
        context.fillText("Credits : Harun Ulum Fajar", canvas.width - 300, 60);
        context.fillText("185150207111011", canvas.width - 300, 80);

        context.font = "bold 20px Consolas";
        context.textAlign = "start";
        context.fillStyle = "white";
        context.fillText("Life: ", 30, 40);

        context.font = "bold 50px Consolas";
        context.textAlign = "center";
        context.fillStyle = "#193439";
        context.fillText(gameOver, context.canvas.width / 2, context.canvas.height / 2 - 32);
    }

    function land() {
        jumping = false;
        knight.y = canvas.height - 210;
        knightImage.src = "images/character/knight_run.png";
    }

    function sprite(options) {
        var that = {},
            frameIndex = 0,
            tickCount = 0,
            tickPerFrame = options.tickPerFrame || 0,
            numberOfFrame = options.numberOfFrame || 1;

        that.context = options.context;
        that.w = options.w;
        that.h = options.h;
        that.img = options.img;
        that.x = options.x;
        that.y = options.y;
        that.scaleRatio = 1;

        that.update = function () {
            tickCount += 1;

            if (tickCount > tickPerFrame) {
                tickCount = 0;

                if (frameIndex < numberOfFrame - 1) {
                    frameIndex += 1;
                } else {
                    frameIndex = 0;
                }
            }
        };

        that.render = function () {

            that.context.drawImage(
                that.img,
                frameIndex * that.w / numberOfFrame,
                0,
                that.w / numberOfFrame,
                that.h,
                that.x,
                that.y,
                that.w / numberOfFrame,
                that.h
            );

        };

        that.getFrameWidth = function () {
            return that.w / numberOfFrame;
        }

        return that;
    }

    canvas = document.getElementById("cnv");
    canvas.width = 1024;
    canvas.height = 480;

    knightImage = new Image();

    knight = sprite({
        context: canvas.getContext("2d"),
        w: 1740,
        h: 210,
        img: knightImage,
        numberOfFrame: 10,
        tickPerFrame: 5,
        x: canvas.width,
        y: canvas.height - 210
    });

    btnRestartImage = new Image();

    btnRestart = sprite({
        context: canvas.getContext("2d"),
        w: 128,
        h: 64,
        img: btnRestartImage,
        numberOfFrame: 1,
        tickPerFrame: 1,
        x: canvas.width / 2 - 70,
        y: canvas.height / 2 - 10
    });

    btnPauseImage = new Image();
    btnPause = sprite({
        context: canvas.getContext("2d"),
        w: 30,
        h: 30,
        img: btnPauseImage,
        numberOfFrame: 1,
        tickPerFrame: 1,
        x: canvas.width - 350,
        y: 20
    });

    btnResumeImage = new Image();
    btnResume = sprite({
        context: canvas.getContext("2d"),
        w: 30,
        h: 30,
        img: btnResumeImage,
        numberOfFrame: 1,
        tickPerFrame: 1,
        x: canvas.width - 425,
        y: 20
    });


    function destroyZombie(param) {
        var i;
        for (i = 0; i < zombie.length; i++) {
            if (zombie[i] === param) {
                zombie[i] = null;
                zombie.splice(i, 1);
                break;
            }
        }
    }

    function spawnZombie() {
        var zombieIndex,
            zombieImage;

        zombieImage = new Image();
        zombieIndex = zombie.length;

        zombie[zombieIndex] = sprite({
            context: canvas.getContext("2d"),
            w: 1740,
            h: 210,
            img: zombieImage,
            numberOfFrame: 10,
            tickPerFrame: Math.floor(Math.random() * 8) + 5
        });

        if ((zombieIndex % 2) == 1) {
            zombieImage.src = "images/character/zombie_female_run.png";
        } else {
            zombieImage.src = "images/character/zombie_run.png";
        }

        zombie[zombieIndex].x = canvas.width + Math.random() * (canvas.width - zombie[zombieIndex].getFrameWidth() * zombie[zombieIndex].scaleRatio);
        zombie[zombieIndex].y = canvas.height - 210;
        zombie[zombieIndex].scaleRatio = Math.random() * 0.5 + 0.5;
    }

    function spawnBush() {
        var bushIndex,
            bushImage;

        bushImage = new Image();
        bushIndex = bush.length;

        bush[bushIndex] = sprite({
            context: canvas.getContext("2d"),
            img: bushImage,
            w: 0,
            h: 0,
            x: 0,
            y: 0,
            numberOfFrame: 1,
            tickPerFrame: 1
        });

        bush[bushIndex].x = 0 + Math.random() * (canvas.width - bush[bushIndex].getFrameWidth() * bush[bushIndex].scaleRatio);

        if (bushIndex == 0) {
            bush[bushIndex].w = 133;
            bush[bushIndex].h = 66;
            bush[bushIndex].y = canvas.height - 62;
        }
        if (bushIndex == 1) {
            bush[bushIndex].w = 73;
            bush[bushIndex].h = 47;
            bush[bushIndex].y = canvas.height - 45;
        }
        if (bushIndex == 2) {
            bush[bushIndex].w = 54;
            bush[bushIndex].h = 55;
            bush[bushIndex].y = canvas.height - 53;
        }
        if (bushIndex == 3) {
            bush[bushIndex].w = 53;
            bush[bushIndex].h = 76;
            bush[bushIndex].y = canvas.height - 74;
        }

        bush[bushIndex].scaleRatio = Math.random() * 0.5 + 0.5;
        bushImage.src = "images/bush/bush" + bushIndex + ".png";
    }

    function spawnTree() {
        var treeIndex,
            treeImage;

        treeImage = new Image();
        treeIndex = tree.length;

        tree[treeIndex] = sprite({
            context: canvas.getContext("2d"),
            w: 282,
            h: 301,
            img: treeImage,
            numberOfFrame: 1,
            tickPerFrame: 1
        });

        if (treeIndex == 1) {
            tree[treeIndex].y = canvas.height - 275;
        } else {
            tree[treeIndex].y = canvas.height - 301;
        }
        tree[treeIndex].x = canvas.width + Math.random() * (canvas.width - tree[treeIndex].getFrameWidth() * tree[treeIndex].scaleRatio);
        tree[treeIndex].scaleRatio = Math.random() * 0.5 + 0.5;

        treeImage.src = "images/tree/tree" + treeIndex + ".png";
    }

    function spawnHeart() {
        var heartIndex,
            heartImage;

        heartImage = new Image();
        heartIndex = heart.length;

        heart[heartIndex] = sprite({
            context: canvas.getContext("2d"),
            w: 32,
            h: 27,
            img: heartImage,
            numberOfFrame: 1,
            tickPerFrame: 1
        });

        if (heartIndex == 0) {
            heart[heartIndex].x = 100;
        }
        if (heartIndex == 1) {
            heart[heartIndex].x = 140;
        }
        if (heartIndex == 2) {
            heart[heartIndex].x = 180;
        }
        heart[heartIndex].y = 22;
        heart[heartIndex].scaleRatio = Math.random() * 0.5 + 0.5;

        heartImage.src = "images/heart/heart.png";
    }

    function tap(e) {
        var i,
            loc = {},
            dist,
            distBtnRestart,
            distKnight,
            zombieToDestroy = [],
            pos = getElementPosition(canvas),
            tapX = e.targetTouches ? e.targetTouches[0].pageX : e.pageX,
            tapY = e.targetTouches ? e.targetTouches[0].pageY : e.pageY,
            canvasScaleRatio = canvas.width / canvas.offsetWidth;

        loc.x = (tapX - pos.x) * canvasScaleRatio;
        loc.y = (tapY - pos.y) * canvasScaleRatio;

        console.log("curX:" + loc.x + "curY:" + loc.y);

        for (i = 0; i < zombie.length; i++) {
            dist = distance({
                x: (zombie[i].x + zombie[i].getFrameWidth() / 2 * zombie[i].scaleRatio),
                y: (zombie[i].y + zombie[i].getFrameWidth() / 2 * zombie[i].scaleRatio)
            }, {
                    x: loc.x,
                    y: loc.y
                });

            if (dist < zombie[i].getFrameWidth() / 2 * zombie[i].scaleRatio) {
                zombieToDestroy.push(zombie[i]);
                console.log(zombie[i].x);
            }
        }

        for (i = 0; i < zombieToDestroy.length; i++) {
            destroyZombie(zombieToDestroy[i]);
            setTimeout(spawnZombie, 1000);
        }

        if (zombieToDestroy.length) {
            score++;
        }

        distBtnRestart = distance(
            {
                x: (btnRestart.x + btnRestart.getFrameWidth() / 2 * btnRestart.scaleRatio),
                y: (btnRestart.y + btnRestart.getFrameWidth() / 2 * btnRestart.scaleRatio)
            }, {
                x: loc.x,
                y: loc.y
            }
        );

        if ((distBtnRestart < btnRestart.getFrameWidth() / 2 * btnRestart.scaleRatio) && isShowBtnRestart) {
            document.location.reload();
        }

        distBtnPause = distance(
            {
                x: (btnPause.x + btnPause.getFrameWidth() / 2 * btnPause.scaleRatio),
                y: (btnPause.y + btnPause.getFrameWidth() / 2 * btnPause.scaleRatio)
            }, {
                x: loc.x,
                y: loc.y
            }
        );

        if ((distBtnPause < btnPause.getFrameWidth() / 2 * btnPause.scaleRatio) && isShowBtnPause) {
            gameOver = "Paused";
            setTimeout(stopAnimation, 600);
        }

        distBtnResume = distance(
            {
                x: (btnResume.x + btnResume.getFrameWidth() / 2 * btnResume.scaleRatio),
                y: (btnResume.y + btnResume.getFrameWidth() / 2 * btnResume.scaleRatio)
            }, {
                x: loc.x,
                y: loc.y
            }
        );

        if ((distBtnResume < btnResume.getFrameWidth() / 2 * btnResume.scaleRatio) && isShowBtnResume) {
            gameOver = "";
            animation = requestAnimationFrame(gameLoop);
        }

        distKnight = distance(
            {
                x: (knight.x + knight.getFrameWidth() / 2 * knight.scaleRatio),
                y: (knight.y + knight.getFrameWidth() / 2 * knight.scaleRatio)
            }, {
                x: loc.x,
                y: loc.y
            }
        );

        if (distKnight < knight.getFrameWidth() / 2 * knight.scaleRatio) {
            knight.x = canvas.width + Math.round(Math.random() * canvas.width);
            life--;
        }
    }

    function getElementPosition(element) {
        var parentOffset,
            pos = {
                x: element.offsetLeft,
                y: element.offsetTop
            }

        if (element.offsetParent) {
            parentOffset = getElementPosition(element.offsetParent);
            pos.x += parentOffset.x;
            pos.y += parentOffset.y;
        }

        return pos;
    }

    function distance(p1, p2) {
        var dx = p1.x - p2.x,
            dy = p1.y - p2.y;

        return Math.sqrt(dx * dx + dy * dy);
    }


    for (i = 0; i < numZombie; i++) {
        spawnZombie();
    }

    for (i = 0; i < numBush; i++) {
        spawnBush();
    }

    for (i = 0; i < numTree; i++) {
        spawnTree();
    }

    for (i = 0; i < life; i++) {
        spawnHeart();
    }

    gameLoop();
    knightImage.src = "images/character/knight_run.png";
    btnRestartImage.src = "images/button/btnRestart.png";
    btnPauseImage.src = "images/button/btnPause.png";
    btnResumeImage.src = "images/button/btnResume.png";

    bgm = new Audio("media/gracetheroof.mp3");
    bgm.loop = true;
    bgm.play();
    bgmGameOver = new Audio("media/gameover.mp3");

    canvas.addEventListener("mousedown", tap);
    canvas.addEventListener("touchstart", tap);
}());
