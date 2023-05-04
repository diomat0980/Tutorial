using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Create : MonoBehaviour
{
    public Button button;
    public GameObject prefab;

    private bool active = true;
    private float fixedTime = 5f;
    private float currentTime = 5f;

    public void CreateGeneric()
    {
        active = false;

        // 게임 오브젝트를 생성하는 함수
        Instantiate
        (
            prefab,                     // 생성되는 게임 오브젝트
            new Vector3(0, -1.25f, 0),  // 생성되는 위치 값
            prefab.transform.rotation   // 생성되는 회전 값
       ).AddComponent<Delate>();
    }

    void Update()
    {
        if(active == false)
        {
            button.interactable = false;                        // button 오브젝트를 비활성화
            currentTime -= Time.deltaTime;                      // currentTime에 한 프레임 실행되는 시간을 뺀다.
            button.image.fillAmount = currentTime / fixedTime;

            if(currentTime <= 0)
            {
                active = true;
                button.interactable = true;
                button.image.fillAmount = currentTime = fixedTime;
            }
        }
    }
}
