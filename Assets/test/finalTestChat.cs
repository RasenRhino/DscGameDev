using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalTestChat : MonoBehaviour
{   public GameObject chatBox1;
	public GameObject chatBox2;
	public GameObject chatContent;
	GameObject t;
	Vector3 pos1;
	Vector3 pos2;
	public float chatBirthY;
	Vector3 momChat1;
	Vector3 momChat2;

    // Start is called before the first frame update
    void Start()
    {
        chatBox1=GameObject.Find("chat1");
        chatBox2=GameObject.Find("chat2");
        pos1=chatBox1.transform.position;
        pos2=chatBox2.transform.position;
        chatBirthY=pos1.y-0.5f;
        momChat1=pos1;
        momChat2=pos2;




    }

    // Update is called once per frame
    void Update()
    {
    	
        
    }
}
