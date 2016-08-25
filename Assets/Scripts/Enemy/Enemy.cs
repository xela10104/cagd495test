using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public float damage = 2;
    public GameObject point1;
    public GameObject point2;
    public float speed = 1;
    public Transform target;
    public float distance;
    public bool back = false;
    public GameObject thePlayer;

    // Use this for initialization
    void Start()
    {
        target = point1.transform;
        //CharController playerscript = thePlayer.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        if (Vector3.Distance(target.position, transform.position) < 1f)
        {
            {
                if (back == false)
                {
                    target = point2.transform;
                    back = true;
                }
                else if (back == true)
                {
                    target = point1.transform;
                    back = false;
                }
            }
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.tag == ("Player"))
        {
            //CharController.health -= 2;
        }

    }
}
