using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WebSocketSharp;
public class client : MonoBehaviour
{
    [SerializeField] InputField input = null;
   WebSocket websocket = null;
    void Start()
    {
        websocket = new WebSocket("ws://172.31.1.60:8080");
        websocket.OnOpen += (sender, e) =>
        {
            Debug.Log("서버에 연결됨");
           
        };
        websocket.OnMessage += (sender, e) =>
        {
            Debug.Log(e.Data);
        };
        websocket.ConnectAsync();
     }
    public void SendChat()
    {
        websocket.Send(input.text);
    } 
}
