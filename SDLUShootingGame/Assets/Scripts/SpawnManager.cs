using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public UIManager uIManager = null;
    public GameObject Player = null;
    public GameObject Enemy = null;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreatePlayer());
        StartCoroutine(CreateEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator CreatePlayer()
    {
        yield return new WaitForSeconds(0.5f);
        Instantiate(Player, new Vector3(0, -3.5f, 0), Quaternion.identity);
    }
    private IEnumerator CreateEnemy()
    {
        yield return new WaitForSeconds(2);

        GameObject enemy = Instantiate(Enemy);
        uIManager.EHeartBox.gameObject.SetActive(true);
        uIManager.EHeartBox.transform.position = enemy.transform.position + Vector3.up;
    }
}
