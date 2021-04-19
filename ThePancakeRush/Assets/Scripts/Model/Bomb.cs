using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    public float attackRange = 0.06f;
    public LayerMask playerLayer;
    public int attackValue = 40;

    public Animator animator;
    public AnimationClip animation;
    public float speed = 10f;
    public Rigidbody2D rb;
    Transform player;

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;
        Vector2 moveDirection = (player.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
    }

    void OnTriggerEnter2D(Collider2D p)
    {
        if(p.gameObject.tag == "Player"){
            p.GetComponent<Player_attack>().esteLovit(attackValue);
        }

        rb.velocity = new Vector2(0,0);
        animator.SetTrigger("Hit");
        Destroy(gameObject,animation.length);
    }

}
