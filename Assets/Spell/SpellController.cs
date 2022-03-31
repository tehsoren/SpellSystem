using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellController : MonoBehaviour {
    public Spell spellContainer;
    public Vector3 targetLoc;
    public Vector3 castLoc;
    public float initTime;

    public SpellController(Vector3 castLoc)
    {
        spellContainer = new Spell();
        
    }
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        

	}
    private void FixedUpdate() {
        spellContainer.spellBase.UpdatePos(this.transform,targetLoc,1f);
        if(this.transform.position.Equals(targetLoc))
        {DestroyImmediate(this.gameObject);}
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, 0.3f);
        
    }

   
    public void SetInfo(Vector3 castLoc,Vector3 targetLoc)
    {
        this.targetLoc = targetLoc;
        this.castLoc = castLoc;
    }

    public void Activate()
    {
        this.gameObject.SetActive(true);
        this.initTime = Time.fixedTime;
    }
//# public void 
}
