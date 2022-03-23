const ws = require('ws');

const server = new ws.Server({port: 8922});

server.on("listening", () => {
    console.log("서버가 열렸습니다!");
});

server.on("connection", (socket) => {
    socket.on("message", (a) => {
        socket.send(a.toString());
    });
});