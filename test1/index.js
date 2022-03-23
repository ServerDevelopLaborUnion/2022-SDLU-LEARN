console.log("Hello World");
const { Socket } = require('dgram');
const ws =require('ws');

const server = new ws.Server({port: 8080});

server.on("listening", () =>{
    console.log("서버가 열렸습니다!");
});
server.on("connection", (Socket) =>{
Socket.send("Hello World!");

Socket.on("mesage", (message)=> {
console.log(message.tostring());
 });
});
