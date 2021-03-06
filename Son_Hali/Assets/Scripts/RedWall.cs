using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedWall : MonoBehaviour
{
    [SerializeField] int waitSecond = 5;
    float speed = 0f;
    public float moveSpeed = 5f;
    Rigidbody wall;
    AudioSource audioSource;
    private void Start()
    {
        wall = GetComponent<Rigidbody>();
        StartCoroutine(MoveCoroutine());
        audioSource = GetComponent<AudioSource>();
    }

    IEnumerator MoveCoroutine()
    {
        yield return new WaitForSeconds(waitSecond);
        speed = moveSpeed;
    }

    private void LateUpdate()
    {
        MoveRight();
    }

    void MoveRight()
    {
        wall.velocity = transform.right * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audioSource.Play();
            GameManager.isGameOver = true;
            Debug.Log("Game over");
        }
    }
}
