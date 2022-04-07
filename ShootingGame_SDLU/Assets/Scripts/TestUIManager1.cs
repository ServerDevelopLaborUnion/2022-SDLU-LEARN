using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUIManager1 : MonoBehaviour
{
public static TestUIManager Instance{
    get{
        if(instance == null){
            instance = FindObjectOfType<TestUIManager>();
        }
        return instance;
    }
}
private static TestUIManager instance;
  public int Score = 0;

  public void PlusScore(){
      
      Score++;
  }
}
