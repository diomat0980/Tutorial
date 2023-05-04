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

        // ���� ������Ʈ�� �����ϴ� �Լ�
        Instantiate
        (
            prefab,                     // �����Ǵ� ���� ������Ʈ
            new Vector3(0, -1.25f, 0),  // �����Ǵ� ��ġ ��
            prefab.transform.rotation   // �����Ǵ� ȸ�� ��
       ).AddComponent<Delate>();
    }

    void Update()
    {
        if(active == false)
        {
            button.interactable = false;                        // button ������Ʈ�� ��Ȱ��ȭ
            currentTime -= Time.deltaTime;                      // currentTime�� �� ������ ����Ǵ� �ð��� ����.
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
