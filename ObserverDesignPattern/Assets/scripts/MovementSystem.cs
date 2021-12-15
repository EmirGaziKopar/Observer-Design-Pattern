using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : Observer
{

    private void Start()
    {
        ObserverManager.Instance.RegisterObserver(this, SubjectType.MovemementPanel);//bir tip gönderdik bir de context tip register fonksiyonu içersinde hangi neyin kaydýnýn yapýldýðýný kontrol ediyor. 
        //context ise kaydedilenin kim olduðunu belirliyor.
    }


    //Burada ben her subject'e üye olmak istemiyorum subjectleri kendi arasýnda ayýrmak istiyorum.
    //Yani her subject'in bir type'ý olmalý o type'ýda enum ile halledebiliriz. 
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