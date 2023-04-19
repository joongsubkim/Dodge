using UnityEngine;


public class playerController : MonoBehaviour
{
    public Rigidbody playerRigidbody; //이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f; //이동속력
    // Start is called before the first frame update
    void Start()
    {
        //게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 playerRigidbody에 활당
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //수평축과 수직축의 입력값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //실제 이동 속도를 입력값고 ㅏ이동 속력을 사용해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //vector3 속도를 (xSpeed, 0 ,zspeed)로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        //리지드 바디의 속도에 newVelocity 활당
        playerRigidbody.velocity = newVelocity;

    }
}
           
        
        
        //if (Input.GetKey(KeyCode.UpArrow) == true)
        //{
        //    //왼쪽으로 방향키 입력이 감지된 경우 z 방향 힘 주기
        //    playerRigidbody.AddForce(0f, 0f, speed);
        //}
        //if (Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    //아래쪽 방향키 입력이 감지된 경우-z방향 힘 주기
        //    playerRigidbody.AddForce(0f, 0f,-speed);

        //}
        //if (Input.GetKey(KeyCode.RightArrow) == true)
        //{
        //    //오른쪽 방향키 입력이 감지된 경우 x방향 힘 주기
        //    playerRigidbody.AddForce(speed, 0f, 0f);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow) == true)
        //{
        //    //왼쪽 방향키 입력이 감지된 경우 -x방향 힘 주기
        //    playerRigidbody.AddForce(-speed, 0f, 0f);
        //}
    //}
   // public void Die()
    //{
        //자신의 게임 오브젝트를 비활성화
        // 컴포넌트 활성화/비활성화 : enabled
     //   gameObject.SetActive(false);
   // }
  //}

