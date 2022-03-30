const ws = require('ws');

const server = new ws.Server({port: 8080});

server.on("listening", () => {
    console.log("서버가 열렸습니다!");
});

server.on("connection", (socket) => {
    console.log(socket.id + " 클라이언트가 접속했습니다!");
    socket.on("message", (message) => {
        console.log(message.toString());
        socket.send(message.toString());
    });
});
