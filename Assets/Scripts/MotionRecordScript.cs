using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionRecordScript : MonoBehaviour
{   
    [SerializeField]
    private GameObject recordObject;
    [SerializeField]
    private GameObject playObject;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickRecordStart()
    {
        recordObject.GetComponent<Entum.MotionDataRecorder>().RecordStart();
    }
    public void OnClickRecordStop()
    {
        recordObject.GetComponent<Entum.MotionDataRecorder>().RecordEnd();
    }

    public void OnClickPlay()
    {
        playObject.GetComponent<Entum.MotionDataPlayer>().PlayMotion();
    }
    public void OnClickStop()
    {
        playObject.GetComponent<Entum.MotionDataPlayer>().StopMotion();
    }

}
