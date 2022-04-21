using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WebSocketSharp;

public class Client : MonoBehaviour
{
    private WebSocket _client;

    [SerializeField]
    private InputField nicknameInput = null;

    private void Start() {
        _client = new WebSocket("ws://localhost:8080");

        _client.OnOpen += (sender, e) =>
        {
            Debug.Log("접속 성공");
        };

        _client.OnMessage += OnMessage;
        _client.ConnectAsync();
    }

    private void OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log(e.Data);
        //string[] data = e.Data.Split('|');
        Debug.Log("이것은?!ㄴ");
        try
        {
            string result = e.Data;
            Debug.Log("1단계 해결");
            result.Replace('|', '\n');
            Debug.Log("2단계 해결");
            result.Replace(",", ": ");
            Debug.Log("3단계 해결");
            BufferHandler._textQueue.Enqueue(result);
        }
        catch(Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }


    public void SubmitScore(){
        string data = "score:" + nicknameInput.text + "," + TestUIManager.Instance.Score;
        _client.Send(data);
    }
}
