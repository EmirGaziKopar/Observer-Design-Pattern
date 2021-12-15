using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPanel : Subject
{
    //Ben bu buttonlara bastım diyecek olan script
    //yapılanları burada bildireceğiz
    //bağıracak olan nesne 
    
    public void ForwardOnClick()
    {
        Notify(NotificationType.Forward);
    }

    public void BackOnClick()
    {
        Notify(NotificationType.Back);
    }

    public void RightOnClick()
    {
        Notify(NotificationType.Right);
    }

    public void LeftOnClick()
    {
        Notify(NotificationType.Left);
    }

}
