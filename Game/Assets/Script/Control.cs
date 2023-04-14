using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Rigidbody rigid;

    // 스크립트가 비활성화된 상태로 게임 오브젝트가 생성되었을 때
    // 단 한번만 호출하는 이벤트 함수이다.
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // 스크립트가 활성화된 상태로 게임 오브젝트가 생성되었다면
    // 단 한 번만 호출되는 이벤트 함수이다.
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        Debug.Log("Start");
    }

    // 프레임과 상관없이 무조건 시간 기준(TimeStep 0.02초)
    // 으로 호출되는 이벤트 함수
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    // 게임 오브젝트가 활성화된 상태로 매 프레임마다
    // 호출되는 이벤트 함수이다.
    void Update()
    {
        Moving();

        Debug.Log("Update");   
    }

    private void Moving()
    {
        float _moveDirX = Input.GetAxisRaw("Horizontal");
        float _moveDirZ = Input.GetAxisRaw("Vertical");

        Vector3 _moveHorizontal = transform.right * _moveDirX;
        Vector3 _moveVertical = transform.forward * _moveDirZ;

        Vector3 _velocity = (_moveHorizontal + _moveVertical).normalized * 20f;   // normalized : 삼각함수 이용하여 대각선 이동에도 합이 1이 되도록 정규화시킴

        rigid.MovePosition(transform.position + _velocity * Time.deltaTime);
    }

    
    // 게임 오브젝트가 활성화된 상태로 Update() 함수가
    // 호출되고 나서 Updata함수중에서 마지막으로 호출되는 이벤트 함수
    private void LateUpdate()
    {
        Debug.Log("Late Update");
    }

    // 게임 오브젝트가 비활성화되었을 때 호출되는
    // 이벤트 함수이다.
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }

    // 게임 오브젝트가 활성화된 상태로 게임 오브젝트가
    // 파괴되었을 때 호출되는 이벤트 함수이다.
    void OnDestroy()
    {
        
    }
}
