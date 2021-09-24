using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Ball : MonoBehaviour
{
    public int damageValue = 1;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -6f)
        {
            AddDamage();
        }

        if (rb.velocity.magnitude <= 0f && transform.position.y < 0f)
        {
            AddDamage();
        }
    }

    void AddDamage()
    {
        GameObject.Find("PlayerController").GetComponent<scr_Player>().AddDamage(damageValue);
        Destroy(gameObject);
    }
}
