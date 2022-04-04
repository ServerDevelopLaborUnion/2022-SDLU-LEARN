using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpViewer : MonoBehaviour
{
    [SerializeField]
    private PlayerHp playerHp;
    private Slider sliderHp;

    private void Awake()
    {
        sliderHp = GetComponent<Slider>();
    }

    /// <summary>
    /// Tip. 더 정확한 방법으로는 이벤트를 이용해 체력 정보가 바뀔때만 UI 정보 갱신
    /// </summary>
    private void Update()
    {
        sliderHp.value = playerHp.CurrentHp / playerHp.MaxHp;
    }
}
