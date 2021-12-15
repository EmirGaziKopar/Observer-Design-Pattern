using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer : MonoBehaviour
{

    //Gözlemlemek istediðimiz objeleri bu sýnýftan türeteceðiz 


    //bunu abstract yaptýk ki doldurmak zorunda kalalým.
    public abstract void OnNotify(NotificationType notificationType); // (Dinleyecek) Bir haber geldiðinde bir bildirim geldiðinde gelene göre iþlem yapacakðýz.
    //fakat neye göre çalýþacak buna haber geldiðinde  "ben a iþini yaptým" "b iþini yaptým" Bunun için bir deðiþkene ihtiyacýmýz var

    // Start is called before the first frame update
    void Start()
    {
        //Subject.Instance.registerSubject derdik ama buradaki yapý musait deðil
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
