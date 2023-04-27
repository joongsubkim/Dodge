using UnityEngine;
using UnityEngine.UI; // UI ���� ���̺귯��
using UnityEngine.SceneManagement; //�� ���� ���� ���̺귯��

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText; //���� ������ Ȱ��ȭ �� �ؽ�Ʈ ���� ������Ʈ
    public Text timeText; //�����ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText; //�ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ
    private float surviveTime; //�����ð�
    private bool isGameover; //���ӿ�������



    // Start is called before the first frame update
    void Start()
    {
        surviveTime = 0;
        isGameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameover)
        {
            //���� �ð� ����
            surviveTime += Time.deltaTime;
            //������ ���� �ð��� timeText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
            timeText.text = "Time : " + (int)surviveTime;
        }
        else
        {


            //���ӿ��� ���¿��� RŰ�� ���� ���
            if (Input.GetKeyDown(KeyCode.R))
            {
                //SampleScene���� �ε�
                SceneManager.LoadScene("SampleScene");
            }
        }

    }
    public void EndGame()
    {
        //���� ���¸� ���ӿ��� ���·� ��ȯ
        isGameover = true;
        //���� ���� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ
        gameoverText.SetActive(true);
    }
}





