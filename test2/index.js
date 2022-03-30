const ws = require("ws");

const wss = new ws.Server({ port: 8080 });
//                                              172.31.1.60
let number = 0;

wss.on("listening", () => {
    console.log("서버가 8080번 포트에서 열렸습니다");
});

wss.on("connection", (client) => {
    console.log("누군가가 연결했습니다");
    client.id = number++;
    client.on("message", (message) => {
        console.log(client.id + ": " + message.toString());
        wss.clients.forEach((targetClient) => {
            targetClient.send(client.id + ": " + message.toString());
        });
    });
});
