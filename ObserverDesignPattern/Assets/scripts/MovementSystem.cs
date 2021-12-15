using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : Observer
{

    private void Start()
    {
        ObserverManager.Instance.RegisterObserver(this, SubjectType.MovemementPanel);//bir tip g�nderdik bir de context tip register fonksiyonu i�ersinde hangi neyin kayd�n�n yap�ld���n� kontrol ediyor. 
        //context ise kaydedilenin kim oldu�unu belirliyor.
    }


    //Burada ben her subject'e �ye olmak istemiyorum subjectleri kendi aras�nda ay�rmak istiyorum.
    //Yani her subject'in bir type'� olmal� o type'�da enum ile halledebiliriz. 
    public override void OnNotify(NotificationType notificationType)
    {
        switch (notificationType)
        {
            case NotificationType.Forward:
                transform.Translate(Vector3.forward);
                break;
            case NotificationType.Back:
                transform.Translate(Vector3.back);
                break;
            case NotificationType.Left:
                transform.Translate(Vector3.left);
                break;
            case NotificationType.Right:
                transform.Translate(Vector3.right);
                break;

        }
    }
}