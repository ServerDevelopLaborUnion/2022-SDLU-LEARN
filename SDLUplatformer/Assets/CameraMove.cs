using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Transform _canTransform = null;
    private PlayerMove _player = null;
    void Start(){
        _player = FindObjectOfType<PlayerMove>();
        _canTransform = Camera.main.transform;
    }
}
