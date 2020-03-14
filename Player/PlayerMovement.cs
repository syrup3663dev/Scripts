using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Player player;

    public float leanValue = 0f;

    private void Start() {
        player = GetComponent<Player>();
    }

    private void Update() {
        Move();
    }

    /// <summary>
    /// 移動
    /// </summary>
    void Move() {
        // 左右移動: X軸
        // 前後移動: Z軸
        var xInput = Input.GetAxisRaw("Horizontal");
        var yInput = Input.GetAxisRaw("Vertical");
        player.rb.velocity = new Vector3(xInput, 0, yInput) * player.speed;
    }
}
