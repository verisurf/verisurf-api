const {app, BrowserWindow} = require('electron');

let mainWindow;

app.on('ready', function () {
    mainWindow = new BrowserWindow({
        height: 600,
        width: 800
    });

    mainWindow.loadURL('file://' + __dirname + '/app.html');
});
