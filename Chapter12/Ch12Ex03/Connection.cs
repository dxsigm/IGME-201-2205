using System;
using System.Timers;


namespace Ch12Ex03
{
	/// <summary>
	/// Summary description for Connection.
	/// </summary>
	
		

   public delegate void MessageHandler(Connection source,
   MessageArrivedEventArgs e);


   public class Connection
   {
      public event MessageHandler MessageArrived;
      private string name;

      public string Name
      {
         get
         {
            return name;
         }
         set
         {
            name = value;
         }
      }


      private Timer pollTimer;

      public Connection()
      {
         pollTimer = new Timer(100);
         pollTimer.Elapsed += new ElapsedEventHandler(CheckForMessage);
      }

      public void Connect()
      {
         pollTimer.Start();
      }

      public void Disconnect()
      {
         pollTimer.Stop();
      }

      private void CheckForMessage(object source, ElapsedEventArgs e)
      {
         Console.WriteLine("Checking for new messages.");
         Random random = new Random();
         if ((random.Next(9) == 0) && (MessageArrived != null))
         {
                       MessageArrived(this, new MessageArrivedEventArgs("Hello Mum!"));
         }
      }
   }
}

	

