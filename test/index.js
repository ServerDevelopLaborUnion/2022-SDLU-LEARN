const ws = require('ws');

const server = new ws.Server({port: 8080});

server.on("listening", () => { //listening == 서버가 열렸을 때
    console.log("서버가 열렸습니다!");
});

server.on("connection", (soket) => { 
    soket.send("Hello World"); //클라한테 메시지 보내기

    soket.on("message", (message) => {
        soket.send(message.toString()); 
    });
});