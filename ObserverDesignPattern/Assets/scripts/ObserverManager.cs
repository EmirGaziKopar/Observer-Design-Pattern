using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverManager : MonoBehaviour
{

    //Hangi register'a neyi atýyacaðýmýzý register üzerinden yapýcaz çünkü ben bir subject'e eriþmek istiyorsam bunu tek bir yerden 
    //yöneteceðim ki kolay olsun.
    #region Singleton

    private static ObserverManager _instance = null;

    public static ObserverManager Instance => _instance;

    #endregion
    private void Start()
    {
        
    }
    private void Awake()
    {
        _instance = this;
    }

    public List<Subject> subjects = null;

    public void registerSubject(Subject subject)
    {
        if(subjects == null)
        {
            subjects = new List<Subject>();
        }
        subjects.Add(subject);
    }

    //Biraz önce subject'in içerisinde observerlarýmý yani gözlemcilerimi tutmuþtum. 
    //þimdiyse observer manager'ýmýn içersinde subject'lerimi tutacaaðým.

    public void RegisterObserver(Observer observer , SubjectType subjectType ) //Observerlara , tipi subject olanlara kayýt ol dedik
    {
        foreach (var subject in subjects)
        {
            if(subject.SubjectType == subjectType)
            {
                subject.registerObserver(observer);
            }
        }
    }
  


}

//Buradan sonrasý yukardaki class'dan baðýmsýz



//Haberi verecek olan subject bu enum'u kullanacak.
//Forward'ý duyduðu zaman o iþlevi yapacak , Back duyduðu zaman o iþlevi yapacak.
public enum NotificationType
{
    Forward, Back, Left, Right
}

public enum SubjectType
{
    MovemementPanel
}
