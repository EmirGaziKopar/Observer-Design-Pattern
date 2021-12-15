using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    //Haberi verecek olan subject'im haberi böyle yayacak
    //Deyim yerindeyse þöyle baðýracak : Forward !!! , Back !!! , Left !!! , Right !!!

    private List<Observer> observers = null;//Bu subject'imizi dinleyecek olanlar listesi yani gözlemciler 


    [SerializeField] private SubjectType subjectType; //bir subject type özelliðim olsun ama diðer scriptlerden sadece çekebileyim deðiþtiremeyeyim.

    public SubjectType SubjectType => subjectType; 



    //observerlarýn kaydýný gerçekleþtirebilmek için bir fonksiyon oluþturalým
    public void registerObserver(Observer observer)
    {
        
        if(observers == null)
        {
            observers = new List<Observer>();
        }
        
        observers.Add(observer); //subjectimize bir gözlemci atadýk.
    }


    private void Start()
    {
        //subject diyor ki beni subject olarak kaydet ben sana birþeyleri baðýrmak istiyorum (observerable)
        ObserverManager.Instance.registerSubject(this); //Beni yani Subjects'i observer manager'in içine kaydet diyorum. 
    }

    public void Notify(NotificationType notificationType) 
    {
        foreach (var observer in observers)
        {
            observer.OnNotify(notificationType);
        }
    }
}
