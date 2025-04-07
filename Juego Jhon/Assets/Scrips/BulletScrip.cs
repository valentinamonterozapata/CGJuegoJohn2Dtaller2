using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScrip : MonoBehaviour
{
    public AudioClip sound;
    public float speed;
    private Rigidbody2D rigiBody2D;
    private Vector2 Direction;
    // Start is called before the first frame update
    void Start()
    {
        rigiBody2D = GetComponent<Rigidbody2D>();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);
    }

    // Update is called once per frame
    void Update()
    {
        rigiBody2D.velocity = Direction * speed;
    }

    public void SetDirection(Vector2 direction)
    {
        Direction = direction;
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        MoverPlayer player = collision.GetComponent<MoverPlayer>();
        GruntScrip grunt = collision.GetComponent<GruntScrip>();
        if (player != null)
        {
            player.Hit();
        }
        if (grunt != null)
        {
            grunt.Hit();
        }

        DestroyBullet();
    }
}
