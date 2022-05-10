using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager  Instance => _instance;
    private static GameManager _instance =null;
    public Transform _maxPosition=null;
    public Transform _minPosition=null;
    public Transform Pooling {get; private set;}
    private void Awake()
    {
        if(_instance ==null){
            _instance = this;
        }
        Pooling = GameObject.Find("pooling").transform;
    }
}
