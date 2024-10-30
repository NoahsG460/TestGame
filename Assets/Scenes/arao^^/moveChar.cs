using UnityEngine;

public class movechar : MonoBehaviour
{
    public float speed = 5.0f; // 移動速度

    void Update()
    {
        // 横移動の入力を取得
        float move = 0;

        if (Input.GetKey(KeyCode.A)) // Aキーで左移動
        {
            move = -1;
        }
        else if (Input.GetKey(KeyCode.D)) // Dキーで右移動
        {
            move = 1;
        }

        // 位置を更新
        transform.Translate(Vector3.right * move * speed * Time.deltaTime);
    }
}
