using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Vector2 xMove;

    Transform player;

    float xMovement;
    public int speedX = 5;

    public Animator animator;

    Rigidbody2D m_Rigidbody;
    public float m_Thrust = 5f;

    public float health;
    public Text HealthText;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;
        m_Rigidbody = GetComponent<Rigidbody2D>();
        health = 3;
        Debug.Log("Hp: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        if(health == 0)
        {
            Debug.Log("GAME OVER");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        //if (Acorns == 5)
        //{
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        //}
        xMovement = Input.GetAxis("Horizontal") * speedX;

        animator.SetFloat("Speed", Mathf.Abs(xMovement));

        xMove = new Vector2(xMovement, 0.0f);

        player.Translate(xMove * Time.deltaTime);

        if (Input.GetAxis("Horizontal") > 0)
        {
            player.localScale = new Vector3(6, 6, 1);
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            player.localScale = new Vector3(-6, 6, 1);
        }

        if (m_Rigidbody.velocity.y == 0)
        {
            if (Input.GetButton("Jump"))
            {
                animator.SetBool("Jumping", true);
                m_Rigidbody.AddForce(transform.up * m_Thrust);
            }
            else
            {
                animator.SetBool("Jumping", false);
            }
        }
        HealthText.text = "HP: " + health;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Acorn")
        {
            Debug.Log("NOM NOM NOM");
        }
        if (col.gameObject.tag == "Enemy")
        {
            health = health - 1;
        }
    }
    void OnBecameInvisible()
    {
        health = 0;
        //Destroy(gameObject);
    }
}   
