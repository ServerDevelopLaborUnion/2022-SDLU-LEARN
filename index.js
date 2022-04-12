const ws = require('ws'); 
const fs = require('fs');

const wss = new ws.Server({port:8080}); 

let scores = {}; //Dictionary


const file = "./save.json" //디렉토리 경로입력

if(fs.existsSync(file))  //Directory 존재 여부 체크
{
    scores = JSON.parse(fs.readFileSync(file)) //파일 정보 읽기
}

function sendScores(socket){
    socket.send(Object.keys(scores).map((key) => {
        return key + "," + scores[key];
    }).join("|"));
}

wss.on('listening', () => { //서버가 켜졌을 때
    console.log("서버가 시작되었습니다!");
});

wss.on('connection', socket => { //클라가 연결했을 때
    console.log('유저가 접속!');
    socket.on('message', message => {
        const type = message.toString().split(':')[0]; // 소켓이 보낸 메시지를 ':' 을 기준으로 나눔

        switch (type)
        {
            case "score": 
                const data = message.toString().split(':')[1]; // ':' 을 기준으로 나누어 data 저장
                const nickname = data.split(",")[0]; //data를 ',' 를 기준으로 나누어 nickname 저장
                const score = data.split(",")[1]; //data 를 ',' 를 기준으로 나누어 score 저장

                scores[nickname] = score; //scores[nickname] 형식으로 score에 담는다
                wss.clients.forEach(client => { 
                    sendScores(client); 
                })
                fs.writeFileSync(file, JSON.stringify(scores)); //JSON.stringify -> JSON 문자열로 변환하는 메서드
                break;

            case "get": 
                sendScores(socket);
                break;
               
        }
    });
});