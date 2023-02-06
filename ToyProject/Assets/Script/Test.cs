using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public float speed = 1.0f;
    private Vector3 des;
    private NavMeshAgent agent = null;
    [SerializeField] private Image image = null;
    private void Start()
    {
        agent= GetComponent<NavMeshAgent>();
        
        if (agent!=null)
        {
            agent.isStopped = true;
        }
        else
        {
            Destroy(this.gameObject);
        }

        if(image!=null)
        {
            image.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        print(Input.mousePosition);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {
            if (Input.GetMouseButtonDown(1))
            {
                des = hitInfo.point;
                agent.SetDestination(des);
                agent.isStopped = false;
            }else if (hitInfo.collider.CompareTag("NPC"))
            {
                if(image !=null)
                {
                    image.gameObject.SetActive(true);
                    print("Test : " + Screen.width + " " + Screen.height);
                    image.transform.localPosition = Input.mousePosition - new Vector3(Screen.width/2, Screen.height/2, 0);
                }
            }
            else
            {
                image.gameObject.SetActive(false);
            }
            
        }

        

        if (this.transform.position.x == des.x && this.transform.position.z == des.z)
        {
            agent.isStopped = true;
        }
    }
    
    
}
