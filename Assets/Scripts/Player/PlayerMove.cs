using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour
{
    private NavMeshAgent playAgent;
    // Start is called before the first frame update
    void Start()
    {
        playAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && EventSystem.current.IsPointerOverGameObject() == false)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            bool isCollide = Physics.Raycast(ray, out hit);
            if(isCollide)
            {
                if(hit.collider.tag == "Ground")
                {
                    playAgent.stoppingDistance = 0;
                    playAgent.SetDestination(hit.point);
                }
                else if(hit.collider.tag == "Interactable")
                {
                    hit.collider.GetComponent<InteractableObject>().Onclick(playAgent);
                }
            }
        }
    }
}
