const ws = require('ws');

const server = new ws.Server({port: 8080});

server.on("listening", () => { //listening == 서버가 열렸을 때
    console.log("서버가 열렸습니다!");
});

server.on("connection", (soket) => { 
    soket.send("Hello World"); //클라한테 메시지 보내기
    console.log("클라이언트가 접속했습니다!");

    soket.on("message", (message) => { //메시지 이벤트
    
        console.log(message.toString());
        soket.send(message.toString()); 
    });
});