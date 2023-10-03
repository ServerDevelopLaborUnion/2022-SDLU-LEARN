const ws = require('ws'); //ws 변수에 ws 모듈 추가

const _ws = new ws.Server({port : 8080}); //포트 8080 지정

_ws.on("listening", () => { //8080포트에 서버 연결
    console.log("8080포트에 서버가 연결되었습니다.");
})

_ws.on("connection", (client) => { //클라이언트에 웹소켓 연결
    console.log("클라이언트에 연결되었습니다.") //클라이언트가 웹소켓 서버에 연결 되었을 때 출력

    client.on("message", messages => { //클라이언트가 연결 되었을 때 클라이언트에서 보내면 보낸 메세지를 messages 변수에 저장
        client.send(messages.toString()) //클라이언트에 저장된 messages 변수 출력
        console.log(messages.toString()); //서버 콘솔창에 저장된 messages 변수 출력
    });
})
