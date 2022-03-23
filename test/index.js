const ws = require('ws');

const server = new ws.Server({port: 8080});

server.on("listening", () => {
    console.log("서버가 열렸습니다!");
});

server.on("connection", (socket) =>{
    socket.send("Hello World");

    socket.on("message", (message) => {
        console.log(message.tostring());
        
    });
});
