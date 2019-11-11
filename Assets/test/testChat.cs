using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testChat : MonoBehaviour
{
    public float chatBoxY;
    public float chatBirthY;
	public GameObject c1;
	GameObject t;
	GameObject ck2;
	Vector3 pos;
	Vector3 chatPos;

	Vector3 momChatPos;
	public bool makeSpace=false;
	
	public bool move1=false;
	 void Start(){
	 	ck2=GameObject.Find("chat2");
	 	pos=transform.position;
	 	chatBoxY=pos.y-0.5f;
	 	chatBirthY=pos.y+0.5f;

	 	chatPos=pos;
	 	momChatPos=pos;
	 }
	 void Update(){
	 	
	 	
	 	momChatPos.y=chatBirthY;
	 	if(Input.GetKeyDown(KeyCode.A)){
     	
     	makeSpace=true;

     	 
     	
     	
     	
     	
	 }
	
	 if(move1==true){
      if(Vector3.Distance(transform.position,momChatPos)>0.01f){
     		 transform.position=Vector3.Lerp(transform.position,momChatPos,Time.deltaTime*10f);
     	}
     	else{
     		 
     		t=(GameObject)Instantiate(c1,chatPos,Quaternion.identity);
     		 t.transform.parent=gameObject.transform;
     		moveChat();
     		chatboxPos();
     		move1=false;
     		
     	}
	 }
	 if(ck2.GetComponent<testChatOther>().makeSpace2==true){
	 	if(Vector3.Distance(transform.position,momChatPos)>0.01f){
     		 transform.position=Vector3.Lerp(transform.position,momChatPos,Time.deltaTime*10f);
     	}
     	else{
     		
     		moveChat();
     		chatboxPos();
     		ck2.GetComponent<testChatOther>().makeSpace2=false;
     		ck2.GetComponent<testChatOther>().move2=true;
     		
     	}
	 }
	 }
	  
    public void moveChat()
	 {
	 	chatBirthY+=0.5f;
	 }
	 public void chatboxPos(){
	 	chatBoxY-=0.5f;

	 }
	}

