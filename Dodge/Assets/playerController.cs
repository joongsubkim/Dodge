using UnityEngine;


public class playerController : MonoBehaviour
{
    public Rigidbody playerRigidbody; //�̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f; //�̵��ӷ�
    // Start is called before the first frame update
    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� playerRigidbody�� Ȱ��
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //������� �������� �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵� �ӵ��� �Է°��� ���̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //vector3 �ӵ��� (xSpeed, 0 ,zspeed)�� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        //������ �ٵ��� �ӵ��� newVelocity Ȱ��
        playerRigidbody.velocity = newVelocity;

    }
}
           
        
        
        //if (Input.GetKey(KeyCode.UpArrow) == true)
        //{
        //    //�������� ����Ű �Է��� ������ ��� z ���� �� �ֱ�
        //    playerRigidbody.AddForce(0f, 0f, speed);
        //}
        //if (Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    //�Ʒ��� ����Ű �Է��� ������ ���-z���� �� �ֱ�
        //    playerRigidbody.AddForce(0f, 0f,-speed);

        //}
        //if (Input.GetKey(KeyCode.RightArrow) == true)
        //{
        //    //������ ����Ű �Է��� ������ ��� x���� �� �ֱ�
        //    playerRigidbody.AddForce(speed, 0f, 0f);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow) == true)
        //{
        //    //���� ����Ű �Է��� ������ ��� -x���� �� �ֱ�
        //    playerRigidbody.AddForce(-speed, 0f, 0f);
        //}
    //}
   // public void Die()
    //{
        //�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        // ������Ʈ Ȱ��ȭ/��Ȱ��ȭ : enabled
     //   gameObject.SetActive(false);
   // }
  //}

