using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WebSocketSharp;

public class client : MonoBehaviour
{
    [SerializeField] InputField input = null;
    WebSocket webSocket = null;
    // Start is called before the first frame update
    void Start()
    {
        webSocket = new WebSocket("ws://127.0.0.1:8080");
        webSocket.OnOpen += (sender, e) =>
        {
            Debug.Log("서버에 연결됨");
        };

        webSocket.OnMessage += (sender, e) =>
        {
            Debug.Log(e.Data);
        };
        webSocket.Connect();
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
