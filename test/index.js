const ws = require('ws');

const server = new ws.Server({port: 8922});

server.on("listening", () => {
	console.log("서버가 열렸습니다!");
});
server.on("connection", (client) => {
	console.log("클라이언트가 접속했습니다.")

	client.on("message", (a) => {
		console.log(a.toString());
		client.send("메세지가 정상적으로 전달되었습니다.");
	});
});
