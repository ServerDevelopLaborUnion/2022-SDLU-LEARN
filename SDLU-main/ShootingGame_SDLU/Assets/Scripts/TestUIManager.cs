using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUIManager : MonoBehaviour
{

    //PlayerPrefs

    public static TestUIManager Instance //싱글톤 패턴 get set property 겟 셋 프로퍼티
    {
        get{
            if(instance == null){
                instance = FindObjectOfType<TestUIManager>();
            }
            return instance;
        }
    }
    private static TestUIManager instance = null;

    private int a = 0;

    public int _score; //getter
    private TestUIManager testUIManager;

    [SerializeField]
    private string _scorekey = "SCORE";

    public int Score = 0;
    public void PlusScore(){
        PlayerPrefs.SetInt(_scorekey, _score);
        PlayerPrefs.SetInt("THREE", 3);
        PlayerPrefs.SetInt("FOUR", 4);

        int score = PlayerPrefs.GetInt(_scorekey, 0);
        Score++;
    }
}
