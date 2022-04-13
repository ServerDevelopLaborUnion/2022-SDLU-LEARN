using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject submitControls;

    public Image hpGage;
    //public Text gameOverText;
    public GameObject player;
    private Text_ GameOver;

    private void Start()
    {
        GameOver = FindObjectOfType<Text_>();
    }

    public void DecreaseHP()
    {
        hpGage.fillAmount -= 0.2f;
    }

    private void Update()
    {
        if (hpGage.fillAmount <= 0.1f)
        {
            player.SetActive(false);
            submitControls.SetActive(true);
            //gameOverText.gameObject.SetActive(true);
            GameOver.TextMove();
            GameOver.DestroyText();
        }
    }

}

