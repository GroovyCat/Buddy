using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // ������Ʈ�� ĳ�� ó���� ����
    private Transform tr;
    // �̵� �ӷ� ����
    public float moveSpeed;     // 10
    // ȸ�� �ӵ� ����
    public float turnSpeed;     // 80


    private void Start()
    {
        tr = GetComponent<Transform>();
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float r = Input.GetAxis("Mouse X");

        // �����¿� �̵� ���� ���� ���
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        // Translate(�̵� ���� * �ӷ� * Time.deltaTime)
        tr.Translate(moveDir * moveSpeed * Time.deltaTime);

        // Vector3.up ���� �������� turnSpeed��ŭ�� �ӵ��� ȸ��
        tr.Rotate(Vector3.up * turnSpeed * Time.deltaTime * r);
    }
}
