using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Event
{
    public string eventName;
    public Animator _event;
}

public class EventManager : MonoBehaviour
{
    [Header("Events")]
    public Event[] Event_List;
    
    [Header("Scripts")]
    public CanvasManager theCanvasManager;
    public PlayerManager thePlayerManager;

        // Start is called before the first frame update
    void Start()
    {
        _Event0("Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void _Event0(string type)
    {
        if (type == "Start")
        {
            theCanvasManager.FadeImageEvent();
            thePlayerManager.ControlMove(false, false);
            thePlayerManager.LookFront();
        }
        else
        {
            thePlayerManager.ControlMove(false, false);
        }
    }

    public void _Event1(string type)
    {
        if (type == "Start")
        {
            Event_List[0]._event.SetTrigger("Event1");
            thePlayerManager.ControlMove(false, false);
            thePlayerManager.LerpRotation(Vector3.zero, 1f);
        }
        else
        {
            thePlayerManager.ControlMove(false, false);
        }
    }
}