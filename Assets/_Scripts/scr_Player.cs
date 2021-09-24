using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Player : MonoBehaviour
{
    public GameObject prefabBall;
    public float speed;
    public int damageTotal = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(new Vector3(speed * Time.deltaTime, 0f, 0f));
        
        if (transform.position.x >= 8.0f || transform.position.x <= -8f)
        {
            speed = -speed;
        }

        if (Input.GetKeyDown("space"))
        {
            Instantiate(prefabBall, transform.position, transform.rotation);
        }
    }

    public void AddDamage(int damageToAdd)
    {
        damageTotal += damageToAdd;
        Debug.Log("Damage Total = " + damageTotal);
    }
}
