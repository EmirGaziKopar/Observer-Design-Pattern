using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPanel : Subject
{
    //Ben bu buttonlara bastým diyecek olan script
    //yapýlanlarý burada bildireceðiz
    //baðýracak olan nesne 
    
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
