using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Respawn"))
        {
                animator.SetBool("RespawnTube", true);
                Debug.Log("Respaawn");
                transform.position = new Vector3(3, 0, 0);
        }
    }
}
