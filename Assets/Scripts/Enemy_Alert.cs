using UnityEngine;
using UnityEngine.AI;

public class Enemy_Alert : MonoBehaviour
{
    public float alertRadius;
    Transform target;
    NavMeshAgent agent;

    public GameObject playerPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = playerPrefab.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= alertRadius)
        {
            agent.SetDestination(target.position);
            
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, alertRadius);
    }
}
