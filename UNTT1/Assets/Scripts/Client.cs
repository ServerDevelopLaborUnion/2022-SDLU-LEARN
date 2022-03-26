using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WebSocketSharp;

public class Client : MonoBehaviour
{
    WebSocket webSocket = null;

    [SerializeField] InputField input = null;

    void Start()
    {
        webSocket = new WebSocket("ws://172.31.1.60:8080");

        webSocket.OnOpen += (sender, e) =>
        {
            Debug.Log("서버에 연걸됨");
            webSocket.Send("Hello World!");
        };

        webSocket.OnMessage += (sender, e) =>
        {
            Debug.Log(e.Data);
        };

        webSocket.Connect();
    }

    //void Update()
    //{
    //    webSocket.Send(input.text);
    //}

    public void SendChat()
    {
        webSocket.Send(input.text);
    }
}
