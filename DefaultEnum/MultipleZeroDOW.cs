/*########################################################
 *#  DefaultEnum.dll                                     #
 *#  Copyright 2018 by WesTex Enterprises                #
 *########################################################*/

namespace DefaultEnum
{
    /// <summary>
    /// This enumeration is used to demonstrant how to having multiple indexes 
    /// with the value of 0 and who the "default" keyword will return the last
    /// one in the list
    /// </summary>
    public enum MultipleZeroDOW
    {
        Monday = 0,
        NoDay = 0,
        Tuesday = 1,
        Wendesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6
    }
}
