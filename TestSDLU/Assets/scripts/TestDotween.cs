using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestDotween : MonoBehaviour
{
    [SerializeField]
    private Image fadeImage = null;
    [SerializeField]
    private Slider slider = null;
    [SerializeField]
    private int playerHP = 10;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = playerHP;
        //fadeImage.DOFade(1f, 1f).SetDelay(1f). OnComplete(() =>
        //{
          //  SceneManager.LoadScene("Main");
       // });
        //transform.DOMove(Vector3.zero, 1f);
        //transform.DORotate(Vector3.forward * 360f, 1f, RotateMode.FastBeyond360);
        //transform.DOPunchRotation(Vector3.forward * 50f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            slider.value--;
            if (slider.value < 1)
            {
                slider.gameObject.SetActive(false);
            }
        }
    }
}
