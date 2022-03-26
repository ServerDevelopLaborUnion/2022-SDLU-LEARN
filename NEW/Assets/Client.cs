using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    [SerializeField] InputField input = null;
    WebSocket webSocket = null;
    // Start is called before the first frame update
    void Start()
    {
        webSocket = new WebSocket("ws://172.31.1.60:8080");

        webSocket.OnOpen += (sender, e) =>
        {
            Debug.Log("서버에 연결됨");
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

    // Update is called once per frame
    void Update()
    {

    }
}
