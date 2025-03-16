using UnityEngine;
using UnityEngine.AI;

public class Enemy_Alert : MonoBehaviour
{
    public float alertRadius;
    Transform target;
    NavMeshAgent agent;
    private bool persiguiendo = false;

    public GameObject playerPrefab;
    
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
            Debug.Log("jugador encontrado: "+distance);
            if (!persiguiendo)
            {
                ActivarPersecucion(target);           
            }
        }
        else
        {
            if (persiguiendo)
            {
                persiguiendo = false;
            }
        }
        if (persiguiendo)
        {
            agent.SetDestination(target.position);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, alertRadius);
    }
    public void ActivarPersecucion(Transform jugador)
    {
        target = jugador;
        persiguiendo = true;
    }
}
