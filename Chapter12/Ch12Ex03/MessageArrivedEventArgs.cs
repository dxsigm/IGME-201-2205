using System;

namespace Ch12Ex03
{
   public class MessageArrivedEventArgs : EventArgs
   {
      private string message;

      public string Message
      {
         get
         {
            return message;
         }
      }

      public MessageArrivedEventArgs()
      {
         message = "No message sent.";
      }

      public MessageArrivedEventArgs(string newMessage)
      {
         message = newMessage;
      }
   }
}
