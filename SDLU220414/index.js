const ws = require('ws'); //ws package 
const server = new ws.Server({port:6090}); //웹소켓 서버 port:6090 을 server로 선언

//이벤트 = 무언가 했을 때(클릭, 접속 등) 어떤 사건을 발생시키는 것 

server.on ("listening", () => { //리스닝 이벤트 (서버가 열렸을 때)
    console.log("서버 열림"); //"서버 열림" 출력
});

server.on("connection", (socket) => { //커넥션 이벤트 (소켓(=클라이언트) 이 서버에 연결했을 때)
    console.log("클라이언트가 연결함"); //"클라이언트가 연결함" 출력

    socket.on ("message", (message) => { //메시지 이벤트 (소켓(=클라이언트) 이 메시지를 보냈을 때)
        console.log(message.toString()); //가공되지 않은 RawData를 String으로 변환하여 출력
        socket.send(message.toString()); //가공되지 않은 RawData를 String으로 변환하여 소켓(=클라이언트) 에게 보냄
    });
});

