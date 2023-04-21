using UnityEngine;

public class bullet : MonoBehaviour
{

    public GameObject bulletPrefab; //������ ź���� ���� ������
    public float spawnerRateMin = 0.5f;
    public float spawnerMax = 3f;

    private Transform target; // �߻��� ���
    private float spawnRate; //�����ֱ�
    private float timeAfterSpawn; //�ֱ� ���� �������� ���� �ð�


    public float speed = 8f; //ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody; //�̵��� ����� ������ٵ� ������Ʈ


    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        //������ �ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;
        //3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 3f);
    }

    //Ʈ�����浹�� �ڵ����� ����Ǵ� �޼���
    private void OnTriggerEnter(Collider other)
    {
        //�浹�� ���� ���� ������Ʈ�� player�±׸� ���� ���
        if (other.tag == "Player")
        {
            playerController PlayerController = other.GetComponent<playerController>();
            //���� ���� ������Ʈ���� playerController ���۳�Ʈ�� �������� �� �����ߴٸ�
            if (PlayerController != null)
            {
                //���� playerController ������Ʈ�� Die() �޼��� ����
                PlayerController.Die();
            }

        }
    }
}
    

    
