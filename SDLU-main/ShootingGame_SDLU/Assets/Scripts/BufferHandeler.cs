using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BufferHandeler : MonoBehaviour
{
    public BufferHandeler Instance;

    private static BufferHandeler Instance
    {
        get
        {
            if( _instance == null)
            {
                _instance = FindObjectOfType<BufferHandeler>();
            }
            return _instance;
        }
    }

    private static BufferHandeler _instance = null;

    public Queue<string> _textQueue = new Queue<string>();

    public void Add(string data)
    {

    }
    [SerializeField]
    private Text _scores = null;

    private void Update()
    {
        if (_textQueue.Count > 0)
        {
            _scores.text = _textQueue.Dequeue();
        }
    }
}
