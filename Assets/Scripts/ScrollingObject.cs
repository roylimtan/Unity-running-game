﻿using UnityEngine;

// 게임 오브젝트를 계속 왼쪽으로 움직이는 스크립트
public class ScrollingObject : MonoBehaviour {

    
    public float speed = 10f; // 이동 속도

    private void Update() {

        if(!GameManager.instance.isGameover)
        {
            // 게임 오브젝트를 왼쪽으로 일정 속도로 평행 이동하는 처리
            transform.Translate(Vector3.left * speed * Time.deltaTime); //vector3.left는 x좌표로 왼쪽으로 이동
        }

        
    }
}