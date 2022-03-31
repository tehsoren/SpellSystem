using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCastController : MonoBehaviour
{
    public GameObject spellObject;
    //public Spell spell;
    // Use this for initialization
    void Start()
    {
        //spell = new Spell();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                //spell.CastSpell(hitInfo.point);
                //Debug.Log("hej");
                CastSpell(hitInfo.point);
            }
        }
    }

    void CastSpell(Vector3 loc)
    {
        var spellObj = Instantiate(spellObject, this.transform.position, new Quaternion());
        var cont = spellObj.GetComponent<SpellController>();
        //Debug.Log(cont.spellContainer == null);
        cont.spellContainer = new Spell(){spellBase = new BaseTypeProjectile()};
        
        cont.SetInfo(this.transform.position,loc);
        cont.Activate();
    }
}
