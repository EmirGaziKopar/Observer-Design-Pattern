using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer : MonoBehaviour
{

    //G�zlemlemek istedi�imiz objeleri bu s�n�ftan t�retece�iz 


    //bunu abstract yapt�k ki doldurmak zorunda kalal�m.
    public abstract void OnNotify(NotificationType notificationType); // (Dinleyecek) Bir haber geldi�inde bir bildirim geldi�inde gelene g�re i�lem yapacak��z.
    //fakat neye g�re �al��acak buna haber geldi�inde  "ben a i�ini yapt�m" "b i�ini yapt�m" Bunun i�in bir de�i�kene ihtiyac�m�z var

    // Start is called before the first frame update
    void Start()
    {
        //Subject.Instance.registerSubject derdik ama buradaki yap� musait de�il
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
