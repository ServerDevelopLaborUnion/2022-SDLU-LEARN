const ws = require("ws");//ws모듈 사용 가능하게 해주는 코드

const server = new ws.Server({port:8080});//8080포트로 웹소켓서버 열기

server.on("listening",()=>{ //서버가 실행되었을때
    console.log("서버가 열렸습니다!");//출력
});

server.on("connection", (client) => {//서버에 클라이언트가 접속했을때
    console.log("클라이언트가 접속했습니다!");//출력
    client.on("message", (message)=>{//클라이언트가 메세지를 보냈을때
        client.send(message.toString());//클라이언트에 저장된 변수를 문자열로 보내주는코드
    });
});
