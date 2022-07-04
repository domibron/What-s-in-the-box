using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killandreplace : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        if (other.transform.tag == "Ball")
        {
            Instantiate(Resources.Load("ball") as GameObject, Vector3.zero, Quaternion.Euler(0, 0, 0));
            Destroy(other.gameObject);
        }

        if (other.transform.tag == "Knife")
        {
            Instantiate(Resources.Load("knife") as GameObject, Vector3.zero, Quaternion.Euler(0, 0, 0));
            Destroy(other.gameObject);
        }

        if (other.transform.tag == "Kox")
        {
            Instantiate(Resources.Load("box") as GameObject, Vector3.zero, Quaternion.Euler(0, 0, 0));
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        if (other.transform.tag == "Ball")
        {
            Instantiate(Resources.Load("ball") as GameObject, Vector3.zero, Quaternion.Euler(0, 0, 0));
            Destroy(other.gameObject);
        }

        if (other.transform.tag == "Knife")
        {
            Instantiate(Resources.Load("knife") as GameObject, Vector3.zero, Quaternion.Euler(0, 0, 0));
            Destroy(other.gameObject);
        }

        if (other.transform.tag == "Kox")
        {
            Instantiate(Resources.Load("box") as GameObject, Vector3.zero, Quaternion.Euler(0, 0, 0));
            Destroy(other.gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Resources.Load("ball") as GameObject, Vector3.zero, Quaternion.Euler(0, 0, 0));
        Instantiate(Resources.Load("knife") as GameObject, Vector3.zero, Quaternion.Euler(0, 0, 0));
        Instantiate(Resources.Load("box") as GameObject, Vector3.zero, Quaternion.Euler(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
