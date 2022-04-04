const ws = require("ws");
const wss = new ws.Server({port: 8081});
let cnt = 0;
wss.on("listening", () => {
    console.log("서버가 8081번 포트에서 열렸습니다!");
});

wss.on("connection", (client) => {
    console.log("누군가가 연결했습니다!");;
    client.id = cnt++;
    client.on("message", (message) => {
        console.log(message.toString());
        wss.clients.forEach((targetclient) => {
            targetclient.send(client.id + ": " + message.toString());
        });
    });
});