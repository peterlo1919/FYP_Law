using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CatMove : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent _agent;

    public GameObject Player;

    public float EnemyDistanceRun = 4.0f;

    public Animator cat_animator;

    // Start is called before the first frame update
    void Start()
    {
        cat_animator.SetBool("IsRun", false);
        _agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        //Debug.Log("Distance: " + distance);

        if(distance < EnemyDistanceRun){
            
            cat_animator.SetBool("IsRun", true);
            
            Vector3 dirToPlayer = transform.position - Player.transform.position;

            Vector3 newPos = transform.position + dirToPlayer;

            _agent.SetDestination(newPos);

        }
        else
        {
            cat_animator.SetBool("IsRun", false);
        }
    }
}
