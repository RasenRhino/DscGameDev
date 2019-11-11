using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testChatOther : MonoBehaviour
{   public GameObject c2;
	GameObject ck;
	GameObject t;
	public bool move2=false;
	
	Vector3 chatPos2;
	Vector3 momChatPos2;
	public bool makeSpace2=false;
	void Start()
	{
    ck=GameObject.Find("chat1");
    chatPos2=transform.position;
    momChatPos2=transform.position;


	}
	void Update(){
		momChatPos2.y=ck.GetComponent<testChat>().chatBirthY;
	 	if(Input.GetKeyDown(KeyCode.D)){
     	makeSpace2=true;
     	
     	}
     	if(move2==true){
     		if(Vector3.Distance(transform.position,momChatPos2)>0.01f){
     			transform.position=Vector3.Lerp(transform.position,momChatPos2,Time.deltaTime*10f);

     		}
     		else{
     			t=(GameObject)Instantiate(c2,chatPos2,Quaternion.identity);
     		 t.transform.parent=gameObject.transform;
     		 ck.GetComponent<testChat>().moveChat();
     		 ck.GetComponent<testChat>().chatboxPos();

     		 move2=false;
     		}
     	}
     	if(ck.GetComponent<testChat>().makeSpace==true){
     		if(Vector3.Distance(transform.position,momChatPos2)>0.01f){
     			transform.position=Vector3.Lerp(transform.position,momChatPos2,Time.deltaTime*10f);

     		}
     		else{
     			 ck.GetComponent<testChat>().moveChat();
     		 ck.GetComponent<testChat>().chatboxPos();
     		 ck.GetComponent<testChat>().makeSpace=false;
     		 ck.GetComponent<testChat>().move1=true;

     		}


     	}
    
}
}
