using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MonoBehaviour �� ��� ���� ������Ʈ���� �����ڸ� ���ؼ� �����ϸ� �ȵȴ�

public class Movement : MonoBehaviour
{
    // ��ũ��Ʈ �ν��Ͻ��� ó�� �ε�� �� ȣ��
    // �ش� ��ũ��Ʈ �ν��Ͻ��� ������Ʈ�� �����ϴ� ���� ������Ʈ�� Ȱ��ȭ �Ǿ� �־�� ȣ��
    // ���� ������Ʈ�� ��Ȱ��ȭ �� ä�� ����Ǹ� �ν��Ͻ�ȭ ���� �����Ƿ� ��ũ��Ʈ �ν��Ͻ��� �ν��Ͻ�ȭ ���� �ʴ´�
    // ��ũ��Ʈ �ν��Ͻ��� ��Ȱ��ȭ �Ͽ��� ���� ������Ʈ�� �ν��Ͻ�ȭ �� ��
    // �ش� ��ũ��Ʈ �ν��Ͻ��� �ε�ǹǷ� Awake�� ȣ�� �ȴ�
    // -> �Ϲ������� ������ ������� ����� ( �����ڿ� �������� �ʰ� ��� �������� �ʱ�ȭ�� �ؾ��Ҷ� �ַ� ��� )
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // �� ������Ʈ�� ������ ���� ������Ʈ�� Ȱ��ȭ �ǰų�
    // �� ��ũ��Ʈ �ν��Ͻ��� Ȱ��ȭ �� ������ ȣ��ȴ�
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // Editor ������ ȣ��ǰ� ��� �������� ��� default �� ����
    private void Reset()
    {
        Debug.Log("Reset");
    }

    // Start is called before the first frame update
    // Awake ���� �ʱ�ȭ�� �Ϸ�� �ٸ� �������� ����ؼ� ��� �Ǵ� �ٸ� ��ü ���� ���� �ѹ� ���� �ؾ��� �� �ַ� ���
    void Start()
    {
        Debug.Log("Start");
    }

    // ���� ������ �ӵ��� �� ������ ȣ���
    // ���� ���� ���� ������ �� �̺�Ʈ���� �����ؾ���
    private void FixedUpdate()
    {
        
    }

    // � �浹ü�� Ʈ���� Ȱ��ȭ �� �浹ü�� �������
    // Ʈ���� : �浹ü�� ���� ������ �����ϴ� ��
    // �� �� �ϳ��� ������ �ٵ� ������ �־�� ������ ������ ����ǹǷ�
    // �ܼ��� �浹ü������ �浹�� �ƴϴ�
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"OnTriggerEnter : {other.name}");
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    // ������ �ٵ� ���� �浹ü�� �ٸ� �浹ü�� ��ȣ�ۿ�
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"OnCollisionEnter : {collision.gameObject.name}");
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log($"OnMouseDown : {gameObject.name}");
    }

    private void OnMouseEnter()
    {
        Debug.Log($"OnMouseEnter : {gameObject.name}");
    }

    private void OnMouseDrag()
    {
        // Debug.Log($"OnMouseDrag : {gameObject.name}");
    }

    private void OnMouseExit()
    {
        Debug.Log($"OnMouseExit : {gameObject.name}");
    }

    private void OnMouseOver()
    {
        // Debug.Log($"OnMouseOver : {gameObject.name}");
    }

    private void OnMouseUp()
    {
        Debug.Log($"OnMouseUp : {gameObject.name}");
    }


    // ���� ������ �⺻ ����
    // �� �����Ӹ��� ȣ��� ( ������ ������ ���귮�� ���� ��� �ٸ� )
    void Update()
    {
        // Debug.Log("Update");
    }

    // �� �������� �������� ȣ���
    // ���� ������ �������� ������ ���� �׳� �����Ӹ��� ȣ�⸸ ���ָ� �Ǵ� �༮���� �ַ� ���⿡ ��´� - �ַ� ī�޶�
    private void LateUpdate()
    {
        
    }

    // ��Ʈ�ڽ� ���鶧 ����ϸ� ���ϴ�
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(Vector3.zero,2.0f);
    }
}
