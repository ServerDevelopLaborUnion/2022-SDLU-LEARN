using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using UnityEngine.UI;

public class client : MonoBehaviour
{
    WebSocket websocket = null;
    [SerializeField] InputField input = null;
    void Start()
    {
        websocket = new WebSocket("ws://172.31.1.60:8080");

        websocket.OnOpen += (sender, e) =>
        {
            Debug.Log("서버에 연결");
            websocket.Send("ㅎㅇ");
        };

        websocket.OnMessage += (sender, e) =>
        {
            Debug.Log(e.Data);
        };


        websocket.Connect();
    }

    public void SendChat()
    {
        websocket.Send(input.text);
    }
    void Update()
    {
        
    }
}
