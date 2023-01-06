using UnityEngine;
using UnityEngine.AI;

public class AIMove : MonoBehaviour

{ 
    public GameObject Player;
    public float Distance;
    public bool isAngered;
    public NavMeshAgent _agent;
    public Animator animator;
 

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update() 
    {
        Distance = Vector3.Distance(Player.transform.position, base.transform.position); if (Distance <= 1000f) { isAngered = true; } if (Distance > 1000f) { isAngered = false; } if (isAngered) { _agent.isStopped = false; GetComponent<Animator>().enabled = true; GetComponent<Animator>().Play("Walk"); } _agent.SetDestination(Player.transform.position); if (!isAngered) { _agent.isStopped = true; GetComponent<Animator>().enabled = false; }
    } 
}