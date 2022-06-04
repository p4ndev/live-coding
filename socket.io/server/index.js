const createServer = require("http").createServer;
const Server = require("socket.io").Server;

const httpServer = createServer();
const io = new Server(httpServer);

const { v4 : uuidv4 } = require('uuid');
var _users = [];

io.on("connection", (socket) => {
    
    socket.on("IN", (name, date) => {
        _users.push(name);
        console.log("User connected: " + name);
        console.log("Established at: " + date);
        console.log("------------------------------------------------");
    });

    socket.on("OUT", (name, date) => {
        _users = _users.filter(x => x != name);
        console.log("User disconnected: " + name);
        console.log("Established at: " + date);
        console.log("------------------------------------------------");
    });

});

setInterval(() => {
    if(_users.length > 0){
        let tmp = "Snapshot # " + uuidv4();
        console.log(tmp);
        console.log(_users.toString());
        io.emit("BKP", tmp);
        console.log("------------------------------------------------");
    }
}, 15000);

httpServer.listen(
    3000, () => {
        console.log("Server started on port 3000");
        console.log("------------------------------------------------");
    }
);