using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class runaway : MonoBehaviour {

    Transform[] array;
    public float radius;
    int self;
    NavMeshAgent agent;
    wander wan;
    Transform run;

    // Use this for initialization
    void Start () {
        agent = this.gameObject.GetComponent<NavMeshAgent>();
        wan = this.gameObject.GetComponent<wander>();
	}

     bool check(Vector3 center, float rad)
    {
        Collider[] hitColliders = Physics.OverlapSphere(center, radius);
        int i = 0;
        bool b = false;
        while (i < hitColliders.Length)
        {   
            if (hitColliders[i].gameObject.name == "Cube")
            {
                Debug.Log("cube");
                run = hitColliders[i].transform;
                b = true;
                break;
            } else
            {
                Debug.Log("safe");
            }
            i++;
        }
        if (b)
        {
            wan.enabled = !wan.enabled;
            agent.enabled = !agent.enabled;
        } else
        {
            agent.enabled = agent.enabled;
            wan.enabled = wan.enabled;
        }
        return b;
    }

    void away(Transform t)
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime *4;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 4;

        transform.Translate(x, 0, 0);
        transform.Translate(0, 0, z);

    }

    // Update is called once per frame
    void Update () {
        if (check(this.gameObject.transform.position, radius))
        {
            away(run);
        }
    }
}
