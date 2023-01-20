using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MonoBehaviour 를 상속 받은 컴포넌트들은 생성자를 통해서 생성하면 안된다

public class Movement : MonoBehaviour
{
    // 스크립트 인스턴스가 처음 로드될 때 호출
    // 해당 스크립트 인스턴스를 컴포넌트로 포함하는 게임 오브젝트가 활성화 되어 있어야 호출
    // 게임 오브젝트가 비활성화 된 채로 실행되면 인스턴스화 되지 않으므로 스크립트 인스턴스도 인스턴스화 되지 않는다
    // 스크립트 인스턴스를 비활성화 하여도 게임 오브젝트가 인스턴스화 될 때
    // 해당 스크립트 인스턴스도 로드되므로 Awake는 호출 된다
    // -> 일반적으로 생성자 대용으로 사용함 ( 생성자와 동일하진 않고 멤버 변수들의 초기화를 해야할때 주로 사용 )
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // 이 컴포넌트를 가지는 게임 오브젝트가 활성화 되거나
    // 이 스크립트 인스턴스가 활성화 될 때마다 호출된다
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // Editor 에서만 호출되고 멤버 변수들을 모두 default 로 설정
    private void Reset()
    {
        Debug.Log("Reset");
    }

    // Start is called before the first frame update
    // Awake 에서 초기화가 완료된 다른 참조들을 사용해서 멤버 또는 다른 객체 생성 등을 한번 수행 해야할 때 주로 사용
    void Start()
    {
        Debug.Log("Start");
    }

    // 고정 프레임 속도로 매 프레임 호출됨
    // 물리 연산 관련 로직은 이 이벤트에서 수행해야함
    private void FixedUpdate()
    {
        
    }

    // 어떤 충돌체가 트리거 활성화 된 충돌체에 닿았을때
    // 트리거 : 충돌체에 대한 감지만 실행하는 것
    // 둘 중 하나라도 리지드 바디를 가지고 있어야 물리적 연산이 적용되므로
    // 단순히 충돌체끼리의 충돌이 아니다
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

    // 리지드 바디를 가진 충돌체와 다른 충돌체의 상호작용
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


    // 게임 로직의 기본 단위
    // 매 프레임마다 호출됨 ( 프레임 간격은 연산량에 따라 계속 다름 )
    void Update()
    {
        // Debug.Log("Update");
    }

    // 매 프레임의 마지막에 호출됨
    // 게임 로직과 직접적인 연관이 없고 그냥 프레임마다 호출만 해주면 되는 녀석들을 주로 여기에 담는다 - 주로 카메라
    private void LateUpdate()
    {
        
    }

    // 히트박스 만들때 사용하면 편하다
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(Vector3.zero,2.0f);
    }
}
