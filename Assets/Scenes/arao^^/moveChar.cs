using UnityEngine;

public class movechar : MonoBehaviour
{
    public float speed = 5.0f; // �ړ����x

    void Update()
    {
        // ���ړ��̓��͂��擾
        float move = 0;

        if (Input.GetKey(KeyCode.A)) // A�L�[�ō��ړ�
        {
            move = -1;
        }
        else if (Input.GetKey(KeyCode.D)) // D�L�[�ŉE�ړ�
        {
            move = 1;
        }

        // �ʒu���X�V
        transform.Translate(Vector3.right * move * speed * Time.deltaTime);
    }
}
