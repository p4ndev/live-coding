const io        = require("socket.io-client");
const url       = "http://localhost:3000";
const readLine  = require("readline");
var socket      = io.connect(url);
var username    = "";

const wrapper = readLine.createInterface({
    input: process.stdin,
    output: process.stdout
});

socket.on("connect", () => {
    wrapper.question("Your client name: ", (name) => {
        username = name;
        socket.emit("IN", username, new Date());
    });
});

socket.on("BKP", (msg) => console.log(msg));

wrapper.on("close", () => {
    socket.emit("OUT", username, new Date());
    socket.disconnect();
    process.exit();
});