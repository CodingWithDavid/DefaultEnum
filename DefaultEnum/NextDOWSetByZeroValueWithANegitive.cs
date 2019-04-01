/*########################################################
 *#  DefaultEnum.dll                                     #
 *#  Copyright 2018 by WesTex Enterprises                #
 *########################################################*/

namespace DefaultEnum
{
    /// <summary>
    /// This enumeration is used to demonstrant how to use the default 
    /// attribute and how it always return the 0 indexed item 
    /// </summary>
    public enum NextDOWSetByZeroValueWithANegitive
    {
        NoDay = -1,
        Tuesday = 1,
        Wendesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6,
        Monday = 0,
    }
}
