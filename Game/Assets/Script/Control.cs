using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Rigidbody rigid;

    // ��ũ��Ʈ�� ��Ȱ��ȭ�� ���·� ���� ������Ʈ�� �����Ǿ��� ��
    // �� �ѹ��� ȣ���ϴ� �̺�Ʈ �Լ��̴�.
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // ��ũ��Ʈ�� Ȱ��ȭ�� ���·� ���� ������Ʈ�� �����Ǿ��ٸ�
    // �� �� ���� ȣ��Ǵ� �̺�Ʈ �Լ��̴�.
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        Debug.Log("Start");
    }

    // �����Ӱ� ������� ������ �ð� ����(TimeStep 0.02��)
    // ���� ȣ��Ǵ� �̺�Ʈ �Լ�
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    // ���� ������Ʈ�� Ȱ��ȭ�� ���·� �� �����Ӹ���
    // ȣ��Ǵ� �̺�Ʈ �Լ��̴�.
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

        Vector3 _velocity = (_moveHorizontal + _moveVertical).normalized * 20f;   // normalized : �ﰢ�Լ� �̿��Ͽ� �밢�� �̵����� ���� 1�� �ǵ��� ����ȭ��Ŵ

        rigid.MovePosition(transform.position + _velocity * Time.deltaTime);
    }

    
    // ���� ������Ʈ�� Ȱ��ȭ�� ���·� Update() �Լ���
    // ȣ��ǰ� ���� Updata�Լ��߿��� ���������� ȣ��Ǵ� �̺�Ʈ �Լ�
    private void LateUpdate()
    {
        Debug.Log("Late Update");
    }

    // ���� ������Ʈ�� ��Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ�
    // �̺�Ʈ �Լ��̴�.
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }

    // ���� ������Ʈ�� Ȱ��ȭ�� ���·� ���� ������Ʈ��
    // �ı��Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��̴�.
    void OnDestroy()
    {
        
    }
}
