

using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectGazeEvent : MonoBehaviour//, IPointerClickHandler, IPointerEnterHandler
{
    private EventSystem m_CurEvent;

	// Use this for initialization
	void Start () 
    {
        m_CurEvent = EventSystem.current;
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    public void OnPointerClick(/*PointerEventData data*/)
    {
        m_CurEvent.SetSelectedGameObject(gameObject);
        Debug.Log("OnPointerClick");
        gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
    }

    public void OnPointerEnter(/*PointerEventData data*/)
    {
        Debug.Log("OnPointerEnter");
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }
    
}
