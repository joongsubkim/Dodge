using UnityEngine;

public class bullet : MonoBehaviour
{

    public GameObject bulletPrefab; //생성할 탄알의 원본 프리팹
    public float spawnerRateMin = 0.5f;
    public float spawnerMax = 3f;

    private Transform target; // 발사항 대상
    private float spawnRate; //생성주기
    private float timeAfterSpawn; //최근 생성 시점에서 지난 시간


    public float speed = 8f; //탄알 이동 속력
    private Rigidbody bulletRigidbody; //이동에 사용할 리지드바디 컴포넌트


    void Start()
    {
        //게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 bulletRigidbody에 할당
        bulletRigidbody = GetComponent<Rigidbody>();
        //리지드 바디의 속도 = 앞쪽 방향 * 이동 속력
        bulletRigidbody.velocity = transform.forward * speed;
        //3초 뒤에 자신의 게임 오브젝트 파괴
        Destroy(gameObject, 3f);
    }

    //트리거충돌시 자동으로 실행되는 메서드
    private void OnTriggerEnter(Collider other)
    {
        //충돌한 상대방 게임 오브젝트가 player태그를 가진 경우
        if (other.tag == "Player")
        {
            playerController PlayerController = other.GetComponent<playerController>();
            //상대방 게임 오브젝트에서 playerController 컴퍼넌트를 가져오는 데 성공했다면
            if (PlayerController != null)
            {
                //상대방 playerController 컴포넌트의 Die() 메서드 실행
                PlayerController.Die();
            }

        }
    }
}
    

    
