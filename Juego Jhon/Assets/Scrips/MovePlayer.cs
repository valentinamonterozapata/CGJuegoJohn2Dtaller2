using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlayer : MonoBehaviour
{
    public GameObject BulletPrefab;
    float horizontal;
    private Rigidbody2D rigiBodyPlaayer;
    public float jumpForce = 5f;
    private Animator Animator;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius = 0.5f;
    public LayerMask whatIsGround;
    private float LastShoot;
    private int Health = 50; 

    void Start()
    {
        rigiBodyPlaayer = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        if (horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        Animator.SetBool("running", horizontal != 0.0f);

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            
            rigiBodyPlaayer.velocity = new Vector2(rigiBodyPlaayer.velocity.x, jumpForce);
        }

        if (Input.GetKey(KeyCode.Space) && Time.time > LastShoot + 0.25f)
        {
            Shoot();
            LastShoot = Time.time;
        }
    }

    private void Shoot()
    {
        Vector3 direction;
        if (transform.localScale.x == 1.0f) direction = Vector2.right;
        else direction = Vector2.left;

        GameObject bullet = Instantiate(BulletPrefab, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<BulletScrip>().SetDirection(direction);
    }

    private void FixedUpdate()
    {
        rigiBodyPlaayer.velocity = new Vector2(horizontal, rigiBodyPlaayer.velocity.y);
    }

    public void Hit()
    {
        Health = Health - 1;
        if (Health == 0) Destroy(gameObject);
    }
   
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy")) // Verifica si colisiona con un enemigo
            {
                Vidas.instance.PerderVida(); // Llama al método para reducir una vida
            }
        }
    }
