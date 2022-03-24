const ws = require('ws');

const server = new ws.Server({port: 8080});
let count = 0;

server.on("listening", () => {
    console.log("서버가 열렸습니다!");
});

server.on("connection", (socket) => {
    socket.id = count++;
    console.log(socket.id + " 클라이언트가 접속했습니다!");
    socket.on("message", (message) => {
        console.log(socket.id + ": " + message.toString());
        socket.send(message.toString());
    });
});
