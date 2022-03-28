using UnityEngine;
using WebSocketSharp;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    [SerializeField] InputField input = null;
    WebSocket webSocket = null;

    void Start()
    {
        webSocket = new WebSocket("ws://172.31.1.60:8080");
        webSocket.OnOpen += (sender, e) =>
        {
            Debug.Log("������ �����"); 
            webSocket.Send("����");
        };

        webSocket.OnMessage += (sender, e) =>
        {
            Debug.Log(e.Data);
        };
        webSocket.ConnectAsync();
    }

    public void SendChat()
    {
        webSocket.Send(input.text);
    }
}
