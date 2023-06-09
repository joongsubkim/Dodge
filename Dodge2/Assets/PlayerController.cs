using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody; //이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f; //이동속력
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //왼쪽으로 방향키 입력이 감지된 경우 z 방향 힘 주기
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            //아래쪽 방향키 입력이 감지된 경우-z방향 힘 주기
            playerRigidbody.AddForce(0f, 0f, -speed);

        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            //오른쪽 방향키 입력이 감지된 경우 x방향 힘 주기
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            //왼쪽 방향키 입력이 감지된 경우 -x방향 힘 주기
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }
    public void Die()
    {
        //자신의 게임 오브젝트를 비활성화
        // 컴포넌트 활성화/비활성화 : enabled
        gameObject.SetActive(false);
    }
}

