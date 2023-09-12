using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class gerak : MonoBehaviour
{

    public float speed;

    Vector3 jalan;

    public Animator anime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jalan.x = Input.GetAxisRaw("Horizontal");
        jalan.y = Input.GetAxisRaw("Vertical");
        transform.position += jalan * speed * Time.deltaTime;

        if (jalan != Vector3.zero)
        {
            anime.SetBool("lari", true);
        } 
        else    
            anime.SetBool("lari", false);

    if (jalan == Vector3.left)
    {
        transform.rotation = Quaternion.Euler(0, 180, 0);

    } else if (jalan == Vector3.right)

        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
