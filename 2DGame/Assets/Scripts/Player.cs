using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject final;

    // 碰撞偵測條件
    // 1. 兩個物件必須有碰撞器 Collider 2D
    // 2. 兩者必須至少有一個剛體 Rigidbody2D

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到傳送門惹!");
        final.SetActive(true);  //
    }
}
