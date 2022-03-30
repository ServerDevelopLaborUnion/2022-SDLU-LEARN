const { WebSocketServer } = require("ws");
const ws = require("ws");

const server = new ws.Server({port:8080});

let number = 0;
server.on("listening",()=>{
    console.log("서버가 열렸습니다!");
});

server.on("connection", (socket) => {
    console.log("클라이언트가 접속했습니다!");
    client.id = number++;
    client.on("message", (message)=>{
        Wss.clients.forEach((client)=> {
            client.send(client.id + ": " + message.toString());
        });
    });
});
