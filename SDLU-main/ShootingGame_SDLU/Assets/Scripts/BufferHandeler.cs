using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BufferHandeler : MonoBehaviour
{
    public BufferHandeler Instance;

    

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
