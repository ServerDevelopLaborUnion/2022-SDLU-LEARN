using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WebSocketSharp;

public class Client : MonoBehaviour
{
	[SerializeField] InputField input = null;
	WebSocket webSocket = null;
	void Start()
	{
		webSocket = new WebSocket("ws://172.31.2.41:8922");
		webSocket.OnOpen += (s, e) =>
		{
			Debug.Log("서버에 연결됨");
		};
		webSocket.OnMessage += (s, e) =>
		{
			Debug.Log(e.Data);
		};
		webSocket.Connect();
	}
	public void SendChat()
    {
		webSocket.Send(input.text);
    }	
}
