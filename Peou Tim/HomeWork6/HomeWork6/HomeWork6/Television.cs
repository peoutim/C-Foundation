using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Programmer: Tim Peou
/// HomeWork6:  Modify the Television class to use properties instead of functions.


namespace HomeWork6
{    
    /* This is a Blue Print of the television Class. Use Television properties instead of Functions.*/

    //A property value is read with a get accessor and written with a set accessor.
    //These get and set accessors function like methods.

    class Television
    {
        #region Television Properties

        //Television Turn on or off
        //Note the Property has a readable access and publicly accessible.        

        public bool IsOn { get; set; }
        //{
        //    get
        //    {
        //        return isOn;
        //    }
        //    set
        //    {
        //        isOn = value;
        //    }
        //}

        private bool isOn = false;

        // Changes the channel on the tv.
        //Note the Property has a readable access and publicly accessible.
        
        public int Channel { get; set;}
        //{
        //    get
        //    {
        //        return channel;
        //    }
        //    set
        //    {
        //        channel = value;
        //    }
        //}

        private int channel = 0;

        //Increase Volume.
        //Note the Property has a readable access and publicly accessible.
        
        public int Volume { get; set;}
        //{
        //    get
        //    {
        //        return volume;
        //    }
        //    set
        //    {
        //        volume = value;
        //    }
        //}

        private int volume = 0;

        #endregion

        #region Constructor

            //Constructor is created by Default.

        #endregion

        #region Methods of television

        //public bool IsOn()
        //{
        //    return isOn;
        //}

        //public void TurnOn()
        //{
        //    isOn = true;
        //    // do the code to turn the tv on
        //}
        //public void TurnOff()
        //{
        //    isOn = false;
        //    // do the code to turn the tv off
        //}

        //public int CurrentVolume()
        //{
        //    return volume;
        //}
        //public void IncreaseVolume()
        //{
        //    if (volume < 100)
        //    {
        //        volume = volume + 1;
        //        // do the code to increase the volume
        //    }
        //}
        //public void DecreaseVolume()
        //{
        //    if (volume > 0)
        //    {
        //        volume = volume - 1;
        //        // do the code to decrease the volume
        //    }
        //}

        //public int CurrentChannel()
        //{
        //    return channel;
        //}
        //public void ChangeChannel(int Channel)
        //{
        //    if (Channel > 0 && Channel < 50)
        //    {
        //        channel = Channel;
        //        // do the code to change the
        //        // channel on the tv
        //    }

        //}//End Methods
               
        #endregion
       
    }//End Class

}

    

